using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor_ques
{
    class ContactInfo
    {
        public string _address;
        public string _city;
        public string _state;
        public string _country;
        public string _phoneNo;
        public string _mobileNo;
        public string _emailId;

        public ContactInfo(string address, string city, string state, string country, string phoneNo, string mobileNo, string emailId)
        {
            _address = address;
            _city = city;
            _state = state;
            _country = country;
            _phoneNo = phoneNo;
            _mobileNo = mobileNo;
            _emailId = emailId;
        }

        public string address
        {
            get
            {
                return _address;

            }
            set { _address = value; }
        }
        public string city
        {
            get
            {
                return _city;
            }
            set { _city = value; }
        }
        public string state
        {
            get { return _state; }
            set { value = _state; }
        }
        public string country
        {
            get { return _country; }
            set
            {
                value = _country;
            }
        }
        public string phoneNo
        {
            get { return _phoneNo; }
            set
            {
                value = _phoneNo;
            }
        }
        public string mobileNo
        {
            get { return _mobileNo; }
            set
            {
                value = _mobileNo;
            }
        }
        public string emailId
        {
            get { return _emailId; }
            set
            {
                value = _emailId;
            }
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            //ContactInfo obj = new ContactInfo("#123","Noida", "UP","India", "9990007778", "999999999", "unknown@gmail.com" );
            //Console.WriteLine("Address = " + obj._address);
            //Console.WriteLine("City = " + obj._city);
            //Console.WriteLine("State = " + obj._state);
            //Console.WriteLine("Country = " + obj._country);
            //Console.WriteLine("PhoneNo = " + obj._phoneNo);
            //Console.WriteLine("MobileNo = " + obj._mobileNo);
            //Console.WriteLine("emailId = " + obj._emailId);
            //Console.ReadLine();


        }
    }
}