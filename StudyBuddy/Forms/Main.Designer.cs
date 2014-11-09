namespace StudyBuddy
{
    partial class StuddyBuddyForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StuddyBuddyForm));
			this.trayIcon = new System.Windows.Forms.NotifyIcon(this.components);
			this.inactiveContentMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.removeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.panel1 = new System.Windows.Forms.Panel();
			this.checkBox1 = new System.Windows.Forms.CheckBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.toolStrip1 = new System.Windows.Forms.ToolStrip();
			this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
			this.addToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
			this.setPanel = new System.Windows.Forms.Panel();
			this.inactiveContentMenu.SuspendLayout();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.toolStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// trayIcon
			// 
			this.trayIcon.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
			this.trayIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("trayIcon.Icon")));
			this.trayIcon.Text = "Study Buddy";
			this.trayIcon.Visible = true;
			this.trayIcon.BalloonTipClicked += new System.EventHandler(this.trayIcon_BalloonTipClicked);
			this.trayIcon.DoubleClick += new System.EventHandler(this.trayIcon_DoubleClick);
			this.trayIcon.MouseClick += new System.Windows.Forms.MouseEventHandler(this.trayIcon_MouseClick);
			this.trayIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.trayIcon_MouseDoubleClick);
			// 
			// inactiveContentMenu
			// 
			this.inactiveContentMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem,
            this.editToolStripMenuItem,
            this.removeToolStripMenuItem});
			this.inactiveContentMenu.Name = "inactiveContentMenu";
			this.inactiveContentMenu.Size = new System.Drawing.Size(118, 70);
			// 
			// addToolStripMenuItem
			// 
			this.addToolStripMenuItem.Name = "addToolStripMenuItem";
			this.addToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
			this.addToolStripMenuItem.Text = "Add";
			// 
			// editToolStripMenuItem
			// 
			this.editToolStripMenuItem.Name = "editToolStripMenuItem";
			this.editToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
			this.editToolStripMenuItem.Text = "Edit";
			// 
			// removeToolStripMenuItem
			// 
			this.removeToolStripMenuItem.Name = "removeToolStripMenuItem";
			this.removeToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
			this.removeToolStripMenuItem.Text = "Remove";
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
			this.panel1.Controls.Add(this.checkBox1);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Controls.Add(this.pictureBox1);
			this.panel1.Location = new System.Drawing.Point(15, 354);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(741, 80);
			this.panel1.TabIndex = 7;
			// 
			// checkBox1
			// 
			this.checkBox1.AutoSize = true;
			this.checkBox1.ImageKey = "(none)";
			this.checkBox1.Location = new System.Drawing.Point(704, 32);
			this.checkBox1.Name = "checkBox1";
			this.checkBox1.Size = new System.Drawing.Size(15, 14);
			this.checkBox1.TabIndex = 8;
			this.checkBox1.UseVisualStyleBackColor = true;
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(83, 30);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(578, 47);
			this.label2.TabIndex = 2;
			this.label2.Text = resources.GetString("label2.Text");
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(83, 6);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(188, 16);
			this.label1.TabIndex = 1;
			this.label1.Text = "Computer Science Exam 1";
			// 
			// pictureBox1
			// 
			this.pictureBox1.Location = new System.Drawing.Point(3, 3);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(74, 74);
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			// 
			// toolStrip1
			// 
			this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton1,
            this.toolStripButton1});
			this.toolStrip1.Location = new System.Drawing.Point(0, 0);
			this.toolStrip1.Name = "toolStrip1";
			this.toolStrip1.Size = new System.Drawing.Size(777, 25);
			this.toolStrip1.TabIndex = 8;
			this.toolStrip1.Text = "toolStrip1";
			// 
			// toolStripDropDownButton1
			// 
			this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem1});
			this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
			this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
			this.toolStripDropDownButton1.Size = new System.Drawing.Size(57, 22);
			this.toolStripDropDownButton1.Text = "Sets";
			// 
			// addToolStripMenuItem1
			// 
			this.addToolStripMenuItem1.Name = "addToolStripMenuItem1";
			this.addToolStripMenuItem1.Size = new System.Drawing.Size(96, 22);
			this.addToolStripMenuItem1.Text = "Add";
			// 
			// toolStripButton1
			// 
			this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
			this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButton1.Name = "toolStripButton1";
			this.toolStripButton1.Size = new System.Drawing.Size(91, 22);
			this.toolStripButton1.Text = "Community";
			// 
			// setPanel
			// 
			this.setPanel.AutoScroll = true;
			this.setPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.setPanel.Location = new System.Drawing.Point(0, 25);
			this.setPanel.Name = "setPanel";
			this.setPanel.Size = new System.Drawing.Size(777, 421);
			this.setPanel.TabIndex = 9;
			// 
			// StuddyBuddyForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(777, 446);
			this.Controls.Add(this.setPanel);
			this.Controls.Add(this.toolStrip1);
			this.Controls.Add(this.panel1);
			this.Name = "StuddyBuddyForm";
			this.Text = "Study Buddy";
			this.Load += new System.EventHandler(this.StuddyBuddyForm_Load);
			this.Resize += new System.EventHandler(this.StuddyBuddyForm_Resize);
			this.inactiveContentMenu.ResumeLayout(false);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.toolStrip1.ResumeLayout(false);
			this.toolStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

		private System.Windows.Forms.NotifyIcon trayIcon;
        private System.Windows.Forms.ContextMenuStrip inactiveContentMenu;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeToolStripMenuItem;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.CheckBox checkBox1;
		private System.Windows.Forms.ToolStrip toolStrip1;
		private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
		private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem1;
		private System.Windows.Forms.Panel setPanel;
		private System.Windows.Forms.ToolStripButton toolStripButton1;
    }
}

