using System;
using System.Collections.Generic;
using System.Text;

namespace OKLMS
{
    public abstract class UserBase
    {
        public UserBase(string userId)
        {
            this.UserId = userId;
        }

        public string UserId { get; set; }

        public List<string> CurrentClasses { get; set; } = new List<string>();

        public List<IFile> Files { get; set; } = new List<IFile>();
    }
}
