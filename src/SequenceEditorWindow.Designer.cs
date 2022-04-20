// Copyright 2021-2022 Woohyun Shin
// SPDX-License-Identifier: GPL-3.0-only

namespace Numouse {
    partial class SequenceEditorWindow {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SequenceEditorWindow));
            this.lblCurrentTitle = new System.Windows.Forms.Label();
            this.lvSequence = new System.Windows.Forms.ListView();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnMoveUp = new System.Windows.Forms.Button();
            this.btnMoveDown = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.gbxAdd = new System.Windows.Forms.GroupBox();
            this.btnAddMoveAbsolute = new System.Windows.Forms.Button();
            this.btnAddMoveRelative = new System.Windows.Forms.Button();
            this.btnAddScrollDown = new System.Windows.Forms.Button();
            this.btnAddScrollUp = new System.Windows.Forms.Button();
            this.btnAddMiddleClick = new System.Windows.Forms.Button();
            this.btnAddRightClick = new System.Windows.Forms.Button();
            this.btnAddLeftClick = new System.Windows.Forms.Button();
            this.gbxAdd.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblCurrentTitle
            // 
            this.lblCurrentTitle.AutoSize = true;
            this.lblCurrentTitle.Location = new System.Drawing.Point(12, 9);
            this.lblCurrentTitle.Name = "lblCurrentTitle";
            this.lblCurrentTitle.Size = new System.Drawing.Size(103, 15);
            this.lblCurrentTitle.TabIndex = 1;
            this.lblCurrentTitle.Tag = "se_current_title";
            this.lblCurrentTitle.Text = "Current Sequence";
            // 
            // lvSequence
            // 
            this.lvSequence.Location = new System.Drawing.Point(12, 27);
            this.lvSequence.Name = "lvSequence";
            this.lvSequence.Size = new System.Drawing.Size(319, 357);
            this.lvSequence.TabIndex = 2;
            this.lvSequence.UseCompatibleStateImageBehavior = false;
            // 
            // btnOk
            // 
            this.btnOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOk.Location = new System.Drawing.Point(345, 361);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(102, 23);
            this.btnOk.TabIndex = 3;
            this.btnOk.Tag = "se_ok";
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.Location = new System.Drawing.Point(453, 361);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(102, 23);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Tag = "se_cancel";
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRemove.Enabled = false;
            this.btnRemove.Location = new System.Drawing.Point(345, 274);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(210, 23);
            this.btnRemove.TabIndex = 5;
            this.btnRemove.Tag = "se_remove";
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnMoveUp
            // 
            this.btnMoveUp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMoveUp.Enabled = false;
            this.btnMoveUp.Location = new System.Drawing.Point(345, 303);
            this.btnMoveUp.Name = "btnMoveUp";
            this.btnMoveUp.Size = new System.Drawing.Size(102, 23);
            this.btnMoveUp.TabIndex = 7;
            this.btnMoveUp.Tag = "se_up";
            this.btnMoveUp.Text = "Move Up";
            this.btnMoveUp.UseVisualStyleBackColor = true;
            // 
            // btnMoveDown
            // 
            this.btnMoveDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMoveDown.Enabled = false;
            this.btnMoveDown.Location = new System.Drawing.Point(453, 303);
            this.btnMoveDown.Name = "btnMoveDown";
            this.btnMoveDown.Size = new System.Drawing.Size(102, 23);
            this.btnMoveDown.TabIndex = 8;
            this.btnMoveDown.Tag = "se_down";
            this.btnMoveDown.Text = "Move Down";
            this.btnMoveDown.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Location = new System.Drawing.Point(453, 332);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(102, 23);
            this.btnSave.TabIndex = 10;
            this.btnSave.Tag = "se_save";
            this.btnSave.Text = "Save...";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // btnLoad
            // 
            this.btnLoad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLoad.Location = new System.Drawing.Point(345, 332);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(102, 23);
            this.btnLoad.TabIndex = 9;
            this.btnLoad.Tag = "se_load";
            this.btnLoad.Text = "Load...";
            this.btnLoad.UseVisualStyleBackColor = true;
            // 
            // gbxAdd
            // 
            this.gbxAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.gbxAdd.Controls.Add(this.btnAddMoveAbsolute);
            this.gbxAdd.Controls.Add(this.btnAddMoveRelative);
            this.gbxAdd.Controls.Add(this.btnAddScrollDown);
            this.gbxAdd.Controls.Add(this.btnAddScrollUp);
            this.gbxAdd.Controls.Add(this.btnAddMiddleClick);
            this.gbxAdd.Controls.Add(this.btnAddRightClick);
            this.gbxAdd.Controls.Add(this.btnAddLeftClick);
            this.gbxAdd.Location = new System.Drawing.Point(345, 12);
            this.gbxAdd.Name = "gbxAdd";
            this.gbxAdd.Size = new System.Drawing.Size(210, 253);
            this.gbxAdd.TabIndex = 11;
            this.gbxAdd.TabStop = false;
            this.gbxAdd.Tag = "se_add_group";
            this.gbxAdd.Text = "Add Behavior";
            // 
            // btnAddMoveAbsolute
            // 
            this.btnAddMoveAbsolute.Location = new System.Drawing.Point(8, 220);
            this.btnAddMoveAbsolute.Name = "btnAddMoveAbsolute";
            this.btnAddMoveAbsolute.Size = new System.Drawing.Size(194, 23);
            this.btnAddMoveAbsolute.TabIndex = 6;
            this.btnAddMoveAbsolute.Tag = "se_action_move_abs";
            this.btnAddMoveAbsolute.Text = "button7";
            this.btnAddMoveAbsolute.UseVisualStyleBackColor = true;
            // 
            // btnAddMoveRelative
            // 
            this.btnAddMoveRelative.Location = new System.Drawing.Point(8, 187);
            this.btnAddMoveRelative.Name = "btnAddMoveRelative";
            this.btnAddMoveRelative.Size = new System.Drawing.Size(194, 23);
            this.btnAddMoveRelative.TabIndex = 5;
            this.btnAddMoveRelative.Tag = "se_action_move_rel";
            this.btnAddMoveRelative.Text = "se_action_move_rel";
            this.btnAddMoveRelative.UseVisualStyleBackColor = true;
            // 
            // btnAddScrollDown
            // 
            this.btnAddScrollDown.Location = new System.Drawing.Point(8, 154);
            this.btnAddScrollDown.Name = "btnAddScrollDown";
            this.btnAddScrollDown.Size = new System.Drawing.Size(194, 23);
            this.btnAddScrollDown.TabIndex = 4;
            this.btnAddScrollDown.Tag = "se_action_scr_down";
            this.btnAddScrollDown.Text = "button5";
            this.btnAddScrollDown.UseVisualStyleBackColor = true;
            // 
            // btnAddScrollUp
            // 
            this.btnAddScrollUp.Location = new System.Drawing.Point(8, 121);
            this.btnAddScrollUp.Name = "btnAddScrollUp";
            this.btnAddScrollUp.Size = new System.Drawing.Size(194, 23);
            this.btnAddScrollUp.TabIndex = 3;
            this.btnAddScrollUp.Tag = "se_action_scr_up";
            this.btnAddScrollUp.Text = "button4";
            this.btnAddScrollUp.UseVisualStyleBackColor = true;
            // 
            // btnAddMiddleClick
            // 
            this.btnAddMiddleClick.Location = new System.Drawing.Point(8, 88);
            this.btnAddMiddleClick.Name = "btnAddMiddleClick";
            this.btnAddMiddleClick.Size = new System.Drawing.Size(194, 23);
            this.btnAddMiddleClick.TabIndex = 2;
            this.btnAddMiddleClick.Tag = "se_action_mid";
            this.btnAddMiddleClick.Text = "button3";
            this.btnAddMiddleClick.UseVisualStyleBackColor = true;
            // 
            // btnAddRightClick
            // 
            this.btnAddRightClick.Location = new System.Drawing.Point(8, 55);
            this.btnAddRightClick.Name = "btnAddRightClick";
            this.btnAddRightClick.Size = new System.Drawing.Size(194, 23);
            this.btnAddRightClick.TabIndex = 1;
            this.btnAddRightClick.Tag = "se_action_right";
            this.btnAddRightClick.Text = "button2";
            this.btnAddRightClick.UseVisualStyleBackColor = true;
            // 
            // btnAddLeftClick
            // 
            this.btnAddLeftClick.Location = new System.Drawing.Point(8, 22);
            this.btnAddLeftClick.Name = "btnAddLeftClick";
            this.btnAddLeftClick.Size = new System.Drawing.Size(194, 23);
            this.btnAddLeftClick.TabIndex = 0;
            this.btnAddLeftClick.Tag = "se_action_left";
            this.btnAddLeftClick.Text = "button1";
            this.btnAddLeftClick.UseVisualStyleBackColor = true;
            // 
            // SequenceEditorWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(567, 396);
            this.Controls.Add(this.gbxAdd);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.btnMoveDown);
            this.Controls.Add(this.btnMoveUp);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.lvSequence);
            this.Controls.Add(this.lblCurrentTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "SequenceEditorWindow";
            this.Tag = "se_title";
            this.Text = "Configure";
            this.Load += new System.EventHandler(this.SequenceEditorWindow_Load);
            this.gbxAdd.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label lblCurrentTitle;
        private ListView lvSequence;
        private Button btnOk;
        private Button btnCancel;
        private Button btnRemove;
        private Button btnMoveUp;
        private Button btnMoveDown;
        private Button btnSave;
        private Button btnLoad;
        private GroupBox gbxAdd;
        private Button btnAddMoveAbsolute;
        private Button btnAddMoveRelative;
        private Button btnAddScrollDown;
        private Button btnAddScrollUp;
        private Button btnAddMiddleClick;
        private Button btnAddRightClick;
        private Button btnAddLeftClick;
    }
}