using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternDemo2
{
    public class Square:IShape
    {
        private double _side;

        public void CalculateArea()
        {
            Console.WriteLine("Please enter one side");
            _side = Convert.ToDouble(Console.ReadLine());

            double area = _side * _side;
            Console.WriteLine($"Area of the square: {area}");
        }
    }
}
