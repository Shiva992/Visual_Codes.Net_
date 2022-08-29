using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentData.Models
{
    interface IStudentRepository
    {
        IEnumerable<Student> GetAllStudents();
        int UpdateStudent(Student student);
        int CreateStudent(Student student);
        int RemoveStudent(Student student);
    }
}
