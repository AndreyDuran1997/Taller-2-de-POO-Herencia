namespace Taller__2_de_POO_Herencia
{
    public class Rectangle : Square
    {
        private double _b;

        public double B
        {
            get => _b;
            set => _b = ValidateB(value);
        }

        public Rectangle(double a, double b) : base(a)
        {
            Name = "Rectangle";
            B = b;
        }

        private double ValidateB(double b)
        {
            if (b <= 0) throw new ArgumentException("El lado B debe ser mayor que 0.");
            return b;
        }

        public override double GetArea() => A * _b;
        public override double GetPerimeter() => 2 * (A + _b);
    }
}