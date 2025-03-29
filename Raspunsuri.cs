using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect_PIU
{
    class Raspunsuri
    {
        private static string cale_raspunsuri = "Raspunsuri.txt";
        public static void AfiseazaRaspunsuri(int index_intrebare)
        {

            

            if (!File.Exists(cale_raspunsuri))
            {
                Console.WriteLine("Fisierul cu raspunsuri nu exista");
                return;
            }

        string[] raspunsuri = File.ReadAllLines(cale_raspunsuri);

            bool gasit = false;
            int contor = 0;

        foreach (string linie in raspunsuri)
            {
                if (linie.StartsWith(index_intrebare+"."))
                {
                    gasit = true;
                    continue;
                }

                if (gasit)
                {
                    Console.WriteLine(linie);
                    contor++;

                    if (contor == 4)  
                        break;
                }

            }


        }
  
    
    
    
    }
}
