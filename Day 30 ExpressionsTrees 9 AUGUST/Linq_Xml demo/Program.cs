using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;


namespace Linq_Xml_demo
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = @"<?xml version = ""1.0""?>
                <country name = ""India"">
                <Capital>NewDelhi</capital>
                </Country>";
            //Preserve whitespaces

            XDocument XDoc = XDocument.Parse(str, LoadOptions.PreserveWhitespace);
            Console.WriteLine(XDoc);
            Console.ReadLine();
        }
    }
}
