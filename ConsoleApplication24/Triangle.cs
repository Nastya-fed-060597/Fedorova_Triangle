using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication24
{
    class Triangle
    {
        public Point A { get; set; }
        public Point B { get; set; }
        public Point C { get; set; }

        public bool status { get; set; }
        

        public Triangle(Point a, Point b, Point c)
        {
            A = a;
            B = b;
            C = c;
        }

        public double Perimetr()
        {
            edge AB = new edge(A, B);
            edge BC = new edge(B, C);
            edge CA = new edge(C, A);
            return AB.GetLength() + BC.GetLength() + CA.GetLength();
        }

        public double Sqare()
        {
            edge AB = new edge(A, B);
            edge BC = new edge(B, C);
            edge CA = new edge(C, A);
            double p;
            p = (AB.GetLength() + BC.GetLength() + CA.GetLength()) / 2;
            return Math.Sqrt((p * (p - AB.GetLength()) * (p - BC.GetLength()) * (p - CA.GetLength())));
        }
        
        public bool IsRight()
        {
            edge AB = new edge(A, B);
            edge BC = new edge(B, C);
            edge CA = new edge(C, A);
            if ((AB.GetLength() * AB.GetLength() + BC.GetLength() * BC.GetLength()) == (CA.GetLength() * CA.GetLength()) || (AB.GetLength() * AB.GetLength()) == (BC.GetLength() * BC.GetLength() + CA.GetLength() * CA.GetLength()) || (BC.GetLength() * BC.GetLength()) == (AB.GetLength() * AB.GetLength() + CA.GetLength() * CA.GetLength()))
                return true;
            else
                return false;
        }

        public bool IsEquilateral()
        {
            edge AB = new edge(A, B);
            edge BC = new edge(B, C);
            edge CA = new edge(C, A);
            if (AB.GetLength() == BC.GetLength() && BC.GetLength() == CA.GetLength())
                return true;
            else
                return false;
        }

        public bool IsIsosceles()
        {
            edge AB = new edge(A, B);
            edge BC = new edge(B, C);
            edge CA = new edge(C, A);
            if (AB.GetLength() == BC.GetLength() || BC.GetLength() == CA.GetLength() || AB.GetLength() == CA.GetLength())
                {
                    return true;
                }
                    return false;
        }

        
        public void Check()
        {
            status = false;
            edge AB = new edge(A, B);
            edge BC = new edge(B, C);
            edge CA = new edge(C, A);

            if ((AB.GetLength() + BC.GetLength() > CA.GetLength()) || (BC.GetLength() + CA.GetLength() > AB.GetLength()) || (AB.GetLength() + CA.GetLength() > BC.GetLength()))
            {
                status = true;
            }
        }

    }
}
