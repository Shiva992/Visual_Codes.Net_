using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebFormAsp.net
{
    public class Author
    {
        //Fields
        string firstName;
        string lastName;
        private string value;

        //Constructors
        public Author()
        { }
        public Author(string firstName, string lastName)
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
                set { lastName  = value; }
            }
        }
    }
