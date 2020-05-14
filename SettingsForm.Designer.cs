namespace UIDelaySimulator
{
    partial class SettingsForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsForm));
            this.icoTray = new System.Windows.Forms.NotifyIcon(this.components);
            this.ctxTrayMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trkDelayMilliseconds = new System.Windows.Forms.TrackBar();
            this.lblMinimumValue = new System.Windows.Forms.Label();
            this.lblMaximumValue = new System.Windows.Forms.Label();
            this.labelCurrent = new System.Windows.Forms.Label();
            this.ctxTrayMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trkDelayMilliseconds)).BeginInit();
            this.SuspendLayout();
            // 
            // icoTray
            // 
            this.icoTray.ContextMenuStrip = this.ctxTrayMenu;
            this.icoTray.Icon = ((System.Drawing.Icon)(resources.GetObject("icoTray.Icon")));
            this.icoTray.Text = "UI Delay Simulator";
            this.icoTray.Visible = true;
            // 
            // ctxTrayMenu
            // 
            this.ctxTrayMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingsToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.ctxTrayMenu.Name = "ctxTrayMenu";
            this.ctxTrayMenu.Size = new System.Drawing.Size(129, 48);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Image = global::UIDelaySimulator.Properties.Resources.clock;
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.settingsToolStripMenuItem.Text = "&Settings ...";
            this.settingsToolStripMenuItem.Click += new System.EventHandler(this.settingsToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Image = global::UIDelaySimulator.Properties.Resources.exit;
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.exitToolStripMenuItem.Text = "&Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // trkDelayMilliseconds
            // 
            this.trkDelayMilliseconds.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.trkDelayMilliseconds.LargeChange = 100;
            this.trkDelayMilliseconds.Location = new System.Drawing.Point(12, 12);
            this.trkDelayMilliseconds.Maximum = 1000;
            this.trkDelayMilliseconds.Name = "trkDelayMilliseconds";
            this.trkDelayMilliseconds.Size = new System.Drawing.Size(510, 45);
            this.trkDelayMilliseconds.SmallChange = 25;
            this.trkDelayMilliseconds.TabIndex = 1;
            this.trkDelayMilliseconds.TickFrequency = 25;
            this.trkDelayMilliseconds.Value = 500;
            this.trkDelayMilliseconds.ValueChanged += new System.EventHandler(this.trkDelayMilliseconds_ValueChanged);
            // 
            // lblMinimumValue
            // 
            this.lblMinimumValue.AutoSize = true;
            this.lblMinimumValue.Location = new System.Drawing.Point(9, 44);
            this.lblMinimumValue.Name = "lblMinimumValue";
            this.lblMinimumValue.Size = new System.Drawing.Size(29, 13);
            this.lblMinimumValue.TabIndex = 2;
            this.lblMinimumValue.Text = "0 ms";
            // 
            // lblMaximumValue
            // 
            this.lblMaximumValue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMaximumValue.AutoSize = true;
            this.lblMaximumValue.Location = new System.Drawing.Point(481, 44);
            this.lblMaximumValue.Name = "lblMaximumValue";
            this.lblMaximumValue.Size = new System.Drawing.Size(47, 13);
            this.lblMaximumValue.TabIndex = 3;
            this.lblMaximumValue.Text = "1000 ms";
            // 
            // labelCurrent
            // 
            this.labelCurrent.AutoSize = true;
            this.labelCurrent.Location = new System.Drawing.Point(242, 44);
            this.labelCurrent.Name = "labelCurrent";
            this.labelCurrent.Size = new System.Drawing.Size(0, 13);
            this.labelCurrent.TabIndex = 4;
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(546, 77);
            this.Controls.Add(this.labelCurrent);
            this.Controls.Add(this.lblMaximumValue);
            this.Controls.Add(this.lblMinimumValue);
            this.Controls.Add(this.trkDelayMilliseconds);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(562, 116);
            this.Name = "SettingsForm";
            this.ShowInTaskbar = false;
            this.Text = "UI Delay Simulator";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ctxTrayMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.trkDelayMilliseconds)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NotifyIcon icoTray;
        private System.Windows.Forms.ContextMenuStrip ctxTrayMenu;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.TrackBar trkDelayMilliseconds;
        private System.Windows.Forms.Label lblMinimumValue;
        private System.Windows.Forms.Label lblMaximumValue;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.Label labelCurrent;
    }
}

