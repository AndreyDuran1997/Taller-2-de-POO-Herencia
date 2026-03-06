namespace Taller__2_de_POO_Herencia
{
    public class Kite : Rhombus
    {
        private double _b;

        public double B
        {
            get => _b;
            set => _b = ValidateB(value);
        }

        public Kite(double a, double b, double d1, double d2) : base(a, d1, d2)
        {
            Name = "Kite";
            B = b;
        }

        private double ValidateB(double b)
        {
            if (b <= 0) throw new ArgumentException("El lado B debe ser mayor que 0.");
            return b;
        }

        public override double GetArea() => (D1 * D2) / 2;
        public override double GetPerimeter() => 2 * (A + _b);
    }
}