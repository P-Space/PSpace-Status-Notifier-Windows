namespace PSpaceStatusChanger
{
    partial class Options
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.IsEnabledLbl = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TimeIntTxt = new System.Windows.Forms.TextBox();
            this.SetTimeBtn = new System.Windows.Forms.Button();
            this.SilentIsEnabledLbl = new System.Windows.Forms.Label();
            this.AutoRunChkBox = new System.Windows.Forms.CheckBox();
            this.SilentChkBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // IsEnabledLbl
            // 
            this.IsEnabledLbl.AutoSize = true;
            this.IsEnabledLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.IsEnabledLbl.Location = new System.Drawing.Point(186, 24);
            this.IsEnabledLbl.Name = "IsEnabledLbl";
            this.IsEnabledLbl.Size = new System.Drawing.Size(92, 20);
            this.IsEnabledLbl.TabIndex = 1;
            this.IsEnabledLbl.Text = "ENABLED";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(260, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "P-Space Status and Event Notifier 1.3 # eparon-2014";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label2.Location = new System.Drawing.Point(31, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(165, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Refresh Interval (sec):";
            // 
            // TimeIntTxt
            // 
            this.TimeIntTxt.Location = new System.Drawing.Point(202, 85);
            this.TimeIntTxt.Name = "TimeIntTxt";
            this.TimeIntTxt.Size = new System.Drawing.Size(61, 20);
            this.TimeIntTxt.TabIndex = 5;
            // 
            // SetTimeBtn
            // 
            this.SetTimeBtn.Location = new System.Drawing.Point(102, 118);
            this.SetTimeBtn.Name = "SetTimeBtn";
            this.SetTimeBtn.Size = new System.Drawing.Size(111, 23);
            this.SetTimeBtn.TabIndex = 6;
            this.SetTimeBtn.Text = "Set";
            this.SetTimeBtn.UseVisualStyleBackColor = true;
            this.SetTimeBtn.Click += new System.EventHandler(this.SetTimeBtn_Click);
            // 
            // SilentIsEnabledLbl
            // 
            this.SilentIsEnabledLbl.AutoSize = true;
            this.SilentIsEnabledLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.SilentIsEnabledLbl.Location = new System.Drawing.Point(186, 49);
            this.SilentIsEnabledLbl.Name = "SilentIsEnabledLbl";
            this.SilentIsEnabledLbl.Size = new System.Drawing.Size(92, 20);
            this.SilentIsEnabledLbl.TabIndex = 8;
            this.SilentIsEnabledLbl.Text = "ENABLED";
            // 
            // AutoRunChkBox
            // 
            this.AutoRunChkBox.AutoSize = true;
            this.AutoRunChkBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.AutoRunChkBox.Location = new System.Drawing.Point(35, 24);
            this.AutoRunChkBox.Name = "AutoRunChkBox";
            this.AutoRunChkBox.Size = new System.Drawing.Size(110, 22);
            this.AutoRunChkBox.TabIndex = 9;
            this.AutoRunChkBox.Text = "Autorun app:";
            this.AutoRunChkBox.UseVisualStyleBackColor = true;
            this.AutoRunChkBox.CheckedChanged += new System.EventHandler(this.AutoRunChkBox_CheckedChanged);
            // 
            // SilentChkBox
            // 
            this.SilentChkBox.AutoSize = true;
            this.SilentChkBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.SilentChkBox.Location = new System.Drawing.Point(35, 49);
            this.SilentChkBox.Name = "SilentChkBox";
            this.SilentChkBox.Size = new System.Drawing.Size(146, 22);
            this.SilentChkBox.TabIndex = 10;
            this.SilentChkBox.Text = "Mute door events:";
            this.SilentChkBox.UseVisualStyleBackColor = true;
            this.SilentChkBox.CheckedChanged += new System.EventHandler(this.SilentChkBox_CheckedChanged);
            // 
            // Options
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(306, 176);
            this.Controls.Add(this.SilentChkBox);
            this.Controls.Add(this.AutoRunChkBox);
            this.Controls.Add(this.SilentIsEnabledLbl);
            this.Controls.Add(this.SetTimeBtn);
            this.Controls.Add(this.TimeIntTxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.IsEnabledLbl);
            this.Name = "Options";
            this.Text = "Options";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label IsEnabledLbl;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TimeIntTxt;
        private System.Windows.Forms.Button SetTimeBtn;
        private System.Windows.Forms.Label SilentIsEnabledLbl;
        private System.Windows.Forms.CheckBox AutoRunChkBox;
        private System.Windows.Forms.CheckBox SilentChkBox;
    }
}