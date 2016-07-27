using System;

namespace CompanyInfo
{
    class CompanyInfo
    {
        static void Main(string[] args)
        {
            string companyName = Console.ReadLine();
            string companyAddress = Console.ReadLine();
            string phoneNumber = Console.ReadLine();
            string faxNumber = Console.ReadLine();
            string webSite = Console.ReadLine();
            string managerFirstName = Console.ReadLine();
            string managerLasttName = Console.ReadLine();
            string managerAge = Console.ReadLine();
            string managerPhone = Console.ReadLine();

            Console.WriteLine(companyName);
            Console.WriteLine("Address: " + companyAddress);
            Console.WriteLine("Tel. " + phoneNumber);
            if (string.IsNullOrWhiteSpace(faxNumber))
                Console.WriteLine("Fax: (no fax)");
            else 
                Console.WriteLine("Fax: " + faxNumber);
            Console.WriteLine("Web site: " + webSite);
            Console.WriteLine("Manager: {0} {1} (age: {2}, tel. {3})", managerFirstName, managerLasttName, managerAge, managerPhone);

        }
    }
}
