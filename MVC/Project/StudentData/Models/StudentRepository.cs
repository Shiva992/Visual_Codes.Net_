using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentData.Models
{
    public class StudentRepository : IStudentRepository
    {
        public int CreateStudent(Student student)
        {
            throw new NotImplementedException(); //Exception
        }

        public IEnumerable<Student> GetAllStudents()
        {
            throw new NotImplementedException();
        }

        public int RemoveStudent(Student student)
        {
            throw new NotImplementedException();
        }

        public int UpdateStudent(Student student)
        {
            throw new NotImplementedException();
        }
    }
}
