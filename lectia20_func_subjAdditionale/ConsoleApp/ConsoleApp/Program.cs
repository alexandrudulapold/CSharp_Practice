using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using static System.Console;

namespace ExpresiiFunc
{
    //class Program
    //{
    //    static void Main()
    //    {
    //        //Func care primeste un numar si returneaza un string formatat
    //        Func<string, string> func1 = (x) => x.Substring(0, x.Length / 2);

    //        //Func care primeste 2 parametri bool si int si returneaza string
    //        Func<int, int> func2 = (x) => Convert.ToInt32(Math.Pow(x, 3));

    //        // Func fara parametri care returneaza Pi/2
    //        Func<int, int> func3 = (x) => x % 2 == 0 ? x / 2 : x * 2;

    //        WriteLine(func1.Invoke("vasile"));
    //        WriteLine(func2.Invoke(10));
    //        WriteLine(func3.Invoke(3));
    //        WriteLine(func3.Invoke(4));
    //    }
    //}
}

namespace ExpresiiFuncParametru
{
    class Program
    {
        static void Main()
        {
            IEnumerable<string> strings = new List<string> { "one", "two", "three", "four" };
            IEnumerable<string> result = strings.Select(str =>
            {
                if (str.First() == 't') return str + str;
                else return str;
            } );

            //lungimea afisare (p1)
            foreach (var element in result)
                WriteLine(element.Length);

            foreach (var element in result)
                WriteLine(element);
        }
    }
}
