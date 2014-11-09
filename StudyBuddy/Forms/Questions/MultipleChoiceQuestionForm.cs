using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudyBuddy.Forms.Questions
{
	public partial class MultipleChoiceQuestionForm : Form
	{
		public Question question;

		public MultipleChoiceQuestionForm(Question question)
		{
			this.question = question;
			InitializeComponent();


			this.questionLabel.Text = this.question.question;
			this.Visible = true;

			this.radioButton1.Text = question.choices[0];
			this.radioButton2.Text = question.choices[1];

			if (question.choices.Length > 2)
				this.radioButton3.Text = question.choices[2];
			else
				this.radioButton3.Visible = false;

			if (question.choices.Length > 3)
				this.radioButton4.Text = question.choices[3];
			else
				this.radioButton4.Visible = false;

            FormClosing += delegate(object o, FormClosingEventArgs e)
            {
                StuddyBuddyForm.ballot = null;
                StuddyBuddyForm.waiting = false;
            };
		}

		private void MultipleChoiceQuestionForm_Load(object sender, EventArgs e)
		{
            
		}

		private void okayButton_Click(object sender, EventArgs e)
		{
			if (radioButton1.Checked || radioButton2.Checked || radioButton3.Checked || radioButton4.Checked)
			{
				string answer = null;
				if (radioButton1.Checked) answer = radioButton1.Text;
				if (radioButton2.Checked) answer = radioButton2.Text;
				if (radioButton3.Checked) answer = radioButton3.Text;
				if (radioButton4.Checked) answer = radioButton4.Text;

				this.Close();

				if (answer.ToLower().Equals(this.question.answer.ToLower()))
				{
					MessageBox.Show("Correct!");
                    question.interval *= 2;
                    StuddyBuddyForm.ballot = null;
					StuddyBuddyForm.stats.IncreaseCorrect();
				}
				else
				{
					MessageBox.Show("Incorrect.\nThe correct answer is " + question.answer + ".");
                    question.interval /= 2;
                    StuddyBuddyForm.ballot = null;
					StuddyBuddyForm.stats.IncreaseIncorrect();
				}

                StuddyBuddyForm.waiting = false;
			}

		}
	}
}
