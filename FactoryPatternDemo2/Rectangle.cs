using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternDemo2
{
    public class Rectangle:IShape
    {
        private double _length;
        private double _width;

        public void CalculateArea()
        {
            Console.WriteLine("Please enter the length");
            _length = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Please enter the width");
            _width = Convert.ToDouble(Console.ReadLine());

            double area = _length * _width;
            Console.WriteLine($"Area of the rectangle: {area}");
        }
    }
}
