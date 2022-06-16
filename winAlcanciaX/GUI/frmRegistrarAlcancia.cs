using System;
using System.Windows.Forms;
using winAlcanciaX.Client;

namespace winAlcanciaX.GUI
{
    public partial class frmRegistrarAlcancia : Form
    {
        public frmRegistrarAlcancia()
        {
            InitializeComponent();
        }
        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            string varDataSend = "regAlcancia" + "," + txbIdentificador.Text + "," + txbDivisa.Text
                + "," + txbCapMonedas.Text + "," + txbCapBilletes.Text + ","
                + txbDenMonedas.Text + "," + txbDenBilletes.Text;

            clsClient.darInstancia().Send(varDataSend);
            lblRegistrarAlcancia.Text = clsClient.darInstancia().Receive().Split(',')[1];
            lblRegistrarAlcancia.Visible = true;
        }
    }
}
