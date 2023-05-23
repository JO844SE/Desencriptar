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
    public partial class Decrypt : Form
    {
        public Decrypt()
        {
            InitializeComponent();
        }

        bool resultado = false;

        private void btndescript_Click(object sender, EventArgs e)
        {

            try
            {
                Seguridad enc = new Seguridad();
               string res = enc.DecryptKey(txtclave.Text);
                resultado = true;
                if (resultado)
                {
 
                    lblresultado.Text = res;
                    lblresultado.Visible = true;
                    btnlimpiar.Visible = true;

                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(""+ex, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
           
        }

   

        private void Form1_Load(object sender, EventArgs e)
        {
            lblresultado.Visible = false;
            btnlimpiar.Visible = false;
        }

        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            txtclave.Text = "";
            lblresultado.Text = "";
            lblresultado.Visible = false;
            btnlimpiar.Visible = false;
        }
    }
}
