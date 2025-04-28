using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect_PIU
{
    class ManagerTest
    {
        private List<string> liniiTest;
        private int indexCurent = 0;
        private int punctaj = 0;

        public ManagerTest(string caleFisier)
        {
            if (File.Exists(caleFisier))
                liniiTest = File.ReadAllLines(caleFisier).ToList();
            else
                liniiTest = new List<string>();
        }

        public string GetIntrebare()
        {
            if (indexCurent >= liniiTest.Count) return null; // Test terminat

            if (char.IsDigit(liniiTest[indexCurent][0])) // E o întrebare
            {
                string intrebare = liniiTest[indexCurent];
                indexCurent++;
                return intrebare;
            }
            return null;
        }

        public List<string> GetRaspunsuri(out string raspunsCorect)
        {
            List<string> raspunsuri = new List<string>();
            raspunsCorect = "";

            for (int j = indexCurent; j < indexCurent + 4 && j < liniiTest.Count; j++)
            {
                bool esteCorect = liniiTest[j].StartsWith("*");
                string raspunsAfisat = liniiTest[j].Trim('*');

                raspunsuri.Add(raspunsAfisat);
                if (esteCorect)
                    raspunsCorect = raspunsAfisat.Split(')')[0]; // Extragem litera

            }
            indexCurent += 4; // Trecem la următoarea întrebare
            return raspunsuri;
        }

        public void VerificaRaspuns(string raspunsUser, string raspunsCorect)
        {
            if (raspunsUser == raspunsCorect) punctaj++;
        }

        public int GetPunctajFinal()
        {
            return punctaj + 1; // Punct din oficiu
        }
    }
}
