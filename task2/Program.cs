using System;

namespace task2
{
    internal class Program
    {
        static void Main(string[] args)
        {





            int cem = 0;
            int say = 234;

            while (say > 0)
            {

                int reqem = say % 10;
                cem = cem + reqem;
                say = (say - reqem) / 10;

            }


            Console.WriteLine(cem);







        }
    }
}
