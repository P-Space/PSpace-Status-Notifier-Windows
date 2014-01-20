using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using PSpaceStatusChanger.Properties;

namespace PSpaceStatusChanger
{
    class TrayIcon : IDisposable
    {
        NotifyIcon nIc;
        //bool showsMessage = false;

        public TrayIcon()
        {
            nIc = new NotifyIcon();
        }

        public void Display()
        {
            nIc.Icon = Resources.closed;
            nIc.Text = "P-Space Notifier";
            nIc.Visible = true;

            // Attach a context menu.
            nIc.ContextMenuStrip = new ContextMenu().Create();
        }

        public void SetOpen()
        {
            nIc.Icon = Resources.open;
            nIc.Text = "P-Space is now open!";
        }

        public void ShowMessage(string header,string msg)
        {
            nIc.ShowBalloonTip(3000, header, msg, ToolTipIcon.Info);
        }

        public void SetClosed()
        {
            nIc.Icon = Resources.closed;
            nIc.Text = "P-Space is now closed!";
        }

        public void Dispose()
        {
            nIc.Dispose();
        }
    }
}
