using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace LibMathArea
{

    public class Figura
    {
        public float[] storoni;
        public double area;

        public static double GetArrea(int s)
        {
            return Math.PI * Math.Pow(s, 2);
        }
    }


    public class Circle : Figura
    {
        public override static double GetArrea(int radiuss)
        {
            return Math.PI * Math.Pow(s, 2);
        }
    }

    public class triangle : Figura
    {
        public override static double GetArrea(float a, float b, float c)
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
    }

}