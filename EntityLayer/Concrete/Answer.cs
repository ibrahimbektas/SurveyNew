using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Answer
    {
        public int ID { get; set; }
        public int ResponseID { get; set; }
        public int QuestionID { get; set; }
        public string Text { get; set; }
        public int OptionID { get; set; }
        public Option Option { get; set; }
        public Question Question { get; set; }
        public Response Response { get; set; }
        List<UploadedFile> UploadedFiles { get; set; } 

    }
}
