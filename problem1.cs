using System;

namespace MultiplesOf3and5
{
    class Program
    {
        static void Main(string[] args)
        {
            int totaal = 0;
            for (int i = 1; i < 334; i++)
            {
                totaal += (i * 3);
                Console.WriteLine(i + " " + totaal + " " + i * 3);
            }
          
            for (int i = 1; i < 200; i++)
            {
                if ((i * 5) % 3 != 0)
                {
                    totaal += (i * 5);
                }
                Console.WriteLine(i + " " + totaal + " " + i * 5);
            }
            
            Console.WriteLine(totaal);
        }

    }
}
