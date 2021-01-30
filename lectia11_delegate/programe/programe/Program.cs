using System;
using static System.Console;
using System.Linq;
using System.Collections.Generic;
using Microsoft.VisualBasic;
using System.Threading;

#region ex1_delegate
//public delegate int MyDelegate();

//class Program
//{
//    static void Main(string[] args)
//    {
//        MyDelegate del1 = ClassA.MetodaA;
//        MyDelegate del2 = ClassB.MetodaB;

//        Console.WriteLine((int)del1() + (int)del2());
//    }
//}

//class ClassA
//{
//    public static int MetodaA()
//    {
//        return 15;
//    }
//}

//class ClassB
//{
//    public static int MetodaB()
//    {
//        return 12;
//    }
//}
#endregion

#region ex2_delegate
//namespace Multicasting
//{
//    public delegate string MyDelegate(string str);

//    class Program
//    {
//        static void Main(string[] args)
//        {
//            MyDelegate del1 = Class1.Metoda1;
//            MyDelegate del2 = Class2.Metoda2;
//            MyDelegate del3 = Class3.Metoda3;
//            WriteLine(del1(del2(del3("ParaMpagartgmi qe"))));
//        }
//    }

//    class Class1
//    {
//        public static string Metoda1(string str)
//        {
//            return str.Replace("a", "");
//        }
//    }

//    class Class2
//    {
//        public static string Metoda2(string str)
//        {
//            return str.ToUpper();
//        }
//    }

//    class Class3
//    {
//        public static string Metoda3(string str)
//        {
//            return str + "xyz";
//        }
//    }
//}

#endregion

#region ex3_delegate
//namespace DelegariParametru
//{
//    public delegate void MyDelegate();

//    class Angajat
//    {
//        public static void InteractiuneAngajat(MyDelegate delegare)
//        {
//            delegare();
//        }
//        public static Random rand = new Random();
//        static void Main()
//        {
//            MyDelegate[] del = new MyDelegate[] { Promovare.Rezultat, Concediere.Rezultat, Nimic.Rezultat };
//            int val = rand.Next(1, 101);
//            int metoda;
//            if (val <= 50) metoda = 1;
//            else if (val > 75) metoda = 0;
//            else metoda = 2;
//            Angajat.InteractiuneAngajat(del[metoda]);
//        }
//    }

//    class Promovare
//    {
//        public static void Rezultat()
//        {
//            WriteLine("Ati primit promovare!");
//        }
//    }

//    class Concediere
//    {
//        public static void Rezultat()
//        {
//            WriteLine("Ati primit concediere!");
//        }
//    }

//    class Nimic
//    {
//        public static void Rezultat()
//        {
//            WriteLine("Ati primit nimic!");
//        }
//    }
//}

#endregion

#region ex1_eveniment

//namespace EvenimentPublisherSubscriber
//{
//    public delegate void MyDel(int _suma);

//    public class ContBancar
//    {
//        public event MyDel ProcessCompleted;
//        public int balantaContului;

//        public void InteractiuneCuMijloace(int _suma)
//        {

//        }

//        protected void TranzactieComplete(int _suma)
//        {
//            ProcessCompleted?.Invoke(_suma);
//        }
//    }

//    class Tranzactie
//    {
//        public static void Main()
//        {
//            Publisher publisher = new Publisher();
//            publisher.ProcessCompleted += subscriber_ProcessCompleted;
//            publisher.StartProcess();
//        }

//        public static void Tranz(int _suma)
//        {

//        }
//    }
//}

#endregion

#region ex2_eveniment
//namespace MetodeAnonimeParametru
//{
//    public delegate void Print(double value, string cuvant);

//    class Executie
//    {
//        public static void MetodaAnonima(double val, string cuvant, Print printDel)
//        {
//            val = Math.Pow(val, 3);
//            cuvant += cuvant;
//            printDel(val, cuvant);
//        }

//        static void Main()
//        {
//            MetodaAnonima(35.6, "cuvdub", delegate (double val, string cuvant)
//             {
//                 WriteLine("Metoda anonima, numarul la puterea 3: {0} , cuvantul dublat: {1}", val, cuvant);
//             });
//        }
//    }
//}

#endregion

#region ex1_lambda_expresie
//namespace ExpresiiLambda2
//{
//    class Program
//    {
//        static void Main()
//        {
//            //Declaram o lista de numere int
//            List<int> list1 = new List<int>() { 36, 71, 12, 15, 29 };
//            List<int> list2 = new List<int>() { 18, 27, 17, 9, 34 };
//            List<int> list3 = new List<int>();

//            Write("Lista numerelor1: ");
//            foreach (var i in list1) Write("{0} ", i);
//                WriteLine();

//            Write("Lista numerelor2: ");
//            foreach (var i in list2) Write("{0} ", i);
//                WriteLine();

//            list3 = list1.Concat(list2).ToList();

//            Write("Lista numerelor3: ");
//            foreach (var i in list3) Write("{0} ", i);
//            WriteLine();

//            //Write("Patratul numerelor: ");
//            //foreach (var value in square) Write("{0} ", value);
//            //WriteLine();

//            ////Determinam numerele divizibile cu 3
//            //List<int> divBy3 = numbers.FindAll(x => (x % 3) == 0);
//            //Write("Numerele divizibile cu 3: ");
//            //foreach (var value in divBy3) Write("{0} ", value);
//            //WriteLine();
//        }
//    }
//}

#endregion

#region ex1_eveniment_06_10

//namespace EvenimenteContinuare
//{
//    public class Publisher
//    {
//        public delegate void Delegare();
//        public static event Delegare MyEvent;
//        public void StartMethod()
//        {
//            MyEvent?.Invoke();
//        }

//    }
//    public class Subscriber
//    {
//        string s;
//        public Subscriber(string _s)
//        {
//            s = _s;
//            Publisher.MyEvent += Afisare;
//        }
//        public void Afisare()
//        {
//            WriteLine(s);
//        }

//    }
//    public class Executie
//    {
//        static void Main(string[] args)
//        {
//            Publisher P = new Publisher();
//            Subscriber S1 = new Subscriber("Primu sub");
//            Subscriber S2 = new Subscriber("Dobl sub");
//            Subscriber S3 = new Subscriber("Trip sub");

//            P.StartMethod();
//        }
//    }
//}
#endregion

#region ex2_eveniment_06_10
class Executie
{
    static void Main()
    {
        Asteptare A = new Asteptare();

        A.StartMethod();
    }
}

class Asteptare
{
    public delegate void Delegare();
    public event Delegare Event;

    public void StartMethod()
    {
        Event?.Invoke();
    }

    public Asteptare()
    {
        Event += Operatie;
    }

    public void Operatie()
    {
        WriteLine("Prima operatie, asteptam 0,5 secunde");
        Beep(500, 350);
        Thread.Sleep(500);
        WriteLine("A doua operatie, asteptam 0,5 secunde");
        Beep(800, 350);
        Thread.Sleep(500);
        WriteLine("A treia operatie, asteptam 0,5 secunde");
        Beep(1100, 350);
        Thread.Sleep(500);
        WriteLine("A patra operatie, asteptam 0,5 secunde");
        Beep(1400, 350);
        Thread.Sleep(500);
        WriteLine("A Cincea operatie");
        Beep(2000, 200);
        Beep(2000, 200);
        Beep(2000, 200);
    }
}
#endregion