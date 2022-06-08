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

namespace winAlcanciaX
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
            if (clsSistema.darInstancia().buscarAlcancia(txbIdentificador.Text) != null)
            {
                lblRegistrarAlcancia.Text = "Ya existe una alcancia con ese identificador";
            }
            else
            {
                List<int> listDenMonedas = new List<int>();
                List<int> listDenBilletes = new List<int>();
                string[] lsDenMonedas = txbDenMonedas.Text.Split(',');
                string[] lsDenBilletes = txbDenBilletes.Text.Split(',');
                lsDenMonedas.ToList();
                lsDenBilletes.ToList();
                foreach (string varItem in lsDenMonedas)
                {
                    listDenMonedas.Add(int.Parse(varItem));
                }
                foreach (string varItem in lsDenBilletes)
                {
                    listDenBilletes.Add(int.Parse(varItem));
                }
                clsSistema.darInstancia().registrarAlcancia(txbIdentificador.Text, txbDivisa.Text, int.Parse(txbCapMonedas.Text), int.Parse(txbCapBilletes.Text), listDenMonedas, listDenBilletes);
                clsAlcancia varAlcancia = clsSistema.darInstancia().buscarAlcancia(txbIdentificador.Text);
                lblRegistrarAlcancia.Text = "Se ha creado la alcancia con los siguientes valores:\n" + varAlcancia.ToString();
            }
            lblRegistrarAlcancia.Visible = true;
        }
    }
}
