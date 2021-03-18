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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            Modulo2 IrModul = new Modulo2();
            this.Hide();
            IrModul.Show();
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            Modulo4 IrModul = new Modulo4();
            this.Hide();
            IrModul.Show();
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            Modulo6 IrModul = new Modulo6();
            this.Hide();
            IrModul.Show();
        }
    }
}
