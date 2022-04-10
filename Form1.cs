using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ex2crescente
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int num1, num2, num3, result;


        private void button1_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToInt32(textBox1.Text);
            num2 = Convert.ToInt32(textBox2.Text);
            num3 = Convert.ToInt32(textBox3.Text);

            if (num2 < num1)
            {
                result = num1;
                num1 = num2;
                num2 = result;
            }

            if (num3 < num1)
            {
                result = num1;
                num1 = num3;
                num3 = result;
            }

            if (num3 < num2)
            {
                result = num2;
                num2 = num3;
                num3 = result;
            }

            MessageBox.Show("Ordem crescente: " + num1 + " > " + num2 + " > " + num3, "Resultado do Cálculo");
        }
    }
}
