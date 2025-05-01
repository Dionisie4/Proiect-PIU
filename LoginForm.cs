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
            string nume = txtNume.Text.Trim();
            string parola = txtParola.Text.Trim();
            List<int> note;

            if (Logare.Login(nume, parola, out note))
            {
                TestForm testform = new TestForm();
                testform.Show();
                this.Hide();

            }
            else
            {
                lblEroare.Text = "Nume sau parola gresite!";
                lblEroare.ForeColor = Color.Red;
            }    
        }
    }
}
