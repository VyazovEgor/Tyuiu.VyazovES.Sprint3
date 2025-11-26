using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.VyazovES.Sprint3.Task7.V26.Lib
{
    public class DataService : ISprint3Task7V26
    {
        public double[] GetMassFunction(int a, int b)
        {
            int size = Math.Abs(b - a) + 1;
            double[] results = new double[size];

            for (int i = 0; i < size; i++)
            {
                double x = a + i;
                double denominator = 2 * x - 0.5;

                // Проверка деления на ноль (когда 2x - 0.5 = 0, т.е. x = 0.25)
                if (Math.Abs(x - 0.25) < 0.000001)
                {
                    results[i] = 0;
                }
                else
                {
                    double functionValue = 5 - 3 * x + (1 + Math.Sin(x)) / denominator;
                    results[i] = Math.Round(functionValue, 2);
                }
            }

            return results;
        }
    }
}
