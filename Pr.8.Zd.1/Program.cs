using System;
namespace HelloApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите значение х=");
            double x = double.Parse(Console.ReadLine());
            double y;

            if (x > 2)
                y = (x * (Math.Cbrt(x-2)));
            else
            {
                if (x < 2)
                    y = 1 / (Math.Pow(Math.Pow(Math.E, x), 2)) * ((Math.Pow(Math.Cos(x), 2)) - (Math.Pow(Math.Sin(x), 2)));
                else
                    y = x * (2*Math.Sin(x) * Math.Cos(x));
            }
            Console.WriteLine("y=" + y);

        }
    }
}
