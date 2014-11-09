namespace StudyBuddy.Forms.Questions
{
	partial class FillInQuestionForm
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
			this.answerBox = new System.Windows.Forms.TextBox();
			this.okayButton = new System.Windows.Forms.Button();
			this.questionLabel = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// answerBox
			// 
			this.answerBox.Location = new System.Drawing.Point(10, 101);
			this.answerBox.Multiline = true;
			this.answerBox.Name = "answerBox";
			this.answerBox.Size = new System.Drawing.Size(314, 77);
			this.answerBox.TabIndex = 4;
			// 
			// okayButton
			// 
			this.okayButton.Location = new System.Drawing.Point(125, 184);
			this.okayButton.Name = "okayButton";
			this.okayButton.Size = new System.Drawing.Size(75, 23);
			this.okayButton.TabIndex = 5;
			this.okayButton.Text = "Okay";
			this.okayButton.UseVisualStyleBackColor = true;
			this.okayButton.Click += new System.EventHandler(this.okayButton_Click);
			// 
			// questionLabel
			// 
			this.questionLabel.Location = new System.Drawing.Point(10, 13);
			this.questionLabel.Name = "questionLabel";
			this.questionLabel.Size = new System.Drawing.Size(313, 85);
			this.questionLabel.TabIndex = 6;
			this.questionLabel.Text = "label1";
			// 
			// FillInQuestionForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(335, 214);
			this.Controls.Add(this.questionLabel);
			this.Controls.Add(this.okayButton);
			this.Controls.Add(this.answerBox);
			this.Name = "FillInQuestionForm";
			this.Text = "FillInQuestionForm";
			this.Load += new System.EventHandler(this.FillInQuestionForm_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox answerBox;
		private System.Windows.Forms.Button okayButton;
		private System.Windows.Forms.Label questionLabel;
	}
}