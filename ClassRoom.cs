using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OKLMS
{
    public class ClassRoom
    {
        public ClassRoom(string classRoomId)
        {
            this.classRoomId = classRoomId;
        }

        private string classRoomId { get; set; }

        private Instructor Instructor { get; set; }

        private List<Student> Students { get; set; } = new List<Student>();

        private List<IFile> Files { get; set; } = new List<IFile>();

        public void AddFile(IFile file)
        {
            this.Files.Add(file);
        }

        public IFile GetFile(string fileName)
        {
            return this.Files.FirstOrDefault(x => x.FileName == fileName);
        }

        public void AddStudent(Student student)
        {
            this.Students.Add(student);
        }

        public Student GetStudent(string id)
        {
            return this.Students.FirstOrDefault(x => x.UserId == id);
        }

        public void SetInstructor(Instructor instructor)
        {
            this.Instructor = instructor;
        }

        public Instructor GetInstructor()
        {
            return this.Instructor;
        }
    }
}
