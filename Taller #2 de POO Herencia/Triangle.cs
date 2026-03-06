namespace Taller__2_de_POO_Herencia
{
    public class Triangle : Rectangle
    {
        private double _c;
        private double _h;

        public double C
        {
            get => _c;
            set => _c = ValidateC(value);
        }

        public double H
        {
            get => _h;
            set => _h = ValidateH(value);
        }

        public Triangle(double a, double b, double c, double h) : base(a, b)
        {
            Name = "Triangle";
            C = c;
            H = h;
        }

        private double ValidateC(double c)
        {
            if (c <= 0) throw new ArgumentException("El lado C debe ser mayor que 0.");
            return c;
        }

        private double ValidateH(double h)
        {
            if (h <= 0) throw new ArgumentException("La altura debe ser mayor que 0.");
            return h;
        }

        public override double GetArea() => (B * _h) / 2;
        public override double GetPerimeter() => A + B + _c;
    }
}