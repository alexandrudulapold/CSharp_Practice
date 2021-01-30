using System;
using static System.Console;
using System.Linq;
using System.Collections.Generic;
using System.Xml.Linq;

namespace ConsoleApp
{
    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        Random rand = new Random();

    //        int[] arr = new int[10];

    //        for (int i = 0; i < arr.Length; i++)
    //            arr[i] = rand.Next(50);

    //        var divizori = from x in arr where x % 3 == 0 select x;

    //        foreach (var x in divizori)
    //            WriteLine(x);
    //    }
    //}
}

namespace LINQ
{
    //class Program
    //{
    //    static void Main()
    //    {
    //        string[] cuvinte = { "salut", "Ion", "Mississippi", "oxigen", "cuvinte" };
    //        var cuvinteLungi = cuvinte.Where(cuvint => cuvint.Length >= 6);

    //        foreach (var cuvint in cuvinteLungi)
    //            Console.WriteLine(cuvint);
    //    }
    //}
}

namespace LINQSelect
{
    //public class Employee
    //{
    //    public int ID { get; set; }
    //    public string Prenume { get; set; }
    //    public string Nume { get; set; }
    //    public int Salariu { get; set; }
    //    public static List<Employee> GetEmployees()
    //    {
    //        List<Employee> employees = new List<Employee>
    //        {
    //            new Employee {ID = 101, Prenume = "Ion",   Nume = "Nicolaescu", Salariu = 5000 },
    //            new Employee {ID = 102, Prenume = "Maria", Nume = "Croitor", Salariu = 6000 },
    //            new Employee {ID = 103, Prenume = "Radu",  Nume = "Moraru", Salariu = 10000 },
    //            new Employee {ID = 104, Prenume = "Daniel",Nume = "Urechean", Salariu = 25000 },
    //            new Employee {ID = 105, Prenume = "Vasile",Nume = "Varzar", Salariu = 7000 },
    //            new Employee {ID = 106, Prenume = "Petru", Nume = "Soimar", Salariu = 8000 }
    //        };
    //        return employees;
    //    }
    //}

    //class Program
    //{
    //    static void Main()
    //    {
    //        List<Employee> basicQuery = 
    //        (from emp in Employee.GetEmployees() where emp.Salariu >= 7000 && emp.Salariu <= 12000 && emp.Nume[0] == 'V' select emp).ToList();

    //        foreach (Employee emp in basicQuery)
    //            Console.WriteLine($"ID: {emp.ID} Nume: {emp.Prenume} {emp.Nume}  Salariu: {emp.Salariu} lei.");
    //    }
    //}
}

namespace LINQOfType
{
    //class Program
    //{
    //    static void Main()
    //    {
    //        List<object> variabile = new List<object>() { "cuvint", "string", 50075, "masina", 'a', 63, "James", true };
    //        //List<string> numere = (from x in variabile.OfType<string>() where x.Length > 5 select x).ToList();
    //        List<string> numere = variabile.OfType<string>().Where(x => x.Length > 5).ToList();

    //        foreach (var numar in numere)
    //            Console.WriteLine(numar);
    //    }
    //}
}

namespace LINQToXML_afisare
{
    //class Program
    //{
    //    static void Main()
    //    {
    //        XElement XMLelement = XElement.Load("tranzactii.xml");
    //        IEnumerable<XElement> tranzactii = XMLelement.Elements();
    //        //List<XElement> employees = XMLelement.Elements().ToList();

    //        foreach (var tranzactie in tranzactii)
    //            WriteLine(tranzactie);
    //    }
    //}
}

namespace LINQToXML_afisare_doar_ValoriElement
{
    //class Program
    //{
    //    static void Main()
    //    {
    //        XElement XMLelement = XElement.Load("tranzactii.xml");
    //        IEnumerable<XElement> tranzactii = XMLelement.Elements();

    //        foreach (var tranzactie in tranzactii)
    //        {
    //            if (Convert.ToInt32(tranzactie.Element("suma").Value) >= 2500 && Convert.ToDateTime(tranzactie.Element("date").Value).Year != 2019)
    //            {
    //                WriteLine("\nID: " + tranzactie.Element("ID").Value);
    //                WriteLine("suma: " + tranzactie.Element("suma").Value);
    //                WriteLine("an: " + Convert.ToDateTime(tranzactie.Element("date").Value).Year);
    //            }
    //        }

    //    }
    //}
}

namespace LINQToXML_atribute
{
    class Program
    {
        static void Main()
        {
            XElement xelement = XElement.Load("tranzactii.xml");

            var enumerare = from x in xelement.Elements("Tranzactie")
                            where (string)x.Attribute("categorie") == "pj"
                            select x;

            WriteLine("Tranzactie cu atribut exemplu:\n");
            foreach (XElement element in enumerare)
                WriteLine(element);
        }
    }
}