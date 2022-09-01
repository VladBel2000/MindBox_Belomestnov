using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Math;

namespace Lib_figure
{
    public class Triangle : Figure
    {
        private double a;
        private double b;
        private double c;

        public double A
        {
            get { return a; }
            set { a = value; }
        }

        public double B
        {
            get { return b; }
            set { b = value; }
        }

        public double C
        {
            get { return c; }
            set { c = value; }
        }

        protected Triangle() : base("Triangle")
        {
     
        }
        public Triangle(double a, double b, double c) : this()
        {
            if (a + b > c && a + c > b && b + c > a)
            {
                A = a;
                B = b;
                C = c;
            }
            else
            {
                Console.WriteLine("Error value");
            }
        }

        // Нахождение площади
        public override double Get_Area()
        {
            double Area = 0;
            // Формула Герона
            double Part_Perimeter = (A + B + C) / 2;
            Area = Sqrt(Part_Perimeter * (Part_Perimeter - A) * (Part_Perimeter - B) * (Part_Perimeter - C));
            return (Area);
        }

        // Проверка треугольника на прямоугольный
        public bool Check_Right_Triangle()
        {
            bool Result = false;
            List<double> Sides = new List<double>(){ A, B, C };
            Sides.Sort();
            if (Pow(Sides[0], 2) + Pow(Sides[1], 2) == Pow(Sides[2], 2))
                Result = true;
            return (Result);
        }
    }
}
