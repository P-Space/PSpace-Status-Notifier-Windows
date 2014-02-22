using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PSpaceStatusChanger
{
    public partial class Options : Form
    {
        bool autorun_enabled = false;
        int silent = 0;

        public Options()
        {
            InitializeComponent();
            this.Load += new EventHandler(Options_Load);
        }

        void Options_Load(object sender, EventArgs e)
        {
            autorun_enabled = Program.IsStartupItem();
            silent = Properties.Settings.Default.silent_mode;

            if (autorun_enabled)
            {
                IsEnabledLbl.Text = "ENABLED";
                IsEnabledLbl.ForeColor = Color.DarkGreen;
                AutoRunChkBox.Checked = true;
            }
            else
            {
                IsEnabledLbl.Text = "DISABLED";
                IsEnabledLbl.ForeColor = Color.DarkRed;
                AutoRunChkBox.Checked = false;
            }

            if (silent==1)
            {
                SilentIsEnabledLbl.Text = "ENABLED";
                SilentIsEnabledLbl.ForeColor = Color.DarkGreen;
                SilentChkBox.Checked = true;
            }
            else
            {
                SilentIsEnabledLbl.Text = "DISABLED";
                SilentIsEnabledLbl.ForeColor = Color.DarkRed;
                SilentChkBox.Checked = false;
            }

            TimeIntTxt.Text = Properties.Settings.Default.refresh_interval.ToString();
        }

        private void SetTimeBtn_Click(object sender, EventArgs e)
        {
            int time = 1;

            if (Int32.TryParse(TimeIntTxt.Text, out time) && time > 0)
                Properties.Settings.Default.refresh_interval = time;
            else
                MessageBox.Show("You've set an invalid value");

            SetTimeBtn.Text = "Done!";
            SetTimeBtn.Enabled = false;

            Properties.Settings.Default.Save();

            Program.UpdateTime();            
        }

        private void AutoRunChkBox_CheckedChanged(object sender, EventArgs e)
        {
            if (autorun_enabled)
            {
                Program.DisableAutoStartup();
            }
            else
            {
                Program.EnableAutoStartup();
            }
            Options_Load(null, null);
        }

        private void SilentChkBox_CheckedChanged(object sender, EventArgs e)
        {
            if (silent==1)
            {
                Properties.Settings.Default.silent_mode = 0;
            }
            else
            {
                Properties.Settings.Default.silent_mode = 1;
            }
            Options_Load(null, null);
            Properties.Settings.Default.Save();
            Program.UpdateSilent();
        }

    }
}
