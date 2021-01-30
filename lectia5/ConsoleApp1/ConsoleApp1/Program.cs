using System;
using Operatii;
using static System.Console;
using static Operatii.ClasaOperatii;

namespace Executie
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 20, b = 5;
            WriteLine(adunare(a, b));
            WriteLine(scadere(a, b));
            WriteLine(inmultire(a, b));
            WriteLine(impartire(a, b));
        }
    }
}
