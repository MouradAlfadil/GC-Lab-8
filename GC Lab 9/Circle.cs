using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GC_Lab_9
{
    internal class Circle
    {

        private double Radius;


        public Circle(double radius)
        {
            Radius = radius;
        }

        public double CalculateCircumference()
        {
            return 2 * Math.PI * Radius;
        }

        public string CalculateFormattedCircumference()
        {
            return Math.Round(CalculateCircumference(), 2).ToString();
        }

        public double CalculateArea()
        {
            return Math.PI * Radius * Radius;
        }
        public string CalculateFormattedArea()
        {
            return Math.Round(CalculateArea(), 2).ToString();
        }
        private string FormatNumber(double x)
        {

            return x.ToString();

        }

    }
}
