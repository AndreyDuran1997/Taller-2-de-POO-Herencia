namespace Taller__2_de_POO_Herencia
{
    public class Trapeze : Triangle
    {
        private double _d;

        public double D
        {
            get => _d;
            set => _d = ValidateD(value);
        }

        public Trapeze(double a, double b, double c, double d, double h) : base(a, b, c, h)
        {
            Name = "Trapeze";
            D = d;
        }

        private double ValidateD(double d)
        {
            if (d <= 0) throw new ArgumentException("El lado D debe ser mayor que 0.");
            return d;
        }

        public override double GetArea() => ((B + _d) * H) / 2;
        public override double GetPerimeter() => A + B + C + _d;
    }
}