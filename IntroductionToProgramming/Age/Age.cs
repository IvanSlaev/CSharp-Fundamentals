using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Age
{
    class Age
    {
        static void Main(string[] args)
        {
            var birthday = new DateTime();
            IFormatProvider culture = new System.Globalization.CultureInfo("en-US", true);
            birthday = DateTime.Parse(Console.ReadLine(), culture);
            var years = DateTime.Now.Year - birthday.Year;

            if (birthday.Month >= DateTime.Now.Month || birthday.Month == DateTime.Now.Month && birthday.Day > DateTime.Now.Day)
                years--;

            Console.WriteLine(years);
            Console.WriteLine(years + 10);
        }
    }
}
