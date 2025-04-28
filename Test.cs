using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect_PIU
{
    class Test
    {
        private ManagerTest managerTest;

        public Test(string caleFisier)
        {
            managerTest = new ManagerTest(caleFisier);
        }

        public void StartTest()
        {
            Console.WriteLine("Testul începe! Introdu litera corespunzătoare răspunsului.");

            string intrebare;
            while ((intrebare = managerTest.GetIntrebare()) != null)
            {
                Console.WriteLine(intrebare);

                string raspunsCorect;
                List<string> raspunsuri = managerTest.GetRaspunsuri(out raspunsCorect);

                foreach (var raspuns in raspunsuri)
                {
                    Console.WriteLine(raspuns);
                }

                Console.Write("Alege răspunsul corect (a, b, c, d): ");
                string raspunsUser = Console.ReadLine().Trim().ToLower();

                managerTest.VerificaRaspuns(raspunsUser, raspunsCorect);
            }

            Console.WriteLine($"Test terminat! Ai obținut {managerTest.GetPunctajFinal()}/10.");
        }


    }
}






















        // o sa am o functie de genul ManagerIntrebare(Index) care o sa ia ca parametru index ul si apoi 
        //se va uita pe fisierul intrebari.txt dupa intrebarea cu indexul potrivit
        //si va printa intrebarea, apoi se va uita si pe raspusuri.txt tot dupa index ul grupurilor de raspuns si 
        //si va printa raspunsurile
        //