using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Response
    {
        public int ResponseID { get; set; }
        public int SurveyID { get; set; }
        public int UserID { get; set; }
        public DateTime ResponseDate { get; set; }
    }
}
