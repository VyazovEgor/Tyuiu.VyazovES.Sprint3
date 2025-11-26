using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.VyazovES.Sprint3.Task4.V17.Lib
{
    public class DataService : ISprint3Task4V17
    {
        public double Calculate(int a, int b)
        {
            int x = a;
            double y = 0;
            do
            {
                if (x == 0)
                {
                    break;
                }

                y = Math.Cos(x) / Math.Sin(x);
                x++;
            }
            while (x < b);

            return Math.Pow(y,3);
        }
    }
}

