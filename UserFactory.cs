using OKLMS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public static class UserFactory
    {
        public static UserBase CreateUser(string userId, UserType userType)
        {
            if (userType == UserType.Student)
            {
                return new Student(userId);
            }
            else if (userType == UserType.Instructor)
            {
                return new Instructor(userId);
            }
            else
            {
                throw new InvalidOperationException($"Invlaid UserType: {userType}");
            }
        }
    }

    public enum UserType
    {
        Student,
        Instructor
    }
}
