 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Survey
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public DateTime CreationDate { get; set; }
        public string? Version { get; set; }
        public string Category { get; set; }
        public string Description { get; set; }
        public List<Question> Questions { get; set; } 
        public List<User> Users { get; set; }
        public int CreatorID { get; set; }
        public Creator Creator { get; set; }
        public List<Response> Responses { get; set; }
        public bool IsPublic { get; set; }
    }
}
