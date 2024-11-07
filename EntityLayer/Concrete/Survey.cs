﻿using System;
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
        public int CreatorID { get; set; }
        public DateTime CreationDate { get; set; }
        public string? Version { get; set; }
        public Creator creator { get; set; }
        List<ConditionalQuestion> ConditionalQuestions { get; set; }
		List<Question> Questions { get; set; }
        List<Response> Responses { get; set; }
        List<User> Users { get; set; }
    }
}
