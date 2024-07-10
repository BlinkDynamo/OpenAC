namespace OpenAC
{
    partial class OpenACForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OpenACForm));
            this.clickIntervalGB = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.clickIntervalMillisecondsTB = new System.Windows.Forms.TextBox();
            this.clickOptionsGB = new System.Windows.Forms.GroupBox();
            this.clickOptionsClickTypeCB = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.clickOptionsMouseButtonCB = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.clickRepeatGB = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.clickRepeatRepeatNTimesNUD = new System.Windows.Forms.NumericUpDown();
            this.clickRepeatRepeatNTimesRB = new System.Windows.Forms.RadioButton();
            this.clickRepeatRepeatUntilStoppedRB = new System.Windows.Forms.RadioButton();
            this.cursorPositionGB = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.yLocationTB = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.xLocationTB = new System.Windows.Forms.TextBox();
            this.pickLocationB = new System.Windows.Forms.Button();
            this.cursorPositionCustomLocationRB = new System.Windows.Forms.RadioButton();
            this.cursorPositionCurrentLocationRB = new System.Windows.Forms.RadioButton();
            this.startB = new System.Windows.Forms.Button();
            this.stopB = new System.Windows.Forms.Button();
            this.statusGB = new System.Windows.Forms.GroupBox();
            this.statusTB = new System.Windows.Forms.TextBox();
            this.titleAndVersionL = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.clickIntervalSecondsTB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.clickIntervalMinutesTB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.clickIntervalHoursTB = new System.Windows.Forms.TextBox();
            this.clickIntervalGB.SuspendLayout();
            this.clickOptionsGB.SuspendLayout();
            this.clickRepeatGB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clickRepeatRepeatNTimesNUD)).BeginInit();
            this.cursorPositionGB.SuspendLayout();
            this.statusGB.SuspendLayout();
            this.SuspendLayout();
            // 
            // clickIntervalGB
            // 
            this.clickIntervalGB.Controls.Add(this.label4);
            this.clickIntervalGB.Controls.Add(this.label3);
            this.clickIntervalGB.Controls.Add(this.label2);
            this.clickIntervalGB.Controls.Add(this.label1);
            this.clickIntervalGB.Controls.Add(this.clickIntervalMillisecondsTB);
            this.clickIntervalGB.Controls.Add(this.clickIntervalSecondsTB);
            this.clickIntervalGB.Controls.Add(this.clickIntervalMinutesTB);
            this.clickIntervalGB.Controls.Add(this.clickIntervalHoursTB);
            this.clickIntervalGB.Location = new System.Drawing.Point(12, 65);
            this.clickIntervalGB.Name = "clickIntervalGB";
            this.clickIntervalGB.Size = new System.Drawing.Size(436, 53);
            this.clickIntervalGB.TabIndex = 0;
            this.clickIntervalGB.TabStop = false;
            this.clickIntervalGB.Text = "Click interval";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(362, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "milliseconds";
            // 
            // clickIntervalMillisecondsTB
            // 
            this.clickIntervalMillisecondsTB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.clickIntervalMillisecondsTB.Location = new System.Drawing.Point(300, 19);
            this.clickIntervalMillisecondsTB.Name = "clickIntervalMillisecondsTB";
            this.clickIntervalMillisecondsTB.Size = new System.Drawing.Size(56, 20);
            this.clickIntervalMillisecondsTB.TabIndex = 11;
            // 
            // clickOptionsGB
            // 
            this.clickOptionsGB.Controls.Add(this.clickOptionsClickTypeCB);
            this.clickOptionsGB.Controls.Add(this.label6);
            this.clickOptionsGB.Controls.Add(this.clickOptionsMouseButtonCB);
            this.clickOptionsGB.Controls.Add(this.label5);
            this.clickOptionsGB.Location = new System.Drawing.Point(12, 124);
            this.clickOptionsGB.Name = "clickOptionsGB";
            this.clickOptionsGB.Size = new System.Drawing.Size(197, 89);
            this.clickOptionsGB.TabIndex = 1;
            this.clickOptionsGB.TabStop = false;
            this.clickOptionsGB.Text = "Click options";
            // 
            // clickOptionsClickTypeCB
            // 
            this.clickOptionsClickTypeCB.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.clickOptionsClickTypeCB.FormattingEnabled = true;
            this.clickOptionsClickTypeCB.Items.AddRange(new object[] {
            "Single",
            "Double"});
            this.clickOptionsClickTypeCB.Location = new System.Drawing.Point(107, 55);
            this.clickOptionsClickTypeCB.Name = "clickOptionsClickTypeCB";
            this.clickOptionsClickTypeCB.Size = new System.Drawing.Size(79, 21);
            this.clickOptionsClickTypeCB.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 60);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Click type:";
            // 
            // clickOptionsMouseButtonCB
            // 
            this.clickOptionsMouseButtonCB.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.clickOptionsMouseButtonCB.FormattingEnabled = true;
            this.clickOptionsMouseButtonCB.Items.AddRange(new object[] {
            "Left ",
            "Right"});
            this.clickOptionsMouseButtonCB.Location = new System.Drawing.Point(107, 18);
            this.clickOptionsMouseButtonCB.Name = "clickOptionsMouseButtonCB";
            this.clickOptionsMouseButtonCB.Size = new System.Drawing.Size(79, 21);
            this.clickOptionsMouseButtonCB.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Mouse button:";
            // 
            // clickRepeatGB
            // 
            this.clickRepeatGB.Controls.Add(this.label9);
            this.clickRepeatGB.Controls.Add(this.clickRepeatRepeatNTimesNUD);
            this.clickRepeatGB.Controls.Add(this.clickRepeatRepeatNTimesRB);
            this.clickRepeatGB.Controls.Add(this.clickRepeatRepeatUntilStoppedRB);
            this.clickRepeatGB.Location = new System.Drawing.Point(223, 124);
            this.clickRepeatGB.Name = "clickRepeatGB";
            this.clickRepeatGB.Size = new System.Drawing.Size(225, 89);
            this.clickRepeatGB.TabIndex = 2;
            this.clickRepeatGB.TabStop = false;
            this.clickRepeatGB.Text = "Click repeat";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(162, 22);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(31, 13);
            this.label9.TabIndex = 3;
            this.label9.Text = "times";
            // 
            // clickRepeatRepeatNTimesNUD
            // 
            this.clickRepeatRepeatNTimesNUD.Location = new System.Drawing.Point(97, 19);
            this.clickRepeatRepeatNTimesNUD.Name = "clickRepeatRepeatNTimesNUD";
            this.clickRepeatRepeatNTimesNUD.Size = new System.Drawing.Size(56, 20);
            this.clickRepeatRepeatNTimesNUD.TabIndex = 2;
            // 
            // clickRepeatRepeatNTimesRB
            // 
            this.clickRepeatRepeatNTimesRB.AutoSize = true;
            this.clickRepeatRepeatNTimesRB.Location = new System.Drawing.Point(7, 22);
            this.clickRepeatRepeatNTimesRB.Name = "clickRepeatRepeatNTimesRB";
            this.clickRepeatRepeatNTimesRB.Size = new System.Drawing.Size(60, 17);
            this.clickRepeatRepeatNTimesRB.TabIndex = 1;
            this.clickRepeatRepeatNTimesRB.TabStop = true;
            this.clickRepeatRepeatNTimesRB.Text = "Repeat";
            this.clickRepeatRepeatNTimesRB.UseVisualStyleBackColor = true;
            this.clickRepeatRepeatNTimesRB.CheckedChanged += new System.EventHandler(this.clickRepeatRepeatNTimesRB_CheckedChanged);
            // 
            // clickRepeatRepeatUntilStoppedRB
            // 
            this.clickRepeatRepeatUntilStoppedRB.AutoSize = true;
            this.clickRepeatRepeatUntilStoppedRB.Location = new System.Drawing.Point(6, 56);
            this.clickRepeatRepeatUntilStoppedRB.Name = "clickRepeatRepeatUntilStoppedRB";
            this.clickRepeatRepeatUntilStoppedRB.Size = new System.Drawing.Size(123, 17);
            this.clickRepeatRepeatUntilStoppedRB.TabIndex = 0;
            this.clickRepeatRepeatUntilStoppedRB.TabStop = true;
            this.clickRepeatRepeatUntilStoppedRB.Text = "Repeat until stopped";
            this.clickRepeatRepeatUntilStoppedRB.UseVisualStyleBackColor = true;
            this.clickRepeatRepeatUntilStoppedRB.CheckedChanged += new System.EventHandler(this.clickRepeatRepeatUntilStoppedRB_CheckedChanged);
            // 
            // cursorPositionGB
            // 
            this.cursorPositionGB.Controls.Add(this.label8);
            this.cursorPositionGB.Controls.Add(this.yLocationTB);
            this.cursorPositionGB.Controls.Add(this.label7);
            this.cursorPositionGB.Controls.Add(this.xLocationTB);
            this.cursorPositionGB.Controls.Add(this.pickLocationB);
            this.cursorPositionGB.Controls.Add(this.cursorPositionCustomLocationRB);
            this.cursorPositionGB.Controls.Add(this.cursorPositionCurrentLocationRB);
            this.cursorPositionGB.Location = new System.Drawing.Point(12, 219);
            this.cursorPositionGB.Name = "cursorPositionGB";
            this.cursorPositionGB.Size = new System.Drawing.Size(436, 53);
            this.cursorPositionGB.TabIndex = 3;
            this.cursorPositionGB.TabStop = false;
            this.cursorPositionGB.Text = "Cursor position";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(356, 24);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(14, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "Y";
            // 
            // yLocationTB
            // 
            this.yLocationTB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.yLocationTB.Location = new System.Drawing.Point(370, 21);
            this.yLocationTB.Name = "yLocationTB";
            this.yLocationTB.Size = new System.Drawing.Size(42, 20);
            this.yLocationTB.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(290, 25);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(14, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "X";
            // 
            // xLocationTB
            // 
            this.xLocationTB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.xLocationTB.Location = new System.Drawing.Point(304, 21);
            this.xLocationTB.Name = "xLocationTB";
            this.xLocationTB.Size = new System.Drawing.Size(42, 20);
            this.xLocationTB.TabIndex = 15;
            // 
            // pickLocationB
            // 
            this.pickLocationB.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pickLocationB.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.pickLocationB.Location = new System.Drawing.Point(192, 13);
            this.pickLocationB.Name = "pickLocationB";
            this.pickLocationB.Size = new System.Drawing.Size(92, 32);
            this.pickLocationB.TabIndex = 8;
            this.pickLocationB.Text = "Pick location";
            this.pickLocationB.UseVisualStyleBackColor = false;
            this.pickLocationB.Click += new System.EventHandler(this.pickLocationB_Click);
            // 
            // cursorPositionCustomLocationRB
            // 
            this.cursorPositionCustomLocationRB.AutoSize = true;
            this.cursorPositionCustomLocationRB.Location = new System.Drawing.Point(172, 25);
            this.cursorPositionCustomLocationRB.Name = "cursorPositionCustomLocationRB";
            this.cursorPositionCustomLocationRB.Size = new System.Drawing.Size(14, 13);
            this.cursorPositionCustomLocationRB.TabIndex = 1;
            this.cursorPositionCustomLocationRB.TabStop = true;
            this.cursorPositionCustomLocationRB.UseVisualStyleBackColor = true;
            this.cursorPositionCustomLocationRB.CheckedChanged += new System.EventHandler(this.cursorPositionCustomLocationRB_CheckedChanged);
            // 
            // cursorPositionCurrentLocationRB
            // 
            this.cursorPositionCurrentLocationRB.AutoSize = true;
            this.cursorPositionCurrentLocationRB.Location = new System.Drawing.Point(6, 23);
            this.cursorPositionCurrentLocationRB.Name = "cursorPositionCurrentLocationRB";
            this.cursorPositionCurrentLocationRB.Size = new System.Drawing.Size(99, 17);
            this.cursorPositionCurrentLocationRB.TabIndex = 0;
            this.cursorPositionCurrentLocationRB.TabStop = true;
            this.cursorPositionCurrentLocationRB.Text = "Current location";
            this.cursorPositionCurrentLocationRB.UseVisualStyleBackColor = true;
            this.cursorPositionCurrentLocationRB.CheckedChanged += new System.EventHandler(this.cursorPositionCurrentLocationRB_CheckedChanged);
            // 
            // startB
            // 
            this.startB.BackColor = System.Drawing.SystemColors.ControlLight;
            this.startB.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.startB.Location = new System.Drawing.Point(12, 282);
            this.startB.Name = "startB";
            this.startB.Size = new System.Drawing.Size(210, 40);
            this.startB.TabIndex = 4;
            this.startB.Text = "Start (F6)";
            this.startB.UseVisualStyleBackColor = false;
            this.startB.Click += new System.EventHandler(this.startB_Click);
            // 
            // stopB
            // 
            this.stopB.BackColor = System.Drawing.SystemColors.ControlLight;
            this.stopB.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.stopB.Location = new System.Drawing.Point(238, 282);
            this.stopB.Name = "stopB";
            this.stopB.Size = new System.Drawing.Size(210, 40);
            this.stopB.TabIndex = 5;
            this.stopB.Text = "Stop (F7)";
            this.stopB.UseVisualStyleBackColor = false;
            this.stopB.Click += new System.EventHandler(this.stopB_Click);
            // 
            // statusGB
            // 
            this.statusGB.Controls.Add(this.statusTB);
            this.statusGB.Location = new System.Drawing.Point(12, 9);
            this.statusGB.Name = "statusGB";
            this.statusGB.Size = new System.Drawing.Size(197, 50);
            this.statusGB.TabIndex = 7;
            this.statusGB.TabStop = false;
            this.statusGB.Text = "Status";
            // 
            // statusTB
            // 
            this.statusTB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.statusTB.Location = new System.Drawing.Point(6, 19);
            this.statusTB.Name = "statusTB";
            this.statusTB.ReadOnly = true;
            this.statusTB.Size = new System.Drawing.Size(180, 20);
            this.statusTB.TabIndex = 0;
            this.statusTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // titleAndVersionL
            // 
            this.titleAndVersionL.AutoSize = true;
            this.titleAndVersionL.BackColor = System.Drawing.SystemColors.Control;
            this.titleAndVersionL.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleAndVersionL.Location = new System.Drawing.Point(225, 25);
            this.titleAndVersionL.Name = "titleAndVersionL";
            this.titleAndVersionL.Size = new System.Drawing.Size(215, 24);
            this.titleAndVersionL.TabIndex = 8;
            this.titleAndVersionL.Text = "OpenAC AutoClicker 1.0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(265, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "secs";
            // 
            // clickIntervalSecondsTB
            // 
            this.clickIntervalSecondsTB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.clickIntervalSecondsTB.Location = new System.Drawing.Point(203, 19);
            this.clickIntervalSecondsTB.Name = "clickIntervalSecondsTB";
            this.clickIntervalSecondsTB.Size = new System.Drawing.Size(56, 20);
            this.clickIntervalSecondsTB.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(169, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "mins";
            // 
            // clickIntervalMinutesTB
            // 
            this.clickIntervalMinutesTB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.clickIntervalMinutesTB.Location = new System.Drawing.Point(107, 19);
            this.clickIntervalMinutesTB.Name = "clickIntervalMinutesTB";
            this.clickIntervalMinutesTB.Size = new System.Drawing.Size(56, 20);
            this.clickIntervalMinutesTB.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(68, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "hours";
            // 
            // clickIntervalHoursTB
            // 
            this.clickIntervalHoursTB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.clickIntervalHoursTB.Location = new System.Drawing.Point(6, 19);
            this.clickIntervalHoursTB.Name = "clickIntervalHoursTB";
            this.clickIntervalHoursTB.Size = new System.Drawing.Size(56, 20);
            this.clickIntervalHoursTB.TabIndex = 8;
            // 
            // OpenACForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 334);
            this.Controls.Add(this.titleAndVersionL);
            this.Controls.Add(this.statusGB);
            this.Controls.Add(this.stopB);
            this.Controls.Add(this.startB);
            this.Controls.Add(this.cursorPositionGB);
            this.Controls.Add(this.clickRepeatGB);
            this.Controls.Add(this.clickOptionsGB);
            this.Controls.Add(this.clickIntervalGB);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "OpenACForm";
            this.Text = "OpenAC";
            this.clickIntervalGB.ResumeLayout(false);
            this.clickIntervalGB.PerformLayout();
            this.clickOptionsGB.ResumeLayout(false);
            this.clickOptionsGB.PerformLayout();
            this.clickRepeatGB.ResumeLayout(false);
            this.clickRepeatGB.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clickRepeatRepeatNTimesNUD)).EndInit();
            this.cursorPositionGB.ResumeLayout(false);
            this.cursorPositionGB.PerformLayout();
            this.statusGB.ResumeLayout(false);
            this.statusGB.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox clickIntervalGB;
        private System.Windows.Forms.GroupBox clickOptionsGB;
        private System.Windows.Forms.GroupBox clickRepeatGB;
        private System.Windows.Forms.GroupBox cursorPositionGB;
        private System.Windows.Forms.Button startB;
        private System.Windows.Forms.Button stopB;
        private System.Windows.Forms.TextBox clickIntervalMillisecondsTB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button pickLocationB;
        private System.Windows.Forms.RadioButton cursorPositionCustomLocationRB;
        private System.Windows.Forms.RadioButton cursorPositionCurrentLocationRB;
        private System.Windows.Forms.RadioButton clickRepeatRepeatUntilStoppedRB;
        private System.Windows.Forms.ComboBox clickOptionsMouseButtonCB;
        private System.Windows.Forms.ComboBox clickOptionsClickTypeCB;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton clickRepeatRepeatNTimesRB;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox yLocationTB;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox xLocationTB;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown clickRepeatRepeatNTimesNUD;
        private System.Windows.Forms.GroupBox statusGB;
        private System.Windows.Forms.TextBox statusTB;
        private System.Windows.Forms.Label titleAndVersionL;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox clickIntervalSecondsTB;
        private System.Windows.Forms.TextBox clickIntervalMinutesTB;
        private System.Windows.Forms.TextBox clickIntervalHoursTB;
    }
}

