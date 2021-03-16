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
            String Resp = Invertir(txtPalabra.Text);
            lbResultado.Text = "Palabra Invertida: " + Resp;
        }

        private String Invertir(string palabra)
        {
            string PalabraInvr = "";
            foreach (char letra in palabra)
            {
                PalabraInvr = letra + PalabraInvr;
            }
            return PalabraInvr;
        }
    }
}
