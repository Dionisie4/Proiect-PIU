using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Windows.Forms;

namespace Proiect_PIU
{
    public partial class ReviewForm : Form
    {
        private List<QuizItem> quizItems;

        private string numeUtilizator;
        private string parolaUtilizator;

        public ReviewForm(List<QuizItem> quizItems, string nume, string parola)
        {
            InitializeComponent();
            this.quizItems = quizItems;
            this.numeUtilizator = nume;
            this.parolaUtilizator = parola;
            this.Load += new System.EventHandler(this.ReviewForm_Load);

            RotunjesteButon(BtnBackcatreMeniu, 30);
            BtnBackcatreMeniu.BackColor = ColorTranslator.FromHtml("#D8BFD8");

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
        private void ReviewForm_Load(object sender, EventArgs e)
        {
            
            listView1.Columns.Clear();
            listView1.Items.Clear();
            listView1.View = View.Details;
            listView1.FullRowSelect = true;

            
            listView1.Columns.Add("Intrebare", 400);
            listView1.Columns.Add("Raspunsul tău", 100);
            listView1.Columns.Add("Raspuns corect", 300);

           
            foreach (var item in quizItems)
            {
                ListViewItem lvItem = new ListViewItem(item.Intrebare);

                lvItem.UseItemStyleForSubItems = false;

                lvItem.SubItems.Add(item.RaspunsUser ?? "");
                lvItem.SubItems.Add(item.RaspunsCorect ?? "");

               
                int userIndex = GetIndexFromLetter(item.RaspunsUser);
                string userRaspunsText = (userIndex != -1 && userIndex < item.Raspunsuri.Count)
                                         ? item.Raspunsuri[userIndex]
                                         : "";

                
                if (!userRaspunsText.Equals(item.RaspunsCorect, StringComparison.InvariantCultureIgnoreCase))
                {
                    lvItem.SubItems[2].BackColor = Color.LightCoral;
                }
                else
                {
                    lvItem.SubItems[2].BackColor = Color.LightGreen;
                }

                    listView1.Items.Add(lvItem);
            }
        }


        
        private int GetIndexFromLetter(string letter)
        {
            if (string.IsNullOrEmpty(letter))
                return -1;
            letter = letter.ToLower();
            if (letter == "a") return 0;
            if (letter == "b") return 1;
            if (letter == "c") return 2;
            if (letter == "d") return 3;
            return -1;
        }

        private void ReviewForm_Load_1(object sender, EventArgs e)
        {

        }

        private void BtnBackcatreMeniu_Click(object sender, EventArgs e)
        {
            MenuForm meniu = new MenuForm(numeUtilizator, parolaUtilizator);
            meniu.Show();
            this.Close();
        }
    }
}