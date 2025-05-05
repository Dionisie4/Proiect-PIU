using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proiect_PIU
{
    public partial class TestForm: Form
    {
        private Test test;
        private string numeUtilizator;
        private string parolaUtilizator;
        

        public TestForm(string nume, string parola)
        {
            InitializeComponent();
            test = new Test("Test.txt");
            numeUtilizator = nume;
            parolaUtilizator = parola;
            IncarcaIntrebare();
        }
        private void IncarcaIntrebare()
        {
            
            if (!test.IncarcaIntrebare())
            {
                test.SalveazaNota(numeUtilizator, parolaUtilizator); 

                lblIntrebare.Text = $"Test terminat! Ai obtinut {test.GetPunctajFinal()}/10.";
                grpRaspunsuri.Enabled = false;
                btnNext.Enabled = false;
                return;
            }

            lblIntrebare.Text = test.IntrebareCurenta;

            rdbA.Text = test.RaspunsuriCurente[0];
            rdbB.Text = test.RaspunsuriCurente[1];
            rdbC.Text = test.RaspunsuriCurente[2];
            rdbD.Text = test.RaspunsuriCurente[3];

            rdbA.Checked = false;
            rdbB.Checked = false;
            rdbC.Checked = false;
            rdbD.Checked = false;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            string raspunsUser = "";

            if (rdbA.Checked) raspunsUser = "a";
            if (rdbB.Checked) raspunsUser = "b";
            if (rdbC.Checked) raspunsUser = "c";
            if (rdbD.Checked) raspunsUser = "d";

            if (string.IsNullOrEmpty(raspunsUser))
            {
                MessageBox.Show("Te rog selecteaza un raspuns!", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            test.VerificaRaspuns(raspunsUser);
            IncarcaIntrebare();

            

        }
    }
}
