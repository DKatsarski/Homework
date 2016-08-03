using System;


namespace _2.CompanyInfo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Company name: ");
            string companyName = Console.ReadLine();
            Console.Write("Company address: ");
            string companyAdress = Console.ReadLine();
            Console.Write("Phone number: ");
            string phoneNumber = Console.ReadLine();
            Console.Write("Fax number ");
            string faxNumber = Console.ReadLine();
            Console.Write("Web site: ");
            string webSite = Console.ReadLine();
            Console.Write("Manager first name: ");
            string managerFirstName = Console.ReadLine();
            Console.Write("Manager last name: ");
            string managerLastName = Console.ReadLine();
            Console.Write("Manager age: ");
            string managerAge = Console.ReadLine();
            Console.Write("Manager phone: ");
            string managerPhone = Console.ReadLine();

            Console.WriteLine(companyName);
            Console.WriteLine("Adress: {0}", companyAdress);
            Console.WriteLine("Tel. {0}", phoneNumber);
            if (faxNumber.CompareTo(string.Empty) == 0)
            {
                Console.WriteLine("Fax: (no fax)");
            }
            else
            {
                Console.WriteLine("Fax: {0}", faxNumber);
            }
            Console.WriteLine("Web site: {0}", webSite);
            Console.WriteLine("Manager: {0} {1} (age:{2}, tel. {3})", managerFirstName, managerLastName, managerAge, managerPhone);

        }
    }
}
