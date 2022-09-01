using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Math;

namespace Lib_figure
{
    public class Circle : Figure
    {
        private double radius;

        public double Radius
        {
            get { return radius; }
            set { radius = value; }
        }

        protected Circle() : base("Circle")
        {

        }

        public Circle(double radius) : this()
        {
            Radius = radius;
        }

        public override double Get_Area() 
        {
            double Area = 0;
            Area = PI * Radius * Radius;
            return (Area);
        }

    }
}
