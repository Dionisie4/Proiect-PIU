using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proiect_PIU
{
    public partial class TestForm: Form
    {
        private QuizTest quizTest;
        private string numeUtilizator;
        private string parolaUtilizator;

        public TestForm(string nume, string parola, string fisierTest)
        {
            InitializeComponent();
            numeUtilizator = nume;
            parolaUtilizator = parola;
            quizTest = new QuizTest(fisierTest);

            
            RotunjesteButon(btnNext, 25);
            RotunjesteButon(btnBack, 25);
            RotunjesteButon(btnSubmit, 20);

            IncarcaIntrebare();
        }



        private void IncarcaIntrebare()
        {
            QuizItem item = quizTest.GetCurrentQuizItem();
            if (item == null)
            {
                MessageBox.Show("Nu s-au putut încărca întrebările!", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            lblIntrebare.Text = item.Intrebare;
            rdbA.Text = item.Raspunsuri[0];
            rdbB.Text = item.Raspunsuri[1];
            rdbC.Text = item.Raspunsuri[2];
            rdbD.Text = item.Raspunsuri[3];

            
            if (!string.IsNullOrEmpty(item.RaspunsUser))
            {
                string raspuns = item.RaspunsUser.ToLower();
                rdbA.Checked = raspuns == "a";
                rdbB.Checked = raspuns == "b";
                rdbC.Checked = raspuns == "c";
                rdbD.Checked = raspuns == "d";
            }
            else
            {
                rdbA.Checked = rdbB.Checked = rdbC.Checked = rdbD.Checked = false;
            }

            btnBack.Enabled = quizTest.HasPrevious();
            
            btnSubmit.Enabled = quizTest.QuizItems.All(q => !string.IsNullOrEmpty(q.RaspunsUser));
        }

        
        private void btnNext_Click(object sender, EventArgs e)
        {
            string raspunsUser = string.Empty;

            if (rdbA.Checked) raspunsUser = "a";
            if (rdbB.Checked) raspunsUser = "b";
            if (rdbC.Checked) raspunsUser = "c";
            if (rdbD.Checked) raspunsUser = "d";

            if (string.IsNullOrEmpty(raspunsUser))
            {
                MessageBox.Show("Selectează un raspuns!", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            
            QuizItem currentItem = quizTest.GetCurrentQuizItem();
            currentItem.RaspunsUser = raspunsUser;

            btnSubmit.Enabled = quizTest.QuizItems.All(q => !string.IsNullOrEmpty(q.RaspunsUser));

            if (quizTest.HasNext())
            {
                quizTest.CurrentIndex++;
                IncarcaIntrebare();
            }
            else
            {
                MessageBox.Show("Aceasta este ultima intrebare!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void RotunjesteButon(Button buton, int raza)
        {
            GraphicsPath path = new GraphicsPath();
            path.AddArc(0, 0, raza, raza, 180, 90);
            path.AddArc(buton.Width - raza, 0, raza, raza, 270, 90);
            path.AddArc(buton.Width - raza, buton.Height - raza, raza, raza, 0, 90);
            path.AddArc(0, buton.Height - raza, raza, raza, 90, 90);
            path.CloseFigure();

            buton.Region = new Region(path);
            buton.FlatStyle = FlatStyle.Flat;
            buton.FlatAppearance.BorderSize = 0;
        }

        private void TestForm_Load(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            if (quizTest.HasPrevious())
            {
                quizTest.CurrentIndex--;
                IncarcaIntrebare();
            }
            else
            {
                MessageBox.Show("Acum esti la prima intrebare!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            
            if (!quizTest.QuizItems.All(q => !string.IsNullOrEmpty(q.RaspunsUser)))
            {
                MessageBox.Show("Completeaza toate intrebarile inainte de submit!", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int punctaj = 0;
            foreach (var item in quizTest.QuizItems)
            {
                int indexUser = GetIndexFromLetter(item.RaspunsUser);
                
                if (indexUser != -1 && item.Raspunsuri[indexUser].Equals(item.RaspunsCorect, StringComparison.InvariantCultureIgnoreCase))
                {
                    punctaj++;
                }
            }

            MessageBox.Show($"Test terminat! Scor: {punctaj} din {quizTest.QuizItems.Count}", "Rezultate", MessageBoxButtons.OK, MessageBoxIcon.Information);

            UserManager.SalveazaNota(numeUtilizator, punctaj);

            ReviewForm review = new ReviewForm(quizTest.QuizItems);
            review.Show();
            this.Close();
        }

        private int GetIndexFromLetter(string letter)
        {
            if (string.IsNullOrEmpty(letter)) return -1;
            letter = letter.ToLower();
            if (letter == "a") return 0;
            if (letter == "b") return 1;
            if (letter == "c") return 2;
            if (letter == "d") return 3;
            return -1;
        }




    }
}

