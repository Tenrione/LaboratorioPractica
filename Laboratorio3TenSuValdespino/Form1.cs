//Codigo creado por Eriel Ten Su y Christian Valdespino
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //Clase para desactivar botones hasta que se inserten todos los datos
        public void verificarTexto()
        {
            if (tBNombre.Text!=""&& tBCedula.Text!= "" && tBDeposito.Text!="")
            {
                rBPlazo12Meses.Enabled = true;
                rBPlazo24Meses.Enabled = true;
                rBPlazo36Meses.Enabled = true;
                rBPlazo48Meses.Enabled = true;
                rBPlazo60Meses.Enabled = true;
            }
            else 
            {
                rBPlazo12Meses.Enabled = false;
                rBPlazo24Meses.Enabled = false;
                rBPlazo36Meses.Enabled = false;
                rBPlazo48Meses.Enabled = false;
                rBPlazo60Meses.Enabled = false;
            }
        }

        public double conversion()
        {
            double Deposito;
            try
            {
                Deposito = Double.Parse(tBDeposito.Text);
            }
            catch (Exception ex)
            {
                Deposito = 0;
            }
            return Deposito;
        }
        private void rBPlazo12Meses_CheckedChanged(object sender, EventArgs e)
        {
            double Deposito=conversion();
            double resultado = Deposito * Math.Pow((1 + 0.04), 1);
            if (Deposito>2000)
            LbImpresion.Text = ("Señor/a:" + tBNombre.Text + "\n" + "Con cedula: " + tBCedula.Text + "\n" +
                    "El monto acumulado en 12 meses de su deposito seria: " + Math.Round(resultado, 2));
            else
            {
                LbImpresion.Text = ("No se cumple la condicion de ser mayor o igual a 2000");
                rBPlazo12Meses.Checked = false;
            }


        }

        private void rBPlazo48Meses_CheckedChanged(object sender, EventArgs e)
        {
            double Deposito = conversion();
            double resultado = Deposito * Math.Pow((1 + 0.0475), 4);
            if (Deposito > 2000)
                LbImpresion.Text = ("Señor/a:" + tBNombre.Text + "\n" + "Con cedula: " + tBCedula.Text + "\n" +
                    "El monto acumulado en 48 meses de su deposito seria: " + Math.Round(resultado, 2));
            else
            {
                LbImpresion.Text = ("No se cumple la condicion de ser mayor o igual a 2000");
                rBPlazo48Meses.Checked = false;
            }
        }

        private void rBPlazo24Meses_CheckedChanged(object sender, EventArgs e)
        {
            double Deposito = conversion();
            double resultado = Deposito * Math.Pow((1 + 0.045), 2);
            if (Deposito > 2000)
                LbImpresion.Text = ("Señor/a:" + tBNombre.Text + "\n"+ "Con cedula: "+tBCedula.Text+ "\n"+
                    "El monto acumulado en 24 meses de su deposito seria: " + Math.Round(resultado, 2));
            else
            {
                LbImpresion.Text = ("No se cumple la condicion de ser mayor o igual a 2000");
                rBPlazo24Meses.Checked = false;
            }
        }

        private void rBPlazo60Meses_CheckedChanged(object sender, EventArgs e)
        {
            double Deposito = conversion();
            double resultado = Deposito * Math.Pow((1 + 0.05), 5);
            if (Deposito > 2000)
                LbImpresion.Text = ("Señor/a:" + tBNombre.Text + "\n" + "Con cedula: " + tBCedula.Text + "\n" +
                    "El monto acumulado en 60 meses de su deposito seria: " + Math.Round(resultado, 2));
            else
            {
                LbImpresion.Text = ("No se cumple la condicion de ser mayor o igual a 2000");
                rBPlazo60Meses.Checked = false;
            }
        }

        private void rBPlazo36Meses_CheckedChanged(object sender, EventArgs e)
        {
            double Deposito = conversion();
            double resultado = Deposito * Math.Pow((1 + 0.0455), 3);
            if (Deposito > 2000)
                LbImpresion.Text = ("Señor/a:" + tBNombre.Text + "\n" + "Con cedula: " + tBCedula.Text + "\n" +
                    "El monto acumulado en 36 meses de su deposito seria: " + Math.Round(resultado, 2));
            else
            {
                LbImpresion.Text = ("No se cumple la condicion de ser mayor o igual a 2000");
                rBPlazo36Meses.Checked = false;
            }
        }
        //Estas tres son para que solo se pueda tocar el boton despues de insertar datos en todas las casillas
        private void tBNombre_TextChanged(object sender, EventArgs e)
        {
            verificarTexto();
        }
       
        private void tBDeposito_TextChanged(object sender, EventArgs e)
        {
            
            verificarTexto();
        }

        private void tBCedula_TextChanged(object sender, EventArgs e)
        {
            
            verificarTexto();
        }
        //Metodo para solo aceptar decimales y un solo punto decimal
        private void VerificarNumerico(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                MessageBox.Show("Solo se permiten enteros o decimales");
                e.Handled = true;
                return;
            }
            if (e.KeyChar == '.' && tBDeposito.Text.Contains("."))
            {
                MessageBox.Show("Ya existe un punto decimal.");
                e.Handled = true; 
                return;
            }
        }
        //Solo permita caracteres a la hora de escribir el nombre
        private void tbSoloCaracteres(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) )
            {
                MessageBox.Show("Solo se permiten letras");
                e.Handled = true;
                return;
            }
           
        }
        //Verificacion de la cedula correctamente
        private void CedulaValida(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '-')
            {
                MessageBox.Show("La cedula solo contiene numeros y guiones");
                e.Handled = true; 
                return;
            }
            //Verifica que no introduzca mas de dos guiones por estructura de cedula
            if (e.KeyChar == '-')
            {
                int CantidadGuiones = tBCedula.Text.Count(c => c == '-');

                if (CantidadGuiones >= 2)
                {
                    MessageBox.Show("La cedula solo contiene dos guiones");
                    e.Handled = true; 
                    return;
                }
            }
        }
    }
}
