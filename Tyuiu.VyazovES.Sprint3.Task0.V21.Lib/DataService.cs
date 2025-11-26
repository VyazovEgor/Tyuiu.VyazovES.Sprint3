using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.VyazovES.Sprint3.Task0.V21.Lib
{
    public class DataService : ISprint3Task0V21
    {
        public double GetSumSeries(double a, int k1, int k2)
        {
            double S = 0;


            for (int k = k1; k <= k2; k++)
            {


                S += (a + Math.Sin(k));
            }

            return S;
        }
    }
}