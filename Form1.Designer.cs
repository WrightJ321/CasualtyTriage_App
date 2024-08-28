namespace MiniProj_WrightJ
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.mobilityYes = new System.Windows.Forms.Button();
            this.MobilityNo = new System.Windows.Forms.Button();
            this.SpotBreath = new System.Windows.Forms.GroupBox();
            this.SpotBreathNo = new System.Windows.Forms.Button();
            this.SpotBreathYes = new System.Windows.Forms.Button();
            this.ReposAirway = new System.Windows.Forms.GroupBox();
            this.ReposAirwayNo = new System.Windows.Forms.Button();
            this.RepoAirwayYes = new System.Windows.Forms.Button();
            this.RespRate = new System.Windows.Forms.GroupBox();
            this.RespR_Lt30 = new System.Windows.Forms.Button();
            this.RespR_Gt30 = new System.Windows.Forms.Button();
            this.Perfusion = new System.Windows.Forms.GroupBox();
            this.PerfusionNo = new System.Windows.Forms.Button();
            this.PerfusionYes = new System.Windows.Forms.Button();
            this.MentalStat = new System.Windows.Forms.GroupBox();
            this.MentalStatNo = new System.Windows.Forms.Button();
            this.MentalStatYes = new System.Windows.Forms.Button();
            this.TriageCat = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Refresh = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.AddCas = new System.Windows.Forms.Button();
            this.clearListBt = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.AddEvac = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SpotBreath.SuspendLayout();
            this.ReposAirway.SuspendLayout();
            this.RespRate.SuspendLayout();
            this.Perfusion.SuspendLayout();
            this.MentalStat.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.RosyBrown;
            this.label1.Location = new System.Drawing.Point(361, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(486, 55);
            this.label1.TabIndex = 0;
            this.label1.Text = "Casualty Triage Tool";
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox1.Controls.Add(this.mobilityYes);
            this.groupBox1.Controls.Add(this.MobilityNo);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(477, 103);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(314, 69);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Is Casualty able to walk?";
            // 
            // mobilityYes
            // 
            this.mobilityYes.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.mobilityYes.Location = new System.Drawing.Point(81, 35);
            this.mobilityYes.Name = "mobilityYes";
            this.mobilityYes.Size = new System.Drawing.Size(53, 23);
            this.mobilityYes.TabIndex = 2;
            this.mobilityYes.Text = "Yes";
            this.mobilityYes.UseVisualStyleBackColor = true;
            this.mobilityYes.Click += new System.EventHandler(this.mobilityYes_Click);
            // 
            // MobilityNo
            // 
            this.MobilityNo.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.MobilityNo.Location = new System.Drawing.Point(171, 35);
            this.MobilityNo.Name = "MobilityNo";
            this.MobilityNo.Size = new System.Drawing.Size(53, 23);
            this.MobilityNo.TabIndex = 1;
            this.MobilityNo.Text = "No";
            this.MobilityNo.UseVisualStyleBackColor = true;
            this.MobilityNo.Click += new System.EventHandler(this.MobilityNo_Click);
            // 
            // SpotBreath
            // 
            this.SpotBreath.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.SpotBreath.BackColor = System.Drawing.SystemColors.ControlLight;
            this.SpotBreath.Controls.Add(this.SpotBreathNo);
            this.SpotBreath.Controls.Add(this.SpotBreathYes);
            this.SpotBreath.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SpotBreath.ForeColor = System.Drawing.Color.Black;
            this.SpotBreath.Location = new System.Drawing.Point(477, 103);
            this.SpotBreath.Name = "SpotBreath";
            this.SpotBreath.Size = new System.Drawing.Size(314, 66);
            this.SpotBreath.TabIndex = 2;
            this.SpotBreath.TabStop = false;
            this.SpotBreath.Text = "Does Casualty have Spontaneous Breathing?";
            // 
            // SpotBreathNo
            // 
            this.SpotBreathNo.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.SpotBreathNo.Location = new System.Drawing.Point(171, 36);
            this.SpotBreathNo.Name = "SpotBreathNo";
            this.SpotBreathNo.Size = new System.Drawing.Size(53, 23);
            this.SpotBreathNo.TabIndex = 2;
            this.SpotBreathNo.Text = "No";
            this.SpotBreathNo.UseVisualStyleBackColor = true;
            this.SpotBreathNo.Click += new System.EventHandler(this.SpotBreathNo_Click);
            // 
            // SpotBreathYes
            // 
            this.SpotBreathYes.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.SpotBreathYes.Location = new System.Drawing.Point(81, 36);
            this.SpotBreathYes.Name = "SpotBreathYes";
            this.SpotBreathYes.Size = new System.Drawing.Size(53, 23);
            this.SpotBreathYes.TabIndex = 1;
            this.SpotBreathYes.Text = "Yes";
            this.SpotBreathYes.UseVisualStyleBackColor = true;
            this.SpotBreathYes.Click += new System.EventHandler(this.SpotBreathYes_Click);
            // 
            // ReposAirway
            // 
            this.ReposAirway.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ReposAirway.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ReposAirway.Controls.Add(this.ReposAirwayNo);
            this.ReposAirway.Controls.Add(this.RepoAirwayYes);
            this.ReposAirway.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReposAirway.ForeColor = System.Drawing.Color.Black;
            this.ReposAirway.Location = new System.Drawing.Point(477, 103);
            this.ReposAirway.Name = "ReposAirway";
            this.ReposAirway.Size = new System.Drawing.Size(314, 76);
            this.ReposAirway.TabIndex = 3;
            this.ReposAirway.TabStop = false;
            this.ReposAirway.Text = "*Re-Position Airway* Improves  Breathing?";
            // 
            // ReposAirwayNo
            // 
            this.ReposAirwayNo.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ReposAirwayNo.Location = new System.Drawing.Point(171, 47);
            this.ReposAirwayNo.Name = "ReposAirwayNo";
            this.ReposAirwayNo.Size = new System.Drawing.Size(53, 23);
            this.ReposAirwayNo.TabIndex = 2;
            this.ReposAirwayNo.Text = "No";
            this.ReposAirwayNo.UseVisualStyleBackColor = true;
            this.ReposAirwayNo.Click += new System.EventHandler(this.ReposAirwayNo_Click);
            // 
            // RepoAirwayYes
            // 
            this.RepoAirwayYes.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.RepoAirwayYes.Location = new System.Drawing.Point(81, 47);
            this.RepoAirwayYes.Name = "RepoAirwayYes";
            this.RepoAirwayYes.Size = new System.Drawing.Size(53, 23);
            this.RepoAirwayYes.TabIndex = 1;
            this.RepoAirwayYes.Text = "Yes";
            this.RepoAirwayYes.UseVisualStyleBackColor = true;
            this.RepoAirwayYes.Click += new System.EventHandler(this.RepoAirwayYes_Click);
            // 
            // RespRate
            // 
            this.RespRate.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.RespRate.BackColor = System.Drawing.SystemColors.ControlLight;
            this.RespRate.Controls.Add(this.RespR_Lt30);
            this.RespRate.Controls.Add(this.RespR_Gt30);
            this.RespRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RespRate.ForeColor = System.Drawing.Color.Black;
            this.RespRate.Location = new System.Drawing.Point(477, 103);
            this.RespRate.Name = "RespRate";
            this.RespRate.Size = new System.Drawing.Size(314, 69);
            this.RespRate.TabIndex = 4;
            this.RespRate.TabStop = false;
            this.RespRate.Text = "Respiratory Rate?";
            // 
            // RespR_Lt30
            // 
            this.RespR_Lt30.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.RespR_Lt30.Location = new System.Drawing.Point(81, 36);
            this.RespR_Lt30.Name = "RespR_Lt30";
            this.RespR_Lt30.Size = new System.Drawing.Size(53, 23);
            this.RespR_Lt30.TabIndex = 3;
            this.RespR_Lt30.Text = "< 30";
            this.RespR_Lt30.UseVisualStyleBackColor = true;
            this.RespR_Lt30.Click += new System.EventHandler(this.RespR_Lt30_Click);
            // 
            // RespR_Gt30
            // 
            this.RespR_Gt30.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.RespR_Gt30.Location = new System.Drawing.Point(171, 36);
            this.RespR_Gt30.Name = "RespR_Gt30";
            this.RespR_Gt30.Size = new System.Drawing.Size(53, 23);
            this.RespR_Gt30.TabIndex = 2;
            this.RespR_Gt30.Text = "> 30";
            this.RespR_Gt30.UseVisualStyleBackColor = true;
            this.RespR_Gt30.Click += new System.EventHandler(this.RespR_Gt30_Click);
            // 
            // Perfusion
            // 
            this.Perfusion.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Perfusion.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Perfusion.Controls.Add(this.PerfusionNo);
            this.Perfusion.Controls.Add(this.PerfusionYes);
            this.Perfusion.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Perfusion.ForeColor = System.Drawing.Color.Black;
            this.Perfusion.Location = new System.Drawing.Point(477, 103);
            this.Perfusion.Name = "Perfusion";
            this.Perfusion.Size = new System.Drawing.Size(314, 76);
            this.Perfusion.TabIndex = 5;
            this.Perfusion.TabStop = false;
            this.Perfusion.Text = "Perfusion? (Radial pulses present)";
            // 
            // PerfusionNo
            // 
            this.PerfusionNo.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.PerfusionNo.Location = new System.Drawing.Point(171, 47);
            this.PerfusionNo.Name = "PerfusionNo";
            this.PerfusionNo.Size = new System.Drawing.Size(53, 23);
            this.PerfusionNo.TabIndex = 2;
            this.PerfusionNo.Text = "No";
            this.PerfusionNo.UseVisualStyleBackColor = true;
            this.PerfusionNo.Click += new System.EventHandler(this.PerfusionNo_Click);
            // 
            // PerfusionYes
            // 
            this.PerfusionYes.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.PerfusionYes.Location = new System.Drawing.Point(81, 47);
            this.PerfusionYes.Name = "PerfusionYes";
            this.PerfusionYes.Size = new System.Drawing.Size(53, 23);
            this.PerfusionYes.TabIndex = 1;
            this.PerfusionYes.Text = "Yes";
            this.PerfusionYes.UseVisualStyleBackColor = true;
            this.PerfusionYes.Click += new System.EventHandler(this.PerfusionYes_Click);
            // 
            // MentalStat
            // 
            this.MentalStat.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.MentalStat.BackColor = System.Drawing.SystemColors.ControlLight;
            this.MentalStat.Controls.Add(this.MentalStatNo);
            this.MentalStat.Controls.Add(this.MentalStatYes);
            this.MentalStat.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MentalStat.ForeColor = System.Drawing.Color.Black;
            this.MentalStat.Location = new System.Drawing.Point(477, 103);
            this.MentalStat.Name = "MentalStat";
            this.MentalStat.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.MentalStat.Size = new System.Drawing.Size(453, 76);
            this.MentalStat.TabIndex = 6;
            this.MentalStat.TabStop = false;
            this.MentalStat.Text = "                             Mental Status";
            // 
            // MentalStatNo
            // 
            this.MentalStatNo.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.MentalStatNo.Location = new System.Drawing.Point(205, 38);
            this.MentalStatNo.Name = "MentalStatNo";
            this.MentalStatNo.Size = new System.Drawing.Size(229, 32);
            this.MentalStatNo.TabIndex = 2;
            this.MentalStatNo.Text = "Does NOT obey Commands";
            this.MentalStatNo.UseVisualStyleBackColor = true;
            this.MentalStatNo.Click += new System.EventHandler(this.MentalStatNo_Click);
            // 
            // MentalStatYes
            // 
            this.MentalStatYes.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.MentalStatYes.Location = new System.Drawing.Point(17, 38);
            this.MentalStatYes.Name = "MentalStatYes";
            this.MentalStatYes.Size = new System.Drawing.Size(165, 32);
            this.MentalStatYes.TabIndex = 1;
            this.MentalStatYes.Text = "Obeys Commands";
            this.MentalStatYes.UseVisualStyleBackColor = true;
            this.MentalStatYes.Click += new System.EventHandler(this.MentalStatYes_Click);
            // 
            // TriageCat
            // 
            this.TriageCat.BackColor = System.Drawing.Color.WhiteSmoke;
            this.TriageCat.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TriageCat.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TriageCat.ForeColor = System.Drawing.SystemColors.MenuText;
            this.TriageCat.Location = new System.Drawing.Point(166, 280);
            this.TriageCat.Multiline = true;
            this.TriageCat.Name = "TriageCat";
            this.TriageCat.Size = new System.Drawing.Size(230, 40);
            this.TriageCat.TabIndex = 7;
            this.TriageCat.Text = "Triage Category";
            this.TriageCat.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TriageCat.TextChanged += new System.EventHandler(this.TriageCat_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.Silver;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(684, 488);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(220, 23);
            this.textBox2.TabIndex = 8;
            this.textBox2.Text = "Expectant";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.Color.Red;
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(684, 526);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(220, 23);
            this.textBox3.TabIndex = 9;
            this.textBox3.Text = "Immediate";
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.Color.Yellow;
            this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox4.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.Location = new System.Drawing.Point(684, 572);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(220, 23);
            this.textBox4.TabIndex = 10;
            this.textBox4.Text = "Delayed";
            this.textBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox5
            // 
            this.textBox5.BackColor = System.Drawing.Color.PaleGreen;
            this.textBox5.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox5.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox5.Location = new System.Drawing.Point(684, 612);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(220, 23);
            this.textBox5.TabIndex = 11;
            this.textBox5.Text = "Minor";
            this.textBox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox6
            // 
            this.textBox6.BackColor = System.Drawing.SystemColors.ControlLight;
            this.textBox6.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox6.Location = new System.Drawing.Point(910, 488);
            this.textBox6.Multiline = true;
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(330, 41);
            this.textBox6.TabIndex = 12;
            this.textBox6.Text = "Casualty is deceased or is not expected to survive due to severity of their injur" +
    "ies.";
            this.textBox6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox7
            // 
            this.textBox7.BackColor = System.Drawing.SystemColors.ControlLight;
            this.textBox7.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox7.Location = new System.Drawing.Point(910, 525);
            this.textBox7.Multiline = true;
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(285, 41);
            this.textBox7.TabIndex = 13;
            this.textBox7.Text = "Casualty has severe injuries requiring immediate treatment.";
            this.textBox7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox8
            // 
            this.textBox8.BackColor = System.Drawing.SystemColors.ControlLight;
            this.textBox8.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox8.Location = new System.Drawing.Point(919, 572);
            this.textBox8.Multiline = true;
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(312, 41);
            this.textBox8.TabIndex = 14;
            this.textBox8.Text = "Casualty has potentially severe injuries, but treatment can be delayed up to a fe" +
    "w hours.";
            this.textBox8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox9
            // 
            this.textBox9.BackColor = System.Drawing.SystemColors.ControlLight;
            this.textBox9.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox9.Location = new System.Drawing.Point(910, 612);
            this.textBox9.Multiline = true;
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(312, 41);
            this.textBox9.TabIndex = 15;
            this.textBox9.Text = "Casualty has minor injuries not requiring immediate treatment.";
            this.textBox9.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Gadugi", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(681, 461);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 14);
            this.label2.TabIndex = 16;
            this.label2.Text = "Triage Legend";
            // 
            // Refresh
            // 
            this.Refresh.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Refresh.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Refresh.Location = new System.Drawing.Point(711, 68);
            this.Refresh.Name = "Refresh";
            this.Refresh.Size = new System.Drawing.Size(80, 33);
            this.Refresh.TabIndex = 17;
            this.Refresh.Text = "Refresh";
            this.Refresh.UseVisualStyleBackColor = true;
            this.Refresh.Click += new System.EventHandler(this.Refresh_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(230, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 25);
            this.label3.TabIndex = 18;
            this.label3.Text = "Casualty Info";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "Weight: ";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(64, 131);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(46, 20);
            this.textBox1.TabIndex = 20;
            this.textBox1.Validating += new System.ComponentModel.CancelEventHandler(this.textBox1_Validating);
            // 
            // textBox10
            // 
            this.textBox10.Location = new System.Drawing.Point(49, 168);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(34, 20);
            this.textBox10.TabIndex = 21;
            this.textBox10.Validating += new System.ComponentModel.CancelEventHandler(this.textBox10_Validating);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 168);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 22;
            this.label5.Text = "Age: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 201);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 13);
            this.label6.TabIndex = 23;
            this.label6.Text = "Gender: ";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(17, 234);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(48, 17);
            this.radioButton1.TabIndex = 24;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Male";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(80, 234);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(59, 17);
            this.radioButton2.TabIndex = 25;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Female";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.listBox1.ForeColor = System.Drawing.Color.Black;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(201, 117);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(270, 134);
            this.listBox1.TabIndex = 26;
            // 
            // AddCas
            // 
            this.AddCas.Location = new System.Drawing.Point(98, 89);
            this.AddCas.Name = "AddCas";
            this.AddCas.Size = new System.Drawing.Size(75, 23);
            this.AddCas.TabIndex = 27;
            this.AddCas.Text = "Add";
            this.AddCas.UseVisualStyleBackColor = true;
            this.AddCas.Click += new System.EventHandler(this.AddCas_Click);
            // 
            // clearListBt
            // 
            this.clearListBt.Location = new System.Drawing.Point(17, 89);
            this.clearListBt.Name = "clearListBt";
            this.clearListBt.Size = new System.Drawing.Size(75, 23);
            this.clearListBt.TabIndex = 28;
            this.clearListBt.Text = "Clear List";
            this.clearListBt.UseVisualStyleBackColor = true;
            this.clearListBt.Click += new System.EventHandler(this.clearListBt_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(289, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(54, 50);
            this.pictureBox1.TabIndex = 29;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(860, 5);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(56, 50);
            this.pictureBox2.TabIndex = 30;
            this.pictureBox2.TabStop = false;
            // 
            // AddEvac
            // 
            this.AddEvac.Location = new System.Drawing.Point(37, 280);
            this.AddEvac.Name = "AddEvac";
            this.AddEvac.Size = new System.Drawing.Size(102, 23);
            this.AddEvac.TabIndex = 31;
            this.AddEvac.Text = "Add Cas. Evac";
            this.AddEvac.UseVisualStyleBackColor = true;
            this.AddEvac.Click += new System.EventHandler(this.AddEvac_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(31, 268);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(12, 20);
            this.button2.TabIndex = 32;
            this.button2.Text = "?";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(116, 134);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(23, 13);
            this.label7.TabIndex = 33;
            this.label7.Text = "lbs.";
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1314, 692);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.RespRate);
            this.Controls.Add(this.SpotBreath);
            this.Controls.Add(this.ReposAirway);
            this.Controls.Add(this.Perfusion);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.MentalStat);
            this.Controls.Add(this.AddEvac);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.clearListBt);
            this.Controls.Add(this.AddCas);
            this.Controls.Add(this.Refresh);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox10);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TriageCat);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox9);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form1";
            this.Text = "ProtoType";
            this.groupBox1.ResumeLayout(false);
            this.SpotBreath.ResumeLayout(false);
            this.ReposAirway.ResumeLayout(false);
            this.RespRate.ResumeLayout(false);
            this.Perfusion.ResumeLayout(false);
            this.MentalStat.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button MobilityNo;
        private System.Windows.Forms.GroupBox SpotBreath;
        private System.Windows.Forms.GroupBox ReposAirway;
        private System.Windows.Forms.GroupBox RespRate;
        private System.Windows.Forms.GroupBox Perfusion;
        private System.Windows.Forms.GroupBox MentalStat;
        private System.Windows.Forms.TextBox TriageCat;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.Button SpotBreathYes;
        private System.Windows.Forms.Button RepoAirwayYes;
        private System.Windows.Forms.Button PerfusionYes;
        private System.Windows.Forms.Button MentalStatYes;
        private System.Windows.Forms.Button SpotBreathNo;
        private System.Windows.Forms.Button ReposAirwayNo;
        private System.Windows.Forms.Button RespR_Lt30;
        private System.Windows.Forms.Button RespR_Gt30;
        private System.Windows.Forms.Button PerfusionNo;
        private System.Windows.Forms.Button MentalStatNo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Refresh;
        private System.Windows.Forms.Button mobilityYes;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button AddCas;
        private System.Windows.Forms.Button clearListBt;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button AddEvac;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label7;
    }
}

