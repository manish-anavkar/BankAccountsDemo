using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternDemo2
{
    public class Triangle:IShape
    {
        private double _base;
        private double _height;

        public void CalculateArea()
        {
            Console.WriteLine("Please enter the base");
            _base = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Please enter the height");
            _height = Convert.ToDouble(Console.ReadLine());

            double area = 0.5 * _base * _height;
            Console.WriteLine($"Area of the triangle: {area}");
        }
    }
}
