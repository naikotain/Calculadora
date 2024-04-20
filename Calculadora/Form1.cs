using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Operaciones obj = new Operaciones();
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void btnSumar_Click(object sender, EventArgs e)
        {
            if(!obj.Numerico(txtValor1.Text) && !obj.Numerico(txtValor2.Text))
            {
                txtResultado.Text = "Ingrese un valor valido";
                MessageBox.Show("Monto debe ser valor de tipo Numerico");
                txtValor1.Text = "";
                txtValor2.Text = "";
            }
            else
            {
                int suma = obj.Suma(Convert.ToInt32(txtValor1.Text), Convert.ToInt32(txtValor2.Text));
                txtResultado.Text = Convert.ToString(suma);
            }  
        }

        private void btnRestar_Click(object sender, EventArgs e)
        {
            if (!obj.Numerico(txtValor1.Text) && !obj.Numerico(txtValor2.Text))
            {
                txtResultado.Text = "Ingrese un valor valido";
            }
            else
            {
                int resta = obj.Resta(Convert.ToInt32(txtValor1.Text), Convert.ToInt32(txtValor2.Text));
                txtResultado.Text = Convert.ToString(resta);
            }
        }

        private void btnMultiplicar_Click(object sender, EventArgs e)
        {
            if (!obj.Numerico(txtValor1.Text) && !obj.Numerico(txtValor2.Text))
            {
                txtResultado.Text = "Ingrese un valor valido";
            }
            else
            {
                int multiplicacion = obj.Multiplicacion(Convert.ToInt32(txtValor1.Text), Convert.ToInt32(txtValor2.Text));
                txtResultado.Text = Convert.ToString(multiplicacion);
            }
        }

        private void btnDividir_Click(object sender, EventArgs e)
        {
            if (!obj.Numerico(txtValor1.Text) && !obj.Numerico(txtValor2.Text))
            {
                txtResultado.Text = "Ingrese un valor valido";
            }
            else
            {
                double division = obj.Division(Convert.ToDouble(txtValor1.Text), Convert.ToDouble(txtValor2.Text));
                txtResultado.Text = Convert.ToString(division);
            }
        }
    }
}
