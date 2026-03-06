namespace Taller__2_de_POO_Herencia
{
    public class Rhombus : Square
    {
        private double _d1;
        private double _d2;

        public double D1
        {
            get => _d1;
            set => _d1 = ValidateD1(value);
        }

        public double D2
        {
            get => _d2;
            set => _d2 = ValidateD2(value);
        }

        public Rhombus(double a, double d1, double d2) : base(a)
        {
            Name = "Rhombus";
            D1 = d1;
            D2 = d2;
        }

        private double ValidateD1(double d1)
        {
            if (d1 <= 0) throw new ArgumentException("La diagonal D1 debe ser mayor que 0.");
            return d1;
        }

        private double ValidateD2(double d2)
        {
            if (d2 <= 0) throw new ArgumentException("La diagonal D2 debe ser mayor que 0.");
            return d2;
        }

        public override double GetArea() => (_d1 * _d2) / 2;
        public override double GetPerimeter() => 4 * A;
    }
}