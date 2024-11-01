using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Option
    {
        public int OptionID { get; set; }
        public string OptionText { get; set; }
        public int OptionOrder { get; set; }
        public int QuestionID { get; set; }
        public int ConditionalQuestionID { get; set; }
}
