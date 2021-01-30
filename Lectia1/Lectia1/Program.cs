// Librariile
using System;

// namespace-urile se folosesc ca delimitari dintre clase
namespace Lectia1
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            //int rand = random.Next(100);

            int a = random.Next(100);
            int b = Convert.ToInt32(Console.ReadLine());
            int c = a+b;

            Console.WriteLine("a= " + Convert.ToInt16(a) + " b= " + b + " rezultatul este:" + c);

            //Console.WriteLine("Hello World!");
            //System.Console.WriteLine("Hello World!"); - fara a include biblioteca System


        }
    }
}
