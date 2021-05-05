using System;

namespace problem2
{
    class Program
    {
        static void Main(string[] args)
        {
            int cijfer = 0;
            int nwTotaal = 1;
            int oudTotaal = 1;
            int som = 0;
            long viermiljoen = 4000000;
            nwTotaal = cijfer + oudTotaal;
            
            while (som < viermiljoen)
            {
                nwTotaal = cijfer + oudTotaal;
                oudTotaal = cijfer;
                cijfer = nwTotaal;
                Console.WriteLine("nwTotaal is: " + nwTotaal);
                if(nwTotaal % 2 == 0)
                {
                    som += nwTotaal;
                    Console.WriteLine("totaal som is: " + som);
                }

            }
        }
    }
}
