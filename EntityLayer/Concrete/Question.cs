using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Question
    {
        public int ID { get; set; }
        public string Text { get; set; }
        public int Number { get; set; }
        public string AnswerType { get; set; }
        public string QuestionType { get; set; }
        public int SurveyID { get; set; }
        public Survey Survey { get; set; }
        public string? QuestionContent { get; set; }
        public int? QuestionOrder { get; set; }
        public int? MaxFileSize { get; set; }
        public string? AllowedFileType { get; set; }
        public List<Answer> Answers { get; set; }
        public List<Option> Options { get; set; }
        public Boolean IsPublic { get; set; } = false;
        public int? ParentID { get; set; }
        public int? ChildID { get; set; }
    }
}
