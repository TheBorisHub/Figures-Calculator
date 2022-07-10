using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kursova_Boris
{
    class Figures
    {
        public static double Square()
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
            return S;
        }
        public static double Triangle()
        {
            double a, b, c, e=0, ha=0, P = 0, S = 0;
            string h, e1;
            Console.WriteLine("Please type the side of the triangle!");
            Console.WriteLine("If you don't have one or two of the sides please type 0 to them!");
            Console.WriteLine("Type the first side of the triangle!");
            Console.Write("a= ");
            a = double.Parse(Console.ReadLine());
            while (a < 0)
            {
                Console.WriteLine("Sides must be positive lenghts!");
                Console.Write("a= ");
                a = double.Parse(Console.ReadLine());
            }
            Console.WriteLine("Type the second side of the triangle!");
            Console.Write("b= ");
            b = double.Parse(Console.ReadLine());
            while (b < 0)
            {
                Console.WriteLine("Sides must be positive lenghts!");
                Console.Write("b= ");
                b = double.Parse(Console.ReadLine());
            }
            Console.WriteLine("Type the trird side of the triangle!");
            Console.Write("c= ");
            c = double.Parse(Console.ReadLine());
            while (c < 0)
            {
                Console.WriteLine("Sides must be positive lenghts!");
                Console.Write("c= ");
                c = double.Parse(Console.ReadLine());
            }
            if (a == 0 || b == 0 || c == 0) {
                Console.WriteLine("Do you have hight to one of the sides of the triangle?");
                Console.WriteLine("Please type yes or no!");
                h = Console.ReadLine().ToLower();
                while (!(h == "yes" || h == "no"))
                {
                    Console.WriteLine("Please type yes or no!");
                    h = Console.ReadLine().ToLower();
                }
                if (h == "yes")
                {
                    Console.Write("Please type the size of the hight! ha= ");
                    ha = double.Parse(Console.ReadLine());
                }
                if (h == "no")
                {
                    Console.WriteLine("Do you have the angle of edge B?");
                    Console.WriteLine("Please type yes or no!");
                    e1 = Console.ReadLine().ToLower();
                    while (!(e1 == "yes" || e1 == "no"))
                    {
                        Console.WriteLine("Please type yes or no!");
                        e1 = Console.ReadLine().ToLower();
                    }
                    if (e1 == "yes")
                    {
                        Console.Write("Please write the angle! e= ");
                        e = double.Parse(Console.ReadLine());
                        ha = b * (Math.Sin(e));
                        Console.WriteLine("The hight is ha= " + ha);
                    }
                }
            }
            int print = 1;
            if (a == 0 || b == 0 || c == 0)
            {
                Console.WriteLine("The parameter can't be calculated because you don't have the lenght of the three sides!");
                print = 0;
            }
            else
            {
                P = a + b + c;
            }
            //Proverka dali stranite otgowarqt po prawiloto za triygylnicite
            while ((a + b <= c || b + c <= a || a + c <= b) && (a != 0 || b != 0 || c != 0))
            {
                Console.WriteLine("No such triangle! The sum of two sides must be larger than the third!");
                Console.WriteLine("Please type the sides again!");
                Console.Write("a= ");
                a = double.Parse(Console.ReadLine());
                Console.Write("b= ");
                b = double.Parse(Console.ReadLine());
                Console.Write("c= ");
                c = double.Parse(Console.ReadLine());
            }
            //Pravougulen triugulnik
            if ((a * a) == (b * b) + (c * c))
            {
                Console.WriteLine("This triangle is with 90 degree angle!");
                //30/60/90
                if (a == (c / 2))
                {
                    Console.WriteLine("This triangle is with angles 30,60 and 90 degrees!");
                    S = (a * b) / 2;
                    Console.WriteLine("The area of the triangle is: " + S);
                }
                if (a == (b / 2))
                {
                    Console.WriteLine("This triangle is with angles 30,60 and 90 degrees!");
                    S = (a * c) / 2;
                    Console.WriteLine("The area of the triangle is: " + S);
                }
                if (b == (c / 2))
                {
                    Console.WriteLine("This triangle is with angles 30,60 and 90 degrees!");
                    S = (a * b) / 2;
                    Console.WriteLine("The area of the triangle is: " + S);
                }
                if (b == (a / 2))
                {
                    Console.WriteLine("This triangle is with angles 30,60 and 90 degrees!");
                    S = (c * b) / 2;
                    Console.WriteLine("The area of the triangle is: " + S);
                }
                if (c == (a / 2))
                {
                    Console.WriteLine("This triangle is with angles 30,60 and 90 degrees!");
                    S = (c * b) / 2;
                    Console.WriteLine("The area of the triangle is: " + S);
                }
                if (c == (b / 2))
                {
                    Console.WriteLine("This triangle is with angles 30,60 and 90 degrees!");
                    S = (a * c) / 2;
                    Console.WriteLine("The area of the triangle is: " + S);
                }
                //Normalen prawoygylen
                if (c > a && c > b)
                {
                    S = (a * b) / 2;
                    Console.WriteLine("The area of the triangle is: " + S);
                }
                if (b > a && b > c)
                {
                    S = (a * c) / 2;
                    Console.WriteLine("The area of the triangle is: " + S);
                }
                if (a > b && a > c)
                {
                    S = (b * c) / 2;
                    Console.WriteLine("The area of the triangle is: " + S);
                }
            }
            //Ravnobedren triugulnik
            if (a == b || b == c || a == c)
            {
                Console.WriteLine("This triangle is Isosceles (two sides are equal)!");

                if (a == 0 || b == 0 || c == 0)
                {
                    Console.WriteLine("The parameter can't be calculated because you don't have the lenght of the three sides!");
                }
                else
                {
                    P = a + b + c;
                }
                Console.WriteLine("The parameter of the triangle is " + P);
                if (ha != 0)
                {
                    if (b == 0 && c == 0)
                    {
                        S = a * ha;
                    }
                    if (a == 0 && c == 0)
                    {
                        S = b * ha;
                    }
                    if (a == 0 && b == 0)
                    {
                        S = c * ha;
                    }
                }
                else
                {
                    double pe = P / 2;
                    Console.Write("The half parameter of the triangle is");
                    Console.WriteLine(pe);
                    S = Math.Sqrt(pe * (pe - a) * (pe - b) * (pe - c));
                }
                Console.WriteLine("The area of the triangle is " + S);
            }
            //Ravnostranen triugulnik
            if (a == b && b == c)
            {
                Console.WriteLine("This triangle is Equilateral!");
                if (print == 1)
                {
                    Console.WriteLine("The parameter of the triangle is " + P);
                }
                if (ha != 0)
                {
                    S = a * ha;
                }
                else
                {
                    double pe = P / 2;
                    Console.Write("The half parameter of the triangle is");
                    Console.WriteLine(pe);
                    S = Math.Sqrt(pe * (pe - a) * (pe - b) * (pe - c));
                }
                Console.WriteLine("The area of the triangle is " + S);
            }
            //Raznostranen triugulnik
            if (a != b && a != c && b != c)
            {
                Console.WriteLine("This triangle is Scalene(Sides are diferent)!");
                if (print == 1)
                {
                    Console.WriteLine("The parameter of the triangle is " + P);
                }
                if (ha != 0)
                {
                    S = a * ha;
                }
                else
                {
                    double pe = P / 2;
                    Console.Write("The half parameter of the triangle is");
                    Console.WriteLine(pe);
                    S = Math.Sqrt(pe * (pe - a) * (pe - b) * (pe - c));
                }
                Console.WriteLine();
                Console.WriteLine("The area of the triangle is " + S);
            }
            return S;
        }
        public static double Rectangle()
        {
            double a, b, d, S, P;

            Console.WriteLine("Please type the sides of the square!");

            Console.WriteLine("If you don't have the lenght of the sides please type 0 to them!");

            Console.WriteLine("Type the first side of the square!");
            Console.Write("a= ");
            a = double.Parse(Console.ReadLine());

            while (a < 0)
            {
                Console.WriteLine("Sides must be positive lenghts!");
                Console.Write("a= ");
                a = double.Parse(Console.ReadLine());
            }

            Console.WriteLine("Type the second side of the square!");
            Console.Write("b= ");

            b = double.Parse(Console.ReadLine());

            while (b < 0)
            {
                Console.WriteLine("Sides must be positive lenghts!");
                Console.Write("b= ");
                b = double.Parse(Console.ReadLine());
            }

            if ((a == 0 && b == 0) || (a == 0) || (b == 0))
            {
                Console.WriteLine("The parameter can't be calculated because the lenght of one or the two sides aren't asigned!");
                Console.WriteLine("Please write the lenght of the diagonal!");
                Console.Write("d= ");
                d = double.Parse(Console.ReadLine());
                double y;
                Console.WriteLine("Please type the angle between the diagonals!");
                Console.WriteLine("The angle must be between 1 and 179 degrees!");
                y = double.Parse(Console.ReadLine());
                while (y < 0 || y > 180)
                {
                    Console.WriteLine("The angle must be between 1 and 179 degrees!");
                    y = double.Parse(Console.ReadLine());
                }
                S = ((d * d) * Math.Sin(y) / 2);
                Console.WriteLine("The area of the rectangle is " + S);
            }
            else
            {
                P = (2 * a) + (2 * b);
                S = a * b;
                d = Math.Sqrt((a * a) + (b * b));
                Console.WriteLine("The parameter of the rectangle is " + P);
                Console.WriteLine("The area of the rectangle is " + S);
                Console.WriteLine("The lenght of the diagonal is" + d);
            }
            if ((a / b) == (b / (a - b)))
            {
                Console.WriteLine("This is a golden rectangle!");
            }
            return S;
        }
        public static double Circle()
        {
            double c, d, r, S;
            Console.WriteLine("Please enter the radius of the circle!");
            Console.WriteLine("If you don't have the radius please type 0 to it!");
            Console.Write("r= ");
            r = double.Parse(Console.ReadLine());

            if (r == 0)
            {
                Console.WriteLine("You don't have the radius so you can type diameter of the circle!");
                Console.Write("d= ");
                d = double.Parse(Console.ReadLine());
                r = d / 2;
                c = 2 * Math.PI * r;
                S = Math.PI * r * r;
                Console.WriteLine("The radius is " + r);
                Console.WriteLine("The length of the circumference" + c);
                Console.WriteLine("The area of the circle" + S);
            }
            else
            {
                c = 2 * Math.PI * r;
                S = Math.PI * r * r;
                Console.WriteLine("The length of the circumference" + c);
                Console.WriteLine("The area of the circle" + S);
            }
            return S;
        }
    }
}