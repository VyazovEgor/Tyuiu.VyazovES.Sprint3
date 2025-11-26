using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.VyazovES.Sprint3.Task1.V18.Lib
{
    public class DataService : ISprint3Task1V18
    {
        public double GetSumSeries(int i1, int i2)
        {
            double S = 0;


            while (i1 <= i2)
            {
                S += Math.Sin(i1) * 0.0625;
                i1++;
            }

            return Math.Round(S, 3);
        }
    }
}
