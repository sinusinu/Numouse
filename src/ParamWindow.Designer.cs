// Copyright 2021-2022 Woohyun Shin
// SPDX-License-Identifier: GPL-3.0-only

namespace Numouse {
    partial class ParamWindow {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.lblTitle = new System.Windows.Forms.Label();
            this.nudValuePrimary = new System.Windows.Forms.NumericUpDown();
            this.nudValueSecondary = new System.Windows.Forms.NumericUpDown();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudValuePrimary)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudValueSecondary)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(12, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(39, 15);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "label1";
            // 
            // nudValuePrimary
            // 
            this.nudValuePrimary.Location = new System.Drawing.Point(14, 29);
            this.nudValuePrimary.Maximum = new decimal(new int[] {
            32767,
            0,
            0,
            0});
            this.nudValuePrimary.Minimum = new decimal(new int[] {
            32766,
            0,
            0,
            -2147483648});
            this.nudValuePrimary.Name = "nudValuePrimary";
            this.nudValuePrimary.Size = new System.Drawing.Size(131, 23);
            this.nudValuePrimary.TabIndex = 1;
            this.nudValuePrimary.KeyDown += new System.Windows.Forms.KeyEventHandler(this.nudValuePrimary_KeyDown);
            // 
            // nudValueSecondary
            // 
            this.nudValueSecondary.Location = new System.Drawing.Point(157, 29);
            this.nudValueSecondary.Maximum = new decimal(new int[] {
            32767,
            0,
            0,
            0});
            this.nudValueSecondary.Minimum = new decimal(new int[] {
            32766,
            0,
            0,
            -2147483648});
            this.nudValueSecondary.Name = "nudValueSecondary";
            this.nudValueSecondary.Size = new System.Drawing.Size(131, 23);
            this.nudValueSecondary.TabIndex = 2;
            this.nudValueSecondary.KeyDown += new System.Windows.Forms.KeyEventHandler(this.nudValuePrimary_KeyDown);
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(134, 58);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 3;
            this.btnOk.Tag = "param_ok";
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(215, 58);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Tag = "param_cancel";
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // ParamWindow
            // 
            this.AcceptButton = this.btnOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(302, 90);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.nudValueSecondary);
            this.Controls.Add(this.nudValuePrimary);
            this.Controls.Add(this.lblTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ParamWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Tag = "param_wtitle";
            this.Text = "Input Parameter";
            this.Load += new System.EventHandler(this.ParamWindow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudValuePrimary)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudValueSecondary)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblTitle;
        private NumericUpDown nudValuePrimary;
        private NumericUpDown nudValueSecondary;
        private Button btnOk;
        private Button btnCancel;
    }
}