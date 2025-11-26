using Tyuiu.VyazovES.Sprint3.Task7.V26.Lib;

DataService ds = new DataService();
double [] s;

int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());

s = ds.GetMassFunction(a, b);

for (int i = 0; i < s.Length; i++)
{
    int x = -5 + i;
    Console.WriteLine($"{x}\t{s[i]:F2}");
}

Console.ReadKey();
