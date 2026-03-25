using System;
using System.Collections.Generic;
using System.Text;

namespace Classes_Rectangle_and_Circle
{
    public class Rectangle
    {
        /// <summary>
        /// Gets or sets the length value.
        /// </summary>
        public double Length { get; set; }

        public double Width { get; set; }



        public Rectangle()
        {
            Length = 0;
            Width = 0;
        }

        /// <summary>
        /// Calculatex the perimeter of the rectangle
        /// </summary>
        /// <returns>A double representing the perimeter value</returns>
        public double CalculatePerimeter()
        {
            double perimeter = 0;

            perimeter = 2 * (Length + Width);

            return perimeter;
        }


        public double CalculateArea()
        {
            double area = 0;

            area = Width * Length;

            return area;
        }

        public override string ToString()
        {
            double p = CalculatePerimeter();
            double a = CalculateArea();
            return $"The rectangle has a length of {Length}, a width of {Width}, a perimeter of {p} and an area of {a}";
        }

    }
}
