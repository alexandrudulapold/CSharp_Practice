using System;

class Program
{
    public static string[] str = { "abcde", "fghij", "klmnQ", "opqrst", "uvwxyz" };

    static void Main(string[] args)
    {
        try
        {
            for (int i = 0; i < str.Length; i++)
            {
                Console.WriteLine(str[i][4]);
            }
        }
        catch (Exception e)
        {
            Console.WriteLine("An exception occured: " + e.Message);
        }
    }


}

