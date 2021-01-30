using System;
using System.Collections.Generic;
using static System.Console;

namespace ClasaGenerica2
{
    //    public class TestClass<T, U, V>
    //    {
    //        T T1;
    //        U U1;
    //        V V1;

    //        public TestClass(T a, U b, V c)
    //        {
    //            T1 = a;
    //            U1 = b;
    //            V1 = c;
    //        }

    //        public T functia()
    //        {
    //            WriteLine(U1);
    //            WriteLine(V1);
    //            return T1;
    //        }
    //        public U functia()
    //        {
    //            return ;
    //        }
    //    }
    //    class Program
    //    {
    //        static void Main(string[] args)
    //        {
    //            TestClass<int, double, byte> OBJ = new TestClass<int, double, byte>(6431,10.50,25);
    //            WriteLine(OBJ.functia());
    //            WriteLine()
    //        }
    //    }
}

namespace NeTo
{
    //    public class TestClass<T, U>
    //    {
    //        object[] obj = new object[5];
    //        int count = 0;
    //        public void Add(T item)
    //        {
    //            if (count + 1 < 6)
    //            {
    //                obj[count] = item;
    //            }
    //            count++;
    //        }
    //        public void Add(U item)
    //        {
    //            if (count + 1 < 6)
    //            {
    //                obj[count] = item;
    //            }
    //            count++;
    //        }

    //        public object this[int index]
    //        {
    //            get { return obj[index]; }
    //            set { obj[index] = value; }
    //        }
    //    }
    //    class Program
    //    {
    //        static void Main(string[] args)
    //        {
    //            TestClass<char, string> intObj = new TestClass<char, string>();
    //            intObj.Add("string");
    //            intObj.Add('a');
    //        }
    //    }
}

#region lista
class program
{
    static void Main(string[] args)
    {
        //crearea lista
        List<char> L = new List<char>() { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h' };

        //adaugare element (la sfarsit)
        L.Add('i');

        //cream array de char-uri si il inseram in lista
        char[] arr = new char[] { ' ', 't', 'a', 'b', 'l', 'o', 'u', ' ' };
        L.InsertRange(4, arr);

        //daca contine z
        WriteLine("Lista contine 'z': " + L.Contains('z'));
        L.Add('z');
        WriteLine("Lista contine 'z': " + L.Contains('z'));

        //stergem toate 'a'
        L.RemoveAll(x => x == 'a');

        //sortarea dupa alfabet
        L.Sort();

        //afisare
        foreach (var val in L)
            Write(val);

        //inversarea
        L.Reverse();

        //afisare
        WriteLine();
        foreach (var val in L)
            Write(val);

    }
}
#endregion