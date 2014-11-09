using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudyBuddy
{
    public class Question
    {
        public int id;
        public string question;
        public string answer;
        public string[] choices;
        public int interval;

        public Question(int id, string question, string answer, string[] choices, int interval)
        {
            this.id = id;
            this.question = question;
            this.answer = answer;
            this.choices = choices;
            this.interval = interval;
        }

        public Question(int id, string question, string answer, string[] choices)
            : this(id, question, answer, choices, 5)
        {
        }

		public Question(int id, string question, string answer)
			: this(id, question, answer, null, 5)
		{
		}

        public Question()
        {
        }

        public bool isMultipleChoice()
        {
            return this.choices != null;
        }

        public override string ToString()
        {
            return this.id.ToString();
        }
    }
}
