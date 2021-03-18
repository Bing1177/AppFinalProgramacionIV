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
    public partial class Modulo4 : Form
    {
        public Modulo4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtPalabra.Text != "") //oblicar al usuario a llenar campos
            {
                String Resp = Invertir(txtPalabra.Text); //Invocar funcion
                lbResultado.Text = "Palabra Invertida: " + Resp; //Mostrar resultado
            }
            else
            {
                MessageBox.Show("por favor llenar campos :)");
            }
            
        }

        private String Invertir(string palabra)
        {
            string PalabraInvr = ""; //Variable para almacenar palabra invertida
            foreach (char letra in palabra)
            {
                PalabraInvr = letra + PalabraInvr; //Invertir palabra
            }
            return PalabraInvr;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 IrModul = new Form1();
            this.Hide();
            IrModul.Show();
        }
    }
}
