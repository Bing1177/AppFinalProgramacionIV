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
    public partial class Modulo6 : Form
    {
        public Modulo6()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtNum.Text != "")
            {
                String Resp = SumNum(txtNum.Text); //Invocar funcion para la suma dificil
                lbResultado.Text = "Resultado: " + Resp; //Mostrar resultado
            }
            else 
            {
                MessageBox.Show("por favor llenar campos :)");
            }
            
        }

        private String SumNum(string ConvertNum)
        {
            ConvertNum = ConvertNum + " "; //Para que sume el ultimo numero
            string Numeros = null; //Donde se guardara el numero antes de sumar
            double resultado = 0;
            string result;
            //Recorrer el string
            foreach (char Unidad in ConvertNum)
            {
                //Para crear el numero
                if (Unidad == '1' || Unidad == '2' || Unidad == '3' || Unidad == '4' || Unidad == '5' || Unidad == '6' || Unidad == '7' || Unidad == '8' || Unidad == '9' || Unidad == '0' || Unidad == '.' || Unidad == ',')
                {
                    Numeros = Numeros + Unidad;
                }
                else if (Unidad == ' ') //Sumar los numeros cuando se encuentre con un espacio
                {
                    resultado = Convert.ToDouble(Numeros) + resultado;
                    Numeros = null; //Limpiar variable
                }
                else {
                    return "Error con caracteres no esperados"; //En caso de tener letras o algun caracter no numerico para el ejercicio
                }
            }
            result = Convert.ToString(resultado);
            return result;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 IrModul = new Form1();
            this.Hide();
            IrModul.Show();
        }
    }
}
