using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laboratorio3TenSuValdespino
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void VerificarCampos()
        {
            if (tbRangoInfer.Text != "" &&  tbRangoSuper.Text != "")
            {
                btGenerar.Enabled = true;

            }
            else 
                { btGenerar.Enabled = false; }
        }

        private void btSiguiente_Click_1(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            this.Hide();
            form1.Show();
        }

        private void tbRangoInfer_TextChanged(object sender, EventArgs e)
        {
            VerificarCampos();
        }

        private void tbRangoSuper_TextChanged_1(object sender, EventArgs e)
        {
            VerificarCampos();
        }

        private void ValidarCaracter(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
            {

                e.Handled = true;
                MessageBox.Show("Por favor, ingrese solo palabras.");
            }
        }

        private void ValidarCaracterSuperior(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
            {

                e.Handled = true;
                MessageBox.Show("Por favor, ingrese solo numeros.");
            }
        }

        private void LBResultado_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbRangoInfer.Text) && string.IsNullOrWhiteSpace(tbRangoSuper.Text))
            {
                LBResultado.Items.Clear();
            }
        }

        private void btGenerar_Click_1(object sender, EventArgs e)
        {
            if (!int.TryParse(tbRangoInfer.Text, out int rangoInferior) || !int.TryParse(tbRangoSuper.Text, out int rangoSuper))
            {
                MessageBox.Show("Por favor, ingrese números válidos.");
                return;
            }

            rangoInferior = Convert.ToInt16(tbRangoInfer.Text);
            rangoSuper = Convert.ToInt16(tbRangoSuper.Text);

            if (string.IsNullOrWhiteSpace(tbRangoInfer.Text) || string.IsNullOrWhiteSpace(tbRangoSuper.Text))
            {
                MessageBox.Show("Por favor, ingrese ambos valores.");
                return;
            }


            if (rangoInferior > rangoSuper)
            {
                MessageBox.Show("El rango inferior debe ser menor o igual al rango superior.");
                return;
            }

            for (int i = rangoInferior; i <= rangoSuper; i++)
            {
                string numStr = i.ToString();
                char[] original = numStr.ToCharArray();
                Array.Reverse(original);
                string invertido = new string(original);

                if (numStr == invertido)
                {
                    LBResultado.Items.Add(numStr);
                }  
            }
        }

        private void EntradaMouseGenerar(object sender, EventArgs e)
        {
            btGenerar.BackColor = Color.LightGreen;
        }

        private void DejarMouseGenerar(object sender, EventArgs e)
        {
            btGenerar.BackColor = Color.LightSkyBlue;
        }
    }
}
