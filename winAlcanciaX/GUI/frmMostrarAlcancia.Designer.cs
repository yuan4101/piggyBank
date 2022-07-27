namespace winAlcanciaX.GUI
{
    partial class frmMostrarAlcancia
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblIdentificador = new System.Windows.Forms.Label();
            this.lblMostrarAlcancia = new System.Windows.Forms.Label();
            this.lblSubtitulo = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnFinalizar = new System.Windows.Forms.Button();
            this.btnMostrar = new System.Windows.Forms.Button();
            this.txbIdentificador = new System.Windows.Forms.TextBox();
            this.lblDivisa = new System.Windows.Forms.Label();
            this.lblCapMonedas = new System.Windows.Forms.Label();
            this.lblCapBilletes = new System.Windows.Forms.Label();
            this.lblDenoMonedas = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btnMostrarDivisaD = new System.Windows.Forms.Button();
            this.lblDenoBilletes = new System.Windows.Forms.Label();
            this.lblSaldoMonedas = new System.Windows.Forms.Label();
            this.lblSaldoBilletes = new System.Windows.Forms.Label();
            this.lblSaldoTotal = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.cbxDivisas = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lblIdentificador
            // 
            this.lblIdentificador.AutoSize = true;
            this.lblIdentificador.Font = new System.Drawing.Font("Cascadia Mono", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdentificador.Location = new System.Drawing.Point(25, 88);
            this.lblIdentificador.Name = "lblIdentificador";
            this.lblIdentificador.Size = new System.Drawing.Size(120, 17);
            this.lblIdentificador.TabIndex = 87;
            this.lblIdentificador.Text = "Identificador:";
            // 
            // lblMostrarAlcancia
            // 
            this.lblMostrarAlcancia.Font = new System.Drawing.Font("Cascadia Mono", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMostrarAlcancia.Location = new System.Drawing.Point(12, 440);
            this.lblMostrarAlcancia.Name = "lblMostrarAlcancia";
            this.lblMostrarAlcancia.Size = new System.Drawing.Size(610, 70);
            this.lblMostrarAlcancia.TabIndex = 85;
            this.lblMostrarAlcancia.Visible = false;
            // 
            // lblSubtitulo
            // 
            this.lblSubtitulo.AutoSize = true;
            this.lblSubtitulo.Font = new System.Drawing.Font("Cascadia Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubtitulo.Location = new System.Drawing.Point(24, 61);
            this.lblSubtitulo.Name = "lblSubtitulo";
            this.lblSubtitulo.Size = new System.Drawing.Size(352, 21);
            this.lblSubtitulo.TabIndex = 84;
            this.lblSubtitulo.Text = "Digite el identificador de la alcancia";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Cascadia Mono", 14F);
            this.lblTitulo.Location = new System.Drawing.Point(12, 14);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(199, 25);
            this.lblTitulo.TabIndex = 83;
            this.lblTitulo.Text = "Datos de alcancia";
            // 
            // btnFinalizar
            // 
            this.btnFinalizar.Font = new System.Drawing.Font("Cascadia Mono", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinalizar.Location = new System.Drawing.Point(522, 10);
            this.btnFinalizar.Name = "btnFinalizar";
            this.btnFinalizar.Size = new System.Drawing.Size(100, 30);
            this.btnFinalizar.TabIndex = 81;
            this.btnFinalizar.Text = "Finalizar";
            this.btnFinalizar.UseVisualStyleBackColor = true;
            this.btnFinalizar.Click += new System.EventHandler(this.btnFinalizar_Click);
            // 
            // btnMostrar
            // 
            this.btnMostrar.Font = new System.Drawing.Font("Cascadia Mono", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMostrar.Location = new System.Drawing.Point(143, 111);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(100, 30);
            this.btnMostrar.TabIndex = 82;
            this.btnMostrar.Text = "Mostrar";
            this.btnMostrar.UseVisualStyleBackColor = true;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // txbIdentificador
            // 
            this.txbIdentificador.Font = new System.Drawing.Font("Cascadia Mono", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbIdentificador.Location = new System.Drawing.Point(151, 85);
            this.txbIdentificador.Name = "txbIdentificador";
            this.txbIdentificador.Size = new System.Drawing.Size(225, 20);
            this.txbIdentificador.TabIndex = 91;
            // 
            // lblDivisa
            // 
            this.lblDivisa.AutoSize = true;
            this.lblDivisa.Font = new System.Drawing.Font("Cascadia Mono", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDivisa.Location = new System.Drawing.Point(25, 147);
            this.lblDivisa.Name = "lblDivisa";
            this.lblDivisa.Size = new System.Drawing.Size(64, 17);
            this.lblDivisa.TabIndex = 92;
            this.lblDivisa.Text = "Divisa:";
            // 
            // lblCapMonedas
            // 
            this.lblCapMonedas.AutoSize = true;
            this.lblCapMonedas.Font = new System.Drawing.Font("Cascadia Mono", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCapMonedas.Location = new System.Drawing.Point(25, 164);
            this.lblCapMonedas.Name = "lblCapMonedas";
            this.lblCapMonedas.Size = new System.Drawing.Size(152, 17);
            this.lblCapMonedas.TabIndex = 93;
            this.lblCapMonedas.Text = "Capacidad monedas:";
            // 
            // lblCapBilletes
            // 
            this.lblCapBilletes.AutoSize = true;
            this.lblCapBilletes.Font = new System.Drawing.Font("Cascadia Mono", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCapBilletes.Location = new System.Drawing.Point(25, 181);
            this.lblCapBilletes.Name = "lblCapBilletes";
            this.lblCapBilletes.Size = new System.Drawing.Size(160, 17);
            this.lblCapBilletes.TabIndex = 94;
            this.lblCapBilletes.Text = "Capacidad billetes:";
            // 
            // lblDenoMonedas
            // 
            this.lblDenoMonedas.AutoSize = true;
            this.lblDenoMonedas.Font = new System.Drawing.Font("Cascadia Mono", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDenoMonedas.Location = new System.Drawing.Point(25, 198);
            this.lblDenoMonedas.Name = "lblDenoMonedas";
            this.lblDenoMonedas.Size = new System.Drawing.Size(176, 17);
            this.lblDenoMonedas.TabIndex = 95;
            this.lblDenoMonedas.Text = "Denominacion monedas:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Cascadia Mono", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(25, 321);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(64, 17);
            this.label9.TabIndex = 98;
            this.label9.Text = "Divisa:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Cascadia Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(24, 294);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(415, 21);
            this.label10.TabIndex = 97;
            this.label10.Text = "Mostrar saldo de alcancia en diferente divisa";
            // 
            // btnMostrarDivisaD
            // 
            this.btnMostrarDivisaD.Enabled = false;
            this.btnMostrarDivisaD.Font = new System.Drawing.Font("Cascadia Mono", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMostrarDivisaD.Location = new System.Drawing.Point(143, 344);
            this.btnMostrarDivisaD.Name = "btnMostrarDivisaD";
            this.btnMostrarDivisaD.Size = new System.Drawing.Size(100, 30);
            this.btnMostrarDivisaD.TabIndex = 96;
            this.btnMostrarDivisaD.Text = "Mostrar";
            this.btnMostrarDivisaD.UseVisualStyleBackColor = true;
            this.btnMostrarDivisaD.Click += new System.EventHandler(this.btnMostrarDivisaD_Click);
            // 
            // lblDenoBilletes
            // 
            this.lblDenoBilletes.AutoSize = true;
            this.lblDenoBilletes.Font = new System.Drawing.Font("Cascadia Mono", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDenoBilletes.Location = new System.Drawing.Point(25, 215);
            this.lblDenoBilletes.Name = "lblDenoBilletes";
            this.lblDenoBilletes.Size = new System.Drawing.Size(184, 17);
            this.lblDenoBilletes.TabIndex = 104;
            this.lblDenoBilletes.Text = "Denominacion billetes:";
            // 
            // lblSaldoMonedas
            // 
            this.lblSaldoMonedas.AutoSize = true;
            this.lblSaldoMonedas.Font = new System.Drawing.Font("Cascadia Mono", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSaldoMonedas.Location = new System.Drawing.Point(25, 232);
            this.lblSaldoMonedas.Name = "lblSaldoMonedas";
            this.lblSaldoMonedas.Size = new System.Drawing.Size(168, 17);
            this.lblSaldoMonedas.TabIndex = 105;
            this.lblSaldoMonedas.Text = "Saldo total monedas:";
            // 
            // lblSaldoBilletes
            // 
            this.lblSaldoBilletes.AutoSize = true;
            this.lblSaldoBilletes.Font = new System.Drawing.Font("Cascadia Mono", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSaldoBilletes.Location = new System.Drawing.Point(25, 249);
            this.lblSaldoBilletes.Name = "lblSaldoBilletes";
            this.lblSaldoBilletes.Size = new System.Drawing.Size(176, 17);
            this.lblSaldoBilletes.TabIndex = 106;
            this.lblSaldoBilletes.Text = "Saldo total billetes:";
            // 
            // lblSaldoTotal
            // 
            this.lblSaldoTotal.AutoSize = true;
            this.lblSaldoTotal.Font = new System.Drawing.Font("Cascadia Mono", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSaldoTotal.Location = new System.Drawing.Point(25, 265);
            this.lblSaldoTotal.Name = "lblSaldoTotal";
            this.lblSaldoTotal.Size = new System.Drawing.Size(104, 17);
            this.lblSaldoTotal.TabIndex = 107;
            this.lblSaldoTotal.Text = "Saldo total:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Cascadia Mono", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(25, 414);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(104, 17);
            this.label7.TabIndex = 110;
            this.label7.Text = "Saldo total:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Cascadia Mono", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(25, 398);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(176, 17);
            this.label8.TabIndex = 109;
            this.label8.Text = "Saldo total billetes:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Cascadia Mono", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(25, 381);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(168, 17);
            this.label11.TabIndex = 108;
            this.label11.Text = "Saldo total monedas:";
            // 
            // cbxDivisas
            // 
            this.cbxDivisas.FormattingEnabled = true;
            this.cbxDivisas.Location = new System.Drawing.Point(95, 318);
            this.cbxDivisas.Name = "cbxDivisas";
            this.cbxDivisas.Size = new System.Drawing.Size(225, 21);
            this.cbxDivisas.TabIndex = 111;
            // 
            // frmMostrarAlcancia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 521);
            this.Controls.Add(this.cbxDivisas);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.lblSaldoTotal);
            this.Controls.Add(this.lblSaldoBilletes);
            this.Controls.Add(this.lblSaldoMonedas);
            this.Controls.Add(this.lblDenoBilletes);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btnMostrarDivisaD);
            this.Controls.Add(this.lblDenoMonedas);
            this.Controls.Add(this.lblCapBilletes);
            this.Controls.Add(this.lblCapMonedas);
            this.Controls.Add(this.lblDivisa);
            this.Controls.Add(this.txbIdentificador);
            this.Controls.Add(this.lblIdentificador);
            this.Controls.Add(this.lblMostrarAlcancia);
            this.Controls.Add(this.lblSubtitulo);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.btnMostrar);
            this.Controls.Add(this.btnFinalizar);
            this.Name = "frmMostrarAlcancia";
            this.Text = "frmMostrarAlcancia";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblIdentificador;
        private System.Windows.Forms.Label lblMostrarAlcancia;
        private System.Windows.Forms.Label lblSubtitulo;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnFinalizar;
        private System.Windows.Forms.Button btnMostrar;
        private System.Windows.Forms.TextBox txbIdentificador;
        private System.Windows.Forms.Label lblDivisa;
        private System.Windows.Forms.Label lblCapMonedas;
        private System.Windows.Forms.Label lblCapBilletes;
        private System.Windows.Forms.Label lblDenoMonedas;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnMostrarDivisaD;
        private System.Windows.Forms.Label lblDenoBilletes;
        private System.Windows.Forms.Label lblSaldoMonedas;
        private System.Windows.Forms.Label lblSaldoBilletes;
        private System.Windows.Forms.Label lblSaldoTotal;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cbxDivisas;
    }
}