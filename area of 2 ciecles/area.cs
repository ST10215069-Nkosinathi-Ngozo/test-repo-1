using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace area_of_2_ciecles
{
    internal class area
    {
        
        double radiusSmall;
        double pi = 3.14;

        public area(double radiusSmall) { 
            this.radiusSmall = radiusSmall;
        
        }
        public double calculateAreaOfSmallCircle() {
            double area = pi * radiusSmall * radiusSmall;
            return area;
        }
        public double calculateAreaOfBigCircle()
        {
            double area = calculateAreaOfSmallCircle() * 2;
            return area;
        }


    }
}
