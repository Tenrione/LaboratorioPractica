namespace Laboratorio3TenSuValdespino
{
    partial class Form2
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
            this.label3 = new System.Windows.Forms.Label();
            this.btProblema2 = new System.Windows.Forms.Button();
            this.lbProblema1 = new System.Windows.Forms.Label();
            this.gbResultado = new System.Windows.Forms.GroupBox();
            this.lbResultado = new System.Windows.Forms.ListBox();
            this.gbDatos = new System.Windows.Forms.GroupBox();
            this.btGenerar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gbResultado.SuspendLayout();
            this.gbDatos.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(309, 1);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 24);
            this.label3.TabIndex = 11;
            // 
            // btProblema2
            // 
            this.btProblema2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btProblema2.Location = new System.Drawing.Point(469, 298);
            this.btProblema2.Margin = new System.Windows.Forms.Padding(2);
            this.btProblema2.Name = "btProblema2";
            this.btProblema2.Size = new System.Drawing.Size(179, 30);
            this.btProblema2.TabIndex = 10;
            this.btProblema2.Text = "Problema 2";
            this.btProblema2.UseVisualStyleBackColor = true;
            this.btProblema2.Click += new System.EventHandler(this.btProblema2_Click);
            this.btProblema2.MouseEnter += new System.EventHandler(this.Problema2Entrada);
            this.btProblema2.MouseLeave += new System.EventHandler(this.Problema2MouseDejar);
            // 
            // lbProblema1
            // 
            this.lbProblema1.AutoSize = true;
            this.lbProblema1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbProblema1.Location = new System.Drawing.Point(116, 41);
            this.lbProblema1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbProblema1.Name = "lbProblema1";
            this.lbProblema1.Size = new System.Drawing.Size(124, 26);
            this.lbProblema1.TabIndex = 9;
            this.lbProblema1.Text = "Problema 1";
            // 
            // gbResultado
            // 
            this.gbResultado.Controls.Add(this.lbResultado);
            this.gbResultado.Location = new System.Drawing.Point(436, 132);
            this.gbResultado.Margin = new System.Windows.Forms.Padding(2);
            this.gbResultado.Name = "gbResultado";
            this.gbResultado.Padding = new System.Windows.Forms.Padding(2);
            this.gbResultado.Size = new System.Drawing.Size(240, 154);
            this.gbResultado.TabIndex = 8;
            this.gbResultado.TabStop = false;
            this.gbResultado.Text = "Resultado";
            // 
            // lbResultado
            // 
            this.lbResultado.FormattingEnabled = true;
            this.lbResultado.Location = new System.Drawing.Point(62, 17);
            this.lbResultado.Margin = new System.Windows.Forms.Padding(2);
            this.lbResultado.Name = "lbResultado";
            this.lbResultado.Size = new System.Drawing.Size(102, 134);
            this.lbResultado.TabIndex = 0;
            // 
            // gbDatos
            // 
            this.gbDatos.Controls.Add(this.btGenerar);
            this.gbDatos.Controls.Add(this.label2);
            this.gbDatos.Controls.Add(this.textBox1);
            this.gbDatos.Location = new System.Drawing.Point(128, 132);
            this.gbDatos.Margin = new System.Windows.Forms.Padding(2);
            this.gbDatos.Name = "gbDatos";
            this.gbDatos.Padding = new System.Windows.Forms.Padding(2);
            this.gbDatos.Size = new System.Drawing.Size(244, 167);
            this.gbDatos.TabIndex = 7;
            this.gbDatos.TabStop = false;
            this.gbDatos.Text = "Datos";
            // 
            // btGenerar
            // 
            this.btGenerar.Location = new System.Drawing.Point(70, 102);
            this.btGenerar.Margin = new System.Windows.Forms.Padding(2);
            this.btGenerar.Name = "btGenerar";
            this.btGenerar.Size = new System.Drawing.Size(97, 37);
            this.btGenerar.TabIndex = 2;
            this.btGenerar.Text = "Generar";
            this.btGenerar.UseVisualStyleBackColor = true;
            this.btGenerar.Click += new System.EventHandler(this.btGenerar_Click_1);
            this.btGenerar.MouseEnter += new System.EventHandler(this.GenerarMouseEntrada);
            this.btGenerar.MouseLeave += new System.EventHandler(this.GenerarDejarMouse);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(4, 59);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ingrese la palabra:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(140, 58);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.MaxLength = 30;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(101, 20);
            this.textBox1.TabIndex = 0;
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.VerificarCaracter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(280, 64);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(246, 29);
            this.label1.TabIndex = 6;
            this.label1.Text = "Cantidad de Vocales";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btProblema2);
            this.Controls.Add(this.lbProblema1);
            this.Controls.Add(this.gbResultado);
            this.Controls.Add(this.gbDatos);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.gbResultado.ResumeLayout(false);
            this.gbDatos.ResumeLayout(false);
            this.gbDatos.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btProblema2;
        private System.Windows.Forms.Label lbProblema1;
        private System.Windows.Forms.GroupBox gbResultado;
        private System.Windows.Forms.ListBox lbResultado;
        private System.Windows.Forms.GroupBox gbDatos;
        private System.Windows.Forms.Button btGenerar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
    }
}