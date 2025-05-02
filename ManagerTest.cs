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
            if (indexCurent >= liniiTest.Count || liniiTest.Count == 0)
            {
                return null;
            }
            string intrebare = liniiTest[indexCurent];
            indexCurent++;
            
            return intrebare;
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
            if (string.Equals(raspunsUser.Trim().ToLower(), raspunsCorect.Trim().ToLower()))
            {
                punctaj++;
            }
        }
        public bool VerificaAutentificare(string numeUtilizator, string parola)
        {
            string caleFisier = "Utilizatori.txt";
            if (!File.Exists(caleFisier)) return false; // Dacă fișierul nu există, login-ul eșuează

            List<string> liniiUtilizatori = File.ReadAllLines(caleFisier).ToList();

            foreach (var linie in liniiUtilizatori)
            {
                string[] date = linie.Split('.');
                if (date.Length >= 2 && date[0] == numeUtilizator && date[1] == parola)
                {
                    return true; // Autentificare validă
                }
            }

            return false; // Utilizatorul nu există
        }

        public void SalveazaNota(string numeUtilizator, string parola)
        {
            string caleFisier = "Utilizatori.txt";
            List<string> liniiUtilizatori = File.Exists(caleFisier) ? File.ReadAllLines(caleFisier).ToList() : new List<string>();
            bool utilizatorGasit = false;

            for (int i = 0; i < liniiUtilizatori.Count; i++)
            {
                string[] date = liniiUtilizatori[i].Split('.');
                if (date.Length >= 2 && date[0] == numeUtilizator && date[1] == parola)
                {
                    date[2] = date.Length > 2 ? date[2] + "," + GetPunctajFinal() : GetPunctajFinal().ToString();

                    liniiUtilizatori[i] = string.Join(".", date);
                    utilizatorGasit = true;
                    break;
                }
            }

            if (!utilizatorGasit) // Dacă utilizatorul nu există, îl adăugăm
            {
                liniiUtilizatori.Add($"{numeUtilizator}.{parola}.{GetPunctajFinal()}");
            }

            File.WriteAllLines(caleFisier, liniiUtilizatori); // Salvăm fișierul actualizat
        }

        public int GetPunctajFinal()
        {
            return punctaj;
        }
    }
}
