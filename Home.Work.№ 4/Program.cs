using System;

namespace Home.Work.__4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* 1-50 arasi (1 ve 50 de daxil olmaqla [1,50]) butun tek ededleri ile alqoritm yazmaq*/

            for (int i = 0; i < 50; i++)
            {
                if (i % 2 == 0)
                    continue;

            Console.WriteLine(i);
            }
            
        }
    }
}
