namespace enteral
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form save generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.FeedRateDisplay = new System.Windows.Forms.Label();
            this.dailyVolumeDisplay = new System.Windows.Forms.Label();
            this.feedTypeDisplay = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.FeedRateTag = new System.Windows.Forms.Label();
            this.dailyVolumeTag = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.loadFile = new System.Windows.Forms.Button();
            this.saveFile = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.gapStop = new System.Windows.Forms.ComboBox();
            this.gapStart = new System.Windows.Forms.ComboBox();
            this.AddGap = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.settingsPanel = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.MaxRateNumeric = new System.Windows.Forms.NumericUpDown();
            this.DailyVolumeNumeric = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.feedTypeCombo = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.dailyStartCombo = new System.Windows.Forms.ComboBox();
            this.SettingsButton = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.missedOutput = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.rateOutput = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dailyStart = new System.Windows.Forms.Label();
            this.currentTime = new System.Windows.Forms.Label();
            this.currentTimer = new System.Windows.Forms.Timer(this.components);
            this.Timeline1 = new System.Windows.Forms.Button();
            this.Timeline2 = new System.Windows.Forms.Button();
            this.Timeline4 = new System.Windows.Forms.Button();
            this.Timeline3 = new System.Windows.Forms.Button();
            this.Timeline8 = new System.Windows.Forms.Button();
            this.Timeline7 = new System.Windows.Forms.Button();
            this.Timeline6 = new System.Windows.Forms.Button();
            this.Timeline5 = new System.Windows.Forms.Button();
            this.Timeline12 = new System.Windows.Forms.Button();
            this.Timeline11 = new System.Windows.Forms.Button();
            this.Timeline10 = new System.Windows.Forms.Button();
            this.Timeline9 = new System.Windows.Forms.Button();
            this.Timeline24 = new System.Windows.Forms.Button();
            this.Timeline23 = new System.Windows.Forms.Button();
            this.Timeline22 = new System.Windows.Forms.Button();
            this.Timeline21 = new System.Windows.Forms.Button();
            this.Timeline20 = new System.Windows.Forms.Button();
            this.Timeline19 = new System.Windows.Forms.Button();
            this.Timeline18 = new System.Windows.Forms.Button();
            this.Timeline17 = new System.Windows.Forms.Button();
            this.Timeline16 = new System.Windows.Forms.Button();
            this.Timeline15 = new System.Windows.Forms.Button();
            this.Timeline14 = new System.Windows.Forms.Button();
            this.Timeline13 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.settingsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MaxRateNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DailyVolumeNumeric)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.FeedRateDisplay);
            this.panel1.Controls.Add(this.dailyVolumeDisplay);
            this.panel1.Controls.Add(this.feedTypeDisplay);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.FeedRateTag);
            this.panel1.Controls.Add(this.dailyVolumeTag);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Location = new System.Drawing.Point(16, 18);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(637, 150);
            this.panel1.TabIndex = 0;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(504, 9);
            this.button4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(117, 34);
            this.button4.TabIndex = 16;
            this.button4.Text = "Change Name";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // FeedRateDisplay
            // 
            this.FeedRateDisplay.AutoSize = true;
            this.FeedRateDisplay.Location = new System.Drawing.Point(207, 102);
            this.FeedRateDisplay.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.FeedRateDisplay.Name = "FeedRateDisplay";
            this.FeedRateDisplay.Size = new System.Drawing.Size(61, 17);
            this.FeedRateDisplay.TabIndex = 15;
            this.FeedRateDisplay.Text = "(not set)";
            // 
            // dailyVolumeDisplay
            // 
            this.dailyVolumeDisplay.AutoSize = true;
            this.dailyVolumeDisplay.Location = new System.Drawing.Point(204, 74);
            this.dailyVolumeDisplay.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.dailyVolumeDisplay.Name = "dailyVolumeDisplay";
            this.dailyVolumeDisplay.Size = new System.Drawing.Size(61, 17);
            this.dailyVolumeDisplay.TabIndex = 14;
            this.dailyVolumeDisplay.Text = "(not set)";
            // 
            // feedTypeDisplay
            // 
            this.feedTypeDisplay.AutoSize = true;
            this.feedTypeDisplay.Location = new System.Drawing.Point(204, 47);
            this.feedTypeDisplay.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.feedTypeDisplay.Name = "feedTypeDisplay";
            this.feedTypeDisplay.Size = new System.Drawing.Size(61, 17);
            this.feedTypeDisplay.TabIndex = 13;
            this.feedTypeDisplay.Text = "(not set)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Patient #1";
            // 
            // FeedRateTag
            // 
            this.FeedRateTag.AutoSize = true;
            this.FeedRateTag.Location = new System.Drawing.Point(32, 102);
            this.FeedRateTag.Name = "FeedRateTag";
            this.FeedRateTag.Size = new System.Drawing.Size(163, 17);
            this.FeedRateTag.TabIndex = 12;
            this.FeedRateTag.Text = "Maximum Feeding Rate: ";
            // 
            // dailyVolumeTag
            // 
            this.dailyVolumeTag.AutoSize = true;
            this.dailyVolumeTag.Location = new System.Drawing.Point(32, 75);
            this.dailyVolumeTag.Name = "dailyVolumeTag";
            this.dailyVolumeTag.Size = new System.Drawing.Size(130, 17);
            this.dailyVolumeTag.TabIndex = 11;
            this.dailyVolumeTag.Text = "Total Daily Volume:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(32, 47);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(103, 17);
            this.label7.TabIndex = 10;
            this.label7.Text = "Feeding Type: ";
            // 
            // loadFile
            // 
            this.loadFile.Location = new System.Drawing.Point(11, 223);
            this.loadFile.Margin = new System.Windows.Forms.Padding(4);
            this.loadFile.Name = "loadFile";
            this.loadFile.Size = new System.Drawing.Size(101, 28);
            this.loadFile.TabIndex = 24;
            this.loadFile.Text = "Load Info";
            this.loadFile.UseVisualStyleBackColor = true;
            this.loadFile.Click += new System.EventHandler(this.loadFile_Click);
            // 
            // saveFile
            // 
            this.saveFile.Location = new System.Drawing.Point(113, 223);
            this.saveFile.Margin = new System.Windows.Forms.Padding(4);
            this.saveFile.Name = "saveFile";
            this.saveFile.Size = new System.Drawing.Size(101, 28);
            this.saveFile.TabIndex = 23;
            this.saveFile.Text = "Save Info";
            this.saveFile.UseVisualStyleBackColor = true;
            this.saveFile.Click += new System.EventHandler(this.saveFile_Click);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.gapStop);
            this.panel2.Controls.Add(this.gapStart);
            this.panel2.Controls.Add(this.AddGap);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.button3);
            this.panel2.Location = new System.Drawing.Point(16, 186);
            this.panel2.Margin = new System.Windows.Forms.Padding(5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(317, 233);
            this.panel2.TabIndex = 1;
            // 
            // gapStop
            // 
            this.gapStop.AllowDrop = true;
            this.gapStop.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.gapStop.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.gapStop.FormattingEnabled = true;
            this.gapStop.Items.AddRange(new object[] {
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
            "11:00 PM",
            "12:00 AM",
            "1:00 AM",
            "2:00 AM",
            "3:00 AM",
            "4:00 AM",
            "5:00 AM"});
            this.gapStop.Location = new System.Drawing.Point(16, 106);
            this.gapStop.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gapStop.Name = "gapStop";
            this.gapStop.Size = new System.Drawing.Size(119, 24);
            this.gapStop.TabIndex = 29;
            // 
            // gapStart
            // 
            this.gapStart.AllowDrop = true;
            this.gapStart.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.gapStart.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.gapStart.FormattingEnabled = true;
            this.gapStart.Items.AddRange(new object[] {
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
            "11:00 PM",
            "12:00 AM",
            "1:00 AM",
            "2:00 AM",
            "3:00 AM",
            "4:00 AM",
            "5:00 AM"});
            this.gapStart.Location = new System.Drawing.Point(16, 57);
            this.gapStart.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gapStart.Name = "gapStart";
            this.gapStart.Size = new System.Drawing.Size(119, 24);
            this.gapStart.TabIndex = 24;
            // 
            // AddGap
            // 
            this.AddGap.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddGap.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddGap.Location = new System.Drawing.Point(165, 57);
            this.AddGap.Margin = new System.Windows.Forms.Padding(4);
            this.AddGap.Name = "AddGap";
            this.AddGap.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.AddGap.Size = new System.Drawing.Size(83, 71);
            this.AddGap.TabIndex = 25;
            this.AddGap.Text = "+";
            this.AddGap.UseVisualStyleBackColor = true;
            this.AddGap.Click += new System.EventHandler(this.AddGap_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(13, 36);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(77, 17);
            this.label12.TabIndex = 28;
            this.label12.Text = "Feed Stop:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(13, 87);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(100, 17);
            this.label11.TabIndex = 27;
            this.label11.Text = "Feed Resume:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 11);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Hours Missed:";
            // 
            // button3
            // 
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(59, 154);
            this.button3.Margin = new System.Windows.Forms.Padding(5);
            this.button3.Name = "button3";
            this.button3.Padding = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.button3.Size = new System.Drawing.Size(189, 41);
            this.button3.TabIndex = 30;
            this.button3.Text = "Clear Hours";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // settingsPanel
            // 
            this.settingsPanel.BackColor = System.Drawing.Color.White;
            this.settingsPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.settingsPanel.Controls.Add(this.button2);
            this.settingsPanel.Controls.Add(this.loadFile);
            this.settingsPanel.Controls.Add(this.button1);
            this.settingsPanel.Controls.Add(this.MaxRateNumeric);
            this.settingsPanel.Controls.Add(this.saveFile);
            this.settingsPanel.Controls.Add(this.DailyVolumeNumeric);
            this.settingsPanel.Controls.Add(this.label4);
            this.settingsPanel.Controls.Add(this.label5);
            this.settingsPanel.Controls.Add(this.label9);
            this.settingsPanel.Controls.Add(this.feedTypeCombo);
            this.settingsPanel.Controls.Add(this.label10);
            this.settingsPanel.Controls.Add(this.dailyStartCombo);
            this.settingsPanel.Location = new System.Drawing.Point(677, 52);
            this.settingsPanel.Margin = new System.Windows.Forms.Padding(4);
            this.settingsPanel.Name = "settingsPanel";
            this.settingsPanel.Size = new System.Drawing.Size(223, 263);
            this.settingsPanel.TabIndex = 3;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(137, 133);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 20;
            this.button2.Text = "Set";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(137, 185);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "Set";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // MaxRateNumeric
            // 
            this.MaxRateNumeric.Location = new System.Drawing.Point(11, 185);
            this.MaxRateNumeric.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaxRateNumeric.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.MaxRateNumeric.Name = "MaxRateNumeric";
            this.MaxRateNumeric.Size = new System.Drawing.Size(120, 22);
            this.MaxRateNumeric.TabIndex = 19;
            // 
            // DailyVolumeNumeric
            // 
            this.DailyVolumeNumeric.Location = new System.Drawing.Point(11, 133);
            this.DailyVolumeNumeric.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DailyVolumeNumeric.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.DailyVolumeNumeric.Name = "DailyVolumeNumeric";
            this.DailyVolumeNumeric.Size = new System.Drawing.Size(120, 22);
            this.DailyVolumeNumeric.TabIndex = 21;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 164);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(206, 17);
            this.label4.TabIndex = 18;
            this.label4.Text = "Max Rate Override (WARNING)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 113);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 17);
            this.label5.TabIndex = 16;
            this.label5.Text = "Total Daily Volume";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(8, 62);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(95, 17);
            this.label9.TabIndex = 14;
            this.label9.Text = "Feeding Type";
            // 
            // feedTypeCombo
            // 
            this.feedTypeCombo.AllowDrop = true;
            this.feedTypeCombo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.feedTypeCombo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.feedTypeCombo.FormattingEnabled = true;
            this.feedTypeCombo.Items.AddRange(new object[] {
            "Nasogastic (NG Tube)",
            "Nasojejunal (NJ Tube)",
            "Percutaneous Endoscopic Gastronomy (PEG Tube)",
            "Jejunostomy (J Tube)"});
            this.feedTypeCombo.Location = new System.Drawing.Point(11, 82);
            this.feedTypeCombo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.feedTypeCombo.Name = "feedTypeCombo";
            this.feedTypeCombo.Size = new System.Drawing.Size(192, 24);
            this.feedTypeCombo.TabIndex = 11;
            this.feedTypeCombo.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(8, 11);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(108, 17);
            this.label10.TabIndex = 12;
            this.label10.Text = "Daily Start Time";
            // 
            // dailyStartCombo
            // 
            this.dailyStartCombo.AllowDrop = true;
            this.dailyStartCombo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.dailyStartCombo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.dailyStartCombo.FormattingEnabled = true;
            this.dailyStartCombo.Items.AddRange(new object[] {
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
            "11:00 PM"});
            this.dailyStartCombo.Location = new System.Drawing.Point(11, 31);
            this.dailyStartCombo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dailyStartCombo.Name = "dailyStartCombo";
            this.dailyStartCombo.Size = new System.Drawing.Size(192, 24);
            this.dailyStartCombo.TabIndex = 13;
            this.dailyStartCombo.SelectedIndexChanged += new System.EventHandler(this.comboBox4_SelectedIndexChanged);
            // 
            // SettingsButton
            // 
            this.SettingsButton.BackColor = System.Drawing.SystemColors.Control;
            this.SettingsButton.Location = new System.Drawing.Point(677, 18);
            this.SettingsButton.Margin = new System.Windows.Forms.Padding(4);
            this.SettingsButton.Name = "SettingsButton";
            this.SettingsButton.Size = new System.Drawing.Size(145, 28);
            this.SettingsButton.TabIndex = 4;
            this.SettingsButton.Text = "Edit Settings";
            this.SettingsButton.UseVisualStyleBackColor = false;
            this.SettingsButton.Click += new System.EventHandler(this.SettingsButton_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label6.Location = new System.Drawing.Point(11, 12);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(246, 29);
            this.label6.TabIndex = 5;
            this.label6.Text = "Recommended Rate";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(368, 348);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(116, 17);
            this.label8.TabIndex = 9;
            this.label8.Text = "Daily Start Time: ";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.missedOutput);
            this.panel3.Controls.Add(this.label14);
            this.panel3.Controls.Add(this.rateOutput);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Location = new System.Drawing.Point(371, 186);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(267, 145);
            this.panel3.TabIndex = 13;
            // 
            // missedOutput
            // 
            this.missedOutput.AutoSize = true;
            this.missedOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.missedOutput.Location = new System.Drawing.Point(184, 101);
            this.missedOutput.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.missedOutput.Name = "missedOutput";
            this.missedOutput.Size = new System.Drawing.Size(60, 26);
            this.missedOutput.TabIndex = 24;
            this.missedOutput.Text = "####";
            this.missedOutput.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label14.Location = new System.Drawing.Point(4, 103);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(177, 24);
            this.label14.TabIndex = 23;
            this.label14.Text = "Total Hours Missed:";
            // 
            // rateOutput
            // 
            this.rateOutput.AutoSize = true;
            this.rateOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F);
            this.rateOutput.Location = new System.Drawing.Point(93, 55);
            this.rateOutput.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.rateOutput.Name = "rateOutput";
            this.rateOutput.Size = new System.Drawing.Size(79, 33);
            this.rateOutput.TabIndex = 6;
            this.rateOutput.Text = "####";
            this.rateOutput.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.rateOutput.Click += new System.EventHandler(this.rateOutput_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(368, 380);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 17);
            this.label3.TabIndex = 14;
            this.label3.Text = "Current Time:";
            // 
            // dailyStart
            // 
            this.dailyStart.AutoSize = true;
            this.dailyStart.Location = new System.Drawing.Point(537, 348);
            this.dailyStart.Name = "dailyStart";
            this.dailyStart.Size = new System.Drawing.Size(84, 17);
            this.dailyStart.TabIndex = 15;
            this.dailyStart.Text = "(not yet set)";
            this.dailyStart.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // currentTime
            // 
            this.currentTime.AutoSize = true;
            this.currentTime.Location = new System.Drawing.Point(537, 382);
            this.currentTime.Name = "currentTime";
            this.currentTime.Size = new System.Drawing.Size(84, 17);
            this.currentTime.TabIndex = 16;
            this.currentTime.Text = "(not yet set)";
            this.currentTime.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // currentTimer
            // 
            this.currentTimer.Enabled = true;
            this.currentTimer.Interval = 1000;
            this.currentTimer.Tick += new System.EventHandler(this.currentTimer_Tick);
            // 
            // Timeline1
            // 
            this.Timeline1.Location = new System.Drawing.Point(16, 463);
            this.Timeline1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Timeline1.Name = "Timeline1";
            this.Timeline1.Size = new System.Drawing.Size(129, 94);
            this.Timeline1.TabIndex = 32;
            this.Timeline1.Text = "Start time";
            this.Timeline1.UseVisualStyleBackColor = true;
            this.Timeline1.Click += new System.EventHandler(this.Timeline1_Click);
            // 
            // Timeline2
            // 
            this.Timeline2.Location = new System.Drawing.Point(151, 463);
            this.Timeline2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Timeline2.Name = "Timeline2";
            this.Timeline2.Size = new System.Drawing.Size(129, 94);
            this.Timeline2.TabIndex = 33;
            this.Timeline2.Text = "Start time";
            this.Timeline2.UseVisualStyleBackColor = true;
            this.Timeline2.Click += new System.EventHandler(this.Timeline2_Click);
            // 
            // Timeline4
            // 
            this.Timeline4.Location = new System.Drawing.Point(420, 463);
            this.Timeline4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Timeline4.Name = "Timeline4";
            this.Timeline4.Size = new System.Drawing.Size(129, 94);
            this.Timeline4.TabIndex = 35;
            this.Timeline4.Text = "Start time";
            this.Timeline4.UseVisualStyleBackColor = true;
            this.Timeline4.Click += new System.EventHandler(this.Timeline4_Click);
            // 
            // Timeline3
            // 
            this.Timeline3.Location = new System.Drawing.Point(286, 463);
            this.Timeline3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Timeline3.Name = "Timeline3";
            this.Timeline3.Size = new System.Drawing.Size(129, 94);
            this.Timeline3.TabIndex = 34;
            this.Timeline3.Text = "Start time";
            this.Timeline3.UseVisualStyleBackColor = true;
            this.Timeline3.Click += new System.EventHandler(this.Timeline3_Click);
            // 
            // Timeline8
            // 
            this.Timeline8.Location = new System.Drawing.Point(959, 463);
            this.Timeline8.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Timeline8.Name = "Timeline8";
            this.Timeline8.Size = new System.Drawing.Size(129, 94);
            this.Timeline8.TabIndex = 39;
            this.Timeline8.Text = "Start time";
            this.Timeline8.UseVisualStyleBackColor = true;
            this.Timeline8.Click += new System.EventHandler(this.Timeline8_Click);
            // 
            // Timeline7
            // 
            this.Timeline7.Location = new System.Drawing.Point(824, 463);
            this.Timeline7.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Timeline7.Name = "Timeline7";
            this.Timeline7.Size = new System.Drawing.Size(129, 94);
            this.Timeline7.TabIndex = 38;
            this.Timeline7.Text = "Start time";
            this.Timeline7.UseVisualStyleBackColor = true;
            this.Timeline7.Click += new System.EventHandler(this.Timeline7_Click);
            // 
            // Timeline6
            // 
            this.Timeline6.Location = new System.Drawing.Point(690, 463);
            this.Timeline6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Timeline6.Name = "Timeline6";
            this.Timeline6.Size = new System.Drawing.Size(129, 94);
            this.Timeline6.TabIndex = 37;
            this.Timeline6.Text = "Start time";
            this.Timeline6.UseVisualStyleBackColor = true;
            this.Timeline6.Click += new System.EventHandler(this.Timeline6_Click);
            // 
            // Timeline5
            // 
            this.Timeline5.Location = new System.Drawing.Point(555, 463);
            this.Timeline5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Timeline5.Name = "Timeline5";
            this.Timeline5.Size = new System.Drawing.Size(129, 94);
            this.Timeline5.TabIndex = 36;
            this.Timeline5.Text = "Start time";
            this.Timeline5.UseVisualStyleBackColor = true;
            this.Timeline5.Click += new System.EventHandler(this.Timeline5_Click);
            // 
            // Timeline12
            // 
            this.Timeline12.Location = new System.Drawing.Point(286, 577);
            this.Timeline12.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Timeline12.Name = "Timeline12";
            this.Timeline12.Size = new System.Drawing.Size(129, 94);
            this.Timeline12.TabIndex = 43;
            this.Timeline12.Text = "Start time";
            this.Timeline12.UseVisualStyleBackColor = true;
            this.Timeline12.Click += new System.EventHandler(this.Timeline12_Click);
            // 
            // Timeline11
            // 
            this.Timeline11.Location = new System.Drawing.Point(151, 577);
            this.Timeline11.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Timeline11.Name = "Timeline11";
            this.Timeline11.Size = new System.Drawing.Size(129, 94);
            this.Timeline11.TabIndex = 42;
            this.Timeline11.Text = "Start time";
            this.Timeline11.UseVisualStyleBackColor = true;
            this.Timeline11.Click += new System.EventHandler(this.Timeline11_Click);
            // 
            // Timeline10
            // 
            this.Timeline10.Location = new System.Drawing.Point(16, 577);
            this.Timeline10.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Timeline10.Name = "Timeline10";
            this.Timeline10.Size = new System.Drawing.Size(129, 94);
            this.Timeline10.TabIndex = 41;
            this.Timeline10.Text = "Start time";
            this.Timeline10.UseVisualStyleBackColor = true;
            this.Timeline10.Click += new System.EventHandler(this.Timeline10_Click);
            // 
            // Timeline9
            // 
            this.Timeline9.Location = new System.Drawing.Point(1094, 463);
            this.Timeline9.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Timeline9.Name = "Timeline9";
            this.Timeline9.Size = new System.Drawing.Size(129, 94);
            this.Timeline9.TabIndex = 40;
            this.Timeline9.Text = "Start time";
            this.Timeline9.UseVisualStyleBackColor = true;
            this.Timeline9.Click += new System.EventHandler(this.Timeline9_Click);
            // 
            // Timeline24
            // 
            this.Timeline24.Location = new System.Drawing.Point(690, 692);
            this.Timeline24.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Timeline24.Name = "Timeline24";
            this.Timeline24.Size = new System.Drawing.Size(129, 94);
            this.Timeline24.TabIndex = 55;
            this.Timeline24.Text = "Start time";
            this.Timeline24.UseVisualStyleBackColor = true;
            this.Timeline24.Click += new System.EventHandler(this.Timeline24_Click);
            // 
            // Timeline23
            // 
            this.Timeline23.Location = new System.Drawing.Point(555, 692);
            this.Timeline23.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Timeline23.Name = "Timeline23";
            this.Timeline23.Size = new System.Drawing.Size(129, 94);
            this.Timeline23.TabIndex = 54;
            this.Timeline23.Text = "Start time";
            this.Timeline23.UseVisualStyleBackColor = true;
            this.Timeline23.Click += new System.EventHandler(this.Timeline23_Click);
            // 
            // Timeline22
            // 
            this.Timeline22.Location = new System.Drawing.Point(420, 692);
            this.Timeline22.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Timeline22.Name = "Timeline22";
            this.Timeline22.Size = new System.Drawing.Size(129, 94);
            this.Timeline22.TabIndex = 53;
            this.Timeline22.Text = "Start time";
            this.Timeline22.UseVisualStyleBackColor = true;
            this.Timeline22.Click += new System.EventHandler(this.Timeline22_Click);
            // 
            // Timeline21
            // 
            this.Timeline21.Location = new System.Drawing.Point(286, 692);
            this.Timeline21.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Timeline21.Name = "Timeline21";
            this.Timeline21.Size = new System.Drawing.Size(129, 94);
            this.Timeline21.TabIndex = 52;
            this.Timeline21.Text = "Start time";
            this.Timeline21.UseVisualStyleBackColor = true;
            this.Timeline21.Click += new System.EventHandler(this.Timeline21_Click);
            // 
            // Timeline20
            // 
            this.Timeline20.Location = new System.Drawing.Point(151, 692);
            this.Timeline20.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Timeline20.Name = "Timeline20";
            this.Timeline20.Size = new System.Drawing.Size(129, 94);
            this.Timeline20.TabIndex = 51;
            this.Timeline20.Text = "Start time";
            this.Timeline20.UseVisualStyleBackColor = true;
            this.Timeline20.Click += new System.EventHandler(this.Timeline20_Click);
            // 
            // Timeline19
            // 
            this.Timeline19.Location = new System.Drawing.Point(16, 692);
            this.Timeline19.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Timeline19.Name = "Timeline19";
            this.Timeline19.Size = new System.Drawing.Size(129, 94);
            this.Timeline19.TabIndex = 50;
            this.Timeline19.Text = "Start time";
            this.Timeline19.UseVisualStyleBackColor = true;
            this.Timeline19.Click += new System.EventHandler(this.Timeline19_Click);
            // 
            // Timeline18
            // 
            this.Timeline18.Location = new System.Drawing.Point(1095, 577);
            this.Timeline18.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Timeline18.Name = "Timeline18";
            this.Timeline18.Size = new System.Drawing.Size(129, 94);
            this.Timeline18.TabIndex = 49;
            this.Timeline18.Text = "Start time";
            this.Timeline18.UseVisualStyleBackColor = true;
            this.Timeline18.Click += new System.EventHandler(this.Timeline18_Click);
            // 
            // Timeline17
            // 
            this.Timeline17.Location = new System.Drawing.Point(960, 577);
            this.Timeline17.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Timeline17.Name = "Timeline17";
            this.Timeline17.Size = new System.Drawing.Size(129, 94);
            this.Timeline17.TabIndex = 48;
            this.Timeline17.Text = "Start time";
            this.Timeline17.UseVisualStyleBackColor = true;
            this.Timeline17.Click += new System.EventHandler(this.Timeline17_Click);
            // 
            // Timeline16
            // 
            this.Timeline16.Location = new System.Drawing.Point(824, 577);
            this.Timeline16.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Timeline16.Name = "Timeline16";
            this.Timeline16.Size = new System.Drawing.Size(129, 94);
            this.Timeline16.TabIndex = 47;
            this.Timeline16.Text = "Start time";
            this.Timeline16.UseVisualStyleBackColor = true;
            this.Timeline16.Click += new System.EventHandler(this.Timeline16_Click);
            // 
            // Timeline15
            // 
            this.Timeline15.Location = new System.Drawing.Point(690, 577);
            this.Timeline15.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Timeline15.Name = "Timeline15";
            this.Timeline15.Size = new System.Drawing.Size(129, 94);
            this.Timeline15.TabIndex = 46;
            this.Timeline15.Text = "Start time";
            this.Timeline15.UseVisualStyleBackColor = true;
            this.Timeline15.Click += new System.EventHandler(this.Timeline15_Click);
            // 
            // Timeline14
            // 
            this.Timeline14.Location = new System.Drawing.Point(555, 577);
            this.Timeline14.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Timeline14.Name = "Timeline14";
            this.Timeline14.Size = new System.Drawing.Size(129, 94);
            this.Timeline14.TabIndex = 45;
            this.Timeline14.Text = "Start time";
            this.Timeline14.UseVisualStyleBackColor = true;
            this.Timeline14.Click += new System.EventHandler(this.Timeline14_Click);
            // 
            // Timeline13
            // 
            this.Timeline13.Location = new System.Drawing.Point(420, 577);
            this.Timeline13.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Timeline13.Name = "Timeline13";
            this.Timeline13.Size = new System.Drawing.Size(129, 94);
            this.Timeline13.TabIndex = 44;
            this.Timeline13.Text = "Start time";
            this.Timeline13.UseVisualStyleBackColor = true;
            this.Timeline13.Click += new System.EventHandler(this.Timeline13_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1285, 895);
            this.Controls.Add(this.Timeline24);
            this.Controls.Add(this.Timeline23);
            this.Controls.Add(this.Timeline22);
            this.Controls.Add(this.Timeline21);
            this.Controls.Add(this.Timeline20);
            this.Controls.Add(this.Timeline19);
            this.Controls.Add(this.Timeline18);
            this.Controls.Add(this.Timeline17);
            this.Controls.Add(this.Timeline16);
            this.Controls.Add(this.Timeline15);
            this.Controls.Add(this.Timeline14);
            this.Controls.Add(this.Timeline13);
            this.Controls.Add(this.Timeline12);
            this.Controls.Add(this.Timeline11);
            this.Controls.Add(this.Timeline10);
            this.Controls.Add(this.Timeline9);
            this.Controls.Add(this.Timeline8);
            this.Controls.Add(this.Timeline7);
            this.Controls.Add(this.Timeline6);
            this.Controls.Add(this.Timeline5);
            this.Controls.Add(this.Timeline4);
            this.Controls.Add(this.Timeline3);
            this.Controls.Add(this.Timeline2);
            this.Controls.Add(this.Timeline1);
            this.Controls.Add(this.currentTime);
            this.Controls.Add(this.dailyStart);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.SettingsButton);
            this.Controls.Add(this.settingsPanel);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Enteral Feeding Rate Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.settingsPanel.ResumeLayout(false);
            this.settingsPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MaxRateNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DailyVolumeNumeric)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel settingsPanel;
        private System.Windows.Forms.Button SettingsButton;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox feedTypeCombo;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox dailyStartCombo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.NumericUpDown MaxRateNumeric;
        private System.Windows.Forms.Label dailyVolumeTag;
        private System.Windows.Forms.Label FeedRateTag;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label rateOutput;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.NumericUpDown DailyVolumeNumeric;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label missedOutput;
        private System.Windows.Forms.Label dailyStart;
        private System.Windows.Forms.Label currentTime;
        private System.Windows.Forms.Timer currentTimer;
        private System.Windows.Forms.Label feedTypeDisplay;
        private System.Windows.Forms.Button saveFile;
        private System.Windows.Forms.Button loadFile;
        private System.Windows.Forms.Label dailyVolumeDisplay;
        private System.Windows.Forms.Label FeedRateDisplay;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button AddGap;
        private System.Windows.Forms.ComboBox gapStop;
        private System.Windows.Forms.ComboBox gapStart;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button Timeline1;
        private System.Windows.Forms.Button Timeline2;
        private System.Windows.Forms.Button Timeline4;
        private System.Windows.Forms.Button Timeline3;
        private System.Windows.Forms.Button Timeline8;
        private System.Windows.Forms.Button Timeline7;
        private System.Windows.Forms.Button Timeline6;
        private System.Windows.Forms.Button Timeline5;
        private System.Windows.Forms.Button Timeline12;
        private System.Windows.Forms.Button Timeline11;
        private System.Windows.Forms.Button Timeline10;
        private System.Windows.Forms.Button Timeline9;
        private System.Windows.Forms.Button Timeline24;
        private System.Windows.Forms.Button Timeline23;
        private System.Windows.Forms.Button Timeline22;
        private System.Windows.Forms.Button Timeline21;
        private System.Windows.Forms.Button Timeline20;
        private System.Windows.Forms.Button Timeline19;
        private System.Windows.Forms.Button Timeline18;
        private System.Windows.Forms.Button Timeline17;
        private System.Windows.Forms.Button Timeline16;
        private System.Windows.Forms.Button Timeline15;
        private System.Windows.Forms.Button Timeline14;
        private System.Windows.Forms.Button Timeline13;
    }
}

