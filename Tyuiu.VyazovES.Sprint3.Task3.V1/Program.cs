using Tyuiu.VyazovES.Sprint3.Task3.V1.Lib;

DataService ds = new DataService();

string s = Convert.ToString(Console.ReadLine());
char a = Convert.ToChar(Console.ReadLine());

int x = ds.GetCharCount(s, a);


Console.WriteLine(x);


Console.ReadKey();
