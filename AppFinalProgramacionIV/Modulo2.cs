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
            int Area;
            if ((txtBase.Text!="")&&(txtAltura.Text!=""))
            {
                Area = CalcArea(Convert.ToInt32(txtBase.Text), Convert.ToInt32(txtAltura.Text));
                lbArea.Text = "Área: " + Area + "m";
            }
            else
            {
                MessageBox.Show("por favor llenar campos :)");
            }
        }

        private int CalcArea(int b, int a) {
            return b * a;
        }
    }
}
