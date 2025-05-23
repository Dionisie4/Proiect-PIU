using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Proiect_PIU
{
    public class QuizTest
    {
        public List<QuizItem> QuizItems { get; private set; }
        public int CurrentIndex { get; set; } = 0;

        
        public QuizTest(string caleFisier)
        {
            LoadQuizItems(caleFisier);
        }

        private void LoadQuizItems(string caleFisier)
        {
            QuizItems = new List<QuizItem>();
            if (!File.Exists(caleFisier))
            {
                throw new FileNotFoundException($"Fisierul {caleFisier} nu a fost gasit!");
            }

            var linii = File.ReadAllLines(caleFisier).ToList();
            
            for (int i = 0; i < linii.Count; i += 5)
            {
                if (i + 4 >= linii.Count)
                    break; 

                QuizItem item = new QuizItem();
                item.Intrebare = linii[i].Trim();
                item.Raspunsuri = new List<string>();

              
                for (int j = 1; j <= 4; j++)
                {
                    string raspuns = linii[i + j].Trim();
                    bool esteCorect = raspuns.StartsWith("*");
                    if (esteCorect)
                    {
                        
                        raspuns = raspuns.TrimStart('*').Trim();
                        item.RaspunsCorect = raspuns;
                    }
                    item.Raspunsuri.Add(raspuns);
                }
                QuizItems.Add(item);
            }
        }

        public QuizItem GetCurrentQuizItem()
        {
            if (CurrentIndex < QuizItems.Count)
                return QuizItems[CurrentIndex];
            return null;
        }

        public bool HasNext() => CurrentIndex < QuizItems.Count - 1;
        public bool HasPrevious() => CurrentIndex > 0;
    }
}
