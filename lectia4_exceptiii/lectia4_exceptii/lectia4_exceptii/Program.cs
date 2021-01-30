using System;

class Program
{
    private static int Salariu = 10000;
    static void Main(string[] args)
    {

        MicsorareSalariu(1500);
        MicsorareSalariu(1990);
        MicsorareSalariu(15000);

    }

    public static void MicsorareSalariu(int valoare)
    {
        Salariu -= valoare;
        try
        {
            if (Salariu < 1200)
                throw new Exception("Salariul nu poate fi mai mic ca 1200");
            else
                Console.WriteLine("Salariul a fost micsorat pana la " + Salariu);
        }
        catch
        {
            Salariu += valoare;
            Console.WriteLine("Salariul nu a fost modificat, si a ramas " + Salariu);
        }
    }

}

