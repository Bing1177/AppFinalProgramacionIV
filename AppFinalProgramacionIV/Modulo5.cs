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
    public partial class Modulo5 : Form
    {
        public Modulo5()
        {
            InitializeComponent();
        }

        private void btnregresar_Click(object sender, EventArgs e)
        {
            Form1 formaSiguiente = new Form1();
            this.Hide(); //oculta la forma actual
            formaSiguiente.Show(); // muestra el formulario principal
        }

        private void btningresar_Click(object sender, EventArgs e)
        {
            String frase;
            bool pangrama = true;
            for (int i = 0; i < 1; i++, pangrama = true)
            {
                frase = txtfrase.Text;
                for (char letra = 'A'; letra <= 'Z'; letra++)
                {
                    if (!frase.ToUpper().Contains("" + letra))
                    {
                        pangrama = false;
                        break;
                    }
                }
                MessageBox.Show((pangrama ? "SI" : "NO"));
                txtfrase.Text = "";
            }
        }
        //La función toupper() toma un carácter y devuelve su versión en mayúscula (si es que existe). Cuando el carácter no tiene versión en mayúscula, entonces se devuelve el argumento sin modificaciones
        // La función contains () devuelve un valor que indica si un carácter especificado aparece dentro de esta cadena, mediante las reglas de comparación especificadas.
    }
}
