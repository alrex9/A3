using System;
using System.Collections.Generic;
using System.Text;

namespace OKLMS
{
    public class Video : IFile
    {
        private Transcription transcription { get; set; }

        public Video(string index)
        {
            this.index = index;
        }

        public string FileName { get; set; }

        public string Extension { get; set; } = ".mp4";

        public object index { get; set; }

        public object GetContent()
        {
            return string.Join(" ", this.transcription.Sentences);
        }

        public object GetIndex()
        {
            return this.index;
        }
    }
}
