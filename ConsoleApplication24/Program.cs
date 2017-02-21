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
            var a = new Point(2, 4);
            var b = new Point(5, 1);
            var c = new Point(3, 6);

            Triangle ABC = new Triangle(a, b, c);
            Console.WriteLine("Площадь = {0}, Периметр = {1}, Тип треугольника = {2}", ABC.Sqare(), ABC.Perimetr(), ABC.Type());
            Console.ReadLine();

        }
    }
    
}
