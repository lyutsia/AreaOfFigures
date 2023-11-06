namespace AreaOfFigures
{
    public class Triangle : IFigureArea
    {
        public Triangle(double sideA, double sideB, double sideC)
        {
            SideA = sideA;
            SideB = sideB;
            SideC = sideC;
        }

        private double sideA;
        public double SideA
        {
            get
            {
                return sideA;
            }
            set
            {
                if (value < 0)
                    throw new ArgumentException();
                sideA = value;
            }
        }

        private double sideB;
        public double SideB
        {
            get
            {
                return sideB;
            }
            set
            {
                if (value < 0)
                    throw new ArgumentException();
                sideB = value;
            }
        }

        private double sideC;
        public double SideC
        {
            get
            {
                return sideC;
            }
            set
            {
                if (value < 0)
                    throw new ArgumentException();
                sideC = value;
            }
        }

        /// <summary>
        /// полупериметр
        /// </summary>
        public double Semiperimeter => (SideA + SideB + SideC) / 2;

        public double GetArea() => Math.Sqrt(Semiperimeter * (Semiperimeter - SideA) * (Semiperimeter - SideB) * (Semiperimeter - SideC));

        /// <summary>
        /// является ли треугольник прямоугольным
        /// </summary>
        /// <returns></returns>
        public bool IsRectangular() => PythagoreanTheoremIsCorrect(SideA, SideB, SideC)
            || PythagoreanTheoremIsCorrect(SideB, SideC, SideA) || PythagoreanTheoremIsCorrect(SideA, SideC, SideB);

        /// <summary>
        /// выполняется ли теорема Пифагора
        /// </summary>
        /// <param name="side1">сторана1</param>
        /// <param name="side2">стоона2</param>
        /// <param name="hypotenuse">гипотенуза</param>
        /// <returns></returns>
        public bool PythagoreanTheoremIsCorrect(double side1, double side2, double hypotenuse) => Math.Pow(side1, 2) + Math.Pow(side2, 2) == Math.Pow(hypotenuse, 2);
    }
}
