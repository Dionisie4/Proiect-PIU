﻿using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Proiect_PIU
{
    class Test
    {
        private ManagerTest managerTest;
        public string IntrebareCurenta { get; private set; }
        public List<string> RaspunsuriCurente { get; private set; }
        public string RaspunsCorect { get; private set; }

        public Test(string caleFisier)
        {
            managerTest = new ManagerTest(caleFisier);
        }

        public void SalveazaNota(string numeUtilizator, string parolaUtilizator)
        {
            UserManager.SalveazaNota(numeUtilizator, GetPunctajFinal());
        }

        public bool IncarcaIntrebare()
        {
            IntrebareCurenta = managerTest.GetIntrebare();
            if (IntrebareCurenta == null)
            {
                return false;
            }
            RaspunsuriCurente = managerTest.GetRaspunsuri(out string raspunsCorect);
            RaspunsCorect = raspunsCorect;

            return true;
        }

        public void VerificaRaspuns(string raspunsUser)
        {
            managerTest.VerificaRaspuns(raspunsUser, RaspunsCorect);
            
        }

        public int GetPunctajFinal()
        {
            return managerTest.GetPunctajFinal();
        }


    }
}




















