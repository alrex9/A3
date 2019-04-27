using System;
using System.Collections.Generic;
using System.Text;

namespace OKLMS
{
    public class Text : IFile
    {
        private List<string> text { get; set; }

        public string FileName { get; set; } = ".docx";

        public string Extension { get; set; }

        public object index { get; set; }

        public object GetContent()
        {
            return string.Join("\n", this.text);
        }

        public object GetIndex()
        {
            return this.index;
        }
    }
}
