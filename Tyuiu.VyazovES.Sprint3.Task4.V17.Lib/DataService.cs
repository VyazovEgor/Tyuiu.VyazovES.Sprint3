using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.VyazovES.Sprint3.Task4.V17.Lib
{
    public class DataService : ISprint3Task4V17
    {
        public double Calculate(int a, int b)
        {
            double product = 1;

            for (int x = a; x <= b; x++)
            {
                if (x == 0)
                {
                    continue; // Пропускаем x = 0 вместо прерывания
                }

                double y = Math.Cos(x) / Math.Sin(x);
                product *= y;
            }

            return Math.Pow(product,3);
        }
    }
}

