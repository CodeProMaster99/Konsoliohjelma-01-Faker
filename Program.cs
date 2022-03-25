using System;

namespace Konsoliohjelma_01_Faker
{
    class Program
    {
        static void Main(string[] args)
        {
            string name1 = Faker.Name.FullName();
            string address1 = Faker.Address.StreetAddress();
            string license1 = Faker.Identification.UsPassportNumber();
            
            string name2 = Faker.Name.FullName();
            string address2 = Faker.Address.StreetAddress();
            string license2 = Faker.Identification.UsPassportNumber();

            string name3 = Faker.Name.FullName();
            string address3 = Faker.Address.StreetAddress();
            string license3 = Faker.Identification.UsPassportNumber();

            Console.WriteLine("Henkilö 1  \n" + "Nimi : " + name1 +"\nOsoite : " + address1 + "\nPassiID : "+ license1);
            Console.WriteLine("\nHenkilö 2  \n" + "Nimi : " + name2 + "\nOsoite : " + address2 + "\nPassiID : " + license2);
            Console.WriteLine("\nHenkilö 3  \n" + "Nimi : " + name3 + "\nOsoite : " + address3 + "\nPassiID : " + license3);
        }
    }
}
