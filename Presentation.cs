using System;
using System.Collections.Generic;
using System.Text;

namespace OKLMS
{
    public class Presentation : IFile
    {
        public Presentation(string fileName)
        {
            this.FileName = fileName;
        }

        private List<string> slideContents { get; set; }

        public string FileName { get; set; }

        public string Extension { get; set; } = ".pptx";

        public object index { get; set; }

        public object GetContent()
        {
            return string.Join("\n", this.slideContents);
        }

        public object GetIndex()
        {
            return this.index;
        }
    }
}
