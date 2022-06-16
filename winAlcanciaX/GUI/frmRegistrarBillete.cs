using System;
using System.Windows.Forms;
using winAlcanciaX.Client;

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
            string varDataSend = "regBillete" + "," + "" + "," + txbSerial.Text + "," + txbDivisa.Text
                + "," + txbDenominacion.Text + "," + txbAño.Text + "," + txbMes.Text + "," + txbDia.Text;

            clsClient.darInstancia().Send(varDataSend);
            lblRegistrarBillete.Text = clsClient.darInstancia().Receive().Split(',')[1];
            lblRegistrarBillete.Visible = true;
        }
    }
}
