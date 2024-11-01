using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Survey
    {
        public int SurveyID { get; set; }
        public string SurveyName { get; set; }
        public int CreatorID { get; set; }
        public DateTime CreationDate { get; set; }
        public string SurveyVersion { get; set; }
    }
}
