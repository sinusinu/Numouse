// Copyright 2021-2022 Woohyun Shin
// SPDX-License-Identifier: GPL-3.0-only

namespace Numouse {
    public partial class ParamWindow : Form {
        private LanguageManager lang;

        internal enum ParamCount { One, Two }
        internal string paramTitle = "";
        internal ParamCount paramCount = ParamCount.One;

        internal int Param1 { get { return (int)nudValuePrimary.Value; } }
        internal int Param2 { get { return (int)nudValueSecondary.Value; } }

        public ParamWindow() {
            InitializeComponent();

            lang = new LanguageManager();
        }

        private void LoadLangauge() {
            var controlsToLoadText = new Control[] {
                this,
                btnOk,
                btnCancel,
            };

            foreach (Control c in controlsToLoadText) {
                c.Text = lang.Get(c.Tag.ToString()!);
            }
        }

        private void ParamWindow_Load(object sender, EventArgs e) {
            if (paramCount == ParamCount.One) {
                nudValuePrimary.Width = 274;
                nudValueSecondary.Visible = false;
            } else {
                nudValuePrimary.Width = 131;
                nudValueSecondary.Visible = true;
            }
            lblTitle.Text = paramTitle;

            LoadLangauge();
        }

        private void btnOk_Click(object sender, EventArgs e) {
            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e) {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void nudValuePrimary_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Enter) btnOk_Click(sender, new EventArgs());
            else if (e.KeyCode == Keys.Escape) btnCancel_Click(sender, new EventArgs());
        }
    }
}
