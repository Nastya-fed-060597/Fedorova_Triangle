using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication24
{
    class Program
    {
        static void Main(string [] args)
        {
            var n = new Triangle[100];
            Random gen = new Random();
            double P = 0;
            double S = 0;
            for (int i = 0; i < n.Length; i++)
            {
                var a = new Point(gen.Next(10), gen.Next(10));
                var b = new Point(gen.Next(10), gen.Next(10));
                var c = new Point(gen.Next(10), gen.Next(10));

                n[i] = new Triangle(a, b, c);
                n[i].Check();
                if (n[i].status == true)
                {


                    Console.WriteLine("Площадь = {0}, Периметр = {1}, Прямоугольный = {2}, Равносторонний = {3}, Равнобедренный = {4}", n[i].Sqare(), n[i].Perimetr(), n[i].IsRight(), n[i].IsEquilateral(), n[i].IsIsosceles());

                    if (n[i].IsRight() == true )
                    {
                        P = P + n[i].Perimetr();
                    }
                    if (n[i].IsIsosceles() == true)
                    {
                        S = S + n[i].Sqare();
                    }
                }
            }

            Console.WriteLine(P / n.Length);
            Console.WriteLine(S / n.Length);
            Console.ReadLine();

        }
    }
    
}
