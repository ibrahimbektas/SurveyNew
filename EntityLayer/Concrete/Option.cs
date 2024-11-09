using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Option
    {
        public int ID { get; set; }
        public string Text { get; set; }
        public int? Order { get; set; }
        public int QuestionID { get; set; }
        public Question Question { get; set; }
    }
}
