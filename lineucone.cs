using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practiceproblem1
{
    internal class lineucone
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
            float x3 = x2 - x1;
            float y3 = y2 - y1;
            float z1 = x3 * x3;
            float z2 = y3 * y3;
            float z3 = z1 + z2;
            Console.WriteLine("Lentgh is " + Math.Sqrt(z3));
        }
    }
}
    

