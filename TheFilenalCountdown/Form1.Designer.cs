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
            this.chk_semicolons = new System.Windows.Forms.CheckBox();
            this.chk_capitalize = new System.Windows.Forms.CheckBox();
            this.cbx_format = new System.Windows.Forms.ComboBox();
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
            this.grp_time.Location = new System.Drawing.Point(12, 58);
            this.grp_time.Name = "grp_time";
            this.grp_time.Size = new System.Drawing.Size(160, 144);
            this.grp_time.TabIndex = 0;
            this.grp_time.TabStop = false;
            this.grp_time.Text = "Time Until Zero";
            // 
            // num_seconds
            // 
            this.num_seconds.Location = new System.Drawing.Point(73, 103);
            this.num_seconds.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.num_seconds.Name = "num_seconds";
            this.num_seconds.Size = new System.Drawing.Size(76, 20);
            this.num_seconds.TabIndex = 4;
            this.num_seconds.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // num_minutes
            // 
            this.num_minutes.Location = new System.Drawing.Point(73, 67);
            this.num_minutes.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.num_minutes.Name = "num_minutes";
            this.num_minutes.Size = new System.Drawing.Size(76, 20);
            this.num_minutes.TabIndex = 3;
            // 
            // num_hours
            // 
            this.num_hours.Location = new System.Drawing.Point(73, 34);
            this.num_hours.Maximum = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.num_hours.Name = "num_hours";
            this.num_hours.Size = new System.Drawing.Size(76, 20);
            this.num_hours.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Seconds";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Minutes";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Hours";
            // 
            // btn_start
            // 
            this.btn_start.Location = new System.Drawing.Point(307, 217);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(75, 23);
            this.btn_start.TabIndex = 10;
            this.btn_start.Text = "Start";
            this.btn_start.UseVisualStyleBackColor = true;
            this.btn_start.Click += new System.EventHandler(this.start_Click);
            // 
            // btn_chooseFile
            // 
            this.btn_chooseFile.Location = new System.Drawing.Point(12, 19);
            this.btn_chooseFile.Name = "btn_chooseFile";
            this.btn_chooseFile.Size = new System.Drawing.Size(75, 23);
            this.btn_chooseFile.TabIndex = 1;
            this.btn_chooseFile.Text = "Output File";
            this.btn_chooseFile.UseVisualStyleBackColor = true;
            this.btn_chooseFile.Click += new System.EventHandler(this.chooseFile_Click);
            // 
            // lbl_filename
            // 
            this.lbl_filename.AutoSize = true;
            this.lbl_filename.Location = new System.Drawing.Point(94, 24);
            this.lbl_filename.Name = "lbl_filename";
            this.lbl_filename.Size = new System.Drawing.Size(33, 13);
            this.lbl_filename.TabIndex = 8;
            this.lbl_filename.Text = "None";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chk_semicolons);
            this.groupBox1.Controls.Add(this.chk_capitalize);
            this.groupBox1.Controls.Add(this.cbx_format);
            this.groupBox1.Location = new System.Drawing.Point(178, 58);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(211, 144);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Format";
            // 
            // chk_semicolons
            // 
            this.chk_semicolons.AutoSize = true;
            this.chk_semicolons.Location = new System.Drawing.Point(19, 102);
            this.chk_semicolons.Name = "chk_semicolons";
            this.chk_semicolons.Size = new System.Drawing.Size(185, 17);
            this.chk_semicolons.TabIndex = 7;
            this.chk_semicolons.Text = "Replace commas with semicolons";
            this.chk_semicolons.UseVisualStyleBackColor = true;
            // 
            // chk_capitalize
            // 
            this.chk_capitalize.AutoSize = true;
            this.chk_capitalize.Location = new System.Drawing.Point(19, 79);
            this.chk_capitalize.Name = "chk_capitalize";
            this.chk_capitalize.Size = new System.Drawing.Size(102, 17);
            this.chk_capitalize.TabIndex = 6;
            this.chk_capitalize.Text = "Capitalize words";
            this.chk_capitalize.UseVisualStyleBackColor = true;
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
            this.cbx_format.Location = new System.Drawing.Point(19, 34);
            this.cbx_format.Name = "cbx_format";
            this.cbx_format.Size = new System.Drawing.Size(174, 21);
            this.cbx_format.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 251);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lbl_filename);
            this.Controls.Add(this.btn_chooseFile);
            this.Controls.Add(this.btn_start);
            this.Controls.Add(this.grp_time);
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
        private System.Windows.Forms.CheckBox chk_capitalize;
        private System.Windows.Forms.CheckBox chk_semicolons;
    }
}

