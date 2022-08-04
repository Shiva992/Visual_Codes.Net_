using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPsAssessment
{
    class StudentDetails
    {
        int _id;
        string _name;
        int _marks;
        string _address;

        public StudentDetails() { }

        public StudentDetails(int id, string name, int marks, string address)
        {
            this._id = id;
            this._name = name;
            this._marks = marks;
            this._address = address;
        }

        public string GetStudentName()
        {
            return _name;
        }
        public int GetStudentId()
        {
            return _id;
        }
        public int GetStudentMarks()
        {
            return _marks;
        }
        public string GetStudentAddress()
        {
            return _address;
        }
        public void SetId(int id)
        {
            if (id != 0)
            {
                this._id = id;
            }
        }
        public void SetName(string name)
        {
            if (name.Length != 0)
            {
                this._name = name;
            }
        }
        public void SetMarks(int marks)
        {
            if (marks != 0)
            {
                this._marks = marks;
            }
        }
        public void SetAddress(string address)
        {
            if (address.Length != 0)
            {
                this._address = address;
            }
        }
    }

}