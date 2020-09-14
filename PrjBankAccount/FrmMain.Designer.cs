namespace PrjBankAccount
{
    partial class FrmMain
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.actionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuChapters = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuOOP = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDR = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDS = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuLinq = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuATM = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuQuit = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.actionsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1067, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // actionsToolStripMenuItem
            // 
            this.actionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuChapters,
            this.mnuATM,
            this.mnuQuit});
            this.actionsToolStripMenuItem.Name = "actionsToolStripMenuItem";
            this.actionsToolStripMenuItem.Size = new System.Drawing.Size(70, 24);
            this.actionsToolStripMenuItem.Text = "Actions";
            // 
            // mnuChapters
            // 
            this.mnuChapters.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuOOP,
            this.mnuDR,
            this.mnuDS,
            this.mnuLinq});
            this.mnuChapters.Name = "mnuChapters";
            this.mnuChapters.Size = new System.Drawing.Size(221, 26);
            this.mnuChapters.Text = "Chapters";
            // 
            // mnuOOP
            // 
            this.mnuOOP.Name = "mnuOOP";
            this.mnuOOP.Size = new System.Drawing.Size(216, 26);
            this.mnuOOP.Text = "OOP";
            this.mnuOOP.Click += new System.EventHandler(this.mnuOOP_Click);
            // 
            // mnuDR
            // 
            this.mnuDR.Name = "mnuDR";
            this.mnuDR.Size = new System.Drawing.Size(216, 26);
            this.mnuDR.Text = "DataReader";
            // 
            // mnuDS
            // 
            this.mnuDS.Name = "mnuDS";
            this.mnuDS.Size = new System.Drawing.Size(216, 26);
            this.mnuDS.Text = "Dataset";
            // 
            // mnuLinq
            // 
            this.mnuLinq.Name = "mnuLinq";
            this.mnuLinq.Size = new System.Drawing.Size(216, 26);
            this.mnuLinq.Text = "Linq";
            // 
            // mnuATM
            // 
            this.mnuATM.Name = "mnuATM";
            this.mnuATM.Size = new System.Drawing.Size(221, 26);
            this.mnuATM.Text = "Bank ATM";
            this.mnuATM.Click += new System.EventHandler(this.mnuATM_Click);
            // 
            // mnuQuit
            // 
            this.mnuQuit.Name = "mnuQuit";
            this.mnuQuit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.A)));
            this.mnuQuit.Size = new System.Drawing.Size(221, 26);
            this.mnuQuit.Text = "Quit Program";
            this.mnuQuit.Click += new System.EventHandler(this.mnuQuit_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmMain";
            this.Text = "OOP";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem actionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuChapters;
        private System.Windows.Forms.ToolStripMenuItem mnuOOP;
        private System.Windows.Forms.ToolStripMenuItem mnuDR;
        private System.Windows.Forms.ToolStripMenuItem mnuDS;
        private System.Windows.Forms.ToolStripMenuItem mnuLinq;
        private System.Windows.Forms.ToolStripMenuItem mnuATM;
        private System.Windows.Forms.ToolStripMenuItem mnuQuit;
    }
}