using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String name = "Quentin";
            int x = 3;
            x = x * 17;
            double d = Math.PI / 2;
            MessageBox.Show("nome é: " + name +
                "\nx é:" + x +
                "\nd é:" + d);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int x = 5;
            if (x == 10)
            {
                MessageBox.Show("X necessita ser 10");
            }
            else
            {
                MessageBox.Show("X não é 10");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int someValue = 2;
            String name = "Joe";
            if((someValue < 3) && (name.Equals("Joe")))
            {
                MessageBox.Show("X é menor que 3 e o nome é Joe");
            }
            MessageBox.Show("Essa aqui mostra sempre");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int count = 0;
            while (count < 10)
            {
                count++;
                //MessageBox.Show("O Resultado é: " + count);
            }
            MessageBox.Show("O Resultado é: " + count);
        } 
    }
}
