using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace beakovicPaoloDz27_10_19
{
    class Program
    {
        static void Main(string[] args)
        {
            int ocjena, brojacOcjena = 0, prosjek = 0;
            Console.WriteLine("Upisite ocjene");
            nazad:
            ocjena =Convert.ToInt32( Console.ReadLine());
           
            do {
               
                if (ocjena == 1)
                {
                    Console.WriteLine("Prosjek ocjena je 1 ");
                    goto dalje;
                }
                if(ocjena<1 || ocjena > 5)
                {
                    Console.WriteLine("Kriva ocena. Probaj opet");
                    goto nazad;
                }
                prosjek = prosjek + ocjena;
                brojacOcjena++;
                ocjena = Convert.ToInt32(Console.ReadLine());
            } while (ocjena != 0) ;

            prosjek = prosjek / brojacOcjena;
            Console.WriteLine("Prosjek ocjena je: "+prosjek);

            dalje:

            Console.ReadKey();


        }
    }
}
