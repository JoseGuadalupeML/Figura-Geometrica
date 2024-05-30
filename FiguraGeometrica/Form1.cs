using FiguraGeometrica.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FiguraGeometrica
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                Datos.Image = Properties.Resources.Cuadrado;
            }
            else if (radioButton2.Checked)
            {
                Datos.Image = Properties.Resources.Triangulo;
            }
            else if (radioButton3.Checked)
            {
                Datos.Image = Properties.Resources.rectangulo;
            }
            else if (radioButton4.Checked)
            {
                if (textBox1.Text == "5")
                {
                    Datos.Image = Properties.Resources.poligono5;
                }
                if (textBox1.Text == "6")
                {
                    Datos.Image = Properties.Resources.poligono6;
                }
                if (textBox1.Text == "7")
                {
                    Datos.Image = Properties.Resources.poligono7;
                }
                if (textBox1.Text == "8")
                {
                    Datos.Image = Properties.Resources.poligono8;
                }
                if (textBox1.Text == "")
                {
                    MessageBox.Show("Ingrese el numero de lados en el cuadro de texto");
                }
            }
            else if (radioButton5.Checked)
            {

            }
            else if (radioButton6.Checked)
            {
                Datos.Image = Properties.Resources.Circulo;
            }
            else if (radioButton7.Checked)
            {
                Datos.Image = Properties.Resources.Cubo;
            }
            else if (radioButton8.Checked)
            {
                
            }
            else
            {
                Datos.Image = Properties.Resources.esfera;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            Datos.Image = Properties.Resources.bienvenida;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                MessageBox.Show("Datos Guadados" + "\nLado: " + textBox1.Text);
            }
            else if (radioButton2.Checked)
            {
                MessageBox.Show("Datos Guadados" + "\nBase: " + textBox1.Text + "\nAltura: " + textBox1.Text);
            }
            else if (radioButton3.Checked)
            {
                MessageBox.Show("Datos Guadados" + "\nBase: " + textBox1.Text + "\nAltura: " + textBox1.Text);
            }
            else if (radioButton4.Checked)
            {
                MessageBox.Show("Datos Guadados" + "\nApotema: " + textBox1.Text + "\nNumero lados: " + textBox1.Text);
            }
            else if (radioButton5.Checked)
            {
                MessageBox.Show("Datos Guadados" + "\nApotema: " + textBox1.Text + "\nNumero lados: " + textBox1.Text);
            }
            else if (radioButton6.Checked)
            {
                MessageBox.Show("Datos Guadados" + "\nRadio: " + textBox1.Text);
            }
            else if (radioButton7.Checked)
            {
                MessageBox.Show("Datos Guadados" + "\nAristas: " + textBox1.Text);
            }
            else if (radioButton8.Checked)
            {
                MessageBox.Show("Datos Guadados" + "\nLado: " + textBox1.Text);
            }
            else
            {
                MessageBox.Show("Datos Guadados" + "\nRadio: " + textBox1.Text);
            }
        }
    }
}
