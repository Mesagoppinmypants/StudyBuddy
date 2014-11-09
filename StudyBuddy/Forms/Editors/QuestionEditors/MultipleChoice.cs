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
	public partial class MultipleChoice : Form
	{
		private QuestionSet set;
		private Question question;
		private SetEditor editor;

		public MultipleChoice(Question question, SetEditor editor)
		{
			InitializeComponent();
			if(question != null)
			{
				button1.Text = "Apply";
				numericUpDown1.Value = question.choices.Count();
				textBox1.Text = question.question;

				textBox2.Text = question.choices[0];
				textBox3.Text = question.choices[1];
				if (numericUpDown1.Value > 2)
					textBox4.Text = question.choices[2];				
				if (numericUpDown1.Value > 3)
					textBox5.Text = question.choices[3];

				for (int i = 0; i < numericUpDown1.Value; i++ )
				{
					if (question.choices[i].ToLower().Equals(question.answer))
					{
						if (i == 0) radioButton1.Checked = true;
						else if (i == 1) radioButton2.Checked = true;
						else if (i == 2) radioButton3.Checked = true;
						else if (i == 3) radioButton4.Checked = true;
						break;
					}
			
				}

				this.question = question;
			}
			this.set = editor.set;
			this.editor = editor;
		}

		private void numericUpDown1_ValueChanged(object sender, EventArgs e)
		{
			switch((int)numericUpDown1.Value)
			{
				case 2:
					Size = new Size(345, 217 + 31);
					textBox5.Visible = false;
					textBox4.Visible = false;
					radioButton3.Visible = false;
					radioButton4.Visible = false;
					if (radioButton4.Checked || radioButton3.Checked) radioButton1.Checked = true;
					button1.Location = new Point(129, 233 - (26 * 2));
					break;
				case 3:
					Size = new Size(345, 245 + 31);
					textBox4.Visible = true;
					textBox5.Visible = false;
					radioButton3.Visible = true;
					radioButton4.Visible = false;
					if (radioButton4.Checked) radioButton1.Checked = true;
					button1.Location = new Point(129, 233 - 26);
					break;
				case 4:
					Size = new Size(345, 273 + 31);
					textBox4.Visible = true;
					textBox5.Visible = true;
					radioButton3.Visible = true;
					radioButton4.Visible = true;
					button1.Location = new Point(129, 233);
					break;
				default:
					break;
			}
		}

		private void button1_Click(object sender, EventArgs e)
		{
			if(question != null)
			{
				// Update choices
				question.choices = new string[(int)numericUpDown1.Value];

				question.choices[0] = textBox2.Text;
				question.choices[1] = textBox3.Text;

				if (numericUpDown1.Value > 2)
					question.choices[2] = textBox4.Text;
				if (numericUpDown1.Value > 3)
					question.choices[3] = textBox5.Text;

				// Update Answer
				if (radioButton1.Checked) question.answer = question.choices[0];
				else if (radioButton2.Checked) question.answer = question.choices[1];
				else if (radioButton3.Checked) question.answer = question.choices[2];
				else if (radioButton4.Checked) question.answer = question.choices[3];

				// Update Question
				question.question = textBox1.Text;
				editor.populateForm();

				// Close form
				this.Close();
			}
			else
			{
				// Create new question
				question = new Question();
                question.interval = 5;

				// Update choices
				question.choices = new string[(int)numericUpDown1.Value];

				question.choices[0] = textBox2.Text;
				question.choices[1] = textBox3.Text;

				if (numericUpDown1.Value > 2)
					question.choices[2] = textBox4.Text;
				if (numericUpDown1.Value > 3)
					question.choices[3] = textBox5.Text;

				// Update answer
				if (radioButton1.Checked) question.answer = question.choices[0];
				else if (radioButton2.Checked) question.answer = question.choices[1];
				else if (radioButton3.Checked) question.answer = question.choices[2];
				else if (radioButton4.Checked) question.answer = question.choices[3];

				// Update question
				question.question = textBox1.Text;

				// Add it to set
				set.questions.Add(question);
				editor.populateForm();

				// Close form
				this.Close();
			}
		}

        private void MultipleChoice_Load(object sender, EventArgs e)
        {

        }
	}
}
