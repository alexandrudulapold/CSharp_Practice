using System;
using System.Threading;
using System.Threading.Tasks;


namespace ex4_async
{
    class Program
    {
        static void Main(string[] args)
        {
           
        }


        public static async Task MetodaGeneral()
        {

        }

        public static async Task Cuv(string cuv)
        {
            await Task.Run(() =>
                for (int i = 0; i < cuv.Length; i++)
            {

            }
        });
        }
    }
}
