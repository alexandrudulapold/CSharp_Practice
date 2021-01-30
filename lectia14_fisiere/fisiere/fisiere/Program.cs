using System;
using static System.Console;
using System.IO;

namespace fisiere1
{
    //    class Program
    //    {
    //        static void Main(string[] args)
    //        {
    //            string denumire;
    //            WriteLine("Introdu denumire txt: ");
    //            denumire = Console.ReadLine();
    //            string path = "D:\\z\\"+ denumire + ".txt";
    //            FileStream fs = new FileStream(path, FileMode.Create);
    //            fs.Close();
    //            WriteLine(path);
    //        }
    //    }
}

namespace StreamReaderExample
{
    //class StreamReaderClass
    //{
    //    static void Main(string[] args)
    //    {
    //        string path = "D:\\z\\cartinca.png";

    //        StreamReader sr = File.OpenText(path);
    //        {
    //            string s = "";

    //            while ((s = sr.ReadLine()) != null)
    //                WriteLine(s);
    //        }
    //    }
    //}
}

namespace StreamWriterExample
{
    //class StreamWriterClass
    //{
    //    static void Main()
    //    {
    //        string path = "D:\\z\\Exempla.txt";

    //        //using (StreamWriter sr = File.AppendText(path))
    //        using (StreamWriter sr = File.CreateText(path))
    //        {
    //            sr.WriteLine("\nStream Writer");
    //            sr.Close();
    //        }
    //        WriteLine(File.ReadAllText(path));
    //    }
    //}
}

namespace DirectoryExample
{
    class CreateFolder
    {
        static void Main()
        {
            string cale = "D:\\z\\newFolder";
            if (!Directory.Exists(cale))
            {
                Directory.CreateDirectory(cale);             
                WriteLine("Fisier creat cu succes");
            }
            else
                WriteLine("Fisierul deja exista1");

            cale += "\\newfolder2";
            if (!Directory.Exists(cale))
            {
                Directory.CreateDirectory(cale);
                WriteLine("Fisier creat cu succes");
            }
            else
                WriteLine("Fisierul deja exista2");

            cale += "\\newFolder3";
            if (!Directory.Exists(cale))
            {
                Directory.CreateDirectory(cale);
                WriteLine("Fisier creat cu succes");
            }
            else
                WriteLine("Fisierul deja exista3");
        }
    }
}
