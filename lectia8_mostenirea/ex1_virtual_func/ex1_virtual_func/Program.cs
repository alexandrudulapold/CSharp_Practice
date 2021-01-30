using System;
using static System.Console;

namespace ex1_virtual_func
{
    class Imobil
    {
        protected int suprafata, pret, nrcam;

        public virtual void DateImobil()
        {
            WriteLine("Imobilul dat are suprafata: {0}m^2, {1} camere si pretul: {2}", suprafata, nrcam, pret);
        }
    }

    class Apartament : Imobil
    {
        public string adresa, vanzator, tel;

        public Apartament(int _suprafata, int _pret, int _nrcam, string _adresa, string _vanzator, string _tel)
        {
            suprafata = _suprafata; pret = _pret; nrcam = _nrcam;
            adresa = _adresa; vanzator = _vanzator; tel = _tel;
        }

        public override void DateImobil()
        {
            base.DateImobil();
            Console.WriteLine("adresa: {0}, vanzator: {1}, telefon: {2}", adresa, vanzator, tel);
        }
    }


    class Executie
    {
        static void Main(string[] args)
        {
            Apartament AP = new Apartament(73, 150000, 3, "rai 7/2", "Ion Vasile", "079123324");

            AP.DateImobil();
        }
    }
}
