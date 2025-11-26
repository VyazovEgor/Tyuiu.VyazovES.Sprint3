using Tyuiu.VyazovES.Sprint3.Task4.V17.Lib;

DataService ds = new DataService();
double s;

int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());

s = ds.Calculate(a, b); 

Console.WriteLine(s);


Console.ReadKey();
