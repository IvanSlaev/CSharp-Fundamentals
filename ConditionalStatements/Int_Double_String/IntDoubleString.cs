using System;

namespace Int_Double_String
{
    class IntDoubleString
    {
        static void Main(string[] args)
        {
            string option = Console.ReadLine();
            switch (option)
            {
                case "integer":
                    int integer = int.Parse(Console.ReadLine());
                    integer += 1;
                    Console.WriteLine(integer);
                    break;
                case "real":
                    double realnumber = double.Parse(Console.ReadLine());
                    realnumber += 1.0;
                    Console.WriteLine("{0:0.00}", realnumber);
                    break;
                case "text":
                    string text = Console.ReadLine();
                    Console.WriteLine(text + "*");
                    break;
            }
        }
    }
}
