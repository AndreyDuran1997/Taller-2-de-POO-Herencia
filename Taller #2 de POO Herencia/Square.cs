namespace Taller__2_de_POO_Herencia
{
    public class Square : GeometricFigure
    {
        private double _a;

        public double A
        {
            get => _a;
            set => _a = ValidateA(value);
        }

        public Square(double a)
        {
            Name = "Square";
            A = a;
        }

        private double ValidateA(double a)
        {
            if (a <= 0) throw new ArgumentException("El lado debe ser mayor que 0.");
            return a;
        }

        public override double GetArea() => _a * _a;
        public override double GetPerimeter() => 4 * _a;
    }
}