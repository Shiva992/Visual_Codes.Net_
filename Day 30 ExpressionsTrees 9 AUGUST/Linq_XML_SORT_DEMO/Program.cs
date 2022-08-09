using System;
using System.Collections.Generic;
using System.Xml.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq_Xml_demo
{
    class Class1
    {


        static void Main(string[] args)
        {
            XElement xelement = XElement.Load(@"D:\.Net_Training\Mynewrepositry\VisualCodes _.Net_training\Visualcodes\Day 30 ExpressionsTrees 9 AUGUST");

            var dict = (from element in xelement.Descendants("")
                        let name = (string)element.Attribute("Name")
                        select new
                        {
                            CusiID = element.Attribute("CustId").Value,
                            CustName = name

                        })
        .ToDictionary(c => c.CustID, c => c.CustName);
            foreach (var item in dict)
            {
                Console.WriteLine(item.Value);
            }
            Console.ReadLine();
        }
    }
}