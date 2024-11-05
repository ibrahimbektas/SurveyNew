﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class UploadedFile
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Path { get; set; }
        public DateTime UploadDate { get; set; }
        public int FileSize { get; set; }
        public string FileType { get; set; }
    }
}
