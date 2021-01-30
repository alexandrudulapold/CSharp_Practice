using System;
using static System.Console;
using System.Diagnostics;


#region ex1
//public class ExampleClass
//{
//    Stopwatch sw;

//    public ExampleClass()
//    {
//        sw = Stopwatch.StartNew();
//        WriteLine("Instantiated object");
//    }

//    public void ShowDuration()
//    {
//        WriteLine("This instance of {0} has been in existence for {1}", this, sw.Elapsed);
//    }

//    ~ExampleClass()
//    {
//        WriteLine("Finalizing object");
//        sw.Stop();
//        WriteLine("This instance of {0} has been in existence for {1}", this, sw.Elapsed);
//    }
//}

//public class test
//{
//    int jora;

//    public void ivan()
//    {
//        WriteLine(jora);
//    }

//    public test(int j)
//    {
//        jora = j;
//        WriteLine("CONSTruIT");
//    }
//    ~test()
//    {
//        WriteLine("ALMEU");
//    }
//}

//public class Demo
//{
//    public static void Main()
//    {
//        test t = new test(5);
//        t.ivan();
//        Details();
//        GC.Collect();
//    }

//    public static void Details()
//    {
//        ExampleClass ex = new ExampleClass();
//        ex.ShowDuration();
//    }
//}
#endregion


namespace Dispose
{
    class FinalizeDemo : IDisposable
    {
        private bool disposed;

        //Constructor si destructor
        public FinalizeDemo() { WriteLine("Constructor"); }
        ~FinalizeDemo() { WriteLine("Destructor"); }

        //Implementarea metodei Dispose
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);  //Blocam executia destructorului pentru ca am utilizat metoda Dispose
            disposed = true;
        }

        private void Dispose(bool disposing)
        {
            if (!disposed)
            {
                if (disposing)
                {
                    //Executati eliberarea resurselor
                    WriteLine("Eliberarea resurselor in dispose");
                }
                disposed = true;
            }
        }
    }

    class Executie
    {       
        static void Main()
        {
            FinalizeDemo demo = new FinalizeDemo();
            demo.Dispose();
        }
    }
}
