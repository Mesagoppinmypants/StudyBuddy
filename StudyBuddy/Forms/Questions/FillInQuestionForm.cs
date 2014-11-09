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
	public partial class FillInQuestionForm : Form
	{
		public Question question;

		public FillInQuestionForm(Question question)
		{
			this.question = question;
			InitializeComponent();

			this.questionLabel.Text = this.question.question;
			this.Visible = true;

            FormClosing += delegate(object o, FormClosingEventArgs e)
            {
                StuddyBuddyForm.ballot = null;
            };
		}

		private void FillInQuestionForm_Load(object sender, EventArgs e)
		{

		}

		private void okayButton_Click(object sender, EventArgs e)
		{
			string answer = answerBox.Text;
			this.Close();

			if (answer.ToLower().Equals(this.question.answer))
			{
				MessageBox.Show("Correct!");
                StuddyBuddyForm.currentQuestion.interval *= 2;
                StuddyBuddyForm.ballot = null;
			}
			else
			{
                MessageBox.Show("Incorrect.");
                StuddyBuddyForm.currentQuestion.interval /= 2;
                StuddyBuddyForm.ballot = null;
			}

            StuddyBuddyForm.waiting = false;

		}
	}
}
