using System;
using System.Globalization;

namespace Internationalization
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CultureInfo cultureInfo = CultureInfo.CurrentCulture;
            CultureInfo Localization = CultureInfo.CurrentUICulture;
            Console.WriteLine($"The Current Globalization Culture is {Localization.Name},{Localization.DisplayName}");
            Console.WriteLine();

            Console.WriteLine("en-US: English (United States)");
            Console.WriteLine("da-DK: Danish (Denmark)");
            Console.WriteLine("fr-CA: French (Canada)");
            Console.Write("Enter an ISO culture code: ");

            string newculture = Console.ReadLine();
            if (!string.IsNullOrEmpty(newculture))
            {
                var ci = new CultureInfo(newculture);
                CultureInfo.CurrentCulture = ci;
                CultureInfo.CurrentUICulture = ci;
            }
            Console.WriteLine();
            Console.Write("Enter Your Name :");
            string name = Console.ReadLine();

            Console.Write("Enter Your DateOfBirth :");
            string dob = Console.ReadLine();

            Console.Write("Enter Your Salary :");
            string salary = Console.ReadLine();

            DateTime date = DateTime.Parse(dob);
            int minutes = (int)DateTime.Today.Subtract(date).TotalMinutes;
            decimal earns = decimal.Parse(salary);

            Console.WriteLine($"{name} Was Born On a {date:dddd} ,Is {minutes:N0} Minutes Old,And Earns {earns:C}");
           
        }
    }
}
