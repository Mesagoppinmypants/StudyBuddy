namespace StudyBuddy.Forms.Questions
{
	partial class MultipleChoiceQuestionForm
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
			this.radioButton1 = new System.Windows.Forms.RadioButton();
			this.radioButton2 = new System.Windows.Forms.RadioButton();
			this.radioButton3 = new System.Windows.Forms.RadioButton();
			this.radioButton4 = new System.Windows.Forms.RadioButton();
			this.okayButton = new System.Windows.Forms.Button();
			this.questionLabel = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// radioButton1
			// 
			this.radioButton1.Location = new System.Drawing.Point(15, 97);
			this.radioButton1.Name = "radioButton1";
			this.radioButton1.Size = new System.Drawing.Size(312, 21);
			this.radioButton1.TabIndex = 3;
			this.radioButton1.TabStop = true;
			this.radioButton1.Text = "Answer 1";
			this.radioButton1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.radioButton1.UseVisualStyleBackColor = true;
			// 
			// radioButton2
			// 
			this.radioButton2.Location = new System.Drawing.Point(15, 124);
			this.radioButton2.Name = "radioButton2";
			this.radioButton2.Size = new System.Drawing.Size(312, 17);
			this.radioButton2.TabIndex = 4;
			this.radioButton2.TabStop = true;
			this.radioButton2.Text = "Answer 2";
			this.radioButton2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.radioButton2.UseVisualStyleBackColor = true;
			// 
			// radioButton3
			// 
			this.radioButton3.Location = new System.Drawing.Point(15, 147);
			this.radioButton3.Name = "radioButton3";
			this.radioButton3.Size = new System.Drawing.Size(312, 17);
			this.radioButton3.TabIndex = 5;
			this.radioButton3.TabStop = true;
			this.radioButton3.Text = "Answer 3";
			this.radioButton3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.radioButton3.UseVisualStyleBackColor = true;
			// 
			// radioButton4
			// 
			this.radioButton4.Location = new System.Drawing.Point(15, 170);
			this.radioButton4.Name = "radioButton4";
			this.radioButton4.Size = new System.Drawing.Size(310, 17);
			this.radioButton4.TabIndex = 6;
			this.radioButton4.TabStop = true;
			this.radioButton4.Text = "Answer 4";
			this.radioButton4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.radioButton4.UseVisualStyleBackColor = true;
			// 
			// okayButton
			// 
			this.okayButton.Location = new System.Drawing.Point(135, 199);
			this.okayButton.Name = "okayButton";
			this.okayButton.Size = new System.Drawing.Size(75, 23);
			this.okayButton.TabIndex = 7;
			this.okayButton.Text = "Submit";
			this.okayButton.UseVisualStyleBackColor = true;
			this.okayButton.Click += new System.EventHandler(this.okayButton_Click);
			// 
			// questionLabel
			// 
			this.questionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.questionLabel.Location = new System.Drawing.Point(12, 9);
			this.questionLabel.Name = "questionLabel";
			this.questionLabel.Size = new System.Drawing.Size(315, 85);
			this.questionLabel.TabIndex = 8;
			this.questionLabel.Text = "Question";
			this.questionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// MultipleChoiceQuestionForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(339, 234);
			this.Controls.Add(this.questionLabel);
			this.Controls.Add(this.okayButton);
			this.Controls.Add(this.radioButton4);
			this.Controls.Add(this.radioButton3);
			this.Controls.Add(this.radioButton2);
			this.Controls.Add(this.radioButton1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Name = "MultipleChoiceQuestionForm";
			this.Text = "Question";
			this.Load += new System.EventHandler(this.MultipleChoiceQuestionForm_Load);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.RadioButton radioButton1;
		private System.Windows.Forms.RadioButton radioButton2;
		private System.Windows.Forms.RadioButton radioButton3;
		private System.Windows.Forms.RadioButton radioButton4;
		private System.Windows.Forms.Button okayButton;
		private System.Windows.Forms.Label questionLabel;

	}
}