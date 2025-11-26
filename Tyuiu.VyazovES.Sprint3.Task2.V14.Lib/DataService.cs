using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.VyazovES.Sprint3.Task2.V14.Lib
{
    public class DataService : ISprint3Task2V14
    {
        public double GetMultiplySeries(int x, int k1, int k2)
        {
            double S = 1;
            do
            {
                S = S * ((double)x / k1) * ((double)x / k1) * ((double)x / k1);
                k1++;
            }
            while (k1 <= k2);

            return Math.Round(S, 3);
        
    }
    }
}
