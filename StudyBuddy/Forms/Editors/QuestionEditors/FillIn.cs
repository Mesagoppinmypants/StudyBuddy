using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudyBuddy.Forms.Editors.QuestionEditors
{
	public partial class FillIn : Form
	{
		private QuestionSet set;
		private Question question;
		private SetEditor editor;

		public FillIn(Question question, SetEditor editor)
		{
			InitializeComponent();

			if(question != null)
			{
				textBox1.Text = question.question;
				textBox2.Text = question.answer;
				button1.Text = "Apply";
			}

			this.question = question;
			this.set = editor.set;
			this.editor = editor;
		}

		private void button1_Click(object sender, EventArgs e)
		{
			if(question != null)
			{
				question.question = textBox1.Text;
				question.answer = textBox2.Text;
			}
			else
			{
				question = new Question();
                question.interval = 5;
				question.question = textBox1.Text;
				question.answer = textBox2.Text;
				set.questions.Add(question);
			}
			editor.populateForm();
			this.Close();
		}
	}
}
