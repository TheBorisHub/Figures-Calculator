using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kursova_Boris
{
    class Square
    {
        public static void square()
        {
            double a, d = 0, r, P = 0, S = 0;

            Console.WriteLine("Please type the sides of the square!");

            Console.WriteLine("If you don't have the lenght of the side please type 0 to it!");

            Console.WriteLine("Type the side of the square!");
            Console.Write("a= ");
            a = double.Parse(Console.ReadLine());

            while (a < 0)
            {
                Console.WriteLine("Sides must be positive lenghts!");
                Console.Write("a= ");
                a = double.Parse(Console.ReadLine());
            }
            if (a == 0)
            {
                Console.Write("Please write the lenght of the diagonal d= ");
                d = double.Parse(Console.ReadLine());
                S = (d * d) / 2;
                a = d / Math.Sqrt(2);
                P = a * a;
                Console.WriteLine("The parameter of the qsuare is " + P);
                Console.WriteLine("The area of the square is " + S);
                double R;
                R = a / Math.Sqrt(2);
                r = a / 2;
                Console.WriteLine("The radius of the circle araund the square is " + R);
                Console.WriteLine("The radius of the circle in the square is " + r);
            }
            else
            {
                P = 4 * a;
                S = a * a;
                Console.WriteLine("The parameter of the square is " + P);
                Console.WriteLine("The area of the square is " + S);
                double R, r1;
                R = a / Math.Sqrt(2);
                r1 = a / 2;
                Console.WriteLine("The radius of the circle araund the square is " + R);
                Console.WriteLine("The radius of the circle in the square is " + r1);
                
            }
        }
    }
}
    
