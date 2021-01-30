using System;
using static System.Console;
using System.Threading;

namespace ConsoleApp3_DateTime
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime timpacum = DateTime.Now;
            WriteLine(timpacum);

            for (int i = 0; i < 10; i++)
            {
                Beep();
                Thread.Sleep(500);
            }
        }
    }
}
