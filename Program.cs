using OKLMS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var student = UserFactory.CreateUser("James", UserType.Student) as Student;
            var instructor = UserFactory.CreateUser("Dr.Guy", UserType.Instructor) as Instructor;
            var classroom = new ClassRoom("CSS370");
            classroom.SetInstructor(instructor);
            classroom.AddStudent(student);

            var file = FileFactory.CreateFile(FileType.Video);
            instructor.Files.Add(file);
            classroom.AddFile(file);

            var getFileAttempt = classroom.GetFile(file.FileName);
        }
    }
}
