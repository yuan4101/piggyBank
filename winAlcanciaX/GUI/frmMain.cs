﻿using System;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using winAlcanciaX.Client;

namespace winAlcanciaX.GUI
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }
        #region Control de ventana
        #region Salir
        private void btnSalir_Click(object sender, EventArgs e)
        {
            clsClient.darInstancia().disconnect();
            Application.Exit();
        }
        private void btnSalir_MouseEnter(object sender, EventArgs e)
        {
            btnSalir.Size = new System.Drawing.Size(25, 25);
            btnSalir.Location = new System.Drawing.Point(768, 7);
        }
        private void btnSalir_MouseLeave(object sender, EventArgs e)
        {
            btnSalir.Size = new System.Drawing.Size(20, 20);
            btnSalir.Location = new System.Drawing.Point(768, 12);
        }
        #endregion
        #region Minimizar
        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void btnMinimizar_MouseEnter(object sender, EventArgs e)
        {
            btnMinimizar.Size = new System.Drawing.Size(25, 25);
            btnMinimizar.Location = new System.Drawing.Point(740, 7);
        }
        private void btnMinimizar_MouseLeave(object sender, EventArgs e)
        {
            btnMinimizar.Size = new System.Drawing.Size(20, 20);
            btnMinimizar.Location = new System.Drawing.Point(740, 12);
        }
        #endregion
        #region Arrastar ventana
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void pnlBarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        private void lblTitle_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        #endregion
        #region Formulario
        private void AbrirFormulario<MiForm>() where MiForm : Form, new()
        {
            Form varFormulario;
            varFormulario = pnlForms.Controls.OfType<MiForm>().FirstOrDefault();
            if (varFormulario == null)
            {
                varFormulario = new MiForm();
                varFormulario.TopLevel = false;
                varFormulario.FormBorderStyle = FormBorderStyle.None;
                varFormulario.Dock = DockStyle.Fill;
                varFormulario.BackColor = Color.FromArgb(228, 242, 231);
                pnlForms.Controls.Add(varFormulario);
                pnlForms.Tag = varFormulario;
                varFormulario.Show();
                varFormulario.BringToFront();
                varFormulario.FormClosed += new FormClosedEventHandler(CloseForms);
            }
            else
                varFormulario.BringToFront();
        }
        private void CloseForms(object sender, FormClosedEventArgs e)
        {
            if (Application.OpenForms["frmRegistrarAlcancia"] == null)
                btnRegistrarAlcancia.BackColor = Color.FromArgb(45, 62, 64);

            if (Application.OpenForms["frmRegistrarMoneda"] == null)
                btnRegistrarMoneda.BackColor = Color.FromArgb(45, 62, 64);

            if (Application.OpenForms["frmRegistrarBillete"] == null)
                btnRegistrarBillete.BackColor = Color.FromArgb(45, 62, 64);

            if (Application.OpenForms["frmMostrarAlcancia"] == null)
                btnMostrarDatosAlcancia.BackColor = Color.FromArgb(45, 62, 64);
        }
        #endregion
        #endregion
        #region Menu lateral
        private void btnRegistrarAlcancia_Click(object sender, EventArgs e)
        {
            AbrirFormulario<frmRegistrarAlcancia>();
            btnRegistrarAlcancia.BackColor = Color.FromArgb(81, 96, 90);
        }
        private void btnRegistrarMoneda_Click(object sender, EventArgs e)
        {
            AbrirFormulario<frmRegistrarMoneda>();
            btnRegistrarMoneda.BackColor = Color.FromArgb(81, 96, 90);
        }
        private void btnRegistrarBillete_Click(object sender, EventArgs e)
        {
            AbrirFormulario<frmRegistrarBillete>();
            btnRegistrarBillete.BackColor = Color.FromArgb(81, 96, 90);
        }
        private void btnMostrarDatosAlcancia_Click(object sender, EventArgs e)
        {
            AbrirFormulario<frmMostrarAlcancia>();
            btnRegistrarBillete.BackColor = Color.FromArgb(81, 96, 90);
            clsClient.darInstancia().Send("calcularListaDivisa");
        }
        #endregion
        #region Procedimientos
        private void btnIngresar_Click(object sender, EventArgs e)
        {
            clsClient.darInstancia().connect();

            string varDataSend = "login" + "," + txbUsuario.Text + "," + txbPassword.Text;

            clsClient.darInstancia().Send(varDataSend);
            string varDataReceived = clsClient.darInstancia().Receive();
            if (int.Parse(varDataReceived.Split(',')[0]) == 1)
            {
                lblStatus.Text = varDataReceived.Split(',')[1];
                btnIngresar.Visible = false;
                lblUsuario.Visible = false;
                lblPassword.Visible = false;
                txbUsuario.Visible = false;
                txbPassword.Visible = false;
                btnMostrarDatosAlcancia.Visible = true;
                btnMostrarDatosAlcancia.Enabled = true;
                btnRegistrarAlcancia.Enabled = true;
                btnRegistrarMoneda.Enabled = true;
                btnRegistrarBillete.Enabled = true;
            }
            else
            {
                lblStatus.Text = varDataReceived.Split(',')[1];
                clsClient.darInstancia().disconnect();
            } 
        }
        #endregion


    }
}
