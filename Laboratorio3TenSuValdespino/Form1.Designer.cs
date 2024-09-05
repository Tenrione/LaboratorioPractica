namespace Laboratorio3TenSuValdespino
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
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
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.LbTitulo = new System.Windows.Forms.Label();
            this.LbPeticionNombre = new System.Windows.Forms.Label();
            this.LbPeticionCedula = new System.Windows.Forms.Label();
            this.LbPeticionIngreso = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tBNombre = new System.Windows.Forms.TextBox();
            this.tBCedula = new System.Windows.Forms.TextBox();
            this.tBDeposito = new System.Windows.Forms.TextBox();
            this.rBPlazo12Meses = new System.Windows.Forms.RadioButton();
            this.rBPlazo24Meses = new System.Windows.Forms.RadioButton();
            this.rBPlazo36Meses = new System.Windows.Forms.RadioButton();
            this.rBPlazo48Meses = new System.Windows.Forms.RadioButton();
            this.rBPlazo60Meses = new System.Windows.Forms.RadioButton();
            this.LbSubtitulo = new System.Windows.Forms.Label();
            this.LbImpresion = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LbTitulo
            // 
            this.LbTitulo.AutoSize = true;
            this.LbTitulo.Font = new System.Drawing.Font("MS Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbTitulo.Location = new System.Drawing.Point(35, 9);
            this.LbTitulo.Name = "LbTitulo";
            this.LbTitulo.Size = new System.Drawing.Size(738, 24);
            this.LbTitulo.TabIndex = 0;
            this.LbTitulo.Text = "¡ABRA SU CUENTA Y DESCUBRA LOS BENEFICIOS A LARGO PLAZO!";
            // 
            // LbPeticionNombre
            // 
            this.LbPeticionNombre.AutoSize = true;
            this.LbPeticionNombre.Font = new System.Drawing.Font("MS Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbPeticionNombre.Location = new System.Drawing.Point(65, 105);
            this.LbPeticionNombre.Name = "LbPeticionNombre";
            this.LbPeticionNombre.Size = new System.Drawing.Size(214, 21);
            this.LbPeticionNombre.TabIndex = 1;
            this.LbPeticionNombre.Text = "ESCRIBA SU NOMBRE";
            // 
            // LbPeticionCedula
            // 
            this.LbPeticionCedula.AutoSize = true;
            this.LbPeticionCedula.Font = new System.Drawing.Font("MS Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbPeticionCedula.Location = new System.Drawing.Point(65, 176);
            this.LbPeticionCedula.Name = "LbPeticionCedula";
            this.LbPeticionCedula.Size = new System.Drawing.Size(214, 21);
            this.LbPeticionCedula.TabIndex = 2;
            this.LbPeticionCedula.Text = "ESCRIBA SU CEDULA";
            // 
            // LbPeticionIngreso
            // 
            this.LbPeticionIngreso.AutoSize = true;
            this.LbPeticionIngreso.Font = new System.Drawing.Font("MS Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbPeticionIngreso.Location = new System.Drawing.Point(49, 248);
            this.LbPeticionIngreso.Name = "LbPeticionIngreso";
            this.LbPeticionIngreso.Size = new System.Drawing.Size(274, 21);
            this.LbPeticionIngreso.TabIndex = 3;
            this.LbPeticionIngreso.Text = "CUANTO DESEA DEPOSITAR";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(66, 269);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(247, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "El minimo para empezar es 2000";
            // 
            // tBNombre
            // 
            this.tBNombre.Font = new System.Drawing.Font("MS Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBNombre.Location = new System.Drawing.Point(428, 100);
            this.tBNombre.MaxLength = 24;
            this.tBNombre.Name = "tBNombre";
            this.tBNombre.Size = new System.Drawing.Size(257, 26);
            this.tBNombre.TabIndex = 5;
            this.tBNombre.TextChanged += new System.EventHandler(this.tBNombre_TextChanged);
            this.tBNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbSoloCaracteres);
            // 
            // tBCedula
            // 
            this.tBCedula.Font = new System.Drawing.Font("MS Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBCedula.Location = new System.Drawing.Point(428, 175);
            this.tBCedula.MaxLength = 15;
            this.tBCedula.Name = "tBCedula";
            this.tBCedula.Size = new System.Drawing.Size(257, 26);
            this.tBCedula.TabIndex = 6;
            this.tBCedula.TextChanged += new System.EventHandler(this.tBCedula_TextChanged);
            this.tBCedula.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CedulaValida);
            // 
            // tBDeposito
            // 
            this.tBDeposito.Font = new System.Drawing.Font("MS Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBDeposito.Location = new System.Drawing.Point(428, 248);
            this.tBDeposito.MaxLength = 12;
            this.tBDeposito.Name = "tBDeposito";
            this.tBDeposito.Size = new System.Drawing.Size(257, 26);
            this.tBDeposito.TabIndex = 7;
            this.tBDeposito.TextChanged += new System.EventHandler(this.tBDeposito_TextChanged);
            this.tBDeposito.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.VerificarNumerico);
            // 
            // rBPlazo12Meses
            // 
            this.rBPlazo12Meses.AutoSize = true;
            this.rBPlazo12Meses.Enabled = false;
            this.rBPlazo12Meses.Font = new System.Drawing.Font("MS Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rBPlazo12Meses.Location = new System.Drawing.Point(36, 348);
            this.rBPlazo12Meses.Name = "rBPlazo12Meses";
            this.rBPlazo12Meses.Size = new System.Drawing.Size(144, 17);
            this.rBPlazo12Meses.TabIndex = 8;
            this.rBPlazo12Meses.Text = "Plazo de 12 meses";
            this.rBPlazo12Meses.UseVisualStyleBackColor = true;
            this.rBPlazo12Meses.CheckedChanged += new System.EventHandler(this.rBPlazo12Meses_CheckedChanged);
            // 
            // rBPlazo24Meses
            // 
            this.rBPlazo24Meses.AutoSize = true;
            this.rBPlazo24Meses.Enabled = false;
            this.rBPlazo24Meses.Font = new System.Drawing.Font("MS Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rBPlazo24Meses.Location = new System.Drawing.Point(36, 387);
            this.rBPlazo24Meses.Name = "rBPlazo24Meses";
            this.rBPlazo24Meses.Size = new System.Drawing.Size(144, 17);
            this.rBPlazo24Meses.TabIndex = 9;
            this.rBPlazo24Meses.Text = "Plazo de 24 meses";
            this.rBPlazo24Meses.UseVisualStyleBackColor = true;
            this.rBPlazo24Meses.CheckedChanged += new System.EventHandler(this.rBPlazo24Meses_CheckedChanged);
            // 
            // rBPlazo36Meses
            // 
            this.rBPlazo36Meses.AutoSize = true;
            this.rBPlazo36Meses.Enabled = false;
            this.rBPlazo36Meses.Font = new System.Drawing.Font("MS Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rBPlazo36Meses.Location = new System.Drawing.Point(36, 426);
            this.rBPlazo36Meses.Name = "rBPlazo36Meses";
            this.rBPlazo36Meses.Size = new System.Drawing.Size(144, 17);
            this.rBPlazo36Meses.TabIndex = 10;
            this.rBPlazo36Meses.Text = "Plazo de 36 meses";
            this.rBPlazo36Meses.UseVisualStyleBackColor = true;
            this.rBPlazo36Meses.CheckedChanged += new System.EventHandler(this.rBPlazo36Meses_CheckedChanged);
            // 
            // rBPlazo48Meses
            // 
            this.rBPlazo48Meses.AutoSize = true;
            this.rBPlazo48Meses.Enabled = false;
            this.rBPlazo48Meses.Font = new System.Drawing.Font("MS Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rBPlazo48Meses.Location = new System.Drawing.Point(210, 348);
            this.rBPlazo48Meses.Name = "rBPlazo48Meses";
            this.rBPlazo48Meses.Size = new System.Drawing.Size(144, 17);
            this.rBPlazo48Meses.TabIndex = 11;
            this.rBPlazo48Meses.Text = "Plazo de 48 meses";
            this.rBPlazo48Meses.UseVisualStyleBackColor = true;
            this.rBPlazo48Meses.CheckedChanged += new System.EventHandler(this.rBPlazo48Meses_CheckedChanged);
            // 
            // rBPlazo60Meses
            // 
            this.rBPlazo60Meses.AutoSize = true;
            this.rBPlazo60Meses.Enabled = false;
            this.rBPlazo60Meses.Font = new System.Drawing.Font("MS Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rBPlazo60Meses.Location = new System.Drawing.Point(210, 387);
            this.rBPlazo60Meses.Name = "rBPlazo60Meses";
            this.rBPlazo60Meses.Size = new System.Drawing.Size(144, 17);
            this.rBPlazo60Meses.TabIndex = 12;
            this.rBPlazo60Meses.Text = "Plazo de 60 meses";
            this.rBPlazo60Meses.UseVisualStyleBackColor = true;
            this.rBPlazo60Meses.CheckedChanged += new System.EventHandler(this.rBPlazo60Meses_CheckedChanged);
            // 
            // LbSubtitulo
            // 
            this.LbSubtitulo.AutoSize = true;
            this.LbSubtitulo.Font = new System.Drawing.Font("MS Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbSubtitulo.Location = new System.Drawing.Point(76, 318);
            this.LbSubtitulo.Name = "LbSubtitulo";
            this.LbSubtitulo.Size = new System.Drawing.Size(215, 16);
            this.LbSubtitulo.TabIndex = 13;
            this.LbSubtitulo.Text = "Monto acumulado por plazos";
            // 
            // LbImpresion
            // 
            this.LbImpresion.AutoSize = true;
            this.LbImpresion.Font = new System.Drawing.Font("MS Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbImpresion.Location = new System.Drawing.Point(424, 318);
            this.LbImpresion.MaximumSize = new System.Drawing.Size(350, 100);
            this.LbImpresion.Name = "LbImpresion";
            this.LbImpresion.Size = new System.Drawing.Size(0, 19);
            this.LbImpresion.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LbImpresion);
            this.Controls.Add(this.LbSubtitulo);
            this.Controls.Add(this.rBPlazo60Meses);
            this.Controls.Add(this.rBPlazo48Meses);
            this.Controls.Add(this.rBPlazo36Meses);
            this.Controls.Add(this.rBPlazo24Meses);
            this.Controls.Add(this.rBPlazo12Meses);
            this.Controls.Add(this.tBDeposito);
            this.Controls.Add(this.tBCedula);
            this.Controls.Add(this.tBNombre);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LbPeticionIngreso);
            this.Controls.Add(this.LbPeticionCedula);
            this.Controls.Add(this.LbPeticionNombre);
            this.Controls.Add(this.LbTitulo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LbTitulo;
        private System.Windows.Forms.Label LbPeticionNombre;
        private System.Windows.Forms.Label LbPeticionCedula;
        private System.Windows.Forms.Label LbPeticionIngreso;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tBNombre;
        private System.Windows.Forms.TextBox tBCedula;
        private System.Windows.Forms.TextBox tBDeposito;
        private System.Windows.Forms.RadioButton rBPlazo12Meses;
        private System.Windows.Forms.RadioButton rBPlazo24Meses;
        private System.Windows.Forms.RadioButton rBPlazo36Meses;
        private System.Windows.Forms.RadioButton rBPlazo48Meses;
        private System.Windows.Forms.RadioButton rBPlazo60Meses;
        private System.Windows.Forms.Label LbSubtitulo;
        private System.Windows.Forms.Label LbImpresion;
    }
}

