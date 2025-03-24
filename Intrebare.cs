using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect_PIU
{
    class Intrebare : Test 
    {
        public void AfiseazaIntrebarea(int index_intrebare)
        {
            string calea_fisier = "Intrebari.txt";

            if (!File.Exists(calea_fisier))
            {
                Console.WriteLine("Fisierul nu exista");
                return;
            }

            string[] linii = File.ReadAllLines(calea_fisier);

            foreach (string linie in linii)
            {
                if (linie.StartsWith(index_intrebare+"."))
                {
                    Console.WriteLine(linie);
                    return;
                }
            }


        }
       
    }
}
