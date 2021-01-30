using System;

namespace calcule
{
    public class Clasa
    {
        public static double metoda(int a, int b)
        {
            inceput:
            try
            {
                return a / b;
            }
            catch(DivideByZeroException e)
            {
                Console.WriteLine("Impartirea la 0 este imposibila, sa efectuat impartirea la 1");
                b = 1;
                goto inceput;
            }
            catch
            {
                Console.WriteLine("Exceptie nepravazuta");
            }
            return a / b;
        }
    }
}
