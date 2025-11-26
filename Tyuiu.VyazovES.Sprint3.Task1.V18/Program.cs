using Tyuiu.VyazovES.Sprint3.Task1.V18.Lib;

DataService ds = new DataService();
double s;

int i1 = Convert.ToInt32(Console.ReadLine());
int i2 = Convert.ToInt32(Console.ReadLine());

s = ds.GetSumSeries(i1, i2);


Console.WriteLine(s);


Console.ReadKey();
