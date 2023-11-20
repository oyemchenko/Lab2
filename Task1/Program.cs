using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Address adressinfo = new Address();
            adressinfo.Index = 31000;
            adressinfo.Country = "Ukraine";
            adressinfo.City = "Pyriatyn";
            adressinfo.Street = "Tyha st.";
            adressinfo.House = 24;
            adressinfo.Apartment = 1;

            Console.WriteLine ($"Index: {adressinfo.Index} | Country: {adressinfo.Country} | City: {adressinfo.City} | Street: {adressinfo.Street} | House: {adressinfo.House} | Apartment: {adressinfo.Apartment}");
        }
    }
}
