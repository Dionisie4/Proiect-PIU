using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect_PIU
{
    public class QuizItem
    {
        public string Intrebare { get; set; }
        public List<string> Raspunsuri { get; set; }
        public string RaspunsCorect { get; set; }
        public string RaspunsUser { get; set; } // Inițial null, se completează după ce utilizatorul alege
    }
}
