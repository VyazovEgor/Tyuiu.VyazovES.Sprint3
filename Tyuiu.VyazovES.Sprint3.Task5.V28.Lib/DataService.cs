using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.VyazovES.Sprint3.Task5.V28.Lib
{
    public class DataService : ISprint3Task5V28
    {
        public double GetSumSumSeries(int x, int st1, int st2, int sp1, int sp2)
        {
            double y = 0;

            for (int i = st1; i <= sp1; i++)
            {
                for (int k = st2; k <= sp2; k++)
                {
                    double numerator = Math.Pow(k, x); // k^x
                    double denominator = Math.Sin(k);  // sin(k)
                    y += numerator / denominator;
                }
            }
            return Math.Round(y, 3);
        }
    }
}
