using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication24
{
    class edge
    {
   
        public Point A { get; set;}
        public Point B { get; set; }

        public edge(Point a, Point b)
        {
            A = a;
            B = b;
        }

        public double GetLength()
        {
            return Math.Sqrt(Math.Pow(B.X - A.X, 2) + Math.Pow(B.Y - A.Y, 2));
        }
    }
}
