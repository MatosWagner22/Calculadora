using System;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        double First, Second;
        string op;
        public Form1()
        {
            InitializeComponent();
        }

        Clases.ClassOp Operacion = new Clases.ClassOp();


        private void NO0_Click(object sender, EventArgs e)
        {
            TBXSCREEN.Text += "0";
        }

        private void NO1_Click(object sender, EventArgs e)
        {
            TBXSCREEN.Text += "1";
        }

        private void NO2_Click(object sender, EventArgs e)
        {
            TBXSCREEN.Text += "2";
        }

        private void NO3_Click(object sender, EventArgs e)
        {
            TBXSCREEN.Text += "3";
        }

        private void NO4_Click(object sender, EventArgs e)
        {
            TBXSCREEN.Text += "4";
        }

        private void NO5_Click(object sender, EventArgs e)
        {
            TBXSCREEN.Text += "5";
        }

        private void NO6_Click(object sender, EventArgs e)
        {
            TBXSCREEN.Text += "6";
        }

        private void NO7_Click(object sender, EventArgs e)
        {
            TBXSCREEN.Text += "7";
        }

        private void NO8_Click(object sender, EventArgs e)
        {
            TBXSCREEN.Text += "8";
        }

        private void NO9_Click(object sender, EventArgs e)
        {
            TBXSCREEN.Text += "9";
        }

        private void suma_Click(object sender, EventArgs e)
        {
            op = "+";
            First = double.Parse(TBXSCREEN.Text);
            TBXSCREEN.Clear();
        }

        private void resta_Click(object sender, EventArgs e)
        {
            op = "-";
            First = double.Parse(TBXSCREEN.Text);
            TBXSCREEN.Clear();
        }

        private void multiplicacion_Click(object sender, EventArgs e)
        {
            op = "*";
            First = double.Parse(TBXSCREEN.Text);
            TBXSCREEN.Clear();
        }

        private void division_Click(object sender, EventArgs e)
        {
            op = "/";
            First = double.Parse(TBXSCREEN.Text);
            TBXSCREEN.Clear();
        }

        private void resultado_Click(object sender, EventArgs e)
        {
            Second = double.Parse(TBXSCREEN.Text);
            double sum, res, mul, div;

            switch (op)
            {
                case "+":
                    sum = Operacion.Sumar((First), (Second));
                    TBXSCREEN.Text = sum.ToString();
                    break;
                case "-":
                    res = Operacion.Sumar((First), (Second));
                    TBXSCREEN.Text = res.ToString();
                    break;
                case "*":
                    mul = Operacion.Sumar((First), (Second));
                    TBXSCREEN.Text = mul.ToString();
                    break;
                case "/":
                    div = Operacion.Sumar((First), (Second));
                    TBXSCREEN.Text = div.ToString();
                    break;
            }
        }

        private void limpiar_Click(object sender, EventArgs e)
        {
            TBXSCREEN.Clear();
        }

        private void borrar_Click(object sender, EventArgs e)
        {
            if (TBXSCREEN.Text.Length == 1)
                TBXSCREEN.Text = "";
            else
                TBXSCREEN.Text = TBXSCREEN.Text.Substring(0, TBXSCREEN.Text.Length - 1);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
