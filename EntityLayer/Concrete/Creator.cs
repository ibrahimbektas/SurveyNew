using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Creator: IdentityUser<int>
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public List<Survey> Surveys { get; set; }
        public string ProfilePicture { get; set; } = "cb5c82e8-460b-4dba-9567-b5f368406b40.png";
    }
}
