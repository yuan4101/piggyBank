using System;
using System.Windows.Forms;
using winAlcanciaX.Client;

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
            string varDataSend = "regMoneda" + "," + "" + "," + txbIdentificador.Text + "," + txbDivisa.Text
                + "," + txbDenominacion.Text + "," + txbAño.Text;

            clsClient.darInstancia().Send(varDataSend);
            lblRegistrarMoneda.Text = clsClient.darInstancia().Receive().Split(',')[1];
            lblRegistrarMoneda.Visible = true;
        }
    }
}
