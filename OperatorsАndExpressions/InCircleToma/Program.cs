using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InCircleToma
{
    class Program
    {
        static void Main(string[] args)
        {
            float x = float.Parse(Console.ReadLine());
            float y = float.Parse(Console.ReadLine());

            float p = ((x - 1)*(x - 1) + (y - 1)*(y - 1));
            float r = 1.5F * 1.5F;
            bool inCircle = (p <= r);
            bool inRectangle = x >= -1 && x <= 5 && y >= -1 && y <= 1;

            if (inCircle && inRectangle)
            {
                Console.WriteLine("inside circle inside rectangle");
            }
            else if (inCircle && !inRectangle)
            {
                Console.WriteLine("inside circle outside rectangle");
            }
            else if (!inCircle && !inRectangle)
            {
                Console.WriteLine("outside circle outside rectangle");
            }
        }
    }
}
