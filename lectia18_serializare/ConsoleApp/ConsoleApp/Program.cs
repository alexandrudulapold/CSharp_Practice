using System;
using static System.Console;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Net;

namespace serializare
{


    //    [Serializable]
    //    class Program1
    //    {
    //        public DateTime[] d = new DateTime[5];
    //        //static void Main(string[] args)
    //        //{
    //        //    Program1 p = new Program1();
    //        //    for (int i = 0; i < p.d.Length; i++)
    //        //    {
    //        //        //d[i] = new DateTime();
    //        //        p.d[i] = DateTime.Today.AddDays(1);
    //        //    }

    //        //    IFormatter formatter = new BinaryFormatter();
    //        //    Stream stream = new FileStream("Exemplu.txt", FileMode.Create, FileAccess.Write);

    //        //    formatter.Serialize(stream, p.d);
    //        //    stream.Close();
    //        //}
    //    }

    //}

    //namespace deserializare
    //{ 
    //    class Program
    //    {
    //        static void Main(string[] args)
    //        {
    //            IFormatter formatter = new BinaryFormatter();
    //            Stream stream = new FileStream("Exemplu.txt", FileMode.Open, FileAccess.Read);
    //            serializare.Program1 obj = (serializare.Program1)formatter.Deserialize(stream);
    //            stream.Close();

    //            List<DateTime> Dates = obj.d.ToList();

    //            Dates.Sort();
    //            Dates.Reverse();

    //            foreach (var data in Dates)
    //                WriteLine(data.Date);

    //            WriteLine(Dates.Max());
    //        }
    //    }
}

namespace Atribute
{
    //[Serializable]
    //class User
    //{
    //    public string nume, parola;
    //    public DateTime ultimaLogare;
    //    [NonSerialized] public int IP;

    //    static void Main()
    //    {
    //        User U = new User();
    //        U.nume = "vasea";
    //        U.parola = "123";
    //        U.ultimaLogare = DateTime.Now;
    //        U.IP = 15;

    //        string hostName = Dns.GetHostName();
    //        string myIP = Dns.GetHostEntry(hostName).AddressList[0].ToString();

    //        IFormatter formatter = new BinaryFormatter();
    //        Stream stream = new FileStream("Exemplu2.txt", FileMode.Create, FileAccess.Write);

    //        formatter.Serialize(stream, U);
    //        stream.Close();
    //    }
    //}

    //class Deserializare
    //{
    //    IFormatter formatter = new BinaryFormatter();
    //    Stream stream = new FileStream("Exemplu2.txt", FileMode.Create, FileAccess.Read);

    //    User DU = (User)formatter.Deserialize(stream);
    //}
}

namespace SerializareLast
{
    [Serializable]
    class Program1
    {
        string nume, limba;
        int populatie;

        static void Main()
        {
            Program1[] P = new Program1[10];

            for (int i = 0; i < P.Length; i++)
            {
                P[i] = new Program1();
                P[i].nume = "name" + i;
                P[i].limba = "l" + i;
                P[i].populatie = i+9572;
            }


        }
    }
}