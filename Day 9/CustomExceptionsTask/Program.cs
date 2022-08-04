using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomExceptionsTask
{
    class MyException : Exception
    {
        public void MyExcep()
        {
            Console.WriteLine("Not enough quantity available");
        }
    }
    class Furniture
    {
        int orderId;
        string orderDate;
        public string furnitureType;
        int quantity;
        int totalAmt;
        string paymentMode;

        public void GetData()
        {
            try
            {
                Console.WriteLine("OrderId :");
                orderId = int.Parse(Console.ReadLine());
                Console.WriteLine("orderDate :");
                orderDate = Console.ReadLine();
                Console.WriteLine("furnitureType :");
                furnitureType = Console.ReadLine();
                Console.WriteLine("quantity :");

                quantity = int.Parse(Console.ReadLine());
                if (quantity > 50)
                {
                    throw new MyException();
                }
                Console.WriteLine("TotalAmt :");
                totalAmt = int.Parse(Console.ReadLine());
                Console.WriteLine("payment mode");
                paymentMode = Console.ReadLine();
            }
            catch (MyException ep)
            {
                ep.MyExcep();
            }

        }

        public void ShowData()
        {
            Console.WriteLine(orderId + "  " + orderDate + "  " + furnitureType + "  " + quantity + "  " + totalAmt + "  " + paymentMode);
        }
    }

    class Chair : Furniture
    {
        public string chairType;
        public string purpose;
        int rate;
        public string subType;


        new public void GetData()
        {
            Console.WriteLine("What is the purpose of your chair?");
            purpose = Console.ReadLine();

            Console.WriteLine("What is the type of chair you ordered?");

            chairType = Console.ReadLine();
            if (chairType == "wood")
            {
                Console.WriteLine("Press 1 for choosing Teak wood");
                Console.WriteLine("Press 2 for choosing rose wood");
                Console.WriteLine("Enter your option");
                int i = int.Parse(Console.ReadLine());
                switch (i)
                {
                    case 1:
                        Console.WriteLine("you chose Teak wood");
                        subType = "Teak wood";
                        break;
                    case 2:
                        Console.WriteLine("you chose rose wood");
                        subType = "rose wood";
                        break;
                    default:
                        Console.WriteLine("you didn't choose any chair type");
                        break;
                }

            }

            else if (chairType == "steel")
            {
                Console.WriteLine("Press 1 for choosing Gray steel");
                Console.WriteLine("Press 2 for choosing green steel");
                Console.WriteLine("Press 3 for choosing brown steel");
                Console.WriteLine("Enter your option");
                int i = int.Parse(Console.ReadLine());
                switch (i)
                {
                    case 1:
                        Console.WriteLine("you chose gray steel");
                        subType = "gray steel";
                        break;
                    case 2:
                        Console.WriteLine("you chose green steel");
                        subType = "green steel";
                        break;
                    case 3:
                        Console.WriteLine("you chose brown steel");
                        subType = "brown steel";
                        break;
                    default:
                        Console.WriteLine("you didn't choose any chair type");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Press 1 for choosing Red");
                Console.WriteLine("Press 2 for choosing blue");
                Console.WriteLine("Press 3 for choosing green");
                Console.WriteLine("Press 4 for choosing white");
                Console.WriteLine("Enter your option");
                int i = int.Parse(Console.ReadLine());
                switch (i)
                {
                    case 1:
                        Console.WriteLine("you chose red");
                        subType = "red";
                        break;
                    case 2:
                        Console.WriteLine("you chose green");
                        subType = "green";
                        break;
                    case 3:
                        Console.WriteLine("you chose blue");
                        subType = "blue";
                        break;
                    case 4:
                        Console.WriteLine("you chose white");
                        subType = "white";
                        break;
                    default:
                        Console.WriteLine("you didn't choose any chair type");
                        break;
                }
            }

            rate = 4000;
            Console.WriteLine("Rate of the chair is {0}", rate);
        }

        new public void ShowData()
        {
            Console.WriteLine(chairType + "  " + subType + "  " + "purpose" + purpose + "  " + rate);
            Console.ReadKey();
        }
    }

    class Cot : Furniture
    {
        public string cotType;
        public string capacity;
        int rate;
        public string subType;

        new public void GetData()
        {
            Console.WriteLine("Enter the capacity of chair :");
            capacity = Console.ReadLine();

            Console.WriteLine("What is the type of chair you ordered?");

            cotType = Console.ReadLine();
            if (cotType == "wood")
            {
                Console.WriteLine("Press 1 for choosing Teak wood");
                Console.WriteLine("Press 2 for choosing rose wood");
                Console.WriteLine("Enter your option");
                int i = int.Parse(Console.ReadLine());
                switch (i)
                {
                    case 1:
                        Console.WriteLine("you chose Teak wood");
                        subType = "Teak wood";
                        break;
                    case 2:
                        Console.WriteLine("you chose rose wood");
                        subType = "rose wood";
                        break;
                    default:
                        Console.WriteLine("you didn't choose any chair type");
                        break;
                }

            }

            else
            {
                Console.WriteLine("Press 1 for choosing Gray steel");
                Console.WriteLine("Press 2 for choosing green steel");
                Console.WriteLine("Press 3 for choosing brown steel");
                Console.WriteLine("Enter your option");
                int i = int.Parse(Console.ReadLine());
                switch (i)
                {
                    case 1:
                        Console.WriteLine("you chose gray steel");
                        subType = "gray steel";
                        break;
                    case 2:
                        Console.WriteLine("you chose green steel");
                        subType = "green steel";
                        break;
                    case 3:
                        Console.WriteLine("you chose brown steel");
                        subType = "brown steel";
                        break;
                    default:
                        Console.WriteLine("you didn't choose any chair type");
                        break;
                }
            }

            rate = 8000;
            Console.WriteLine("Rate of the chair is {0}", rate);
        }

        new public void ShowData()
        {
            Console.WriteLine(cotType + "  " + subType + "  " + "Capacity" + capacity + "  " + rate);
            Console.ReadKey();
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Furniture obj = new Furniture();
            obj.GetData();
            obj.ShowData();
            if (obj.furnitureType == "chair")
            {
                Chair chairObj = new Chair();
                chairObj.GetData();
                chairObj.ShowData();
            }
            else
            {
                Cot cotObj = new Cot();
                cotObj.GetData();
                cotObj.ShowData();
            }


        }
    }
}