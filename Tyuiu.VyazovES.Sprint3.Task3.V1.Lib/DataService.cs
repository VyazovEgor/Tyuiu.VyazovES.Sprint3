using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.VyazovES.Sprint3.Task3.V1.Lib
{
    public class DataService : ISprint3Task3V1
    {
        public int GetCharCount(string s, char a)
        {
            int count = 0;

            foreach (char ch in s)
            {
                if (ch == a)
                {
                    count++;
                }

            }
            return count;
        }
    }
}
