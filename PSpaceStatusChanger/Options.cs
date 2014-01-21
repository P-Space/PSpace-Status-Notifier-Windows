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

        public Options()
        {
            InitializeComponent();
            this.Load += new EventHandler(Options_Load);
        }

        void Options_Load(object sender, EventArgs e)
        {
            autorun_enabled = Program.IsStartupItem();

            if (autorun_enabled)
            {
                IsEnabledLbl.Text = "ENABLED";
                IsEnabledLbl.ForeColor = Color.DarkGreen;
                ToggleActionBtn.Text = "Disable Autorun";
            }
            else
            {
                IsEnabledLbl.Text = "DISABLED";
                IsEnabledLbl.ForeColor = Color.DarkRed;
                ToggleActionBtn.Text = "Enable Autorun";
            }

            TimeIntTxt.Text = Properties.Settings.Default.refresh_interval.ToString();
        }

        private void ToggleActionBtn_Click(object sender, EventArgs e)
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

        private void SetTimeBtn_Click(object sender, EventArgs e)
        {
            int time = 1;

            if (Int32.TryParse(TimeIntTxt.Text, out time) && time > 0)
                Properties.Settings.Default.refresh_interval = time;
            else
                MessageBox.Show("You've set an invalid value");

            SetTimeBtn.Text = "Done!";
            SetTimeBtn.Enabled = false;

            Program.UpdateTime();

            Properties.Settings.Default.Save();
        }

    }
}
