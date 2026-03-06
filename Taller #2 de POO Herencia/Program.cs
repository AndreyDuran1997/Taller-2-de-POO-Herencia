namespace Taller__2_de_POO_Herencia
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GeometricFigure[] figures =
            {
                new Circle(5),
                new Square(10),
                new Rhombus(5, 7, 10),
                new Kite(10, 5, 5, 6),
                new Rectangle(67.79, 4.568),
                new Parallelogram(29.32, 40, 31.558),
                new Triangle(27.495, 30, 27.495, 6.17),
                new Trapeze(20, 20, 20, 40, 20)
            };

            foreach (var fig in figures)
                Console.WriteLine(fig.ToString());
        }
    }
}