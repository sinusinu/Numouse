// Copyright 2021-2022 Woohyun Shin
// SPDX-License-Identifier: GPL-3.0-only

namespace Numouse {
    public partial class SequenceEditorWindow : Form {
        private LanguageManager lang;
        private string[] behaviorLabels = { "se_action_left", "se_action_right", "se_action_mid", "se_action_scr_up", "se_action_scr_down", "se_action_move_rel", "se_action_move_abs" };
        private readonly int[] behaviorParams = { 0, 0, 0, 1, 1, 2, 2 };
        internal List<Behavior>? behaviors;

        public SequenceEditorWindow() {
            InitializeComponent();

            lang = new LanguageManager();
            behaviors = null;
        }

        private void SequenceEditorWindow_Load(object sender, EventArgs e) {
            if (behaviors == null) behaviors = new List<Behavior>();
            LoadLangauge();
            UpdateList();
            
        }

        private void LoadLangauge() {
            var controlsToLoadText = new Control[] {
                this,
                lblCurrentTitle,
                gbxAdd,
                btnRemove,
                btnMoveUp,
                btnMoveDown,
                btnLoad,
                btnSave,
                btnOk,
                btnCancel,
                btnAddLeftClick,
                btnAddRightClick,
                btnAddMiddleClick,
                btnAddScrollUp,
                btnAddScrollDown,
                btnAddMoveRelative,
                btnAddMoveAbsolute
            };

            foreach (Control c in controlsToLoadText) {
                c.Text = lang.Get(c.Tag.ToString()!);
            }

            for (int i = 0; i < behaviorLabels.Length; i++) {
                behaviorLabels[i] = lang.Get(behaviorLabels[i]);
            }

            chBehavior!.Text = lang.Get(chBehavior!.Tag.ToString()!);
            chParam!.Text = lang.Get(chParam!.Tag.ToString()!);
        }

        internal void UpdateList() {
            lvSequence.Items.Clear();
            if (behaviors == null) return;

            for (int i = 0; i < behaviors.Count; i++) {
                lvSequence.Items.Add(behaviorLabels[(int)behaviors[i].type]);
                if (behaviorParams[(int)behaviors[i].type] == 1) {
                    lvSequence.Items[i].SubItems.Add(behaviors[i].param1.ToString());
                } else if (behaviorParams[(int)behaviors[i].type] == 2) {
                    lvSequence.Items[i].SubItems.Add(behaviors[i].param1.ToString() + ", " + behaviors[i].param2.ToString());
                }
            }
        }

        private void btnOk_Click(object sender, EventArgs e) {
            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e) {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void btnRemove_Click(object sender, EventArgs e) {
            if (behaviors == null || lvSequence.SelectedItems.Count == 0) return;
            behaviors.RemoveAt(lvSequence.SelectedIndices[0]);
            UpdateList();
            UpdateButtonEnable();
        }

        private void UpdateButtonEnable() {
            btnRemove.Enabled = lvSequence.SelectedItems.Count > 0;
            if (btnRemove.Enabled) {
                btnMoveUp.Enabled = lvSequence.SelectedIndices[0] > 0;
                btnMoveDown.Enabled = lvSequence.SelectedIndices[0] < lvSequence.Items.Count - 1;
            } else {
                btnMoveUp.Enabled = false;
                btnMoveDown.Enabled = false;
            }
        }

        private void lvSequence_SelectedIndexChanged(object sender, EventArgs e) {
            UpdateButtonEnable();
        }

        private void btnAddLeftClick_Click(object sender, EventArgs e) {
            behaviors!.Add(new Behavior(Behavior.BehaviorType.LeftClick, 0, 0));
            UpdateList();
        }

        private void btnAddRightClick_Click(object sender, EventArgs e) {
            behaviors!.Add(new Behavior(Behavior.BehaviorType.RightClick, 0, 0));
            UpdateList();
        }

        private void btnAddMiddleClick_Click(object sender, EventArgs e) {
            behaviors!.Add(new Behavior(Behavior.BehaviorType.MiddleClick, 0, 0));
            UpdateList();
        }

        private void btnAddScrollUp_Click(object sender, EventArgs e) {
            using (var pd = new ParamWindow()) {
                pd.paramTitle = lang.Get("param_title_scroll");
                pd.paramCount = ParamWindow.ParamCount.One;
                pd.ShowDialog();
                if (pd.DialogResult == DialogResult.OK) {
                    behaviors!.Add(new Behavior(Behavior.BehaviorType.ScrollUp, pd.Param1, 0));
                    UpdateList();
                }
            }
        }

        private void btnAddScrollDown_Click(object sender, EventArgs e) {
            using (var pd = new ParamWindow()) {
                pd.paramTitle = lang.Get("param_title_scroll");
                pd.paramCount = ParamWindow.ParamCount.One;
                pd.ShowDialog();
                if (pd.DialogResult == DialogResult.OK) {
                    behaviors!.Add(new Behavior(Behavior.BehaviorType.ScrollDown, pd.Param1, 0));
                    UpdateList();
                }
            }
        }

        private void btnAddMoveRelative_Click(object sender, EventArgs e) {
            using (var pd = new ParamWindow()) {
                pd.paramTitle = lang.Get("param_title_move_rel");
                pd.paramCount = ParamWindow.ParamCount.Two;
                pd.ShowDialog();
                if (pd.DialogResult == DialogResult.OK) {
                    behaviors!.Add(new Behavior(Behavior.BehaviorType.MoveRelative, pd.Param1, pd.Param2));
                    UpdateList();
                }
            }
        }

        private void btnAddMoveAbsolute_Click(object sender, EventArgs e) {
            using (var pd = new ParamWindow()) {
                pd.paramTitle = lang.Get("param_title_move_abs");
                pd.paramCount = ParamWindow.ParamCount.Two;
                pd.ShowDialog();
                if (pd.DialogResult == DialogResult.OK) {
                    behaviors!.Add(new Behavior(Behavior.BehaviorType.MoveAbsolute, pd.Param1, pd.Param2));
                    UpdateList();
                }
            }
        }

        private void btnMoveUp_Click(object sender, EventArgs e) {
            var selectedIndex = lvSequence.SelectedIndices[0];
            var tmp = behaviors![selectedIndex];
            behaviors![selectedIndex] = behaviors![selectedIndex - 1];
            behaviors![selectedIndex - 1] = tmp;
            UpdateList();
            lvSequence.SelectedItems.Clear();
            lvSequence.Items[selectedIndex - 1].Selected = true;
            lvSequence.Select();
        }

        private void btnMoveDown_Click(object sender, EventArgs e) {
            var selectedIndex = lvSequence.SelectedIndices[0];
            var tmp = behaviors![selectedIndex];
            behaviors![selectedIndex] = behaviors![selectedIndex + 1];
            behaviors![selectedIndex + 1] = tmp;
            UpdateList();
            lvSequence.SelectedItems.Clear();
            lvSequence.Items[selectedIndex + 1].Selected = true;
            lvSequence.Select();
        }

        private void lvSequence_ColumnWidthChanging(object sender, ColumnWidthChangingEventArgs e) {
            e.Cancel = true;
            e.NewWidth = lvSequence.Columns[e.ColumnIndex].Width;
        }
    }
}
