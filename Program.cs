using System;

namespace TimeLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, x;
            string msg = "Abracadabra";
            n = int.Parse(Console.ReadLine());
            for (x = 1; x <= n; x++)
                Console.WriteLine(x + " " + msg);
        }
    }
}
