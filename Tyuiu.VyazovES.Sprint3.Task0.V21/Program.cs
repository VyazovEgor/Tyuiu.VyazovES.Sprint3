using Tyuiu.VyazovES.Sprint3.Task0.V21.Lib;

DataService ds = new DataService();
double s;

double a = Convert.ToDouble(Console.ReadLine());
int k1 = Convert.ToInt32(Console.ReadLine());
int k2 = Convert.ToInt32(Console.ReadLine());

s = ds.GetSumSeries(a, k1, k2);


Console.WriteLine(Math.Round(s, 3));


Console.ReadKey();
