using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab06_1
{
    public class RectSolid : ISolid
    {
        public double C { get; set; }  // Довжина основи
        public double D { get; set; }  // Ширина основи
        public double H { get; set; }  // Висота

        public RectSolid(double c, double d, double h)
        {
            C = c;
            D = d;
            H = h;
        }

        // Реалізація методу GetSurfaceArea для прямокутного паралелепіпеда
        public double GetSurfaceArea()
        {
            return 2 * (C * D + D * H + C * H);  // Площа паралелепіпеда: S = 2(CD + DH + CH)
        }
    }
}
