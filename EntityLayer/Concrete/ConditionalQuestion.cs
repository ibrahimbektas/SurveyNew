using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class ConditionalQuestion
    {
        public int ConditionalQuestionID { get; set; }
        public string ConditionalQuestionText { get; set; }
        public int ConditionalQuestionNumber { get; set; }
        public string ConditionalQuestionType { get; set; }
        public int SurveyID { get; set; }
        public string ConditionalQuestionContent { get; set; }
        public int ConditionalQuestionOrder { get; set; }
    }
}
