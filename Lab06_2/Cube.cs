using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab06_1
{
    public class Cube : ISolid
    {
        public double A { get; set; }  // Довжина ребра куба

        public Cube(double a)
        {
            A = a;
        }

        // Реалізація методу GetSurfaceArea для куба
        public double GetSurfaceArea()
        {
            return 6 * Math.Pow(A, 2);  // Площа куба: S = 6 * A^2
        }
    }
}
