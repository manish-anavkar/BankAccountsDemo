using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternDemo2
{
    public class Circle:IShape
    {
        private double _radius;

        public void CalculateArea()
        {
            Console.WriteLine("Please enter the radius");
            _radius = Convert.ToDouble(Console.ReadLine());

            double area = 3.14159265 * _radius * _radius;
            Console.WriteLine($"Area of the circle: {area}");
        }
    }
}
