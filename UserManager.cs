using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect_PIU
{
    class UserManager
    {
        private static string cale = "Utilizatori.txt";

        public static bool Autentifica(string nume, string parola, out List<int> note)
        {
            note = new List<int>();

            if (!File.Exists(cale))
                return false;

            foreach (var linie in File.ReadLines(cale))
            {
                var parti = linie.Split('.');
                if (parti.Length == 3 && parti[0] == nume && parti[1] == parola)
                {
                    note = parti[2].Split(',').Select(int.Parse).ToList();
                    return true;
                }
            }
            return false;
        }

        public static void SalveazaNota(string nume, int notaNoua)
        {
            if (!File.Exists(cale)) return;

            var linii = File.ReadAllLines(cale);
            for (int i = 0; i < linii.Length; i++)
            {
                var parti = linii[i].Split('.');
                if (parti.Length == 3 && parti[0] == nume)
                {
                    parti[2] += "," + notaNoua;
                    linii[i] = string.Join(".", parti);
                    break;
                }
            }
            File.WriteAllLines(cale, linii);
        }

    }
}
