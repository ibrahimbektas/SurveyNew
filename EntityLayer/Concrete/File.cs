using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class File
    {
        public int FileID { get; set; }
        public int AnswerID { get; set; }
        public string FileName { get; set; }
        public string FilePath { get; set; }
        public DateTime UploadDate { get; set; }
        public int FileSize { get; set; }
        public string FileType { get; set; }
    }
}
