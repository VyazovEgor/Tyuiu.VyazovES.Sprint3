using Tyuiu.VyazovES.Sprint3.Task2.V14.Lib;

DataService ds = new DataService();
double s;

int x = Convert.ToInt32(Console.ReadLine());
int k1 = Convert.ToInt32(Console.ReadLine());
int k2 = Convert.ToInt32(Console.ReadLine());

s = ds.GetMultiplySeries(x, k1, k2);


Console.WriteLine(s);


Console.ReadKey();
