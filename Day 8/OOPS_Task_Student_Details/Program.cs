using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPsAssessment
{

    class Program
    {
        static StudentDetails[] studentArray = new StudentDetails[0];
        static void DisplayMenu()
        {
            Console.WriteLine("Press 1 to enter the student details.");
            Console.WriteLine("Press 2 to update the student details.");
            Console.WriteLine("Press 3 to delete the student details.");
            Console.WriteLine("Press 4 to exit.");
        }

        static Boolean SelectionOption(int opt)
        {
            switch (opt)
            {
                case 1:
                    studentArray = DynamicArray(studentArray);
                    studentArray = CreateStudent(studentArray);
                    return true;
                case 2:
                    studentArray = Update(studentArray);
                    return true;
                case 3: return false;
                default:
                    Console.WriteLine("Thankyou for using us" + "");
                    return true;
            }
        }

        static StudentDetails[] CreateStudent(StudentDetails[] arr)
        {
            Console.WriteLine("Please enter the elements");
            for (int i = arr.Length - 1; i < arr.Length; i++)
            {
                arr[i] = new StudentDetails();
                Console.WriteLine("Enter the student's NAme");
                String name = Console.ReadLine();
                arr[i].SetName(name);

                Console.WriteLine("Enter the marks");
                int marks = int.Parse(Console.ReadLine());
                arr[i].SetMarks(marks);

                Console.WriteLine("Enter the id");
                int id = int.Parse(Console.ReadLine());
                arr[i].SetId(id);

                Console.WriteLine("please enter the address");
                string address = Console.ReadLine();
                arr[i].SetAddress(address);

            }
            return arr;
        }

        static StudentDetails[] DynamicArray(StudentDetails[] arr)
        {
            StudentDetails[] temp = new StudentDetails[arr.Length + 1];
            for (int i = 0; i < arr.Length; i++)
            {
                temp[i] = arr[i];
            }
            return temp;
        }

        static StudentDetails[] Update(StudentDetails[] arr)
        {
            Console.WriteLine("Which detail you want to update?");
            Console.WriteLine("Press 1 for name");
            Console.WriteLine("Press 2 for id");
            Console.WriteLine("Press 3 for marks");
            Console.WriteLine("Press 4 for address");
            Console.WriteLine("Press 5 for next student details");
            bool flagg = true;
            do
            {
                int update_opt = Convert.ToInt32(Console.ReadLine());
                switch (update_opt)
                {
                    case 1:
                        Console.WriteLine("Enter name of the student");
                        Console.ReadLine();
                        break;
                }
            } while (flagg);

            return arr;
        }
        public static void Main(string[] args)
        {
            DisplayMenu();
            int i = Convert.ToInt32(Console.ReadLine());


            Boolean flag = true;
            do
            {
                DisplayMenu();
                Console.WriteLine("Please Enter Your option");
                int opt = int.Parse(Console.ReadLine());
                flag = SelectionOption(opt);
            } while (flag);




        }
    }
}