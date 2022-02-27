using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_CheWeiHsu_task5
{
    class testing : IEquatable<testing>
    {
        public string question;
        public string answer;

        public testing(string question, string answer)
        {
            this.question = question;
            this.answer = answer;
        }

        public override bool Equals(object obj)
        {
            return Equals(obj as testing);
        }

        public bool Equals(testing other)
        {
            return other != null &&
                   question == other.question &&
                   answer == other.answer;
        }

        public override int GetHashCode()
        {
            var hashCode = -444598804;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(question);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(answer);
            return hashCode;
        }
    }
}
