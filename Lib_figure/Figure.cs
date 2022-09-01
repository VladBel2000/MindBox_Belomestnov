using System;

namespace Lib_figure
{
    public abstract class Figure
    {
        private String Type;
        public Figure(string type)
        {
            Type = type;
        }
        public abstract double Get_Area();
    }
}
