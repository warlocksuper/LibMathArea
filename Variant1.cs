using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

//способ решения задачи первый
// Монолитный класс для решения задачи
// главный плюс данного подхода все обрабатывается и анализаруется в одном классе что позволяет не плодить лишние сущьности
// главный минус данного подхода это маштабируемость добавление новых фигур будет осложнено


namespace LibMathArea
{

    public enum FigureType
    {
        triangle,
        circle
    }

    class LibMathArea
    {

        public static double figure_area(FigureType type, params float[] storoni)
        {
            double s = 0;
            switch (type)
            {
                case FigureType.circle:
                    s = circle_area(storoni[0]);
                    break;
                case FigureType.triangle:
                    s = triangle_area(storoni[0], storoni[1], storoni[2]);
                    break;
            }
            return s;
        }

        static double triangle_area(float a, float b, float c)
        {
            float[] x = new float[3] { a, b, c };
            Array.Sort(x);
            if (Math.Pow(x[2], 2) == (Math.Pow(x[0], 2) + Math.Pow(x[1], 2)))
            {
                Console.WriteLine("Треугольник прямоугольный");
            }

            double p = (a + b + c) / 2;

            double s = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            return s;
        }


        static double circle_area(float R)
        {
            return Math.PI * Math.Pow(R, 2);
        }

    }
}
