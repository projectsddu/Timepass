using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StaffManagement.Models
{
    public class Student
    {
        public int id { get; set; }
        public string name { get; set; }
        public string Address { get; set; }
    }
    public interface IStudentRepository
    {
        Student GetStudentDetails(int id);
        IEnumerable<Student> GetAllStudentDetails();
        //Student GetStudentMarks
    }
    public class MockStudentRepo:IStudentRepository
    {
        public List<Student> _studentList;
        public MockStudentRepo()
        {

            _studentList = new List<Student>() {
                new Student(){id=1,name="Jenil",Address="101 Adhiraj APPTS" },
                new Student(){id=2,name="kenil",Address="101 Adhiraj APPTS" },
                new Student(){id=3,name="penil",Address="101 Adhiraj APPTS" },
                
            };
        }
        public Student GetStudentDetails(int id)
        {
            return this._studentList.FirstOrDefault(e => e.id == id);
        }
        public  IEnumerable<Student> GetAllStudentDetails()
        {
            return _studentList;
        }
    }

}
