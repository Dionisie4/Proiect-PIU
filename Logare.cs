using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect_PIU
{
    class Logare
    {
        private static string cale = "Utilizatori.txt";

        public static bool Login(string nume, string parola, out List<int> note)
        {
            note = new List<int>();

            if (!File.Exists(cale))
            {
                return false;
            }

            foreach (var linie in File.ReadLines(cale))
            {
                string[] parti = linie.Split('.');
                if (parti.Length == 3)
                {
                    string numeDinFisier = parti[0];
                    string parolaDinFisier = parti[1];
                    string noteDinFisier = parti[2];

                    if (numeDinFisier == nume && parolaDinFisier == parola)
                    {
                        note = noteDinFisier.Split(',').Select(int.Parse).ToList();
                        return true;
                    }
                }
            }
            return false;
        }

        public static void SalveazaNota(string nume, int notaNoua)
        {
            if (!File.Exists(cale))
            {
                Console.WriteLine("Fișierul cu utilizatori nu există!");
                return;
            }

            var linii = File.ReadAllLines(cale);
            for (int i = 0; i < linii.Length; i++)
            {
                string[] parti = linii[i].Split('.');
                if (parti.Length == 3 && parti[0] == nume)
                {
                    parti[2] = parti[2] + "," + notaNoua.ToString();
                    linii[i] = string.Join(".", parti);
                    break;
                }
            }

            File.WriteAllLines(cale, linii);
        }
    }
}

        

