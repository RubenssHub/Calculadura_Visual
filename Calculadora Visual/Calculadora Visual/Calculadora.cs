using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora_Visual
{
    public partial class Calculadora : Form
    {
        double primero;
        double segundo;
        string operador;
        public Calculadora()
        {
            InitializeComponent();
        }

        Clases.ClsSuma obj = new Clases.ClsSuma();
        Clases.ClsResta obj2 = new Clases.ClsResta();
        Clases.ClsMultiplicacion obj3 = new Clases.ClsMultiplicacion();
        Clases.ClsDivision obj4 = new Clases.ClsDivision();

        private void Btn0_Click(object sender, EventArgs e)
        {
            TxtBPantalla.Text = TxtBPantalla.Text + "0";
        }

        private void Btn1_Click(object sender, EventArgs e)
        {
            TxtBPantalla.Text = TxtBPantalla.Text + "1";
        }

        private void Btn2_Click(object sender, EventArgs e)
        {
            TxtBPantalla.Text = TxtBPantalla.Text + "2";
        }

        private void Btn3_Click(object sender, EventArgs e)
        {
            TxtBPantalla.Text = TxtBPantalla.Text + "3";
        }

        private void Btn4_Click(object sender, EventArgs e)
        {
            TxtBPantalla.Text = TxtBPantalla.Text + "4";
        }

        private void Btn5_Click(object sender, EventArgs e)
        {
            TxtBPantalla.Text = TxtBPantalla.Text + "5";
        }

        private void Btn6_Click(object sender, EventArgs e)
        {
            TxtBPantalla.Text = TxtBPantalla.Text + "6";
        }

        private void Btn7_Click(object sender, EventArgs e)
        {
            TxtBPantalla.Text = TxtBPantalla.Text + "7";
        }

        private void Btn8_Click(object sender, EventArgs e)
        {
            TxtBPantalla.Text = TxtBPantalla.Text + "8";
        }

        private void Btn9_Click(object sender, EventArgs e)
        {
            TxtBPantalla.Text = TxtBPantalla.Text + "9";
        }

        private void BtnDecimal_Click(object sender, EventArgs e)
        {
            TxtBPantalla.Text = TxtBPantalla.Text + ".";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void BtnSuma_Click(object sender, EventArgs e)
        {
            operador = "+";
            primero = double.Parse(TxtBPantalla.Text);
            TxtBPantalla.Clear();

        }

        private void BtnResta_Click(object sender, EventArgs e)
        {
            operador = "-";
            primero = double.Parse(TxtBPantalla.Text);
            TxtBPantalla.Clear();
        }

        private void BtnMultiplicacion_Click(object sender, EventArgs e)
        {
            operador = "*";
            primero = double.Parse(TxtBPantalla.Text);
            TxtBPantalla.Clear();
        }

        private void BtnDivision_Click(object sender, EventArgs e)
        {
            operador = "/";
            primero = double.Parse(TxtBPantalla.Text);
            TxtBPantalla.Clear();
        }

        private void BtnResultado_Click(object sender, EventArgs e)
        {
            segundo = double.Parse(TxtBPantalla.Text);

            double Suma;
            double Resta;
            double Multiplicacion;
            double Division;

            switch(operador)
            {
                case "+":
                    Suma = obj.Sumar((primero), (segundo));
                    TxtBPantalla.Text = Suma.ToString();
                    break;
                case "-":
                    Resta = obj2.Restar((primero), (segundo));
                    TxtBPantalla.Text = Resta.ToString();
                    break;
                case "*":
                    Multiplicacion = obj3.Multiplicacion((primero), (segundo));
                    TxtBPantalla.Text = Multiplicacion.ToString();
                    break;
                case "/":
                    Division = obj4.Division((primero), (segundo));
                    TxtBPantalla.Text = Division.ToString();
                    break;
            }
        }
    }
}
