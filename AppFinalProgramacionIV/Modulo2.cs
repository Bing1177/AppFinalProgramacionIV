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
    public partial class Modulo2 : Form
    {
        public Modulo2()
        {
            InitializeComponent();
        }

        private void Modulo2_Load(object sender, EventArgs e)
        {

        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            if ((txtBase.Text!="")&&(txtAltura.Text!="")) //hacer que el usuario llene campos
            {
                int Area = CalcArea(Convert.ToInt32(txtBase.Text), Convert.ToInt32(txtAltura.Text)); //Invocar funcion
                lbArea.Text = "Área: " + Area + "m"; //Mostrar resultados
            }
            else
            {
                MessageBox.Show("por favor llenar campos :)");
            }
        }

        private int CalcArea(int b, int a) //calcular area
        {
            return b * a;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 IrModul = new Form1();
            this.Hide();
            IrModul.Show();
        }
    }
}
