using Tyuiu.VyazovES.Sprint3.Task5.V28.Lib;

DataService ds = new DataService();
double s;

int x = Convert.ToInt32(Console.ReadLine());
int st1 = Convert.ToInt32(Console.ReadLine());
int st2 = Convert.ToInt32(Console.ReadLine());
int sp1 = Convert.ToInt32(Console.ReadLine());
int sp2 = Convert.ToInt32(Console.ReadLine());

s = ds.GetSumSumSeries(x, st1, st2, sp1, sp2);

Console.WriteLine(s);


Console.ReadKey();
