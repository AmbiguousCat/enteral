using System;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace enteral
{
    public partial class Form1 : Form
    {
        private PatientInfo patientData = new PatientInfo("0", FeedType.J, 1, 0);

        public System.Windows.Forms.Button[] Timeline = new System.Windows.Forms.Button[24];

        public Form1()
        {
            InitializeComponent();
            rateOutput.Text = "0";
            missedOutput.Text = "0";
            int new_start = RegistryEdit.check_daily_start();
            if (new_start > -1 && new_start < 24)
            {
                dailyStartCombo.SelectedIndex = new_start;
                this.gapStart.Items.Clear();
                this.gapStop.Items.Clear();
                this.gapStart.Items.AddRange(generate_times(dailyStartCombo.SelectedIndex));
                this.gapStop.Items.AddRange(generate_times(dailyStartCombo.SelectedIndex));
            }
            Timeline[0] = Timeline1;
            Timeline[1] = Timeline2;
            Timeline[2] = Timeline3;
            Timeline[3] = Timeline4;
            Timeline[4] = Timeline5;
            Timeline[5] = Timeline6;
            Timeline[6] = Timeline7;
            Timeline[7] = Timeline8;
            Timeline[8] = Timeline9;
            Timeline[9] = Timeline10;
            Timeline[10] = Timeline11;
            Timeline[11] = Timeline12;
            Timeline[12] = Timeline13;
            Timeline[13] = Timeline14;
            Timeline[14] = Timeline15;
            Timeline[15] = Timeline16;
            Timeline[16] = Timeline17;
            Timeline[17] = Timeline18;
            Timeline[18] = Timeline19;
            Timeline[19] = Timeline20;
            Timeline[20] = Timeline21;
            Timeline[21] = Timeline22;
            Timeline[22] = Timeline23;
            Timeline[23] = Timeline24;

            // Disable maximize and window resize
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false; 

            int time = 0;
            string timestring = "";

            for (int i = 0; i <= 23; i++)
            {
                time = RegistryEdit.check_daily_start() + i;
                if (time > 12)
                {
                    time -= 12;
                    if (time > 12)
                    {
                        time -= 12;
                        timestring = time + ":00am";
                    }
                    else
                    {
                        timestring = time + ":00pm";
                    }
                }
                else
                {
                    timestring = time + ":00am";
                }
                Timeline[i].Text = timestring;
            }
        }

        public void Set_patient_info(PatientInfo new_data) {
            patientData = new_data;
            sync_ui();
        }


        private void setTimeline()
        {
            int start = 0;
            int stop = 0;
            int blockNumber = 0;
            double rate = 0;
            int time = 0;
            string timestring = "";

            for (int i = 0; i <= 23; i++)
            {
                time = RegistryEdit.check_daily_start() + i;
                if (time > 12)
                {
                    time -= 12;
                    if (time > 12)
                    {
                        time -= 12;
                        timestring = time + ":00am";
                    }
                    else
                    {
                        timestring = time + ":00pm";
                    }
                }
                else
                {
                    timestring = time + ":00am";
                }
                rate = this.patientData.getTimeBlocks(start, stop, blockNumber, i);

                Timeline[i].BackColor = Color.LightGray;

                if (rate == 0)
                {
                    Timeline[i].Text = timestring + "\nMissed";
                    Timeline[i].BackColor = Color.Pink;
                }
                else if (rate == -1)
                {
                    Timeline[i].Text = timestring;
                }
                else
                {
                    Timeline[i].Text = timestring + "\nRate: " + rate + "ml/hr";
                }

            }

            blockNumber++;
            stop++;
        }



        private void SettingsButton_Click(object sender, EventArgs e)
        {
            if (settingsPanel.Visible)
            {
                if (dailyStartCombo.SelectedItem.ToString() != "")
                {
                    RegistryEdit.set_daily_start(dailyStartCombo.SelectedIndex);
                }

                settingsPanel.Hide();
                SettingsButton.Text = "Edit Settings";
            }
            else
            {
                settingsPanel.Show();
                SettingsButton.Text = "Close [X]";
            }
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            MessageBox.Show("Daily start time set to: " + dailyStartCombo.Text);
            dailyStart.Text = dailyStartCombo.Text;
            gapStart.Items.Clear();
            gapStart.Items.AddRange(generate_times(dailyStartCombo.SelectedIndex));
            gapStop.Items.Clear();
            gapStop.Items.AddRange(generate_times(dailyStartCombo.SelectedIndex));

            // Set value in registry
            RegistryEdit.set_daily_start(dailyStartCombo.SelectedIndex);
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            MessageBox.Show("Feeding type set to: " + feedTypeCombo.Text);
            feedTypeDisplay.Text = feedTypeCombo.Text;
            // Match each option of the combobox to one of our feeding types
            // Windows Form App has validation to ensure values are one of the form options
            // If somehow this doesn't happen, don't set any feed type
            switch (feedTypeCombo.SelectedIndex)
            {
                case 0:
                    patientData.set_feed(FeedType.NG);
                    break;
                case 1:
                    patientData.set_feed(FeedType.NJ);
                    break;
                case 2:
                    patientData.set_feed(FeedType.PEG);
                    break;
                case 3:
                    patientData.set_feed(FeedType.J);
                    break;
                default:
                    return;
            }
            // Internally and visually set the feeding rate to the appropriate amount 
            // 240ml/hr for Gastric feeding (NG & PEG, indices 0 & 2)
            // 150ml/hr for Jejunal feeding (NJ & J, indices 1 & 3)
            if (feedTypeCombo.SelectedIndex % 2 == 0)
            {
                patientData.set_max_rate(240);
                MaxRateNumeric.Value = 240;
            }
            else
            {
                patientData.set_max_rate(150);
                MaxRateNumeric.Value = 150;
            }

            FeedRateDisplay.Text = MaxRateNumeric.Value.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Hide settings panel on initial form appearance
            settingsPanel.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Maximum feeding rate set to: " + MaxRateNumeric.Value);
            FeedRateDisplay.Text = "" + MaxRateNumeric.Value + "     \n(WARNING! This value may differ from the recommended max.)";
            patientData.set_max_rate((double)MaxRateNumeric.Value);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Total daily volume set to: " + DailyVolumeNumeric.Value);
            dailyVolumeDisplay.Text = "" + DailyVolumeNumeric.Value;
            patientData.set_volume((double)DailyVolumeNumeric.Value);
            sync_ui();

        }

        private void currentTimer_Tick(object sender, EventArgs e)
        {
            // Visually update the time when our timer updates
            currentTime.Text = DateTime.Now.ToString("h:mm tt");
        }

        private void saveSettings_Click(object sender, EventArgs e)
        {
            if (dailyStartCombo.SelectedItem.ToString() != "")
            {
                RegistryEdit.set_daily_start(dailyStartCombo.SelectedIndex);
            }
            Properties.Settings.Default.Save();

            settingsPanel.Hide();
            SettingsButton.Text = "Edit Settings";
        }

        private void saveFile_Click(object sender, EventArgs e)
        {
            Stream fs;
            SaveFileDialog savedFile = new SaveFileDialog();
            savedFile.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            savedFile.FilterIndex = 2;
            savedFile.RestoreDirectory = true;

            if (savedFile.ShowDialog() == DialogResult.OK)
            {
                if ((fs = savedFile.OpenFile()) != null || (fs = File.Create(savedFile.FileName)) != null)
                {
                    // Code to write the stream goes here.
                    string data = patientData.to_string(DateTime.Now.Date.AddHours(RegistryEdit.check_daily_start()));
                    byte[] info = new UTF8Encoding(true).GetBytes(data);
                    try
                    {
                        fs.Write(info, 0, info.Length);
                        fs.Close();
                    }
                    catch (Exception _e)
                    {
                        MessageBox.Show("Write error when committing changes to patient info file.");
                    }
                }
                else
                {
                    MessageBox.Show("Could not open the file path for writing, check file path and try again.");
                }
            }
        }

        private void loadFile_Click(object sender, EventArgs e)
        {
            // Create a new file opening dialog that automatically searches for files with a .txt extension
            OpenFileDialog fileToSave = new OpenFileDialog();
            fileToSave.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            fileToSave.FilterIndex = 1;
            fileToSave.RestoreDirectory = true;
            // Load all file content into here if possible
            var fileContent = string.Empty;

            // If they select OK on the dialog
            if (fileToSave.ShowDialog() == DialogResult.OK)
            {
                // Try to open the file
                var fs = fileToSave.OpenFile();
                // Try to read the whole file
                using (StreamReader reader = new StreamReader(fs))
                {
                    fileContent = reader.ReadToEnd();
                }

                // Set our reset time to today + time offset
                DateTime resetTime = DateTime.Now.Date.AddHours(RegistryEdit.check_daily_start
                    ());
                PatientInfo patientDataTmp = new PatientInfo(fileContent, resetTime);
                if (patientDataTmp.validate())
                {
                    // If the file did not contain enough data or had invalid lines
                    MessageBox.Show("ERROR: Could not load patient information check file name and path.");
                    return;
                }
                else
                {
                    // Let a nurse know if old times were dropped (so they don't think the times just disappeared)
                    if (patientDataTmp.is_trimmed())
                    {
                        MessageBox.Show("Warning: Times over 24 hours were present and have been removed.");
                    }
                    // Save the data in our data class & sync
                    patientData = patientDataTmp;
                    sync_ui();
                }
            }



        }

        public void sync_ui()
        {
            // Set values for every visual indicator to match the values stored in patient data
            this.DailyVolumeNumeric.Value = (decimal)this.patientData.get_volume();
            this.feedTypeCombo.SelectedIndex = (int)this.patientData.get_feed_type();
            this.MaxRateNumeric.Value = (decimal)this.patientData.get_maxrate();
            this.label1.Text = this.patientData.get_id();
            this.dailyVolumeDisplay.Text = "" + this.patientData.get_volume();
            this.FeedRateDisplay.Text = "" + this.patientData.get_maxrate();
            this.feedTypeDisplay.Text = this.feedTypeCombo.Text;
            setTimeline();
            // Update feeding rate
            display_feed_rate();

        }

        private void display_feed_rate()
        {
            this.rateOutput.Text = String.Format("{000}", this.patientData.get_feed_rate_ml()) + " ml";
            this.rateOutput.Text = String.Format("{000}", (int)this.patientData.get_feed_rate_ml()) + " ml";
            this.missedOutput.Text = this.patientData.hours_missed().ToString();
        }
        public void changeName()
        {
            Form changeName = new Form();
            Button accept = new Button();
            Button cancel = new Button();
            TextBox newName = new TextBox();

            changeName.Text = "Set Patient Name";
            newName.Text = "Enter Patient Name.";
            accept.Text = "OK";
            cancel.Text = "Cancel";

            accept.DialogResult = System.Windows.Forms.DialogResult.OK;

            newName.Location = new Point(10, 10);
            accept.Location = new Point(newName.Left, newName.Height + newName.Top + 10);
            cancel.Location = new Point(accept.Left, accept.Height + accept.Top + 10);

            changeName.HelpButton = true;

            changeName.StartPosition = FormStartPosition.CenterParent;

            changeName.AcceptButton = accept;
            changeName.CancelButton = cancel;

            changeName.Controls.Add(newName);
            changeName.Controls.Add(accept);
            changeName.Controls.Add(cancel);

            // Show testDialog as a modal dialog and determine if DialogResult = OK.
            if (changeName.ShowDialog(this) == DialogResult.OK)
            {
                // Read the contents of testDialog's TextBox.
                this.label1.Text = newName.Text;
                this.patientData.set_id(newName.Text);
            }
            changeName.Dispose();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            changeName();
        }

        private void AddGap_Click(object sender, EventArgs e)
        {
            int previousRate = (int)this.patientData.get_feed_rate_ml();
            int gapStart = this.gapStart.SelectedIndex;
            int gapStop = this.gapStop.SelectedIndex;

            for (int i = gapStart; i < gapStop; i++)
            {
                this.patientData.setTime(i, previousRate, 0, true);
            }

            sync_ui();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.patientData.clearTimes();
            sync_ui();
        }

        private void listBlocks_Click(object sender, EventArgs e)
        {
            setTimeline();
        }

        private object[] generate_times(int offset)
        {
            // List of possible time names
            string[] time_table = {
            "12:00 AM",
            "1:00 AM",
            "2:00 AM",
            "3:00 AM",
            "4:00 AM",
            "5:00 AM",
            "6:00 AM",
            "7:00 AM",
            "8:00 AM",
            "9:00 AM",
            "10:00 AM",
            "11:00 AM",
            "12:00 PM",
            "1:00 PM",
            "2:00 PM",
            "3:00 PM",
            "4:00 PM",
            "5:00 PM",
            "6:00 PM",
            "7:00 PM",
            "8:00 PM",
            "9:00 PM",
            "10:00 PM",
            "11:00 PM" };
            string[] output = new string[24];
            for (int i = 0; i < 24; i++)
            {
                output[i] = time_table[(i + offset) % 24];
            }
            return output;
        }


        public void changeRate(int index)
        {
            Form changeRate = new Form();
            Button accept = new Button();
            Button cancel = new Button();
            TextBox newRate = new TextBox();

            changeRate.Text = "Edit Time Block";
            newRate.Text = "Enter New Rate";
            accept.Text = "Set Rate";
            cancel.Text = "Cancel";

            accept.DialogResult = System.Windows.Forms.DialogResult.OK;
            newRate.Location = new Point(10, 10);
            accept.Location = new Point(newRate.Left, newRate.Height + newRate.Top + 10);
            cancel.Location = new Point(accept.Left, accept.Height + accept.Top + 10);

            changeRate.HelpButton = true;

            changeRate.StartPosition = FormStartPosition.CenterParent;

            changeRate.AcceptButton = accept;
            changeRate.CancelButton = cancel;

            changeRate.Controls.Add(newRate);
            changeRate.Controls.Add(accept);
            changeRate.Controls.Add(cancel);

            // Show testDialog as a modal dialog and determine if DialogResult = OK.
            if (changeRate.ShowDialog(this) == DialogResult.OK)
            {
                // Read the contents of testDialog's TextBox.
                int previousRate = (int)this.patientData.get_feed_rate_ml();
                int newRateInt = Int32.Parse(newRate.Text);

                bool missed = false;
                if (newRateInt == 0)
                    missed = true;

                this.patientData.setTime(index-1, previousRate, newRateInt, missed);
                

                sync_ui();
            }
            changeRate.Dispose();
        }


        private void Timeline1_Click(object sender, EventArgs e)
        {
            changeRate(1);
        }

        private void Timeline2_Click(object sender, EventArgs e)
        {
            changeRate(2);
        }

        private void Timeline3_Click(object sender, EventArgs e)
        {
            changeRate(3);
        }

        private void Timeline4_Click(object sender, EventArgs e)
        {
            changeRate(4);
        }

        private void Timeline5_Click(object sender, EventArgs e)
        {
            changeRate(5);
        }

        private void Timeline6_Click(object sender, EventArgs e)
        {
            changeRate(6);
        }

        private void Timeline7_Click(object sender, EventArgs e)
        {
            changeRate(7);
        }

        private void Timeline8_Click(object sender, EventArgs e)
        {
            changeRate(8);
        }

        private void Timeline9_Click(object sender, EventArgs e)
        {
            changeRate(9);
        }

        private void Timeline10_Click(object sender, EventArgs e)
        {
            changeRate(10);
        }

        private void Timeline11_Click(object sender, EventArgs e)
        {
            changeRate(11);
        }

        private void Timeline12_Click(object sender, EventArgs e)
        {
            changeRate(12);
        }

        private void Timeline13_Click(object sender, EventArgs e)
        {
            changeRate(13);
        }

        private void Timeline14_Click(object sender, EventArgs e)
        {
            changeRate(14);
        }

        private void Timeline15_Click(object sender, EventArgs e)
        {
            changeRate(15);
        }

        private void Timeline16_Click(object sender, EventArgs e)
        {
            changeRate(16);
        }

        private void Timeline17_Click(object sender, EventArgs e)
        {
            changeRate(17);
        }

        private void Timeline18_Click(object sender, EventArgs e)
        {
            changeRate(18);
        }

        private void Timeline19_Click(object sender, EventArgs e)
        {
            changeRate(19);
        }

        private void Timeline20_Click(object sender, EventArgs e)
        {
            changeRate(20);
        }

        private void Timeline21_Click(object sender, EventArgs e)
        {
            changeRate(21);
        }

        private void Timeline22_Click(object sender, EventArgs e)
        {
            changeRate(22);
        }

        private void Timeline23_Click(object sender, EventArgs e)
        {
            changeRate(23);
        }

        private void Timeline24_Click(object sender, EventArgs e)
        {
            changeRate(24);
        }

        private void rateOutput_Click(object sender, EventArgs e)
        {

        }
    }
}
