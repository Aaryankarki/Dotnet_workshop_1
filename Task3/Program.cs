// See https://aka.ms/new-console-template for more information
using System.Threading.Tasks.Dataflow;

class Program
{
    static void Main()
    {
        byte bt = 3;
        short st = 6;
        int it = 8;
        long ln = 1200000000;
        float ft = 2.88f;
        double dt = 40.67890;
        decimal dc = 3.5m;
        char ch = 'A';
        bool bl = true;

        String so = it.ToString();
        Double ak = Convert.ToDouble("3.14");


         Console.WriteLine("byte: " + bt);
        Console.WriteLine("short: " + st);
        Console.WriteLine("int: " + it);
        Console.WriteLine("long: " + ln);
        Console.WriteLine("float: " + ft);
        Console.WriteLine("double: " + dt);
        Console.WriteLine("decimal: " + dc);
        Console.WriteLine("char: " + ch);
        Console.WriteLine("bool: " + bl);
        Console.WriteLine("Integer to string: " + so);
        Console.WriteLine("String to double: " + ak);
    }
}