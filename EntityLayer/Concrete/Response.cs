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
        List<Answer> Answers { get; set; }
    }
}
