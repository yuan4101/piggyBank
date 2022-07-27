using System;
using System.Windows.Forms;
using winAlcanciaX.Client;

namespace winAlcanciaX.GUI
{
    public partial class frmMostrarAlcancia : Form
    {
        string atrIdentificador;
        string atrDivisasDisponibles;
        public frmMostrarAlcancia()
        {
            InitializeComponent();
        }
        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnMostrar_Click(object sender, EventArgs e)
        {
            atrIdentificador = txbIdentificador.Text;
            string varDataSend = "mostrarAlcancia" + "," + atrIdentificador;
            clsClient.darInstancia().Send(varDataSend);
            string[] varReceive = clsClient.darInstancia().Receive().Split(',');

            lblDivisa.Text = "Divisa: " + varReceive[1];
            lblCapMonedas.Text = "Capacidad monedas: " + varReceive[2];
            lblCapBilletes.Text = "Capacidad billetes: " + varReceive[3];
            lblDenoMonedas.Text = "Denominacion monedas: " + varReceive[4];
            lblDenoBilletes.Text = "Denominacion billetes: " + varReceive[5];
            lblSaldoMonedas.Text = "Saldo total monedas: " + varReceive[6];
            lblSaldoBilletes.Text = "Saldo total billetes: " + varReceive[7];
            lblSaldoTotal.Text = "Saldo total: " + varReceive[8];

            clsClient.darInstancia().Send("calcularListaDivisa");
            atrDivisasDisponibles = clsClient.darInstancia().Receive();

            btnMostrarDivisaD.Enabled = true;
            cbxDivisas.Enabled = true;
            cbxDivisas.Items.AddRange(atrDivisasDisponibles.Split(','));
        }
        private void btnMostrarDivisaD_Click(object sender, EventArgs e)
        {
            string varDataSend = "mostrarSaldoDifDivisa" + "," + atrIdentificador + "," + cbxDivisas.Text;
            clsClient.darInstancia().Send(varDataSend);
            string[] varReceive = clsClient.darInstancia().Receive().Split('.');
            label11.Text = "Saldo total monedas: " + varReceive[1];
            label8.Text = "Saldo total billetes: " + varReceive[2];
            label7.Text = "Saldo total: " + varReceive[3];
        }
    }
}
