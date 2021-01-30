using System;
using static System.Console;

class Persoana
{
    private string nume, prenume, cod;

    public string Nume
    {
        get { return nume; }
        set { nume = value; }
    }
    public string Prenume
    {
        get { return prenume; }
        set { prenume = value; }
    }
    public string Cod
    {
        get { return cod; }
        set { cod = value; }
    }
}

class Program
{
    static void Main(string[] args)
    {
        Persoana P1 = new Persoana();
        Persoana P2 = new Persoana();
        Persoana P3 = new Persoana();

        P1.Prenume = "Vasea";
        P1.Nume = "Vaseavici";
        P1.Cod = "12345";

        P2.Prenume = "Ivan";
        P2.Nume = "Ivanici";
        P2.Cod = "12534";

        P3.Prenume = "Alexei";
        P3.Nume = "Alexeici";
        P3.Cod = "21435";

        ForegroundColor = ConsoleColor.Red;
        WriteLine(P1.Prenume + " " + P1.Nume + " " + P1.Cod);
        ForegroundColor = ConsoleColor.Yellow;
        WriteLine(P2.Prenume + " " + P2.Nume + " " + P2.Cod);
        ForegroundColor = ConsoleColor.Blue;
        WriteLine(P3.Prenume + " " + P3.Nume + " " + P3.Cod);
        ForegroundColor = ConsoleColor.White;
    }
}