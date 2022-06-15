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
    public partial class frmRegistrarMoneda : Form
    {
        public frmRegistrarMoneda()
        {
            InitializeComponent();
        }
        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (clsSistema.darInstancia().buscarMoneda(txbIdentificador.Text) != null)
            {
                lblRegistrarMoneda.Text = "Ya existe una moneda con ese identificador";
            }
            else
            {
                clsSistema.darInstancia().registrarMoneda(null, txbIdentificador.Text, txbDivisa.Text, int.Parse(txbDenominacion.Text), int.Parse(txbAño.Text));
                clsMoneda varMoneda = clsSistema.darInstancia().buscarMoneda(txbIdentificador.Text);
                lblRegistrarMoneda.Text = "Se ha creado la moneda con los siguientes valores:\n" + varMoneda.ToString();
            }
            lblRegistrarMoneda.Visible = true;
        }
    }
}
