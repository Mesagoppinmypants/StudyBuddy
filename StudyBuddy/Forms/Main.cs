using StudyBuddy.Forms.Questions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.IO;
using System.Threading;
using StudyBuddy.Forms.Editors;

namespace StudyBuddy
{
	public partial class StuddyBuddyForm : Form
	{

		static Community pull = new Community();
		static public List<QuestionSet> sets = new List<QuestionSet>();
		static SetEditor setEditor = null;
		static SetCreator setCreator = null;
		static Community community = null;
        static public Form ballot = null;
		public static StuddyBuddyForm instance;

		public static Question currentQuestion = null;

        static Thread threat;

        static Random random = new Random();

        public static bool waiting = false;

		public StuddyBuddyForm()
		{
			InitializeComponent();
			instance = this;

            if (File.Exists("data.json"))
            {
                sets = JsonConvert.DeserializeObject<List<QuestionSet>>(File.ReadAllText("data.json"));
            }

            this.FormClosing += delegate(object o, FormClosingEventArgs e)
            {
                threat.Abort();
                string json = JsonConvert.SerializeObject(sets);
                File.WriteAllText("data.json", json);
            };

            threat = new Thread(delegate ()
            {
                while (true)
                {

                    IEnumerable<QuestionSet> activeSets = sets.Where(a => a.active && a.questions.Count() > 0);
                    if (activeSets.Count() == 0)
                    {
                        Thread.Sleep(5000);
                        continue;
                    }
                    int r = random.Next(activeSets.Count());
                    QuestionSet set = activeSets.ElementAt(r);
                    currentQuestion = set.questions[random.Next(set.questions.Count())];

                    if (currentQuestion.interval == 0) currentQuestion.interval = 5;

                    Thread.Sleep(currentQuestion.interval * 2500);

                    int i = 0;
                    while (waiting && i < 10 || ballot != null)
                    {
                        Thread.Sleep(1000);
                        i++;
                    }
                    trayIcon.ShowBalloonTip(10000, "Study Buddy", currentQuestion.question, ToolTipIcon.None);
                }
            });

            threat.Start();
		}

		private void StuddyBuddyForm_Load(object sender, EventArgs e)
		{
			populateForm();

		}

		private void StuddyBuddyForm_Resize(object sender, EventArgs e)
		{
			if (FormWindowState.Minimized == WindowState)
				Hide();
		}

		private void pullButton_Click(object sender, EventArgs e)
		{
			pull.Visible = true;
			//trayIcon.BalloonTipText = "Sup";
			//trayIcon.ShowBalloonTip(5000, "SUP NOOB", "This here is details on how much of a noob you are. Noob.", ToolTipIcon.Info);
		}

		private void trayIcon_BalloonTipClicked(object sender, EventArgs e)
		{
			if (currentQuestion.choices == null)
			{
				ballot = new FillInQuestionForm(currentQuestion);
			}
			else
			{
				ballot = new MultipleChoiceQuestionForm(currentQuestion);
			}
		}

		private void trayIcon_DoubleClick(object sender, EventArgs e)
		{
			Show();
			WindowState = FormWindowState.Normal;
		}

		public void populateForm()
		{
			setPanel.Controls.Clear();

			for (int i = 0; i < sets.Count; i++)
			{
				QuestionSet set = sets[i];

				// Panel
				Panel panel = new Panel();
				panel.Location = new Point(15, (i * 80) + 8);
				panel.Size = new Size(741, 80);
				if (i % 2 == 0) panel.BackColor = SystemColors.ControlLight;

				// Icon
				PictureBox icon = new PictureBox();
				icon.Location = new Point(3, 3);
				icon.Size = new Size(74, 74);
				icon.Image = Image.FromFile("icons/" + set.icon + ".png");

				// Name
				Label name = new Label();
				name.Location = new Point(83, 6);
				name.Size = new Size(188, 16);
				name.Font = new Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
				name.Text = set.name;

				// Description
				Label description = new Label();
				description.Location = new Point(83, 30); 
				description.Size = new Size(578, 47);
				description.Text = set.description;

				// Active 
				CheckBox active = new CheckBox();
				active.Location = new Point(704, 32);
				active.Size = new Size(15, 14);
				if (set.active) active.Checked = true;		

				// Add delegates
				active.CheckedChanged += delegate(System.Object o, System.EventArgs e)
				{ set.active = !set.active; };

				EventHandler dc = delegate(System.Object o, System.EventArgs e)
				{
					if (setEditor != null) setEditor.Close();
					setEditor = new SetEditor(set);
					setEditor.Show();
				};

				panel.DoubleClick += dc;
				icon.DoubleClick += dc;
				name.DoubleClick += dc;
				description.DoubleClick += dc;

				// Add components to panel
				panel.Controls.Add(icon);
				panel.Controls.Add(name);
				panel.Controls.Add(description);
				panel.Controls.Add(active);

				// Add panel to scrollable panel
				setPanel.Controls.Add(panel);


                ContextMenu contextMenu = new ContextMenu();
                contextMenu.MenuItems.Add("Delete", delegate(object o, EventArgs e)
                {
                    sets.Remove(set);
                    populateForm();
                });

                panel.ContextMenu = contextMenu;
			}
		}

		private void trayIcon_MouseDoubleClick(object sender, MouseEventArgs e)
		{

		}

		private void trayIcon_MouseClick(object sender, MouseEventArgs e)
		{
		}

		private void toolStripButton1_Click(object sender, EventArgs e)
		{
			if(community != null)
			{
				community.Close();
			}
			community = new Community();
			community.Show();
		}

		private void addToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			if(setCreator != null)
				setCreator.Close();

			setCreator = new SetCreator();
			setCreator.Show();
		}
	}
}