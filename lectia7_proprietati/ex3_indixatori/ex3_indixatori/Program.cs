using System;

namespace ex3_indixatori
{
    class Tranzactii
    {
        private int[] arr = new int[3];

        public int this[int i]
        {
            get { return arr[i]; }
            set { arr[i] = value; }
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Tranzactii T = new Tranzactii();

            T[0] = 100; T[1] = 670; T[2] = 35;

            int max = -1;
            for (int i = 0; i < 3; i++)
                if (max < T[i]) max = T[i];

            Console.WriteLine("tranzactia maxima: " + max);
        }
    }
}
