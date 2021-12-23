/*
 *  Numouse
 *  Copyright (C) 2021 Woohyun Shin
 *
 *  This program is free software: you can redistribute it and/or modify
 *  it under the terms of the GNU General Public License as published by
 *  the Free Software Foundation, either version 3 of the License, or
 *  (at your option) any later version.
 *
 *  This program is distributed in the hope that it will be useful,
 *  but WITHOUT ANY WARRANTY; without even the implied warranty of
 *  MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 *  GNU General Public License for more details.
 *
 *  You should have received a copy of the GNU General Public License
 *  along with this program.  If not, see <https://www.gnu.org/licenses/>.
 */

using static Numouse.NativeFunctions;

namespace Numouse {
    public partial class MainWindow : Form {
        private enum ClickSpeed { Immediate, Interval, Sequence }
        private enum ClickStop { Never, AfterSec, OnTime }

        private ClickSpeed clickSpeedMode {
            get {
                if (rdoClickSpeedInterval.Checked) return ClickSpeed.Interval;
                if (rdoClickSpeedSequence.Checked) return ClickSpeed.Sequence;
                else return ClickSpeed.Immediate;
            }
        }
        private int clickIntervalSec { get { return decimal.ToInt32(nudClickSpeedInterval.Value); } }

        private ClickStop clickStopMode {
            get {
                if (rdoStopAfterSec.Checked) return ClickStop.AfterSec;
                else if (rdoStopOnTime.Checked) return ClickStop.OnTime;
                else return ClickStop.Never;
            }
        }
        private int clickStopAfterSec { get { return decimal.ToInt32(nudStopAfterSec.Value); } }
        private int clickStopOnTimeHour { get { return decimal.ToInt32(nudStopOnTimeHour.Value); } }
        private int clickStopOnTimeMinute { get { return decimal.ToInt32(nudStopOnTimeMinute.Value); } }

        private DateTime clickIntervalTargetNextTime;
        private DateTime clickStopAfterTargetTime;

        private bool isCapsLockOn;
        private bool isRunning = false;

        private LanguageManager lang;

        public MainWindow() {
            InitializeComponent();

            lang = new LanguageManager();
        }

        private void rdoClickSpeedInterval_CheckedChanged(object sender, EventArgs e) {
            nudClickSpeedInterval.Enabled = rdoClickSpeedInterval.Checked;
        }

        private void rdoStopAfterSec_CheckedChanged(object sender, EventArgs e) {
            nudStopAfterSec.Enabled = rdoStopAfterSec.Checked;
        }

        private void rdoStopOnTime_CheckedChanged(object sender, EventArgs e) {
            nudStopOnTimeHour.Enabled = rdoStopOnTime.Checked;
            nudStopOnTimeMinute.Enabled = rdoStopOnTime.Checked;
        }

        private void MainWindow_Load(object sender, EventArgs e) {
            LoadLangauge();
        }

        private void LoadLangauge() {
            var controlsToLoadText = new Control[] {
                gbxClickSpeed,
                rdoClickSpeedImm,
                rdoClickSpeedInterval,
                lblClickSpeedIntervalPostfix,
                gbxStop,
                rdoStopNever,
                rdoStopAfterSec,
                lblStopAfterPostfix,
                rdoStopOnTime,
                lblStopOnHourPostfix,
                lblStopOnMinPostfix,
                lblStatus,
                btnStartStop,
                rdoClickSpeedSequence,
                btnEditSequence
            };

            foreach (Control c in controlsToLoadText) {
                c.Text = lang.Get(c.Tag.ToString()!);
            }
        }

        private void btnStartStop_Click(object sender, EventArgs e) {
            isRunning = !isRunning;
            if (clickSpeedMode == ClickSpeed.Sequence) {
                // TODO: do sequence thing
            } else {
                if (isRunning) {
                    tmrClicker.Enabled = true;

                    gbxClickSpeed.Enabled = false;
                    gbxStop.Enabled = false;
                    btnStartStop.Text = lang.Get("button_stop");
                    btnStartStop.Enabled = false;
                    tmrButtonEnabler.Enabled = true;
                    lblStatus.Text = lang.Get("tip_capslock");
                    lblStatus.ForeColor = Color.Black;

                    if (clickSpeedMode == ClickSpeed.Interval) clickIntervalTargetNextTime = DateTime.Now.AddSeconds(clickIntervalSec);
                    if (clickStopMode == ClickStop.AfterSec) clickStopAfterTargetTime = DateTime.Now.AddSeconds(clickStopAfterSec);
                } else {
                    tmrClicker.Enabled = false;

                    gbxClickSpeed.Enabled = true;
                    gbxStop.Enabled = true;
                    btnStartStop.Text = lang.Get("button_start");
                    lblStatus.Text = lang.Get("tip_capslock");
                    lblStatus.ForeColor = Color.Black;
                }
            }
        }

        private void tmrClicker_Tick(object sender, EventArgs e) {
            if (clickStopMode == ClickStop.AfterSec && DateTime.Now > clickStopAfterTargetTime) {
                btnStartStop_Click(sender, e);
                System.Media.SystemSounds.Exclamation.Play();
                return;
            } else if (clickStopMode == ClickStop.OnTime) {
                var now = DateTime.Now;
                if (now.Hour == clickStopOnTimeHour && now.Minute == clickStopOnTimeMinute) {
                    btnStartStop_Click(sender, e);
                    System.Media.SystemSounds.Exclamation.Play();
                    return;
                }
            }

            bool isCapsLockOnNow = IsKeyLocked(Keys.CapsLock);
            if (isCapsLockOn != isCapsLockOnNow) {
                if (isCapsLockOnNow) {
                    lblStatus.Text = lang.Get("tip_capslock_enabled");
                    lblStatus.ForeColor = Color.Red;
                } else {
                    lblStatus.Text = lang.Get("tip_capslock");
                    lblStatus.ForeColor = Color.Black;
                }
                isCapsLockOn = isCapsLockOnNow;
            }

            if (clickSpeedMode == ClickSpeed.Interval) {
                if (DateTime.Now > clickIntervalTargetNextTime) {
                    while (clickIntervalTargetNextTime < DateTime.Now) clickIntervalTargetNextTime = clickIntervalTargetNextTime.AddSeconds(clickIntervalSec);
                    if (!isCapsLockOn) MouseActions.SimulateClick();
                }
            } else {
                if (!isCapsLockOn) MouseActions.SimulateClick();
            }
        }

        private void tmrButtonEnabler_Tick(object sender, EventArgs e) {
            tmrButtonEnabler.Enabled = false;
            btnStartStop.Enabled = true;
        }
    }
}