using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace Proiect_PIU
{
    public partial class MenuForm: Form
    {
        private string numeUtilizator;
        private string parolaUtilizator;

        public MenuForm(string nume, string parola)
        {
            InitializeComponent();
            numeUtilizator = nume;
            parolaUtilizator = parola;
            this.Load += MenuForm_Load;
            RotunjesteButon(btnAfisareNote, 50);
            RotunjesteButon(btnCautaUtilizator, 50);
            RotunjesteButon(btnIncepereTest, 50);
        }

        private void MenuForm_Load(object sender, EventArgs e)
        {
            
            cmbTeste.Items.Add("Test.txt");
            cmbTeste.Items.Add("Biologie.txt");
            cmbTeste.Items.Add("Chimie.txt");

            
        }

        private void btnIncepereTest_Click(object sender, EventArgs e)
        {
            if (cmbTeste.SelectedItem == null)
            {
                MessageBox.Show("Selecteaza un test din lista.", "Atentie", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            
            string fisierTest = cmbTeste.SelectedItem.ToString();

            
            if (!File.Exists(fisierTest))
            {
                MessageBox.Show("Fisierul de test nu exista.", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            
            TestForm testForm = new TestForm(numeUtilizator, parolaUtilizator, fisierTest);
            testForm.Show();
            this.Hide();
        }

        private void btnAfisareNote_Click(object sender, EventArgs e)
        {
            List<int> note;
            bool autentificat = UserManager.Autentifica(numeUtilizator, parolaUtilizator, out note);
            if (autentificat)
            {
                string afisareNote = $"Notele tale sunt: {string.Join(", ", note)}";
                MessageBox.Show(afisareNote, "Note Utilizator", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Utilizatorul nu a putut fi autentificat pentru afisarea notelor.",
                                "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void btnCautaUtilizator_Click(object sender, EventArgs e)
        {
            string cautare = txtCautareUtilizator.Text.Trim();
            if (string.IsNullOrEmpty(cautare))
            {
                MessageBox.Show("Introdu un text pentru cautare.", "Atentie", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string caleFisier = "Utilizatori.txt";
            if (!File.Exists(caleFisier))
            {
                MessageBox.Show("Fisierul cu utilizatori nu a fost gasit.", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            List<string> rezultate = new List<string>();
            foreach (var linie in File.ReadLines(caleFisier))
            {
                
                string[] parti = linie.Split('.');
                if (parti.Length == 3 && parti[0].IndexOf(cautare, StringComparison.OrdinalIgnoreCase) >= 0)
                {
                    rezultate.Add($"{parti[0]} - Note: {parti[2]}"); 
                }
            }

           
            if (rezultate.Count > 0)
            {
                string mesaj = string.Join(Environment.NewLine, rezultate);
                MessageBox.Show(mesaj, "Utilizatori gasiți", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Nu s-au gasit utilizatori care să corespunda criteriilor.", "Rezultate", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
