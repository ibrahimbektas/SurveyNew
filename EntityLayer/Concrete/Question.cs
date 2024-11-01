using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Question
    {
        public int QuestionID { get; set; }
        public string QuestionText { get; set; }
        public int QuestionNumber { get; set; }
        public string QuestionType { get; set; }
        public int SurveyID { get; set; }
        public string QuestionContent { get; set; }
        public int QuestionOrder { get; set; }
        public int MaxFileSize { get; set; }
        public string AllowedFileType { get; set; }
    }
}
