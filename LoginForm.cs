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
    public partial class LoginForm: Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string numeUtilizator = txtNume.Text;
            string parolaUtilizator = txtParola.Text;

            ManagerTest managerTest = new ManagerTest("Utilizatori.txt");

            if (managerTest.VerificaAutentificare(numeUtilizator, parolaUtilizator))
            {
                
                TestForm testForm = new TestForm(numeUtilizator, parolaUtilizator); // Transmitem utilizatorul corect
                testForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Autentificare eșuată! Verifică numele și parola.", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
