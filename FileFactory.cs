using OKLMS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public static class FileFactory
    {
        public static IFile CreateFile(FileType fileType)
        {
            if (fileType == FileType.Text)
            {
                return new Text();
            }
            else if (fileType == FileType.Presentation)
            {
                return new Presentation("FileName1");
            }
            else if (fileType == FileType.Video)
            {
                return new Video("FileName2");
            }
            else
            {
                throw new InvalidOperationException($"Invalid file type: {fileType}");
            }
        }
    }

    public enum FileType
    {
        Text,
        Presentation,
        Video
    }
}
