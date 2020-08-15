using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using System.Globalization;


namespace enteral
{
    public enum FeedType {
        NG,
        NJ,
        PEG,
        J
    }


    public class TimeBlock {
        public double feedRate;
        public Boolean written;
        public Boolean missed;

        public TimeBlock() {
            this.feedRate = 0;
            this.written = false;
            this.missed = false;
        }

        public TimeBlock(double rate, Boolean missed) {
            this.feedRate = rate;
            this.missed = missed;
            this.written = true;
        }
    }



    //Class to manage patient data.
    public class PatientInfo
    {
        String PatientID;
        FeedType feedingType;
        double totalVolume;
        double maxFeedRate;
        TimeBlock[] times;
        bool trimmed = false;

        public PatientInfo(String id, FeedType feed, double totalVol, double maxRate) {
            this.PatientID = id;
            this.feedingType = feed;
            this.totalVolume = totalVol;
            this.maxFeedRate = maxRate;
            this.times = new TimeBlock[24];
            this.trimmed = false;
        }

        // Used to add a missing time slot to the timeline, earlier time goes first
        public void setTime(int index, double previousRate, double rate, Boolean missing) {
            if (index < 0 || index > 23)
            {
                return;
            }
            //TO DO: make sure stop happens after start
            this.times[index] = new TimeBlock(rate, missing);
            for (int i = 0; i < index; i++) {
                if (this.times[i] == null)
                {
                    this.times[i] = new TimeBlock(previousRate, false);
                }
            }
            return;
        }

        public void clearTimes()
        {
            for (int i = 0; i < 24; i++)
            {
                this.times[i] = null;
            }
            return;
        }

        // Trims times outside of the current time slot, timeDateReset is the earliest time to keep
        /*
        public void trimMissing(DateTime timeDateReset) {
            List<Tuple<DateTime, DateTime>> new_list = new List<Tuple<DateTime, DateTime>>();
            foreach (var time in this.times) {
                if (DateTime.Compare(time.Item1, timeDateReset) > -1)
                {
                    new_list.Add(time);
                }
                else if (DateTime.Compare(time.Item1, timeDateReset) < 0 && DateTime.Compare(time.Item2, timeDateReset) > 0) {
                    var new_time = new Tuple<DateTime, DateTime>(timeDateReset,time.Item2);
                    new_list.Add(new_time);
                }
            }

            this.times = new_list;
        }*/

        // The time passed in should be the time of day of reset + current time
        public PatientInfo(String fileContents, DateTime timeDateReset) {
            // Windows line endings are \r\n, but the \r doesn't matter
            string[] lines = fileContents.Replace("\r", "").Split('\n');
            // 4 lines is the absolute minimum data for a patient if no miss times specified
            if (lines.Length < 5) { return; }

            // Instantiate all the variables we will need to instantiate the patient class
            // All but the patient ID could fail in parsing, so they aren't assigned yet
            string patientID = lines[0];
            FeedType feed;
            double totalVol;
            double maxRate;

            // This will read the line and check if it has any of our valid feed types
            // The cases can be changed as needed to match any text
            // we only have a finite amount of feed types, this switch statement *just works*
            switch (lines[1]) {
                case "NG":
                    feed = FeedType.NG;
                    break;
                case "NJ":
                    feed = FeedType.NJ;
                    break;
                case "PEG":
                    feed = FeedType.PEG;
                    break;
                case "J":
                    feed = FeedType.J;
                    break;
                default:
                    return;
            }

            // Total Volume is either parsed, or we give up
            if (!double.TryParse(lines[2], out totalVol)) {
                return;
            }
            // Same with our maxrate
            if (!double.TryParse(lines[3], out maxRate)) {
                return;
            }
            // We have now *hopefully* parsed all of the information we need to create the patient info
            // So let's instantiate it
            this.PatientID = patientID;
            this.feedingType = feed;
            this.totalVolume = totalVol;
            this.maxFeedRate = maxRate;
            this.times = new TimeBlock[24];
            this.trimmed = false;


            // Now we need to read the reset time from the file in order to properly do time comparisons
            DateTime startingTime;
            string dateFormat = "yyyy MM dd HH";
            if (!DateTime.TryParseExact(lines[4], dateFormat, CultureInfo.CurrentCulture, DateTimeStyles.None, out startingTime)) {
                return;
            }

            // Now we can try reading the list of stuff and toss if we have to
            // Currently we also kill the file read if any time slot is invalid
            // This is for patient safety purposes
            for (int i = 5; i < lines.Length; i++) {
                //First make sure the time is within our bounds
                int hour_offset = i - 5;
                if (hour_offset > 23) {
                    this.trimmed = true;
                    return;
                }

                if (DateTime.Compare(startingTime.AddHours(hour_offset), timeDateReset) < 0) { this.trimmed = true;  continue; }


                string[] timeSlots = lines[i].Split(' ');
                if (timeSlots.Length != 2) {
                    return;
                }

                // Let's try to parse some stuff
                double feedRate;
                Boolean missed;

                if (!double.TryParse(timeSlots[0], out feedRate) || !Boolean.TryParse(timeSlots[1], out missed)) {
                    // TODO: Report an error
                    throw new System.InvalidOperationException("Could not parse time block data at line " + i);
                }

                int index = (int)(startingTime.AddHours(hour_offset) - timeDateReset).TotalHours;

                System.Diagnostics.Debug.WriteLine("File start time: " + startingTime.AddHours(hour_offset) + " Given Start Time: " + timeDateReset);
                System.Diagnostics.Debug.WriteLine("Writing some data to " + index);
                this.times[index] = new TimeBlock(feedRate, missed);
            }
        }

        public Boolean validate() {
            return this.PatientID == null || this.totalVolume < 0 || this.maxFeedRate < 0;
        }
        public String to_string(DateTime timeDateReset) {
            string vals = "";
            string endl = "\r\n";
            string dateFormat = "yyyy MM dd HH";
            vals += this.PatientID + "\r\n";
            string feed = "";
            switch (this.feedingType) {
                case FeedType.J:
                    feed = "J";
                    break;
                case FeedType.NJ:
                    feed = "NJ";
                    break;
                case FeedType.PEG:
                    feed = "PEG";
                    break;
                case FeedType.NG:
                    feed = "NG";
                    break;
            }
            vals += feed + endl;
            vals += this.totalVolume + endl;
            vals += this.maxFeedRate + endl;
            vals += timeDateReset.ToString(dateFormat) + endl;

            if (times == null) {
                return vals;
            } else {
                foreach (TimeBlock time in this.times) {
                    if (time == null || !time.written) { break; }
                    vals += time.feedRate + " " + time.missed + endl;
                }
            }

            return vals;
        }

        public void set_feed(FeedType feed) {
            this.feedingType = feed;
        }

        //Sets the patient's ID to a given string
        public void set_id(String id) {
            this.PatientID = id;
        }

        // Set the total daily volume
        public void set_volume(double vol) {
            this.totalVolume = vol;
        }

        // Set the maximum allowable rate
        public void set_max_rate(double maxRate) {
            this.maxFeedRate = maxRate;
        }

        public double get_volume() {
            return this.totalVolume;
        }

        public String get_id() {
            return this.PatientID;
        }

        public double get_maxrate() {
            return this.maxFeedRate;
        }

        public FeedType get_feed_type() {
            return this.feedingType;
        }

        public Boolean is_trimmed() {
            return this.trimmed;
        }

        // Calculates the rate of feeding in ml
        public double get_feed_rate_ml() {
            int times_remaining = 24;
            double total_volume = 0;
            if (times == null) {
                return Math.Min((this.totalVolume / 24), this.maxFeedRate);
            }
            foreach (TimeBlock time in times) {
                if (time == null || time.written == false) {
                    break;
                }
                times_remaining--;
                if (!time.missed) {
                    total_volume += time.feedRate;
                }
            }

            if (times_remaining < 1) {
                return 0;
            }

            return Math.Min((this.totalVolume - total_volume) / times_remaining,this.maxFeedRate);
        }

        public int hours_missed() {
            int hours_missed = 0;
            if (times == null) {
                return 0;
            }
            foreach (TimeBlock time in times) {
                if (time == null || time.written == false) {
                    break;
                }
                if (time.feedRate == 0) {
                    hours_missed++;
                }
            }

            return hours_missed;
        }

        //Return the entire timeline as tuples of missed times
        public TimeBlock[] get_timeline() {
            return this.times;
        }

        public double getTimeBlocks(int start, int stop, int blockNumber, int i)
        {

            if (this.times[i] != null)
            {
                if (i != 0)
                {
                    stop = i;

                    if (this.times[i].feedRate != this.times[i - 1].feedRate)
                    {
                        blockNumber++;
                        start = i;
                    }
                }
                return (this.times[i].feedRate);
            }
            else
            {
                return -1;
            }

        }

    }
}
