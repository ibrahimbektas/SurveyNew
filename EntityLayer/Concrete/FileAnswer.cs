    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class FileAnswer:Answer
    {
        public string Path { get; set; }
        public int FileSize { get; set; }
        public string FileType { get; set; }
        public string? Description { get; set; }
    }
}
