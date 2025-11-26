using Tyuiu.VyazovES.Sprint3.Task6.V13.Lib;

DataService ds = new DataService();
double s;

int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());


s = ds.GetSumTheDivisors(a, b);

Console.WriteLine(s);


Console.ReadKey();
