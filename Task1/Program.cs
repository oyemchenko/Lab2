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
            adressinfo.Index = 02098;
            adressinfo.Country = "Ukraine";
            adressinfo.City = "Brovaru";
            adressinfo.Street = "Peremohi st.";
            adressinfo.House = 321;
            adressinfo.Apartment = 17;

            Console.WriteLine ($"Index: {adressinfo.Index} | Country: {adressinfo.Country} | City: {adressinfo.City} | Street: {adressinfo.Street} | House: {adressinfo.House} | Apartment: {adressinfo.Apartment}");
        }
    }
}
