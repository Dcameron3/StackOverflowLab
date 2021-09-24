using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StackOverflowLab.Models
{
    public class QuestionAnswer
    {
        public List<Answers> answers { get; set; }
        public Questions question { get; set; }
    }
}
