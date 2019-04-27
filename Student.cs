using System;
using System.Collections.Generic;
using System.Text;

namespace OKLMS
{
    public class Student : UserBase
    {
        public Student(string id) : base(id)
        {
            this.UserId = id;
        }
    }
}
