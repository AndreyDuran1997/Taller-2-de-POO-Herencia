namespace Taller__2_de_POO_Herencia
{
    public class Circle : GeometricFigure
    {
        private double _r;

        public double R
        {
            get => _r;
            set => _r = ValidateR(value);
        }

        public Circle(double r)
        {
            Name = "Circle";
            R = r;
        }

        private double ValidateR(double r)
        {
            if (r <= 0) throw new ArgumentException("El radio debe ser mayor que 0.");
            return r;
        }

        public override double GetArea() => Math.PI * _r * _r;
        public override double GetPerimeter() => 2 * Math.PI * _r;
    }
}