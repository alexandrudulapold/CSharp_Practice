using System;
using static System.Console;

#region ex1_struct
//namespace StructExemplu
//{
//    class Exemplu
//    {
//        private static void Main()
//        {
//            Angajat ang1 = new Angajat(new int[10], new string[10], new string[10], new int[10]);
//            for (int i = 0; i < 10; i++)
//            {
//                ang1.id[i] = i;
//                ang1.nume[i] = "Vaseok" + Convert.ToString(i);
//                ang1.prenume[i] = "Alexceici" + Convert.ToString(i);
//                ang1.salariu[i] = 7000 + i * 100;
//                WriteLine("Angajatul {0}, {1} {2} are salariul {3} lei.", ang1.id[i], ang1.nume[i], ang1.prenume[i], ang1.salariu[i]);
//            }


//        }
//    }
//    struct Angajat
//    {
//        public int[] id;
//        public string[] nume;
//        public string[] prenume;
//        public int[] salariu;

//        public Angajat(int[] _id, string[] _nume, string[] _prenume, int[] _salariu)
//        {
//            id = _id;
//            nume = _nume;
//            prenume = _prenume;
//            salariu = _salariu;
//        }
//    }
//}
#endregion

#region ex1_enum
//class Exemplu
//{
//    private static void Main()
//    {
//        Masina[] CAR = new Masina[5];
//        CAR[0] = new Masina("BMW", 40000, 2018, (Masina.StareMasina)0);
//        CAR[1] = new Masina("VAZ", 1500, 1999, (Masina.StareMasina)1);
//        CAR[2] = new Masina("CADILLAC", 75000, 2016, (Masina.StareMasina)0);
//        CAR[3] = new Masina("FERRARI", 20000, 1996, (Masina.StareMasina)3);
//        CAR[4] = new Masina("FORD", 15000, 1979, (Masina.StareMasina)2);

//        for (int i = 0; i < CAR.Length; i++)
//        {
//            int procent;
//            switch ((int)CAR[i].stareCurenta)
//            {
//                case 0: procent = 0; break;
//                case 1: procent = 0; break;
//                case 2: procent = 0; break;
//                case 3: procent = 0; break;
//                default: procent = 0; break;
//            }
//            WriteLine("Masina {0} din anul {1} costa {2} dar ea este {3}, de asta costa {4}", CAR[i].denumire, CAR[i].pret, CAR[i].anProd, CAR[i].stareCurenta, (CAR[i].pret - (CAR[i].pret * procent)));
//        }
//    }
//}

//class Masina
//{
//    public string denumire;
//    public int pret;
//    public int anProd;
//    public StareMasina stareCurenta;

//    public Masina(string d, int p, int a, StareMasina s)
//    {
//        denumire = d; pret = p;
//        anProd = a; stareCurenta = s;
//    }

//    public enum StareMasina
//    {
//        Noua,
//        Uzata,
//        Veche,
//        Defectata
//    }
//}

#endregion

#region ex2_enum
class GetNames
{
    enum Obiecte
    {
        Televizor = 82,
        Calculator = 102,
        Masa = 15,
        Scaun = 45,
        Telefon = 10,
        Usa = 30
    };

    public static void Main()
    {
        int[] arr = (int[])Enum.GetValues(typeof(Obiecte));
        string[] str = Enum.GetNames(typeof(Obiecte));

        int foreachi1 = 0;
        WriteLine("Avem obiectele:");
        foreach (string s in str)
        {
            WriteLine(s + ", cantareste " + arr[foreachi1] + "kg");
            foreachi1++;
        }
    }
}

#endregion