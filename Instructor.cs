using System;
using System.Collections.Generic;
using System.Text;

namespace OKLMS
{
    public class Instructor : UserBase
    {
        public Instructor(string id) : base(id)
        {
            // todo - lookup info from DB based on id
            this.UserId = id;
        }
    }
}
