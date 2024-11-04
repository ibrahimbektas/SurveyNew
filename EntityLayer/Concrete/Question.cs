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
        public string Type { get; set; }
        public int SurveyID { get; set; }
        public string Content { get; set; }
        public int Order { get; set; }
        public int MaxFileSize { get; set; }
        public string AllowedFileType { get; set; }
    }
}
