using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Answer
    {
        public int AnswerID { get; set; }
        public int ResponseID { get; set; }
        public int QuestionID { get; set; }
        public string AnswerText { get; set; }
        public int OptionID { get; set; }

    }
}
