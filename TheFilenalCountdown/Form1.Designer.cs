namespace TheFilenalCountdown
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
            this.grp_time = new System.Windows.Forms.GroupBox();
            this.num_seconds = new System.Windows.Forms.NumericUpDown();
            this.num_minutes = new System.Windows.Forms.NumericUpDown();
            this.num_hours = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_start = new System.Windows.Forms.Button();
            this.btn_chooseFile = new System.Windows.Forms.Button();
            this.lbl_filename = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbx_replaceCommasWith = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbx_capitalization = new System.Windows.Forms.ComboBox();
            this.cbx_format = new System.Windows.Forms.ComboBox();
            this.chk_countUp = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.grp_time.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_seconds)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_minutes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_hours)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grp_time
            // 
            this.grp_time.Controls.Add(this.num_seconds);
            this.grp_time.Controls.Add(this.num_minutes);
            this.grp_time.Controls.Add(this.num_hours);
            this.grp_time.Controls.Add(this.label4);
            this.grp_time.Controls.Add(this.label3);
            this.grp_time.Controls.Add(this.label2);
            this.grp_time.Location = new System.Drawing.Point(38, 165);
            this.grp_time.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.grp_time.Name = "grp_time";
            this.grp_time.Padding = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.grp_time.Size = new System.Drawing.Size(507, 410);
            this.grp_time.TabIndex = 0;
            this.grp_time.TabStop = false;
            this.grp_time.Text = "Time Until Zero";
            // 
            // num_seconds
            // 
            this.num_seconds.Location = new System.Drawing.Point(231, 293);
            this.num_seconds.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.num_seconds.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.num_seconds.Name = "num_seconds";
            this.num_seconds.Size = new System.Drawing.Size(241, 44);
            this.num_seconds.TabIndex = 4;
            this.num_seconds.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // num_minutes
            // 
            this.num_minutes.Location = new System.Drawing.Point(231, 191);
            this.num_minutes.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.num_minutes.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.num_minutes.Name = "num_minutes";
            this.num_minutes.Size = new System.Drawing.Size(241, 44);
            this.num_minutes.TabIndex = 3;
            // 
            // num_hours
            // 
            this.num_hours.Location = new System.Drawing.Point(231, 97);
            this.num_hours.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.num_hours.Maximum = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.num_hours.Name = "num_hours";
            this.num_hours.Size = new System.Drawing.Size(241, 44);
            this.num_hours.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(48, 302);
            this.label4.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(141, 37);
            this.label4.TabIndex = 10;
            this.label4.Text = "Seconds";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 202);
            this.label3.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 37);
            this.label3.TabIndex = 8;
            this.label3.Text = "Minutes";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 102);
            this.label2.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 37);
            this.label2.TabIndex = 6;
            this.label2.Text = "Hours";
            // 
            // btn_start
            // 
            this.btn_start.Location = new System.Drawing.Point(393, 605);
            this.btn_start.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(238, 65);
            this.btn_start.TabIndex = 9;
            this.btn_start.Text = "Start";
            this.btn_start.UseVisualStyleBackColor = true;
            this.btn_start.Click += new System.EventHandler(this.start_Click);
            // 
            // btn_chooseFile
            // 
            this.btn_chooseFile.Location = new System.Drawing.Point(38, 54);
            this.btn_chooseFile.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.btn_chooseFile.Name = "btn_chooseFile";
            this.btn_chooseFile.Size = new System.Drawing.Size(238, 65);
            this.btn_chooseFile.TabIndex = 1;
            this.btn_chooseFile.Text = "Output File";
            this.btn_chooseFile.UseVisualStyleBackColor = true;
            this.btn_chooseFile.Click += new System.EventHandler(this.chooseFile_Click);
            // 
            // lbl_filename
            // 
            this.lbl_filename.AutoSize = true;
            this.lbl_filename.Location = new System.Drawing.Point(298, 68);
            this.lbl_filename.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.lbl_filename.Name = "lbl_filename";
            this.lbl_filename.Size = new System.Drawing.Size(94, 37);
            this.lbl_filename.TabIndex = 8;
            this.lbl_filename.Text = "None";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.cbx_replaceCommasWith);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cbx_capitalization);
            this.groupBox1.Controls.Add(this.cbx_format);
            this.groupBox1.Location = new System.Drawing.Point(564, 165);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.groupBox1.Size = new System.Drawing.Size(707, 410);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Format";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(51, 302);
            this.label5.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(353, 37);
            this.label5.TabIndex = 13;
            this.label5.Text = "Replace Commas With ";
            // 
            // cbx_replaceCommasWith
            // 
            this.cbx_replaceCommasWith.FormattingEnabled = true;
            this.cbx_replaceCommasWith.Items.AddRange(new object[] {
            ";",
            " //",
            " /",
            " :",
            " &"});
            this.cbx_replaceCommasWith.Location = new System.Drawing.Point(443, 293);
            this.cbx_replaceCommasWith.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.cbx_replaceCommasWith.Name = "cbx_replaceCommasWith";
            this.cbx_replaceCommasWith.Size = new System.Drawing.Size(194, 45);
            this.cbx_replaceCommasWith.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 202);
            this.label1.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(210, 37);
            this.label1.TabIndex = 11;
            this.label1.Text = "Capitalization";
            // 
            // cbx_capitalization
            // 
            this.cbx_capitalization.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_capitalization.FormattingEnabled = true;
            this.cbx_capitalization.Items.AddRange(new object[] {
            "all lowercase",
            "ALL CAPS",
            "Inital Caps"});
            this.cbx_capitalization.Location = new System.Drawing.Point(288, 194);
            this.cbx_capitalization.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.cbx_capitalization.Name = "cbx_capitalization";
            this.cbx_capitalization.Size = new System.Drawing.Size(349, 45);
            this.cbx_capitalization.TabIndex = 6;
            // 
            // cbx_format
            // 
            this.cbx_format.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_format.FormattingEnabled = true;
            this.cbx_format.Items.AddRange(new object[] {
            "hh:mm:ss",
            "hh hours, mm mins, ss secs",
            "hh hours, mm minutes, ss seconds",
            "mm:ss",
            "mm minutes, ss seconds",
            "mm mins, ss secs"});
            this.cbx_format.Location = new System.Drawing.Point(60, 97);
            this.cbx_format.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.cbx_format.Name = "cbx_format";
            this.cbx_format.Size = new System.Drawing.Size(577, 45);
            this.cbx_format.TabIndex = 5;
            // 
            // chk_countUp
            // 
            this.chk_countUp.AutoSize = true;
            this.chk_countUp.Location = new System.Drawing.Point(38, 618);
            this.chk_countUp.Name = "chk_countUp";
            this.chk_countUp.Size = new System.Drawing.Size(312, 41);
            this.chk_countUp.TabIndex = 8;
            this.chk_countUp.Text = "Count Up Instead";
            this.chk_countUp.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(916, 619);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(285, 37);
            this.label6.TabIndex = 12;
            this.label6.Text = "git.io/JJPOS v1.1.4";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1347, 714);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.chk_countUp);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lbl_filename);
            this.Controls.Add(this.btn_chooseFile);
            this.Controls.Add(this.btn_start);
            this.Controls.Add(this.grp_time);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.Name = "Form1";
            this.Text = "The Filenal Countdown";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing_1);
            this.grp_time.ResumeLayout(false);
            this.grp_time.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_seconds)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_minutes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_hours)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grp_time;
        private System.Windows.Forms.Button btn_start;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_chooseFile;
        private System.Windows.Forms.Label lbl_filename;
        private System.Windows.Forms.NumericUpDown num_seconds;
        private System.Windows.Forms.NumericUpDown num_minutes;
        private System.Windows.Forms.NumericUpDown num_hours;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbx_format;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbx_capitalization;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbx_replaceCommasWith;
        private System.Windows.Forms.CheckBox chk_countUp;
        private System.Windows.Forms.Label label6;
    }
}

