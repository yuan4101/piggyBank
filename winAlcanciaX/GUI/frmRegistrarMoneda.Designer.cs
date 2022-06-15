namespace winAlcanciaX.GUI
{
    partial class frmRegistrarMoneda
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
            this.lblRegistrarMoneda = new System.Windows.Forms.Label();
            this.lblSubtitulo = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.btnFinalizar = new System.Windows.Forms.Button();
            this.txbDenominacion = new System.Windows.Forms.TextBox();
            this.txbAño = new System.Windows.Forms.TextBox();
            this.txbIdentificador = new System.Windows.Forms.TextBox();
            this.txbDivisa = new System.Windows.Forms.TextBox();
            this.lblAño = new System.Windows.Forms.Label();
            this.lblDenominacion = new System.Windows.Forms.Label();
            this.lblIdentificador = new System.Windows.Forms.Label();
            this.lblDivisa = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblRegistrarMoneda
            // 
            this.lblRegistrarMoneda.Font = new System.Drawing.Font("Cascadia Mono", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegistrarMoneda.Location = new System.Drawing.Point(12, 440);
            this.lblRegistrarMoneda.Name = "lblRegistrarMoneda";
            this.lblRegistrarMoneda.Size = new System.Drawing.Size(610, 70);
            this.lblRegistrarMoneda.TabIndex = 67;
            this.lblRegistrarMoneda.Visible = false;
            // 
            // lblSubtitulo
            // 
            this.lblSubtitulo.AutoSize = true;
            this.lblSubtitulo.Font = new System.Drawing.Font("Cascadia Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubtitulo.Location = new System.Drawing.Point(190, 58);
            this.lblSubtitulo.Name = "lblSubtitulo";
            this.lblSubtitulo.Size = new System.Drawing.Size(271, 21);
            this.lblSubtitulo.TabIndex = 52;
            this.lblSubtitulo.Text = "Digite los datos de la moneda";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Cascadia Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(12, 14);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(154, 21);
            this.lblTitulo.TabIndex = 51;
            this.lblTitulo.Text = "Registrar Moneda";
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Font = new System.Drawing.Font("Cascadia Mono", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrar.Location = new System.Drawing.Point(275, 393);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(100, 30);
            this.btnRegistrar.TabIndex = 50;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // btnFinalizar
            // 
            this.btnFinalizar.Font = new System.Drawing.Font("Cascadia Mono", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinalizar.Location = new System.Drawing.Point(522, 10);
            this.btnFinalizar.Name = "btnFinalizar";
            this.btnFinalizar.Size = new System.Drawing.Size(100, 30);
            this.btnFinalizar.TabIndex = 49;
            this.btnFinalizar.Text = "Finalizar";
            this.btnFinalizar.UseVisualStyleBackColor = true;
            this.btnFinalizar.Click += new System.EventHandler(this.btnFinalizar_Click);
            // 
            // txbDenominacion
            // 
            this.txbDenominacion.Font = new System.Drawing.Font("Cascadia Mono", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbDenominacion.Location = new System.Drawing.Point(342, 258);
            this.txbDenominacion.Name = "txbDenominacion";
            this.txbDenominacion.Size = new System.Drawing.Size(200, 20);
            this.txbDenominacion.TabIndex = 80;
            // 
            // txbAño
            // 
            this.txbAño.Font = new System.Drawing.Font("Cascadia Mono", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbAño.Location = new System.Drawing.Point(342, 298);
            this.txbAño.Name = "txbAño";
            this.txbAño.Size = new System.Drawing.Size(200, 20);
            this.txbAño.TabIndex = 78;
            // 
            // txbIdentificador
            // 
            this.txbIdentificador.Font = new System.Drawing.Font("Cascadia Mono", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbIdentificador.Location = new System.Drawing.Point(342, 178);
            this.txbIdentificador.Name = "txbIdentificador";
            this.txbIdentificador.Size = new System.Drawing.Size(200, 20);
            this.txbIdentificador.TabIndex = 77;
            // 
            // txbDivisa
            // 
            this.txbDivisa.Font = new System.Drawing.Font("Cascadia Mono", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbDivisa.Location = new System.Drawing.Point(342, 218);
            this.txbDivisa.Name = "txbDivisa";
            this.txbDivisa.Size = new System.Drawing.Size(200, 20);
            this.txbDivisa.TabIndex = 76;
            // 
            // lblAño
            // 
            this.lblAño.AutoSize = true;
            this.lblAño.Font = new System.Drawing.Font("Cascadia Mono", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAño.Location = new System.Drawing.Point(92, 298);
            this.lblAño.Name = "lblAño";
            this.lblAño.Size = new System.Drawing.Size(32, 17);
            this.lblAño.TabIndex = 73;
            this.lblAño.Text = "Año";
            // 
            // lblDenominacion
            // 
            this.lblDenominacion.AutoSize = true;
            this.lblDenominacion.Font = new System.Drawing.Font("Cascadia Mono", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDenominacion.Location = new System.Drawing.Point(92, 258);
            this.lblDenominacion.Name = "lblDenominacion";
            this.lblDenominacion.Size = new System.Drawing.Size(104, 17);
            this.lblDenominacion.TabIndex = 72;
            this.lblDenominacion.Text = "Denominacion";
            // 
            // lblIdentificador
            // 
            this.lblIdentificador.AutoSize = true;
            this.lblIdentificador.Font = new System.Drawing.Font("Cascadia Mono", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdentificador.Location = new System.Drawing.Point(92, 181);
            this.lblIdentificador.Name = "lblIdentificador";
            this.lblIdentificador.Size = new System.Drawing.Size(112, 17);
            this.lblIdentificador.TabIndex = 71;
            this.lblIdentificador.Text = "Identificador";
            // 
            // lblDivisa
            // 
            this.lblDivisa.AutoSize = true;
            this.lblDivisa.Font = new System.Drawing.Font("Cascadia Mono", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDivisa.Location = new System.Drawing.Point(92, 221);
            this.lblDivisa.Name = "lblDivisa";
            this.lblDivisa.Size = new System.Drawing.Size(56, 17);
            this.lblDivisa.TabIndex = 70;
            this.lblDivisa.Text = "Divisa";
            // 
            // frmRegistrarMoneda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 521);
            this.Controls.Add(this.txbDenominacion);
            this.Controls.Add(this.txbAño);
            this.Controls.Add(this.txbIdentificador);
            this.Controls.Add(this.txbDivisa);
            this.Controls.Add(this.lblAño);
            this.Controls.Add(this.lblDenominacion);
            this.Controls.Add(this.lblIdentificador);
            this.Controls.Add(this.lblDivisa);
            this.Controls.Add(this.lblRegistrarMoneda);
            this.Controls.Add(this.lblSubtitulo);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.btnFinalizar);
            this.Name = "frmRegistrarMoneda";
            this.Text = "Registrar Moneda";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRegistrarMoneda;
        private System.Windows.Forms.Label lblSubtitulo;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Button btnFinalizar;
        private System.Windows.Forms.TextBox txbDenominacion;
        private System.Windows.Forms.TextBox txbAño;
        private System.Windows.Forms.TextBox txbIdentificador;
        private System.Windows.Forms.TextBox txbDivisa;
        private System.Windows.Forms.Label lblAño;
        private System.Windows.Forms.Label lblDenominacion;
        private System.Windows.Forms.Label lblIdentificador;
        private System.Windows.Forms.Label lblDivisa;
    }
}