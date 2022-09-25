using System;

namespace ClassLibrary
{
    public class Circle:IShape
    {
        /// <summary>
        /// Радиус круга
        /// </summary>
        protected double Radius { get; }

        /// <summary>
        /// Круг
        /// </summary>
        /// <param name="rad">Радиус круга</param>
        /// <exception cref="ArgumentOutOfRangeException">Если радиус круга имеет отрицательное значение</exception>
        public Circle(double rad)
        {
            if(rad <0) {
                throw new ArgumentOutOfRangeException("Радиус не может быть отрицательным");
            }
            Radius = rad;
        }

        /// <summary>
        /// Вычисление площади круга
        /// </summary>
        /// <returns></returns>
        public double GetSquare()
        {
            return Math.PI * (Math.Pow(Radius, 2));           
        }

    }
}
