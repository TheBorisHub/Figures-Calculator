using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kursova_Boris
{

    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c, h, d, l, r, s1, s2, s3, s4, S, V, be;
            string g, ba, pr;
            Console.WriteLine("Welcome to the ultimate figures calculator!");
            while (true)
            {                
                Console.WriteLine("Which type of figure you want to calculate");
                Console.WriteLine("Please type triangle, rectangle, circle, square, sphere, piramid, parallelepiped, cube!");
                g = Console.ReadLine().ToLower();
                while (!(g == "triangle" || g == "rectangle" || g == "circle" || g == "square" || g == "sphere" || g == "piramid" || g == "parallelepiped" || g == "cube"))
                {
                    Console.WriteLine("Which type of figure you want to calculate");
                    Console.Write("Please type triangle, rectangle, circle, square, sphere, piramid, rectangular parallelepiped, cube");
                    g = Console.ReadLine().ToLower();
                }
                //Ploski figuri:
                if (g == "triangle")
                {
                    Console.WriteLine("      *      ");
                    Console.WriteLine("     * *     ");
                    Console.WriteLine("    *   *    ");
                    Console.WriteLine("   *     *   ");
                    Console.WriteLine("  *       *  ");
                    Console.WriteLine(" * * * * * * ");

                    Figures.Triangle();
                }
                if (g == "square")
                {
                    Console.WriteLine(" * * * * * * ");
                    Console.WriteLine(" *         * ");
                    Console.WriteLine(" *         * ");
                    Console.WriteLine(" *         * ");
                    Console.WriteLine(" *         * ");
                    Console.WriteLine(" * * * * * * ");

                    Figures.Square();
                }
                if (g == "rectangle")
                {
                    Console.WriteLine(" * * * * * * * * * ");
                    Console.WriteLine(" *               * ");
                    Console.WriteLine(" *               * ");
                    Console.WriteLine(" *               * ");
                    Console.WriteLine(" *               * ");
                    Console.WriteLine(" * * * * * * * * * ");
                    Figures.Rectangle();
                }
                if (g == "circle")
                {
                    Console.WriteLine("     *     ");
                    Console.WriteLine("  *     *  ");
                    Console.WriteLine(" *       * ");
                    Console.WriteLine(" *       * ");
                    Console.WriteLine("  *     *  ");
                    Console.WriteLine("     *     ");
                    Figures.Circle();
                }
                //Obemni figuri:                
                if (g == "piramid")
                {
                    Console.WriteLine("Enter the type of the base of the piramid!");
                    Console.WriteLine("Please type rectangle, triangle, square or circle!");
                    ba = Console.ReadLine().ToLower();
                    while (!(ba == "rectangle" || ba == "square" || ba == "circle" || ba == "triangle"))
                    {
                        Console.WriteLine("Please type rectangle, triangle, square or circle!");
                        ba = Console.ReadLine().ToLower();
                    }
                    Console.WriteLine("Please type the hight of the piramid!");
                    h = double.Parse(Console.ReadLine());
                    if (ba == "triangle")
                    {
                        Console.WriteLine("For calculating the full parameter of the piramid");
                        Console.WriteLine(" we need to calculate the side triangles!");
                        Console.WriteLine("You can use the hight of the sides of the piramid if you have it.");
                        Console.WriteLine("First side of the piramid!");
                        s1 = Figures.Triangle();
                        Console.WriteLine("Second side of the piramid!");
                        s2 = Figures.Triangle();
                        Console.WriteLine("Third side of the piramid!");
                        s3 = Figures.Triangle();
                        Console.WriteLine("Now we will calculate the base area.");
                        be = Figures.Triangle();
                        S = s1 + s2 + s3 + be;
                        V = (be * h) / 3;
                        Console.WriteLine("The volume of the piramid is " + V);
                        Console.WriteLine("The full parameter of the piramid is " + S);
                    }
                    if (ba == "square")
                    {
                        Console.WriteLine("For calculating the surface area of the piramid we need to calculate the side triangles!");
                        Console.WriteLine("First side of the piramid!");
                        s1 = Figures.Triangle();
                        Console.WriteLine("Second side of the piramid!");
                        s2 = Figures.Triangle();
                        Console.WriteLine("Third side of the piramid!");
                        s3 = Figures.Triangle();
                        Console.WriteLine("Fourth side of the piramid!");
                        s4 = Figures.Triangle();
                        Console.WriteLine("Now we will calculate the base area.");
                        be = Figures.Square();
                        S = s1 + s2 + s3 + s4 + be;
                        V = (be * h) / 3;
                        Console.WriteLine("The volume of the piramid is " + V);
                        Console.WriteLine("The full surface area of the piramid is " + S);
                    }
                    if (ba == "rectangle")
                    {
                        Console.WriteLine("For calculating the surface area of the piramid we need to calculate the side triangles!");
                        Console.WriteLine("First side of the piramid!");
                        s1 = Figures.Triangle();
                        Console.WriteLine("Second side of the piramid!");
                        s2 = Figures.Triangle();
                        Console.WriteLine("Third side of the piramid!");
                        s3 = Figures.Triangle();
                        Console.WriteLine("Fourth side of the piramid!");
                        s4 = Figures.Triangle();
                        Console.WriteLine("Now we will calculate the base area.");
                        be = Figures.Rectangle();
                        S = s1 + s2 + s3 + s4 + be;
                        V = (be * h) / 3;
                        Console.WriteLine("The volume of the piramid is " + V);
                    }
                    if (ba == "circle")
                    {
                        Console.WriteLine("This figure is actually cone!");
                        Console.WriteLine("Please type the hight of the side of the cone!");
                        Console.Write("l= ");
                        l = double.Parse(Console.ReadLine());
                        while (l <= 0)
                        {
                            Console.WriteLine("Sides must be positive lenghts!");
                            Console.Write("a= ");
                            l = double.Parse(Console.ReadLine());
                        }
                        Console.WriteLine("Please type the radius of the base circle!");
                        Console.Write("r= ");
                        r = double.Parse(Console.ReadLine());
                        while (r < 0)
                        {
                            Console.WriteLine("Sides must be positive lenghts!");
                            Console.Write("a= ");
                            r = double.Parse(Console.ReadLine());
                        }
                        s1 = Math.PI * r * l;
                        Console.WriteLine("Now we need to calculate the base area.");
                        be = Figures.Circle();
                        S = s1 + be;
                        V = (be * h) / 3;
                        Console.WriteLine("The volume of the cone is " + V);
                        Console.WriteLine("The full surface area of the cone is " + S);
                    }
                }
                //if (g == "prism")
                //{
                //    Console.WriteLine("Please type the hight of the prism!");
                //    h = double.Parse(Console.ReadLine());
                //    while (h<=0)
                //    {
                //        Console.WriteLine("The hight must be positive number!");
                //        h = double.Parse(Console.ReadLine());
                //    }
                //    Console.WriteLine("For calculating the full parameter of the prism");
                //    Console.WriteLine(" we need to calculate the sides!");
                //    Console.WriteLine("First side of the piramid!");
                //    s1 = Figures.Rectangle();
                //    Console.WriteLine("Second side of the piramid!");
                //    s2 = Figures.Rectangle();
                //    Console.WriteLine("Third side of the piramid!");
                //    s3 = Figures.Rectangle();
                //    Console.WriteLine("Now we will calculate the base area.");
                //    be = Figures.Triangle();
                //    S = s1 + s2 + s3 + (2*be);
                //    V = be * h;
                //    Console.WriteLine("The volume of the piramid is " + V);
                //    Console.WriteLine("The full parameter of the piramid is " + S);
                //}
                //if (g == "cylinder")
                //{                    
                //    Console.WriteLine("Please type the hight of the cylinder!");
                //    Console.Write("h= ");
                //    h = double.Parse(Console.ReadLine());
                //    while (h <= 0)
                //    {
                //        Console.WriteLine("Sides must be positive lenghts!");
                //        Console.Write("h= ");
                //        h = double.Parse(Console.ReadLine());
                //    }
                //    Console.WriteLine("Please type the radius of the base circle!");
                //    Console.Write("r= ");
                //    r = double.Parse(Console.ReadLine());
                //    while (r < 0)
                //    {
                //        Console.WriteLine("Sides must be positive lenghts!");
                //        Console.Write("r= ");
                //        r = double.Parse(Console.ReadLine());
                //    }
                //    s1 = (2 * Math.PI * r)*h;
                //    Console.WriteLine("Now we need to calculate the base area.");
                //    be = Figures.Circle();
                //    S = s1 + be;
                //    V = be * h;
                //    Console.WriteLine("The volume of the cylinder is " + V);
                //    Console.WriteLine("The full surface area of the cylinder is " + S);
                //}
                
                if (g == "parallelepiped")
                {
                    Console.WriteLine("Type the side of the paralelepiped!");
                    Console.Write("a= ");
                    a = double.Parse(Console.ReadLine());
                    while (a < 0)
                    {
                        Console.WriteLine("Sides must be positive lenghts!");
                        Console.Write("a= ");
                        a = double.Parse(Console.ReadLine());
                    }
                    Console.WriteLine("Type the side of the paralelepiped!");
                    Console.Write("b= ");
                    b = double.Parse(Console.ReadLine());
                    while (b < 0)
                    {
                        Console.WriteLine("Sides must be positive lenghts!");
                        Console.Write("b= ");
                        b = double.Parse(Console.ReadLine());
                    }
                    Console.WriteLine("Type the side of the paralelepiped!");
                    Console.Write("c= ");
                    c = double.Parse(Console.ReadLine());
                    while (c < 0)
                    {
                        Console.WriteLine("Sides must be positive lenghts!");
                        Console.Write("c= ");
                        c = double.Parse(Console.ReadLine());
                    }
                    V = a * b * c;
                    S = 2 * ((a * b) + (a * c) + (b * c));
                    d = Math.Sqrt((a*a)+(b*b)+(c*c));
                    if (a == b && b == c)
                    {
                        Console.WriteLine("That is actually a cube!");
                        Console.WriteLine("The volume of the cube is " + V);
                        Console.WriteLine("The surface area of the cube is " + S);
                        Console.WriteLine("The diagonal is "+d);
                    }
                    else
                    {
                        Console.WriteLine("The volume of the paralelepiped is " + V);
                        Console.WriteLine("The surface area of the paralelepiped is " + S);
                        Console.WriteLine("The diagonal is " + d);
                    }
                }
                if (g == "sphere")
                {
                    Console.WriteLine("Please write the radius of the sphere!");
                    Console.WriteLine("r= ");
                    r = double.Parse(Console.ReadLine()); ;
                    S = 4*Math.PI*(r*r);
                    V = (4 * Math.PI * (r * r * r)) / 3;
                    Console.WriteLine("The surface area of the sphere is "+S);
                    Console.WriteLine("The volume of the sphere is "+V);
                }
                Console.WriteLine("Do you want to calculate another figure?");
                Console.WriteLine("Please type yes or no!");
                pr = Console.ReadLine().ToLower();
                while (!(pr=="yes" || pr=="no"))
                {
                    Console.WriteLine("Please type yes or no!");
                    pr = Console.ReadLine().ToLower();
                }
                if (pr=="yes")
                {
                    Console.Clear();
                }
                if (pr=="no")
                {
                    break;
                }
            }
        }
    }
    
}