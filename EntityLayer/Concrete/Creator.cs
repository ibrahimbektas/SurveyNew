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
        List<Survey> Surveys { get; set; }
    }
}
