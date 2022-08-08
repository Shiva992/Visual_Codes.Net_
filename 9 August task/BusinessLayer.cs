using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_August_task
{
    public class BusinessLayer
    {
        static PatientDetails patientDetails;
        static List<PatientDetails> patientList = new List<PatientDetails>();

        public BusinessLayer() //c
        {
            patientDetails = new PatientDetails();
        }

        public void AddRecord()
        {
            try
            {
                patientDetails.Id = Guid.NewGuid();//make new unique id

                Console.WriteLine("Enter the patient's name");
                patientDetails.Name = Console.ReadLine();

                Console.WriteLine("Enter the patient's age");
                patientDetails.Age = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter the patient's address");
                patientDetails.Address = Console.ReadLine();

                Console.WriteLine("Enter the patient's disease");
                patientDetails.Disease = Console.ReadLine();

                Console.WriteLine("Enter the patient's doctor-in-charge");
                patientDetails.Doctor_In_Charge = Console.ReadLine();

                Console.WriteLine("Enter the patient's room no allocated");
                patientDetails.Room_No = Console.ReadLine();

                patientList.Add(patientDetails);
                Console.WriteLine("Patient succesfully added to records");

                HandlePatientRecords();
            }

            catch (Exception ex)
            {
                Console.WriteLine($"AddRecords() failed with exception: {ex.Message}");
            }
        }
        public void UpdateRecord(Guid id)
        {
            var record = patientList.Where(p => p.Id == id);
            Console.WriteLine($"Updating record with ID {id}");
            HandlePatientRecords();
        }
        public void DisplayRecords()
        {
            Console.WriteLine("Displaying the records");
            Console.WriteLine($"Found {patientList.Count} records ");//replacedisplay//count
            foreach (var item in patientList)
            {
                Console.WriteLine($"Displaying records for patient {item.Id}");
                Console.WriteLine($"Name: {item.Name}");
                Console.WriteLine($"Age: {item.Age}");
                Console.WriteLine($"Address: {item.Address}");
                Console.WriteLine($"Disease: {item.Disease}");
                Console.WriteLine($"Doctor-in-charge: {item.Doctor_In_Charge}");
                Console.WriteLine($"Room_No allocated: {item.Room_No}");
                Console.WriteLine("------------------------------");
                HandlePatientRecords();
            }
        }
        public void DeleteRecord(string name)
        {
            patientList.RemoveAll(p => p.Name == name);
            Console.WriteLine("Record deleted...");
            HandlePatientRecords();
        }


        public void HandlePatientRecords()
        {
            //bool showMenu = true;

            //while (showMenu)
            //{
            try
            {
                Console.WriteLine("Enter your choice for handling records. \n" +
                  "Press 1  for adding, \n" +
                  "Press 2 for edit/update \n" +
                  "Press 3 to display all records \n" +
                  "Press 4 to delete a record \n");
                int n = Convert.ToInt32(Console.ReadLine());


                BusinessLayer businessLogic = new BusinessLayer();
                switch (n)
                {
                    case 1:
                        businessLogic.AddRecord();
                        break;
                    case 2:
                        Console.WriteLine("Enter the Id to update");
                        string id = Console.ReadLine();
                        Guid s = Guid.Parse(id);
                        businessLogic.UpdateRecord(s);
                        break;
                    case 3:
                        businessLogic.DisplayRecords();
                        break;
                    case 4:
                        Console.WriteLine("Enter the name to delete");
                        string nameToDelete = Console.ReadLine();
                        businessLogic.DeleteRecord(nameToDelete);
                        break;
                    default:
                        Console.WriteLine("Please enter a valid input");
                        break;
                }
                Console.Read();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exception: {ex.Message}");
            }
            //}
        }
    }
}
