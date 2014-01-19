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
            this.label1 = new System.Windows.Forms.Label();
            this.IsEnabledLbl = new System.Windows.Forms.Label();
            this.ToggleActionBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label1.Location = new System.Drawing.Point(31, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Autorun Status:";
            // 
            // IsEnabledLbl
            // 
            this.IsEnabledLbl.AutoSize = true;
            this.IsEnabledLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.IsEnabledLbl.Location = new System.Drawing.Point(171, 24);
            this.IsEnabledLbl.Name = "IsEnabledLbl";
            this.IsEnabledLbl.Size = new System.Drawing.Size(92, 20);
            this.IsEnabledLbl.TabIndex = 1;
            this.IsEnabledLbl.Text = "ENABLED";
            // 
            // ToggleActionBtn
            // 
            this.ToggleActionBtn.Location = new System.Drawing.Point(104, 61);
            this.ToggleActionBtn.Name = "ToggleActionBtn";
            this.ToggleActionBtn.Size = new System.Drawing.Size(111, 23);
            this.ToggleActionBtn.TabIndex = 2;
            this.ToggleActionBtn.Text = "button1";
            this.ToggleActionBtn.UseVisualStyleBackColor = true;
            this.ToggleActionBtn.Click += new System.EventHandler(this.ToggleActionBtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(269, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "P-Space Status and Event Notifier 1.0.1 # eparon-2013";
            // 
            // Options
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(306, 141);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ToggleActionBtn);
            this.Controls.Add(this.IsEnabledLbl);
            this.Controls.Add(this.label1);
            this.Name = "Options";
            this.Text = "Options";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label IsEnabledLbl;
        private System.Windows.Forms.Button ToggleActionBtn;
        private System.Windows.Forms.Label label3;
    }
}