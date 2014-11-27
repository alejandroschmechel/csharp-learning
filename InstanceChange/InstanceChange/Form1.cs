using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InstanceChange
{
    public partial class Form1 : Form
    {
        Elephant lucinda;
        Elephant lloyd;

        public Form1()
        {
            InitializeComponent();
            lucinda = new Elephant() { Name = "Lucinda", EarSize = 40 };
            lloyd = new Elephant() { Name = "Lloyd", EarSize = 89 };
        }

        private void lloydButton_Click(object sender, EventArgs e)
        {
            lloyd.WhoAmI();
        }

        private void lucindaButton_Click(object sender, EventArgs e)
        {
            lucinda.WhoAmI();
        }

        private void troca_Click(object sender, EventArgs e)
        {
            Elephant temp;
            temp = lloyd;
            lloyd = lucinda;
            lucinda = temp;
            MessageBox.Show("Instancias Invertidas");
        }
    }
}
