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
using System.Net;

namespace StudyBuddy
{
    public partial class Community : Form
    {
		static string filter_search = "http://104.236.25.40:1337/api/SearchSets?filter={0}";

        public Community()
        {
            InitializeComponent();
        }

		private void splitter1_SplitterMoved(object sender, SplitterEventArgs e)
		{

		}

		private void pictureBox1_Click(object sender, EventArgs e)
		{
			if(textBox1.Text.Length > 0)
			{
				WebClient wc = new WebClient();
				List<QuestionSet> sets = JsonConvert.DeserializeObject<List<QuestionSet>>(wc.DownloadString(string.Format(filter_search,textBox1.Text)));
				populateForm(sets);		
				foreach (QuestionSet qc in sets)
				{
					qc.active = false;
				}
			}
		}

		private void populateForm(List<QuestionSet> sets)
		{
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
				//icon.Image = set.icon;

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

				// Download picturebox
				PictureBox download = new PictureBox();
				download.Location = new Point(704, 32);
				download.Size = new Size(15, 14);
				download.Image = global::StudyBuddy.Properties.Resources.arrow_down;

				// Add delegates
				EventHandler dc = delegate(System.Object o, System.EventArgs e)
				{
					StuddyBuddyForm.sets.Add(set);
					StuddyBuddyForm.instance.populateForm();
				};

				download.Click += dc;

				// Add components to panel
				panel.Controls.Add(icon);
				panel.Controls.Add(name);
				panel.Controls.Add(description);
				panel.Controls.Add(download);

				// Add panel to scrollable panel
				panel1.Controls.Add(panel);
			}
		}
    }
}
