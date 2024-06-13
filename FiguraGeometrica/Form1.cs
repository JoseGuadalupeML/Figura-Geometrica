using FiguraGeometrica.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
                Datos.Image = Properties.Resources.prisma;
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
            informacion.Clear();
            textBox1.Clear();
            Datos.Image = Properties.Resources.bienvenida;
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;
            radioButton4.Checked = false;
            radioButton5.Checked = false;
            radioButton6.Checked = false;
            radioButton7.Checked = false;
            radioButton8.Checked = false;
            radioButton9.Checked = false;
            if (MessageBox.Show("¿Deseas salir de la aplicación?", "Aviso",MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("DATOS GUARDADOS" + textBox1.Text, "Datos de alumnos",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                string fileName = @"C:\Users\mezal\OneDrive\Escritorio\POO2\Cajero ATM\FiguraGeometrica\Datos.txt";
                StreamWriter writer = File.AppendText(fileName);
                writer.WriteLine("Datos: " + informacion.Text);
                writer.WriteLine("\n");
                writer.Close();
            }
            catch
            {
                MessageBox.Show("Error al guardar Datos en el Archivo", "ERROR",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (MessageBox.Show("¿Deseas salir de la aplicacion?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                informacion.Text = "Figura seleccionada: Cuadrado, " + "\n" + "Sus datos son: " + "\n" + "Longitud del lado: " + textBox1.Text;
            }
            else if (radioButton2.Checked)
            {
                informacion.Text = "Figura seleccionada Triangulo, " + "\n" + "Sus datos son:" + "\n" + textBox1.Text;
            }
            else if (radioButton3.Checked)
            {
                informacion.Text = "Figura seleccionada Rectangulo, " + "\n" + "Sus datos son:" + "\n" + textBox1.Text;
            }
            else if (radioButton4.Checked)
            {
                informacion.Text = "Figura seleccionada Poligono Regular, " + "\n" + "Sus datos son:" + "\n" + textBox1.Text;
            }
            else if (radioButton5.Checked)
            {
                informacion.Text = "Figura seleccionada Poligono Regular, " + "\n" + "Sus datos son:" + "\n" + textBox1.Text;
            }
            else if (radioButton6.Checked)
            {
                informacion.Text = "Figura seleccionada Circulo, " + "\n" + "Sus datos son:" + "\n" + textBox1.Text;
            }
            else if (radioButton7.Checked)
            {
                informacion.Text = "Figura seleccionada Cubo, " + "\n" + "Sus datos son:" + "\n" + textBox1.Text;
            }
            else if (radioButton8.Checked)
            {
                informacion.Text = "Figura seleccionada Prisma, " + "\n" + "Sus datos son:" + "\n" + textBox1.Text;
            }
            else if (radioButton9.Checked)
            {
                informacion.Text = "Figura seleccionada Esfera, " + "\n" + "Sus datos son:" + "\n" + textBox1.Text;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                informacion.Text = informacion.Text + "\n" + "Area= " + "\n" + "Perimetro= " + "\n" + "Volumen, no se calcula en figuras planas" + "\n";
            }
            else if (radioButton2.Checked)
            {
                informacion.Text = informacion.Text + "\n" + "Area= " + "\n" + "Perimetro= " + "\n" + "Volumen, no se calcula en figuras planas" + "\n";
            }
            else if (radioButton3.Checked)
            {
                informacion.Text = informacion.Text + "\n" + "Area= " + "\n" + "Perimetro= " + "\n" + "Volumen, no se calcula en figuras planas" + "\n";
            }
            else if (radioButton4.Checked)
            {
                informacion.Text = informacion.Text + "\n" + "Area= " + "\n" + "Perimetro= " + "\n" + "Volumen, no se calcula en figuras planas" + "\n";
            }
            else if (radioButton5.Checked)
            {
                informacion.Text = informacion.Text + "\n" + "Area= " + "\n" + "Perimetro= " + "\n" + "Volumen, no se calcula en figuras planas" + "\n";
            }
            else if (radioButton6.Checked)
            {
                informacion.Text = informacion.Text + "\n" + "Area= " + "\n" + "Perimetro= " + "\n" + "Volumen, no se calcula en figuras planas" + "\n";
            }
            else if (radioButton7.Checked)
            {
                informacion.Text = informacion.Text + "\n" + "Area= " + "\n" + "Perimetro no definido" + "\n" + "Volumen= ";
            }
            else if (radioButton8.Checked)
            {
                informacion.Text = informacion.Text + "\n" + "Area= " + "\n" + "Perimetro no definido" + "\n" + "Volumen= ";
            }
            else if (radioButton9.Checked)
            {
                informacion.Text = informacion.Text + "\n" + "Area= " + "\n" + "Perimetro no definido" + "\n" + "Volumen= ";
            }
        }
    }
}
