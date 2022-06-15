using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using appAlcancia.Dominio;

namespace winAlcanciaX.GUI
{
    public partial class frmRegistrarBillete : Form
    {
        public frmRegistrarBillete()
        {
            InitializeComponent();
        }
        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (clsSistema.darInstancia().buscarBillete(txbSerial.Text) != null)
            {
                lblRegistrarBillete.Text = "Ya existe un billete con ese identificador";
            }
            else
            {
                clsSistema.darInstancia().registrarBillete(null, txbSerial.Text, txbDivisa.Text, int.Parse(txbDenominacion.Text), int.Parse(txbAño.Text), int.Parse(txbMes.Text), int.Parse(txbDia.Text));
                clsBillete varBillete = clsSistema.darInstancia().buscarBillete(txbSerial.Text);
                lblRegistrarBillete.Text = "Se ha creado el billete con los siguientes valores:\n" + varBillete.ToString();
            }
            lblRegistrarBillete.Visible = true;
        }
    }
}
