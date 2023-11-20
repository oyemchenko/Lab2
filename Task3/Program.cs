using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee inform = new Employee();
            inform.Name = "Oleh";
            inform.Surname = "Yemchenko";
            inform.Ocupation = "Web-Designer";
            inform.Experience = 1;
            inform.Taxes = 0.5;
            inform.Amount = 300;
            
            inform.Info();
        }
    }
}
