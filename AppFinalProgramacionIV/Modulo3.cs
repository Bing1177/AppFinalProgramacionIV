using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppFinalProgramacionIV
{
    public partial class Modulo3 : Form
    {
        public Modulo3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 formaSiguiente = new Form1();
            this.Hide(); //oculta la forma actual
            formaSiguiente.Show(); // muestra el formulario del modulo1
        }

        private void btningresar_Click(object sender, EventArgs e)
        {
            String frase = txtfrase.Text;
            String letra = txtletra.Text;
            String nombre = "";
            int cont = 0;
            if (string.IsNullOrEmpty(txtfrase.Text) || (string.IsNullOrEmpty(txtletra.Text)))
            {
                MessageBox.Show("Verifique los campos");
            }
            else
            {
                for (int i = 0; i < frase.Length; i++)
                {
                    char caracter = frase[i];
                    nombre = nombre + caracter;

                    if (nombre.Contains(letra))
                    {
                        cont++;
                        nombre = "";

                    }
                }
                MessageBox.Show("la letra " + letra + " aparace " + cont + " veces");
                txtletra.Text = "";
                txtfrase.Text = "";
            }

        }
    }
}
