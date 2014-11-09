namespace StudyBuddy
{
    partial class Pull
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pull));
            this.pullTabControl = new System.Windows.Forms.TabControl();
            this.communityTabPage = new System.Windows.Forms.TabPage();
            this.createTabPage = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.pullTabControl.SuspendLayout();
            this.createTabPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // pullTabControl
            // 
            this.pullTabControl.Controls.Add(this.communityTabPage);
            this.pullTabControl.Controls.Add(this.createTabPage);
            this.pullTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pullTabControl.Location = new System.Drawing.Point(0, 0);
            this.pullTabControl.Name = "pullTabControl";
            this.pullTabControl.SelectedIndex = 0;
            this.pullTabControl.Size = new System.Drawing.Size(380, 250);
            this.pullTabControl.TabIndex = 0;
            // 
            // communityTabPage
            // 
            this.communityTabPage.Location = new System.Drawing.Point(4, 22);
            this.communityTabPage.Name = "communityTabPage";
            this.communityTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.communityTabPage.Size = new System.Drawing.Size(372, 224);
            this.communityTabPage.TabIndex = 0;
            this.communityTabPage.Text = "Community";
            this.communityTabPage.UseVisualStyleBackColor = true;
            // 
            // createTabPage
            // 
            this.createTabPage.BackColor = System.Drawing.SystemColors.Window;
            this.createTabPage.Controls.Add(this.button1);
            this.createTabPage.Controls.Add(this.textBox2);
            this.createTabPage.Controls.Add(this.label2);
            this.createTabPage.Controls.Add(this.textBox1);
            this.createTabPage.Controls.Add(this.label1);
            this.createTabPage.Location = new System.Drawing.Point(4, 22);
            this.createTabPage.Name = "createTabPage";
            this.createTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.createTabPage.Size = new System.Drawing.Size(372, 224);
            this.createTabPage.TabIndex = 1;
            this.createTabPage.Text = "Create";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Question:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(6, 25);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(360, 92);
            this.textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(8, 148);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(360, 26);
            this.textBox2.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Answer:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(144, 193);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Create Question";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Pull
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(380, 250);
            this.Controls.Add(this.pullTabControl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Pull";
            this.Text = "Pull";
            this.pullTabControl.ResumeLayout(false);
            this.createTabPage.ResumeLayout(false);
            this.createTabPage.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl pullTabControl;
        private System.Windows.Forms.TabPage communityTabPage;
        private System.Windows.Forms.TabPage createTabPage;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
    }
}