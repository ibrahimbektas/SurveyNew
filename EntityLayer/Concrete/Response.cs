using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Response
    {
        public int ID { get; set; }
        public DateTime? ResponseDate { get; set; }
        public List<Answer> Answers { get; set; }
        public int SurveyID { get; set; }
        public Survey Survey { get; set; }
        public int UserID { get; set; }
        public User User { get; set; }
    }
}
