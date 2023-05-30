using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Desencriptar
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

       

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Encriptar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Desencriptar f = new Desencriptar();
            f.Show();
            f.FormClosing += Frm_closing;//cierra inicio y muestra el formulario de login
        }

        private void Frm_closing(object sender, FormClosingEventArgs e)
        {
            this.Show();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Decrypt f = new Decrypt();
            f.Show();
            f.FormClosing += Frm_closing;//cierra inicio y muestra el formulario de login
        }
    }
}
