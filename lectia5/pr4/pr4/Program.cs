using System;
using editare;

namespace afisare
{
    class Program
    {
        public static string[] str = { "abx", "yzc", "qwe" };
        static void Main(string[] args)
        {
            Console.WriteLine(str[2]);
            Clasa.metoda(ref str);
            Console.WriteLine(str[2]);
        }
    }
}
