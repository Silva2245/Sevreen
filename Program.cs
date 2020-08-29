using System;
using Sev;
using Reen;
using System.Text;
using System.Collections.Generic;
using System.Xml;
using System.Xml.Linq;
using System.IO;
using System.Security.Cryptography;
using System.Linq;

namespace Sevreen
{
    class Program
    {
        static void Main(string[] args)
        {
            try{
                Console.WriteLine();
                Console.Write("ENTER PRIMARY CODE : ");
                string pc = Console.ReadLine();
            }
            catch (Exception ex){
                Console.WriteLine();
                Console.WriteLine("THE PROBLEM : " + ex.Message.ToString());
            }
            Console.ReadLine();
        }
    }
}
