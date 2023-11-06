namespace AreaOfFigures
{
    public class Circle : IFigureArea
    {
        public Circle(double radius)
        {
            Radius = radius;
        }

        private double radius;
        public double Radius
        {
            get
            {
                return radius;
            }
            set
            {
                if (value < 0)
                    throw new ArgumentException();
                radius = value;
            }
        }

        public double GetArea() => Math.PI * Math.Pow(Radius, 2);
    }
}
