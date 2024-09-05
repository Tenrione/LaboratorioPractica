namespace Laboratorio3TenSuValdespino
{
    partial class Form3
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
            this.gbResultado = new System.Windows.Forms.GroupBox();
            this.LBResultado = new System.Windows.Forms.ListBox();
            this.gbDatos = new System.Windows.Forms.GroupBox();
            this.btSiguiente = new System.Windows.Forms.Button();
            this.tbRangoSuper = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btGenerar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tbRangoInfer = new System.Windows.Forms.TextBox();
            this.lbProblema = new System.Windows.Forms.Label();
            this.lbProblema2 = new System.Windows.Forms.Label();
            this.gbResultado.SuspendLayout();
            this.gbDatos.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbResultado
            // 
            this.gbResultado.Controls.Add(this.LBResultado);
            this.gbResultado.Font = new System.Drawing.Font("MS Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbResultado.Location = new System.Drawing.Point(414, 120);
            this.gbResultado.Margin = new System.Windows.Forms.Padding(2);
            this.gbResultado.Name = "gbResultado";
            this.gbResultado.Padding = new System.Windows.Forms.Padding(2);
            this.gbResultado.Size = new System.Drawing.Size(240, 121);
            this.gbResultado.TabIndex = 8;
            this.gbResultado.TabStop = false;
            this.gbResultado.Text = "Resultado";
            // 
            // LBResultado
            // 
            this.LBResultado.FormattingEnabled = true;
            this.LBResultado.Location = new System.Drawing.Point(62, 17);
            this.LBResultado.Margin = new System.Windows.Forms.Padding(2);
            this.LBResultado.Name = "LBResultado";
            this.LBResultado.Size = new System.Drawing.Size(82, 95);
            this.LBResultado.TabIndex = 0;
            this.LBResultado.SelectedIndexChanged += new System.EventHandler(this.LBResultado_SelectedIndexChanged_1);
            // 
            // gbDatos
            // 
            this.gbDatos.Controls.Add(this.btSiguiente);
            this.gbDatos.Controls.Add(this.tbRangoSuper);
            this.gbDatos.Controls.Add(this.label1);
            this.gbDatos.Controls.Add(this.btGenerar);
            this.gbDatos.Controls.Add(this.label2);
            this.gbDatos.Controls.Add(this.tbRangoInfer);
            this.gbDatos.Font = new System.Drawing.Font("MS Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbDatos.Location = new System.Drawing.Point(106, 120);
            this.gbDatos.Margin = new System.Windows.Forms.Padding(2);
            this.gbDatos.Name = "gbDatos";
            this.gbDatos.Padding = new System.Windows.Forms.Padding(2);
            this.gbDatos.Size = new System.Drawing.Size(256, 233);
            this.gbDatos.TabIndex = 7;
            this.gbDatos.TabStop = false;
            this.gbDatos.Text = "Datos";
            // 
            // btSiguiente
            // 
            this.btSiguiente.Font = new System.Drawing.Font("MS Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSiguiente.Location = new System.Drawing.Point(69, 167);
            this.btSiguiente.Margin = new System.Windows.Forms.Padding(2);
            this.btSiguiente.Name = "btSiguiente";
            this.btSiguiente.Size = new System.Drawing.Size(130, 44);
            this.btSiguiente.TabIndex = 5;
            this.btSiguiente.Text = "Siguiente";
            this.btSiguiente.UseVisualStyleBackColor = true;
            this.btSiguiente.Click += new System.EventHandler(this.btSiguiente_Click_1);
            // 
            // tbRangoSuper
            // 
            this.tbRangoSuper.Location = new System.Drawing.Point(148, 67);
            this.tbRangoSuper.Margin = new System.Windows.Forms.Padding(2);
            this.tbRangoSuper.MaxLength = 15;
            this.tbRangoSuper.Name = "tbRangoSuper";
            this.tbRangoSuper.Size = new System.Drawing.Size(76, 20);
            this.tbRangoSuper.TabIndex = 4;
            this.tbRangoSuper.TextChanged += new System.EventHandler(this.tbRangoSuper_TextChanged_1);
            this.tbRangoSuper.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ValidarCaracterSuperior);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(4, 67);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Rango Superior:";
            // 
            // btGenerar
            // 
            this.btGenerar.Enabled = false;
            this.btGenerar.Location = new System.Drawing.Point(86, 111);
            this.btGenerar.Margin = new System.Windows.Forms.Padding(2);
            this.btGenerar.Name = "btGenerar";
            this.btGenerar.Size = new System.Drawing.Size(88, 38);
            this.btGenerar.TabIndex = 5;
            this.btGenerar.Text = "GENERAR";
            this.btGenerar.Click += new System.EventHandler(this.btGenerar_Click_1);
            this.btGenerar.MouseEnter += new System.EventHandler(this.EntradaMouseGenerar);
            this.btGenerar.MouseLeave += new System.EventHandler(this.DejarMouseGenerar);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(4, 24);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Rango inferior:";
            // 
            // tbRangoInfer
            // 
            this.tbRangoInfer.Location = new System.Drawing.Point(148, 24);
            this.tbRangoInfer.Margin = new System.Windows.Forms.Padding(2);
            this.tbRangoInfer.MaxLength = 15;
            this.tbRangoInfer.Name = "tbRangoInfer";
            this.tbRangoInfer.Size = new System.Drawing.Size(76, 20);
            this.tbRangoInfer.TabIndex = 0;
            this.tbRangoInfer.TextChanged += new System.EventHandler(this.tbRangoInfer_TextChanged);
            this.tbRangoInfer.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ValidarCaracter);
            // 
            // lbProblema
            // 
            this.lbProblema.AutoSize = true;
            this.lbProblema.Font = new System.Drawing.Font("MS Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbProblema.Location = new System.Drawing.Point(96, 4);
            this.lbProblema.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbProblema.Name = "lbProblema";
            this.lbProblema.Size = new System.Drawing.Size(109, 19);
            this.lbProblema.TabIndex = 6;
            this.lbProblema.Text = "Problema 2";
            // 
            // lbProblema2
            // 
            this.lbProblema2.AutoSize = true;
            this.lbProblema2.Font = new System.Drawing.Font("MS Gothic", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbProblema2.Location = new System.Drawing.Point(241, 73);
            this.lbProblema2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbProblema2.Name = "lbProblema2";
            this.lbProblema2.Size = new System.Drawing.Size(262, 23);
            this.lbProblema2.TabIndex = 5;
            this.lbProblema2.Text = "Palindromos Numéricos";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gbResultado);
            this.Controls.Add(this.gbDatos);
            this.Controls.Add(this.lbProblema);
            this.Controls.Add(this.lbProblema2);
            this.Name = "Form3";
            this.Text = "Form3";
            this.gbResultado.ResumeLayout(false);
            this.gbDatos.ResumeLayout(false);
            this.gbDatos.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbResultado;
        private System.Windows.Forms.ListBox LBResultado;
        private System.Windows.Forms.GroupBox gbDatos;
        private System.Windows.Forms.Button btSiguiente;
        private System.Windows.Forms.TextBox tbRangoSuper;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btGenerar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbRangoInfer;
        private System.Windows.Forms.Label lbProblema;
        private System.Windows.Forms.Label lbProblema2;
    }
}