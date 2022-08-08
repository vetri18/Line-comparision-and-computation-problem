using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practiceproblem2
{
    internal class Lineuctwo

    {
         
        public static void LineModel()
        {
            Console.WriteLine("x1 is ");
            float x1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("x2 is ");
            float x2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("y1 is ");
            float y1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("y2 is ");
            float y2 = Convert.ToInt32(Console.ReadLine());
            if (y1 == y2 && x1 == x2)
            {
                Console.WriteLine("Lines are Equal");
            }
            else
            {
                Console.WriteLine("Lines are unequal");
            }
        }
    }
}
    
