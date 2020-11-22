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
        double primero;
        double segundo;
        string operador;

        public Form1()
        {
            InitializeComponent();
        }

        ClasesClaculadora.ClaseSuma objeto1 = new ClasesClaculadora.ClaseSuma();
        ClasesClaculadora.ClaseResta objeto2 = new ClasesClaculadora.ClaseResta();
        ClasesClaculadora.ClaseMultiplicacion objeto3 = new ClasesClaculadora.ClaseMultiplicacion();
        ClasesClaculadora.ClaseDivicion objeto4 = new ClasesClaculadora.ClaseDivicion();
        ClasesClaculadora.ClasePorcentaje objeto5 = new ClasesClaculadora.ClasePorcentaje();
        ClasesClaculadora.ClaseFactorial objeto6 = new ClasesClaculadora.ClaseFactorial();

        private void btn0_Click(object sender, EventArgs e)
        {
            txtpantalla.Text = txtpantalla.Text + "0";
        }

        private void btnpunto_Click(object sender, EventArgs e)
        {
            txtpantalla.Text = txtpantalla.Text + ",";
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            txtpantalla.Text = txtpantalla.Text + "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txtpantalla.Text = txtpantalla.Text + "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            txtpantalla.Text = txtpantalla.Text + "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            txtpantalla.Text = txtpantalla.Text + "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            txtpantalla.Text = txtpantalla.Text + "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            txtpantalla.Text = txtpantalla.Text + "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            txtpantalla.Text = txtpantalla.Text + "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            txtpantalla.Text = txtpantalla.Text + "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            txtpantalla.Text = txtpantalla.Text + "9";
        }

        private void btnMultiplicacion_Click(object sender, EventArgs e)
        {
            operador = "*";
            primero = Convert.ToDouble(txtpantalla.Text);
            txtpantalla.Clear();
        }

        private void btnSuma_Click(object sender, EventArgs e)
        {
            operador = "+";
            primero = Convert.ToDouble(txtpantalla.Text);
            txtpantalla.Clear();
        }

        private void btnResta_Click(object sender, EventArgs e)
        {
            operador = "-";
            primero = Convert.ToDouble(txtpantalla.Text);
            txtpantalla.Clear();
        }

        private void btnDivision_Click(object sender, EventArgs e)
        {
            operador = "/";
            primero = Convert.ToDouble(txtpantalla.Text);
            txtpantalla.Clear();
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            segundo = Convert.ToDouble(txtpantalla.Text);

            double Suma;
            double Resta;
            double Multiplicacion;
            double Division;

            switch (operador)
            {
                case "+":
                    Suma = objeto1.Sumar((primero), (segundo));
                    txtresultado.Text = Suma.ToString();
                    break;

                case "-":
                    Resta = objeto2.Restar((primero), (segundo));
                    txtresultado.Text = Resta.ToString();
                    break;

                case "*":
                    Multiplicacion = objeto3.Multiplicar((primero), (segundo));
                    txtresultado.Text = Multiplicacion.ToString();
                    break;

                case "/":
                    Division = objeto4.Dividir((primero), (segundo));
                    txtresultado.Text = Division.ToString();
                    break;

            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtpantalla.Clear();
            txtresultado.Clear();
        }

        private void btnporcentaje_Click(object sender, EventArgs e)
        {
            segundo = Convert.ToDouble(txtpantalla.Text);

            double Porcentaje;

            Porcentaje = objeto5.Porcentuar((primero), (segundo));
            txtresultado.Text = Porcentaje.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnfactorial_Click(object sender, EventArgs e)
        {
            primero = Convert.ToDouble(txtpantalla.Text);

            double Factor;

            Factor = objeto6.Factorial((primero));
            txtpantalla.Text = Factor.ToString();
        }

        private void lblsalir_Click_1(object sender, EventArgs e)
        {

        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }

        private void lblsalir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Seguro(a) que desea salir del sistema?", "Calculadora",
                 MessageBoxButtons.YesNo,
                 MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}

