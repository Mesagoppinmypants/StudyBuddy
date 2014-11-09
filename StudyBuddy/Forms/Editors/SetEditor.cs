using Newtonsoft.Json;
using StudyBuddy.Forms.Editors.QuestionEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudyBuddy
{
	public partial class SetEditor : Form
	{
		public QuestionSet set;
		private Form editor = null;

		public SetEditor(QuestionSet set)
		{
			InitializeComponent();
			this.set = set;
			this.Text = set.name;

			populateForm();
		}

		public void populateForm()
		{
			panel2.Controls.Clear();

			for (int i = 0; i < set.questions.Count; i++)
			{
				Question question = set.questions[i];

				// Panel
				Panel panel = new Panel();
				panel.Location = new Point(12, (i * 39) + 8);
				panel.Size = new Size(545, 39);
				if (i % 2 == 0) panel.BackColor = SystemColors.ControlLight;

				// ID label
				Label question_id = new Label();
				question_id.Location = new Point(3, 8);
				question_id.Size = new Size(25, 23);
				question_id.TextAlign = ContentAlignment.MiddleCenter;
				question_id.Text = (i + 1).ToString();

				// Question label
				Label question_text = new Label();
				question_text.Font = new Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
				question_text.Location = new Point(27, 8);
				question_text.Size = new Size(487, 23);
				question_text.Text = question.question;
				question_text.TextAlign = ContentAlignment.MiddleCenter;

				// Remove picture-box
				PictureBox remove = new PictureBox();
				remove.Image = global::StudyBuddy.Properties.Resources.delete;
				remove.Location = new Point(519, 12);
				remove.Size = new Size(16, 16);

				// Add delegates
				remove.MouseClick += delegate(object o, MouseEventArgs e)
				{
					set.questions.Remove(question);
					populateForm();
				};

				EventHandler dc = delegate(System.Object o, System.EventArgs e)
				{
					if (editor != null) editor.Close();

					if (question.isMultipleChoice()) editor = new MultipleChoice(question, this);
					else editor = new FillIn(question, this);

					editor.Show();
				};

				panel.DoubleClick += dc;
				question_id.DoubleClick += dc;
				question_text.DoubleClick += dc;

				// Add components to panel
				panel.Controls.Add(question_id);
				panel.Controls.Add(question_text);
				panel.Controls.Add(remove);
				panel2.Controls.Add(panel);
			}
		}

		private void SetEditor_Load(object sender, EventArgs e)
		{

		}

		private void AddQuestion_Click(object sender, EventArgs e)
		{
			set.questions.Add(new Question(0, "hello", "hello"));
			populateForm();
		}

		private void fillinToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (editor != null) editor.Close();
			editor = new FillIn(null, this);
			editor.Show();
		}

		private void multipleChoiceToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (editor != null) editor.Close();
			editor = new MultipleChoice(null, this);
			editor.Show();
		}

		private void toolStripButton1_Click(object sender, EventArgs e)
		{
			WebClient wc = new WebClient();
			wc.UploadString("http://104.236.25.40:1337/api/SubmitSet?a=a", JsonConvert.SerializeObject(set)); // upload our json of question set
		}
	}
}
