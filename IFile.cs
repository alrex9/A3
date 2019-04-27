using System;
using System.Collections.Generic;
using System.Text;

namespace OKLMS
{
    public interface IFile
    {
        object GetContent();

        object GetIndex();        

        string FileName { get; set; }

        string Extension { get; set; }

        object index { get; set; }
    }
}
