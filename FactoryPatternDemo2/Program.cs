namespace FactoryPatternDemo2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                IShape shape1 = ShapeFactory.Create(Constants.Shape.Circle);
                shape1.CalculateArea();

                IShape shape2 = ShapeFactory.Create(Constants.Shape.Triangle);
                shape2.CalculateArea();

                IShape shape3 = ShapeFactory.Create(Constants.Shape.Square);
                shape3.CalculateArea();

                IShape shape4 = ShapeFactory.Create(Constants.Shape.Rectangle);
                shape4.CalculateArea();

                IShape shape5 = ShapeFactory.Create(Constants.Shape.Hexagon);
                shape5.CalculateArea();
            }
            catch (NotImplementedException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
