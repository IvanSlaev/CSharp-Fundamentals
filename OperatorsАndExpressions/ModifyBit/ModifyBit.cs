using System;

namespace ModifyBit
{
    class ModifyBit
    {
        static void Main(string[] args)
        {
            ulong N = ulong.Parse(Console.ReadLine()); //tuka traa da imam ulong
            int P = int.Parse(Console.ReadLine()); //twa e ot 0 do 63 moje da e int
            int v = int.Parse(Console.ReadLine());
            ulong one = 1; //slagam 1-ca w ulong
            if (v == 0)
            {
                ulong mask = ~(one << P); //za da move tuka da mi operira samo s ulong-ove
                ulong result = mask & N;//i tuka
                Console.WriteLine(result);
            }
            else if (v == 1)
            {
                ulong mask = one << P;//i tuka
                ulong result = mask | N;//i tuka
                Console.WriteLine(result);
            }
        }
    }
}
