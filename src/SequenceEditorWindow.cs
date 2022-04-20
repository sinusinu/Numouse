using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Numouse {
    public partial class SequenceEditorWindow : Form {
        private LanguageManager lang;
        internal List<Behavior> behaviors;

        public SequenceEditorWindow() {
            InitializeComponent();

            lang = new LanguageManager();
            behaviors = new List<Behavior>();
        }

        private void SequenceEditorWindow_Load(object sender, EventArgs e) {
            LoadLangauge();
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
        }

        private void btnOk_Click(object sender, EventArgs e) {
            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e) {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
