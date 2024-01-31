using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternDemo2
{
    public class ShapeFactory
    {
        public static IShape Create(Constants.Shape shape)
        {
            switch (shape)
            {
                case Constants.Shape.Circle:
                    return new Circle();
                case Constants.Shape.Square:
                    return new Square();
                case Constants.Shape.Rectangle:
                    return new Rectangle();
                case Constants.Shape.Triangle:
                    return new Triangle();
                default:
                    throw new NotImplementedException($"Calculate Area for {shape} is not implemented");
            }
        }
    }
}
