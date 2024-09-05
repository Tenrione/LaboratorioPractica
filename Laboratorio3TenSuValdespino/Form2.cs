using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Laboratorio3TenSuValdespino
{
    public partial class Form2 : Form
    {
        char[] arrLetras;
        public Form2()
        {
            InitializeComponent();
        }


        private void VerificarCaracter(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {

                e.Handled = true;
                MessageBox.Show("Por favor, ingrese solo palabras.");
            }
        }

        private void btGenerar_Click_1(object sender, EventArgs e)
        {
            string palabra = textBox1.Text;

            arrLetras = palabra.ToCharArray();

            if (arrLetras.Length == 0)
            {
                MessageBox.Show("No hay palabras ingresadas.");
                return;
            }


            for (int i = 0; i < arrLetras.Length; i++)
            {

                if (arrLetras[i].Equals('a') || arrLetras[i].Equals('e') || arrLetras[i].Equals('i') || arrLetras[i].Equals('o') || arrLetras[i].Equals('u') || arrLetras[i].Equals('A') || arrLetras[i].Equals('E') || arrLetras[i].Equals('I') || arrLetras[i].Equals('O') || arrLetras[i].Equals('U'))
                {
                    lbResultado.Items.Add(arrLetras[i].ToString());

                }
            }

        }

        private void btProblema2_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            this.Hide();
            form3.Show();

        }

        private void GenerarMouseEntrada(object sender, EventArgs e)
        {
            btGenerar.BackColor = Color.LightGreen;
        }

        private void GenerarDejarMouse(object sender, EventArgs e)
        {
            btGenerar.BackColor = Color.LightSkyBlue;
        }

        private void Problema2Entrada(object sender, EventArgs e)
        {
            btProblema2.BackColor = Color.LightGreen;
        }

        private void Problema2MouseDejar(object sender, EventArgs e)
        {
            btProblema2.BackColor = Color.LightSkyBlue;
        }
    }
    }
