using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Proiect_PIU;

namespace Proiect_PIU
{
    class Program
    {
        static void Main(string[] args)
        {

            Logare.Login();
            
            AfiseazaSetul(1);
            AfiseazaSetul(2);

        }
            static void AfiseazaSetul(int index_intrebare)
            {
                Intrebare.AfiseazaIntrebarea(index_intrebare);
                Raspunsuri.AfiseazaRaspunsuri(index_intrebare);
            }
    }
}
