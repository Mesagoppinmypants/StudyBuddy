using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudyBuddy.Forms
{
	public partial class Statistics : Form
	{
		public int correct = 0;
		public int incorrect = 0;
		public int streak = 0;
		public int longestStreak = 0;

		public Statistics()
		{
			InitializeComponent();
		}
		public void IncreaseCorrect()
		{
			correct++;
			streak++;
			if (streak > longestStreak) longestStreak = streak;
			UpdateForm();
		}
		public void IncreaseIncorrect()
		{
			incorrect++;
			if (streak > longestStreak) longestStreak = streak;
			streak = 0;
			UpdateForm();
		}

		private void UpdateForm()
		{
			this.label2.Text = "Correct: " + correct;
			this.label3.Text = "Incorrect: " + incorrect;
			this.label4.Text = "Current Streak: " + streak;
			this.label5.Text = "Longest Streak: " + longestStreak;

		}
	}
}
