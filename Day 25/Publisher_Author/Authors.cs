using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication2
{
    public class Authors
    {
        //Fields
        string firstName;
        string lastName;

        //Constructors
        public Authors()
        { }
        public Authors(string firstName, string lastName)
        {
            this.firstName = firstName;
            this.lastName = lastName;
        }
        //properties
        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }

        public string LastName
        {
            get
            {
                return lastName;
            }
            set { lastName = value; }
        }
    }
}