using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace StudyBuddy
{
    public class QuestionSet
    {
        public int id;
        public string name;
		public string description;
        public List<Question> questions;
		public Bitmap icon;
		public bool active;

        public QuestionSet(int id, string name, string description, List<Question> questions)
        {
            this.id = id;
            this.name = name;
			this.description = description;
            this.questions = questions;
			this.active = false;
        }

        public QuestionSet(string name, string description)
        {
            this.name = name;
			this.description = description;
			this.questions = new List<Question>();
			this.active = true;
        }

        public QuestionSet()
        {
        }

        public override string ToString()
        {
            return this.name;
        }
    }
}
