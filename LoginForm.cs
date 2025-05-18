using System;
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
    public partial class LoginForm: Form
    {
        public LoginForm()
        {
            InitializeComponent();

            RotunjesteButon(btnLogin, 50);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string numeUtilizator = txtNume.Text;
            string parolaUtilizator = txtParola.Text;

            List<int> noteUtilizator;
            if (UserManager.Autentifica(numeUtilizator, parolaUtilizator, out noteUtilizator))
            {
                MenuForm menuForm = new MenuForm(numeUtilizator, parolaUtilizator);
                menuForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Autentificare esuata! Verifica numele și parola.", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
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

    }
}
