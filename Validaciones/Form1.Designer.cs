namespace Validaciones
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.CboTipoDocumento = new System.Windows.Forms.ComboBox();
            this.CboRango = new System.Windows.Forms.ComboBox();
            this.textNombre = new System.Windows.Forms.TextBox();
            this.rbMujer = new System.Windows.Forms.RadioButton();
            this.rbHombre = new System.Windows.Forms.RadioButton();
            this.textNumeroDocumento = new System.Windows.Forms.TextBox();
            this.textCosto = new System.Windows.Forms.TextBox();
            this.btnMontoPagar = new System.Windows.Forms.Button();
            this.btnRegistar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.erpMensaje = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.erpMensaje)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "&Nombre de paciente";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "&Tipo Documento";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "&Numero de Documento";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(38, 174);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "&Sexo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(38, 228);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "&Rango";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(38, 292);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "&Costo Servicio";
            // 
            // CboTipoDocumento
            // 
            this.CboTipoDocumento.FormattingEnabled = true;
            this.CboTipoDocumento.Location = new System.Drawing.Point(178, 59);
            this.CboTipoDocumento.Name = "CboTipoDocumento";
            this.CboTipoDocumento.Size = new System.Drawing.Size(313, 21);
            this.CboTipoDocumento.TabIndex = 6;
            // 
            // CboRango
            // 
            this.CboRango.FormattingEnabled = true;
            this.CboRango.Location = new System.Drawing.Point(178, 225);
            this.CboRango.Name = "CboRango";
            this.CboRango.Size = new System.Drawing.Size(313, 21);
            this.CboRango.TabIndex = 7;
            // 
            // textNombre
            // 
            this.textNombre.Location = new System.Drawing.Point(178, 18);
            this.textNombre.Name = "textNombre";
            this.textNombre.Size = new System.Drawing.Size(313, 20);
            this.textNombre.TabIndex = 8;
            // 
            // rbMujer
            // 
            this.rbMujer.AutoSize = true;
            this.rbMujer.Location = new System.Drawing.Point(178, 172);
            this.rbMujer.Name = "rbMujer";
            this.rbMujer.Size = new System.Drawing.Size(51, 17);
            this.rbMujer.TabIndex = 9;
            this.rbMujer.TabStop = true;
            this.rbMujer.Text = "Mujer";
            this.rbMujer.UseVisualStyleBackColor = true;
            // 
            // rbHombre
            // 
            this.rbHombre.AutoSize = true;
            this.rbHombre.Location = new System.Drawing.Point(420, 170);
            this.rbHombre.Name = "rbHombre";
            this.rbHombre.Size = new System.Drawing.Size(62, 17);
            this.rbHombre.TabIndex = 10;
            this.rbHombre.TabStop = true;
            this.rbHombre.Text = "Hombre";
            this.rbHombre.UseVisualStyleBackColor = true;
            // 
            // textNumeroDocumento
            // 
            this.textNumeroDocumento.Location = new System.Drawing.Point(178, 115);
            this.textNumeroDocumento.Name = "textNumeroDocumento";
            this.textNumeroDocumento.Size = new System.Drawing.Size(313, 20);
            this.textNumeroDocumento.TabIndex = 11;
            this.textNumeroDocumento.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textCosto
            // 
            this.textCosto.Location = new System.Drawing.Point(178, 284);
            this.textCosto.Name = "textCosto";
            this.textCosto.Size = new System.Drawing.Size(313, 20);
            this.textCosto.TabIndex = 12;
            // 
            // btnMontoPagar
            // 
            this.btnMontoPagar.Location = new System.Drawing.Point(48, 348);
            this.btnMontoPagar.Name = "btnMontoPagar";
            this.btnMontoPagar.Size = new System.Drawing.Size(103, 49);
            this.btnMontoPagar.TabIndex = 13;
            this.btnMontoPagar.Text = "&Monto a pagar";
            this.btnMontoPagar.UseVisualStyleBackColor = true;
            this.btnMontoPagar.Click += new System.EventHandler(this.btnMontoPagar_Click);
            // 
            // btnRegistar
            // 
            this.btnRegistar.Location = new System.Drawing.Point(241, 348);
            this.btnRegistar.Name = "btnRegistar";
            this.btnRegistar.Size = new System.Drawing.Size(100, 49);
            this.btnRegistar.TabIndex = 14;
            this.btnRegistar.Text = "&Registar";
            this.btnRegistar.UseVisualStyleBackColor = true;
            this.btnRegistar.Click += new System.EventHandler(this.btnRegistar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(420, 347);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(100, 50);
            this.btnCancelar.TabIndex = 15;
            this.btnCancelar.Text = "&Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // erpMensaje
            // 
            this.erpMensaje.ContainerControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(565, 409);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnRegistar);
            this.Controls.Add(this.btnMontoPagar);
            this.Controls.Add(this.textCosto);
            this.Controls.Add(this.textNumeroDocumento);
            this.Controls.Add(this.rbHombre);
            this.Controls.Add(this.rbMujer);
            this.Controls.Add(this.textNombre);
            this.Controls.Add(this.CboRango);
            this.Controls.Add(this.CboTipoDocumento);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Registro de servicios de pacientes";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.erpMensaje)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox CboTipoDocumento;
        private System.Windows.Forms.ComboBox CboRango;
        private System.Windows.Forms.TextBox textNombre;
        private System.Windows.Forms.RadioButton rbMujer;
        private System.Windows.Forms.RadioButton rbHombre;
        private System.Windows.Forms.TextBox textNumeroDocumento;
        private System.Windows.Forms.TextBox textCosto;
        private System.Windows.Forms.Button btnMontoPagar;
        private System.Windows.Forms.Button btnRegistar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.ErrorProvider erpMensaje;
    }
}

