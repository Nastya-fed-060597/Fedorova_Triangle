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
                Console.WriteLine("Площадь = {0}, Периметр = {1}, Тип треугольника = {2}", n[i].Sqare(), n[i].Perimetr(), n[i].Type());
                string t = n[i].Type();
                if (t == "Прямоугольный")
                {
                    P = P + n[i].Perimetr();
                }
                if (t == "Равнобедренный")
                {
                    S = S + n[i].Sqare();
                }
            }

            Console.WriteLine(P / n.Length);
            Console.WriteLine(S / n.Length);
            Console.ReadLine();

        }
    }
    
}
