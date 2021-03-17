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
    public partial class Modulo1 : Form
    {
        public Modulo1()
        {
            InitializeComponent();
        }

        private void btningresar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtn1.Text) || (string.IsNullOrEmpty(txtn2.Text)))
            {
                MessageBox.Show("Verifique los campos");
            }
            else
            {
                int num1 = Int32.Parse(txtn1.Text);
                int num2 = Int32.Parse(txtn2.Text);
                if (num1 > num2)
                {
                    MessageBox.Show("El número uno es el mayor");
                    txtn1.Text = "";
                    txtn2.Text = "";
                }
                else if (num2 > num1)
                {
                    MessageBox.Show("El número dos es el mayor");
                    txtn1.Text = "";
                    txtn2.Text = "";
                }
                else
                {
                    MessageBox.Show("Los números son iguales");
                    txtn1.Text = "";
                    txtn2.Text = "";
                }
            }
        }

        private void btnregresar_Click(object sender, EventArgs e)
        {
            Form1 formaSiguiente = new Form1();
            this.Hide(); //oculta la forma actual
            formaSiguiente.Show(); // muestra el formulario principal
        }
    }
}
