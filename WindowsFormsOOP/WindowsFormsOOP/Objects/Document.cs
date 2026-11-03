using System;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsOOP.Objects
{
    internal abstract class Document
    {
        public Document()
        {
                
        }

        public string DocumentName { get; set; }
        public string Path { get; set; }
        public double Size { get; set; }
        public string Extension { get; set; }
        public string DocumentType { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime ModifiedDate { get; set; }

        public string GetFileInfo()
        {
            string info = $"Name:{DocumentName} \rExt:{Extension} \rPath:{Path} \rSize:{Size} \rType:{DocumentType} \rCreate Date:{CreateDate} \rModified Date:{ModifiedDate}";

            return info;
        }

        public abstract void Print();

    }
}
