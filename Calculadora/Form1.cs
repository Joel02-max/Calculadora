using System;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        private double num1, num2, res;
        private string ope;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text += "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text += "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text += "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text += "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text += "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text += "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text += "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text += "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text += "9";
        }

        private void button0_Click(object sender, EventArgs e)
        {
            textBox1.Text += "0";
        }

        private void buttonPunto_Click(object sender, EventArgs e)
        {
            if (!textBox1.Text.Contains("."))
            {
                textBox1.Text += ".";
            }
        }

        private void buttonSuma_Click(object sender, EventArgs e)
        {
            try
            {
                num1 = Convert.ToDouble(textBox1.Text);
                ope = "+";
                textBox1.Text += " + "; // Muestra la operación en el TextBox
            }
            catch (Exception)
            {
                MessageBox.Show("Error en la entrada de datos.");
            }
        }

        private void buttonResta_Click(object sender, EventArgs e)
        {
            try
            {
                num1 = Convert.ToDouble(textBox1.Text);
                ope = "-";
                textBox1.Text += " - "; // Muestra la operación en el TextBox
            }
            catch (Exception)
            {
                MessageBox.Show("Error en la entrada de datos.");
            }
        }

        private void buttonMultip_Click(object sender, EventArgs e)
        {
            try
            {
                num1 = Convert.ToDouble(textBox1.Text);
                ope = "*";
                textBox1.Text += " * "; // Muestra la operación en el TextBox
            }
            catch (Exception)
            {
                MessageBox.Show("Error en la entrada de datos.");
            }
        }

        private void buttonDivision_Click(object sender, EventArgs e)
        {
            try
            {
                num1 = Convert.ToDouble(textBox1.Text);
                ope = "/";
                textBox1.Text += " / "; // Muestra la operación en el TextBox
            }
            catch (Exception)
            {
                MessageBox.Show("Error en la entrada de datos.");
            }
        }

        private void buttonIgual_Click(object sender, EventArgs e)
        {
            try
            {
                // Extraer el segundo número de la cadena en el TextBox
                string[] parts = textBox1.Text.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                if (parts.Length < 3)
                {
                    MessageBox.Show("Error: operación incompleta.");
                    return;
                }

                num1 = Convert.ToDouble(parts[0]);
                num2 = Convert.ToDouble(parts[2]);

                switch (parts[1]) // Usar el operador de la cadena
                {
                    case "+":
                        res = num1 + num2;
                        break;
                    case "-":
                        res = num1 - num2;
                        break;
                    case "*":
                        res = num1 * num2;
                        break;
                    case "/":
                        if (num2 != 0)
                            res = num1 / num2;
                        else
                        {
                            MessageBox.Show("Error: División entre cero.");
                            return;
                        }
                        break;
                    default:
                        MessageBox.Show("Seleccione una operación.");
                        return;
                }
                textBox1.Text = res.ToString(); // Muestra el resultado
            }
            catch (Exception)
            {
                MessageBox.Show("Error en la operación.");
            }
        }

        private void buttonLimpiar_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            num1 = num2 = res = 0;
            ope = "";
        }
    }
}