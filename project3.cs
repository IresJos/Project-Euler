using System;

namespace project3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Voer het nummer in: ");
            //Console.ReadLine();
            long eindTotaal = 600851475143;
            for (int i = 2; i < eindTotaal; i++)
            {
                if (is_priemgetal(i) == 1)
                {
                    if ((eindTotaal % i) == 0)
                    {
                        eindTotaal /= i;
                        Console.WriteLine(eindTotaal + " " + i);
                    }
                }
            }
        }
        static int is_priemgetal(int getal)
        {
            for (int i = 2; i < getal; i++)
            {
                if (getal % i == 0)
                {
                    // geen priemgetal
                    return 0;
                }
            }
            // als alles wordt doorlopen zonder te stoppen --> priemgetal
            return 1;
        }

    }
}
