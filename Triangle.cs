using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kursova_Boris
{
    class Triangle
    {
        public static double triangle()
        {
            double a, b, c = 0, e = 0, ha = 0, P = 0, S = 0;
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

                while (a < 0)
                {
                    Console.WriteLine("Sides must be positive lenghts!");
                    Console.Write("c= ");
                    c = double.Parse(Console.ReadLine());
                }

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
        }
    }
