using System;
using System.Linq;
using System.Reflection;

namespace editare
{
    public class Clasa
    {
        public static void metoda(ref string[] str)
        {
            if(str.Contains("qwe"))
            {
                for(int i=0; i < str.Length; i++)
                {
                    if (str[i] == "qwe") str[i] = "y";
                }

            }
            
        }
    }
}
