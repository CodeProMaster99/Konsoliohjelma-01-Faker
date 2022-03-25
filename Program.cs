using System;

namespace Konsoliohjelma_01_Faker
{
    class Program
    {
        static void Main(string[] args)
        {
            string paramaters = args[0];
            if (args.Length > 2)
            {
                Console.WriteLine("ERROR : Too many paramaters given! (max = 2)");
                return;
            }


            if (paramaters == "--personcount")
            {
                int amount = Convert.ToInt32(args[1]);
                printInfo(amount);
            }
            else if (paramaters == "--interactive")
            {
                if (args.Length > 1)
                {
                    Console.WriteLine("ERROR : Too many paramaters given! (max = 1)");
                    return;
                }
                Console.WriteLine("How many people?");
                int amount = Convert.ToInt32(Console.ReadLine());
                printInfo(amount);
            }
            else
            {
                Console.WriteLine("ERROR : nothing found with name " + paramaters);
            }

        }
        public static void printInfo(int times)
        {
            for (int i = 0; i < times; i++)
            {
                int u = i + 1;
                Console.WriteLine("\nHenkilö " + u + "\nNimi : " +  Faker.Name.FullName() + "\nOsoite : " + Faker.Address.StreetAddress() + "\nPassiID : " + Faker.Identification.UsPassportNumber());
            }
        }





        //if (string.Join("", args).Contains("--interactive"))
        //{
        //    Console.WriteLine("option1");
        //}





        //Console.WriteLine("Paljonko henkilöä?");
        //int amount = Convert.ToInt32(Console.ReadLine());
        //printInfo(amount);
        //
        //string name1 = Faker.Name.FullName();
        //string address1 = Faker.Address.StreetAddress();
        //string license1 = Faker.Identification.UsPassportNumber();
        //
        //string name2 = Faker.Name.FullName();
        //string address2 = Faker.Address.StreetAddress();
        //string license2 = Faker.Identification.UsPassportNumber();
        //
        //string name3 = Faker.Name.FullName();
        //string address3 = Faker.Address.StreetAddress();
        //string license3 = Faker.Identification.UsPassportNumber();
        //
        //Console.WriteLine("Henkilö 1  \n" + "Nimi : " + name1 +"\nOsoite : " + address1 + "\nPassiID : "+ license1);
        //Console.WriteLine("\nHenkilö 2  \n" + "Nimi : " + name2 + "\nOsoite : " + address2 + "\nPassiID : " + license2);
        //Console.WriteLine("\nHenkilö 3  \n" + "Nimi : " + name3 + "\nOsoite : " + address3 + "\nPassiID : " + license3);



    }
}
