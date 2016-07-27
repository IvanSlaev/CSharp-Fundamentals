using System;

namespace BitExchange
{
    class BitExchange
    {
        static void Main(string[] args)
        {
            uint number = uint.Parse(Console.ReadLine());

            //Console.WriteLine(Convert.ToString(number, 2).PadLeft(32, '0'));
            //setting ...00000001 value to uint
            uint one = 1;
            //setting the wanted digit to 0 position
            uint position3 = number >> 3;                 
            uint position4 = number >> 4;                 
            uint position5 = number >> 5;                 
            uint position24 = number >> 24;               
            uint position25 = number >> 25;               
            uint position26 = number >> 26;               
            //extracting the wanted digit value to a separate variable
            uint digit3 = position3 & 1;
            uint digit4 = position4 & one;
            uint digit5 = position5 & one;          
            uint digit24 = position24 & one;          
            uint digit25 = position25 & one;          
            uint digit26 = position26 & one;          
            //declaration of new viarables
            uint new3;
            uint new4;
            uint new5;
            uint new24;
            uint new25;
            uint newNumber;
            //checking and setting values of the new variables
            if (digit24 == 0)
            {
                uint mask3 = ~(one << 3);
                new3 = mask3 & number;
            }
            else
            {
                uint mask3 = one << 3;
                new3 = mask3 | number;
            }
            if (digit25 == 0)
            {
                uint mask4 = ~(one << 4);
                new4 = mask4 & new3;
            }
            else
            {
                uint mask4 = one << 4;
                new4 = mask4 | new3;
            }
            if (digit26 == 0)
            {
                uint mask5 = ~(one << 5);
                new5 = mask5 & new4;
            }
            else
            {
                uint mask5 = one << 5;
                new5 = mask5 | new4;
            }
            if (digit3 == 0)
            {
                uint mask24 = ~(one << 24);
                new24 = mask24 & new5;
            }
            else
            {
                uint mask24 = one << 24;
                new24 = mask24 | new5;
            }
            if (digit4 == 0)
            {
                uint mask25 = ~(one << 25);
                new25 = mask25 & new24;
            }
            else
            {
                uint mask25 = one << 25;
                new25 = mask25 | new24;
            }
            if (digit5 == 0)
            {
                uint mask26 = ~(one << 26);
                newNumber = mask26 & new25;
            }
            else
            {
                uint mask26 = one << 26;
                newNumber = mask26 | new25;
            }
            //Console.WriteLine(Convert.ToString(newNumber, 2).PadLeft(32, '0'));
            Console.WriteLine(newNumber);
        }
    }
}
