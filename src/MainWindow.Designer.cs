// Copyright 2021-2022 Woohyun Shin
// SPDX-License-Identifier: GPL-3.0-only

namespace Numouse {
    partial class MainWindow {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.gbxClickSpeed = new System.Windows.Forms.GroupBox();
            this.btnEditSequence = new System.Windows.Forms.Button();
            this.rdoClickSpeedSequence = new System.Windows.Forms.RadioButton();
            this.lblClickSpeedIntervalPostfix = new System.Windows.Forms.Label();
            this.nudClickSpeedInterval = new System.Windows.Forms.NumericUpDown();
            this.rdoClickSpeedInterval = new System.Windows.Forms.RadioButton();
            this.rdoClickSpeedImm = new System.Windows.Forms.RadioButton();
            this.gbxStop = new System.Windows.Forms.GroupBox();
            this.nudStopOnTimeMinute = new System.Windows.Forms.NumericUpDown();
            this.nudStopOnTimeHour = new System.Windows.Forms.NumericUpDown();
            this.lblStopOnMinPostfix = new System.Windows.Forms.Label();
            this.lblStopOnHourPostfix = new System.Windows.Forms.Label();
            this.rdoStopOnTime = new System.Windows.Forms.RadioButton();
            this.lblStopAfterPostfix = new System.Windows.Forms.Label();
            this.nudStopAfterSec = new System.Windows.Forms.NumericUpDown();
            this.rdoStopAfterSec = new System.Windows.Forms.RadioButton();
            this.rdoStopNever = new System.Windows.Forms.RadioButton();
            this.lblStatus = new System.Windows.Forms.Label();
            this.btnStartStop = new System.Windows.Forms.Button();
            this.tmrClicker = new System.Windows.Forms.Timer(this.components);
            this.tmrButtonEnabler = new System.Windows.Forms.Timer(this.components);
            this.gbxClickSpeed.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudClickSpeedInterval)).BeginInit();
            this.gbxStop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudStopOnTimeMinute)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudStopOnTimeHour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudStopAfterSec)).BeginInit();
            this.SuspendLayout();
            // 
            // gbxClickSpeed
            // 
            this.gbxClickSpeed.Controls.Add(this.btnEditSequence);
            this.gbxClickSpeed.Controls.Add(this.rdoClickSpeedSequence);
            this.gbxClickSpeed.Controls.Add(this.lblClickSpeedIntervalPostfix);
            this.gbxClickSpeed.Controls.Add(this.nudClickSpeedInterval);
            this.gbxClickSpeed.Controls.Add(this.rdoClickSpeedInterval);
            this.gbxClickSpeed.Controls.Add(this.rdoClickSpeedImm);
            this.gbxClickSpeed.Location = new System.Drawing.Point(12, 12);
            this.gbxClickSpeed.Name = "gbxClickSpeed";
            this.gbxClickSpeed.Size = new System.Drawing.Size(350, 126);
            this.gbxClickSpeed.TabIndex = 0;
            this.gbxClickSpeed.TabStop = false;
            this.gbxClickSpeed.Tag = "click_interval";
            this.gbxClickSpeed.Text = "Click Interval";
            // 
            // btnEditSequence
            // 
            this.btnEditSequence.Location = new System.Drawing.Point(143, 97);
            this.btnEditSequence.Name = "btnEditSequence";
            this.btnEditSequence.Size = new System.Drawing.Size(94, 23);
            this.btnEditSequence.TabIndex = 5;
            this.btnEditSequence.Tag = "edit_sequence";
            this.btnEditSequence.Text = "Configure...";
            this.btnEditSequence.UseVisualStyleBackColor = true;
            this.btnEditSequence.Click += new System.EventHandler(this.btnEditSequence_Click);
            // 
            // rdoClickSpeedSequence
            // 
            this.rdoClickSpeedSequence.AutoSize = true;
            this.rdoClickSpeedSequence.Location = new System.Drawing.Point(15, 99);
            this.rdoClickSpeedSequence.Name = "rdoClickSpeedSequence";
            this.rdoClickSpeedSequence.Size = new System.Drawing.Size(122, 19);
            this.rdoClickSpeedSequence.TabIndex = 4;
            this.rdoClickSpeedSequence.Tag = "click_interval_sequence";
            this.rdoClickSpeedSequence.Text = "Execute Sequence";
            this.rdoClickSpeedSequence.UseVisualStyleBackColor = true;
            // 
            // lblClickSpeedIntervalPostfix
            // 
            this.lblClickSpeedIntervalPostfix.AutoSize = true;
            this.lblClickSpeedIntervalPostfix.Location = new System.Drawing.Point(93, 74);
            this.lblClickSpeedIntervalPostfix.Name = "lblClickSpeedIntervalPostfix";
            this.lblClickSpeedIntervalPostfix.Size = new System.Drawing.Size(58, 15);
            this.lblClickSpeedIntervalPostfix.TabIndex = 3;
            this.lblClickSpeedIntervalPostfix.Tag = "click_interval_seconds_postfix";
            this.lblClickSpeedIntervalPostfix.Text = "second(s)";
            // 
            // nudClickSpeedInterval
            // 
            this.nudClickSpeedInterval.Enabled = false;
            this.nudClickSpeedInterval.Location = new System.Drawing.Point(33, 70);
            this.nudClickSpeedInterval.Maximum = new decimal(new int[] {
            3600,
            0,
            0,
            0});
            this.nudClickSpeedInterval.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudClickSpeedInterval.Name = "nudClickSpeedInterval";
            this.nudClickSpeedInterval.Size = new System.Drawing.Size(55, 23);
            this.nudClickSpeedInterval.TabIndex = 2;
            this.nudClickSpeedInterval.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // rdoClickSpeedInterval
            // 
            this.rdoClickSpeedInterval.AutoSize = true;
            this.rdoClickSpeedInterval.Location = new System.Drawing.Point(15, 47);
            this.rdoClickSpeedInterval.Name = "rdoClickSpeedInterval";
            this.rdoClickSpeedInterval.Size = new System.Drawing.Size(83, 19);
            this.rdoClickSpeedInterval.TabIndex = 1;
            this.rdoClickSpeedInterval.Tag = "click_interval_seconds";
            this.rdoClickSpeedInterval.Text = "Click every";
            this.rdoClickSpeedInterval.UseVisualStyleBackColor = true;
            this.rdoClickSpeedInterval.CheckedChanged += new System.EventHandler(this.rdoClickSpeedInterval_CheckedChanged);
            // 
            // rdoClickSpeedImm
            // 
            this.rdoClickSpeedImm.AutoSize = true;
            this.rdoClickSpeedImm.Checked = true;
            this.rdoClickSpeedImm.Location = new System.Drawing.Point(15, 22);
            this.rdoClickSpeedImm.Name = "rdoClickSpeedImm";
            this.rdoClickSpeedImm.Size = new System.Drawing.Size(222, 19);
            this.rdoClickSpeedImm.TabIndex = 0;
            this.rdoClickSpeedImm.TabStop = true;
            this.rdoClickSpeedImm.Tag = "click_interval_none";
            this.rdoClickSpeedImm.Text = "No Interval (Click as fast as possible)";
            this.rdoClickSpeedImm.UseVisualStyleBackColor = true;
            // 
            // gbxStop
            // 
            this.gbxStop.Controls.Add(this.nudStopOnTimeMinute);
            this.gbxStop.Controls.Add(this.nudStopOnTimeHour);
            this.gbxStop.Controls.Add(this.lblStopOnMinPostfix);
            this.gbxStop.Controls.Add(this.lblStopOnHourPostfix);
            this.gbxStop.Controls.Add(this.rdoStopOnTime);
            this.gbxStop.Controls.Add(this.lblStopAfterPostfix);
            this.gbxStop.Controls.Add(this.nudStopAfterSec);
            this.gbxStop.Controls.Add(this.rdoStopAfterSec);
            this.gbxStop.Controls.Add(this.rdoStopNever);
            this.gbxStop.Location = new System.Drawing.Point(12, 144);
            this.gbxStop.Name = "gbxStop";
            this.gbxStop.Size = new System.Drawing.Size(350, 160);
            this.gbxStop.TabIndex = 1;
            this.gbxStop.TabStop = false;
            this.gbxStop.Tag = "stop_condition";
            this.gbxStop.Text = "Stop Condition";
            // 
            // nudStopOnTimeMinute
            // 
            this.nudStopOnTimeMinute.Enabled = false;
            this.nudStopOnTimeMinute.Location = new System.Drawing.Point(118, 123);
            this.nudStopOnTimeMinute.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.nudStopOnTimeMinute.Name = "nudStopOnTimeMinute";
            this.nudStopOnTimeMinute.Size = new System.Drawing.Size(55, 23);
            this.nudStopOnTimeMinute.TabIndex = 8;
            // 
            // nudStopOnTimeHour
            // 
            this.nudStopOnTimeHour.Enabled = false;
            this.nudStopOnTimeHour.Location = new System.Drawing.Point(33, 123);
            this.nudStopOnTimeHour.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.nudStopOnTimeHour.Name = "nudStopOnTimeHour";
            this.nudStopOnTimeHour.Size = new System.Drawing.Size(55, 23);
            this.nudStopOnTimeHour.TabIndex = 7;
            // 
            // lblStopOnMinPostfix
            // 
            this.lblStopOnMinPostfix.AutoSize = true;
            this.lblStopOnMinPostfix.Location = new System.Drawing.Point(179, 127);
            this.lblStopOnMinPostfix.Name = "lblStopOnMinPostfix";
            this.lblStopOnMinPostfix.Size = new System.Drawing.Size(36, 15);
            this.lblStopOnMinPostfix.TabIndex = 12;
            this.lblStopOnMinPostfix.Tag = "stop_condition_on_min_postfix";
            this.lblStopOnMinPostfix.Text = "(24h)";
            // 
            // lblStopOnHourPostfix
            // 
            this.lblStopOnHourPostfix.AutoSize = true;
            this.lblStopOnHourPostfix.Location = new System.Drawing.Point(93, 127);
            this.lblStopOnHourPostfix.Name = "lblStopOnHourPostfix";
            this.lblStopOnHourPostfix.Size = new System.Drawing.Size(10, 15);
            this.lblStopOnHourPostfix.TabIndex = 11;
            this.lblStopOnHourPostfix.Tag = "stop_condition_on_hour_postfix";
            this.lblStopOnHourPostfix.Text = ":";
            // 
            // rdoStopOnTime
            // 
            this.rdoStopOnTime.AutoSize = true;
            this.rdoStopOnTime.Location = new System.Drawing.Point(15, 100);
            this.rdoStopOnTime.Name = "rdoStopOnTime";
            this.rdoStopOnTime.Size = new System.Drawing.Size(68, 19);
            this.rdoStopOnTime.TabIndex = 6;
            this.rdoStopOnTime.Tag = "stop_condition_on";
            this.rdoStopOnTime.Text = "Stop on";
            this.rdoStopOnTime.UseVisualStyleBackColor = true;
            this.rdoStopOnTime.CheckedChanged += new System.EventHandler(this.rdoStopOnTime_CheckedChanged);
            // 
            // lblStopAfterPostfix
            // 
            this.lblStopAfterPostfix.AutoSize = true;
            this.lblStopAfterPostfix.Location = new System.Drawing.Point(93, 75);
            this.lblStopAfterPostfix.Name = "lblStopAfterPostfix";
            this.lblStopAfterPostfix.Size = new System.Drawing.Size(58, 15);
            this.lblStopAfterPostfix.TabIndex = 7;
            this.lblStopAfterPostfix.Tag = "stop_condition_after_postfix";
            this.lblStopAfterPostfix.Text = "second(s)";
            // 
            // nudStopAfterSec
            // 
            this.nudStopAfterSec.Enabled = false;
            this.nudStopAfterSec.Location = new System.Drawing.Point(33, 71);
            this.nudStopAfterSec.Maximum = new decimal(new int[] {
            3600,
            0,
            0,
            0});
            this.nudStopAfterSec.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudStopAfterSec.Name = "nudStopAfterSec";
            this.nudStopAfterSec.Size = new System.Drawing.Size(55, 23);
            this.nudStopAfterSec.TabIndex = 5;
            this.nudStopAfterSec.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // rdoStopAfterSec
            // 
            this.rdoStopAfterSec.AutoSize = true;
            this.rdoStopAfterSec.Location = new System.Drawing.Point(15, 47);
            this.rdoStopAfterSec.Name = "rdoStopAfterSec";
            this.rdoStopAfterSec.Size = new System.Drawing.Size(78, 19);
            this.rdoStopAfterSec.TabIndex = 4;
            this.rdoStopAfterSec.Tag = "stop_condition_after";
            this.rdoStopAfterSec.Text = "Stop after";
            this.rdoStopAfterSec.UseVisualStyleBackColor = true;
            this.rdoStopAfterSec.CheckedChanged += new System.EventHandler(this.rdoStopAfterSec_CheckedChanged);
            // 
            // rdoStopNever
            // 
            this.rdoStopNever.AutoSize = true;
            this.rdoStopNever.Checked = true;
            this.rdoStopNever.Location = new System.Drawing.Point(15, 22);
            this.rdoStopNever.Name = "rdoStopNever";
            this.rdoStopNever.Size = new System.Drawing.Size(56, 19);
            this.rdoStopNever.TabIndex = 3;
            this.rdoStopNever.TabStop = true;
            this.rdoStopNever.Tag = "stop_condition_never";
            this.rdoStopNever.Text = "Never";
            this.rdoStopNever.UseVisualStyleBackColor = true;
            // 
            // lblStatus
            // 
            this.lblStatus.Location = new System.Drawing.Point(12, 309);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(350, 18);
            this.lblStatus.TabIndex = 2;
            this.lblStatus.Tag = "tip_capslock";
            this.lblStatus.Text = "Enable [Caps Lock] to stop clicking temporarily.";
            this.lblStatus.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnStartStop
            // 
            this.btnStartStop.Location = new System.Drawing.Point(12, 330);
            this.btnStartStop.Name = "btnStartStop";
            this.btnStartStop.Size = new System.Drawing.Size(350, 29);
            this.btnStartStop.TabIndex = 9;
            this.btnStartStop.Tag = "button_start";
            this.btnStartStop.Text = "Start";
            this.btnStartStop.UseVisualStyleBackColor = true;
            this.btnStartStop.Click += new System.EventHandler(this.btnStartStop_Click);
            // 
            // tmrClicker
            // 
            this.tmrClicker.Interval = 50;
            this.tmrClicker.Tick += new System.EventHandler(this.tmrClicker_Tick);
            // 
            // tmrButtonEnabler
            // 
            this.tmrButtonEnabler.Interval = 1000;
            this.tmrButtonEnabler.Tick += new System.EventHandler(this.tmrButtonEnabler_Tick);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 371);
            this.Controls.Add(this.btnStartStop);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.gbxStop);
            this.Controls.Add(this.gbxClickSpeed);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainWindow";
            this.Text = "Numouse 1.0";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.gbxClickSpeed.ResumeLayout(false);
            this.gbxClickSpeed.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudClickSpeedInterval)).EndInit();
            this.gbxStop.ResumeLayout(false);
            this.gbxStop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudStopOnTimeMinute)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudStopOnTimeHour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudStopAfterSec)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private GroupBox gbxClickSpeed;
        private Label lblClickSpeedIntervalPostfix;
        private NumericUpDown nudClickSpeedInterval;
        private RadioButton rdoClickSpeedInterval;
        private RadioButton rdoClickSpeedImm;
        private GroupBox gbxStop;
        private Label lblStopOnMinPostfix;
        private Label lblStopOnHourPostfix;
        private RadioButton rdoStopOnTime;
        private Label lblStopAfterPostfix;
        private NumericUpDown nudStopAfterSec;
        private RadioButton rdoStopAfterSec;
        private RadioButton rdoStopNever;
        private Label lblStatus;
        private Button btnStartStop;
        private NumericUpDown nudStopOnTimeMinute;
        private NumericUpDown nudStopOnTimeHour;
        private System.Windows.Forms.Timer tmrClicker;
        private System.Windows.Forms.Timer tmrButtonEnabler;
        private Button btnEditSequence;
        private RadioButton rdoClickSpeedSequence;
    }
}