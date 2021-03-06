﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;
using System.Windows.Forms;
using PSpaceStatusChanger.Properties;

namespace PSpaceStatusChanger
{
    class ContextMenu
    {

        public ContextMenuStrip Create()
        {
            // Add the default menu options.
            ContextMenuStrip menu = new ContextMenuStrip();
            ToolStripMenuItem item;
            ToolStripSeparator sep;

            // Open.
            item = new ToolStripMenuItem();
            item.Image = Resources.Shop_Open_32;
            item.Text = "P-Space open";
            item.Click += new EventHandler(open_Click);
            menu.Items.Add(item);

            // Separator.
            sep = new ToolStripSeparator();
            menu.Items.Add(sep);

            // Closed.
            item = new ToolStripMenuItem();
            item.Image = Resources.Shop_Closed_32;
            item.Text = "P-Space closed";
            item.Click += new EventHandler(closed_Click);
            menu.Items.Add(item);

            // Separator.
            sep = new ToolStripSeparator();
            menu.Items.Add(sep);

            // Options.
            item = new ToolStripMenuItem();
            item.Image = Resources.Options_32;
            item.Text = "Options";
            item.Click += new EventHandler(options_Click);
            menu.Items.Add(item);

            // Separator.
            sep = new ToolStripSeparator();
            menu.Items.Add(sep);

            // History.
            item = new ToolStripMenuItem();
            item.Image = Resources.History_32;
            item.Text = "Last event";
            item.Click += new EventHandler(last_Click);
            menu.Items.Add(item);

            // Separator.
            sep = new ToolStripSeparator();
            menu.Items.Add(sep);

            // Exit.
            item = new ToolStripMenuItem();
            item.Text = "Exit";
            item.Click += new System.EventHandler(Exit_Click);
            item.Image = Resources.exit_32;
            menu.Items.Add(item);

            return menu;
        }

        void options_Click(object sender, EventArgs e)
        {
            Options opt = new Options();
            opt.Show();
        }

        void open_Click(object sender, EventArgs e)
        {
            Requests.SetStatus(true);
        }

        void closed_Click(object sender, EventArgs e)
        {
            Requests.SetStatus(false);
        }

        void last_Click(object sender, EventArgs e)
        {
            var status = Requests.CheckStatus();
            var last = Requests.GetLastEvents(1);
            var str = "P-Space is: "+((status==1)?"Open":"Closed")+"\nLast event: "+(last!=null?last[0].extra:"-");
            MessageBox.Show(str,"P-Space Status and History");
        }

        void Exit_Click(object sender, EventArgs e)
        {
            // Quit without further ado.
            Application.Exit();
        }
    }
}
