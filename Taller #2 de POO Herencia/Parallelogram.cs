namespace Taller__2_de_POO_Herencia
{
    public class Parallelogram : Rectangle
    {
        private double _h;

        public double H
        {
            get => _h;
            set => _h = ValidateH(value);
        }

        public Parallelogram(double a, double b, double h) : base(a, b)
        {
            Name = "Parallelogram";
            H = h;
        }

        private double ValidateH(double h)
        {
            if (h <= 0) throw new ArgumentException("La altura debe ser mayor que 0.");
            return h;
        }

        public override double GetArea() => B * _h;
        public override double GetPerimeter() => 2 * (A + B);
    }
}