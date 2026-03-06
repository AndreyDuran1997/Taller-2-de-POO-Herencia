namespace Taller__2_de_POO_Herencia
{
    public abstract class GeometricFigure
    {
        public string Name { get; protected set; }

        public abstract double GetArea();
        public abstract double GetPerimeter();

        public override string ToString()
        {
            return $"{Name,-15} => Area.....: {GetArea(),13:N5}   Perimeter: {GetPerimeter(),13:N5}";
        }
    }
}