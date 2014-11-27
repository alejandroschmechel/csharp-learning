﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KMCalculator
{
    public partial class Form1 : Form
    {
        int startingMileage,
            endingMileage;
        double milesTraveled,
            amountOwed,
            reimburseRate = 0.39;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            startingMileage = (int) initialKM.Value;
            endingMileage = (int) finalKM.Value;
            if(startingMileage <= endingMileage){
                milesTraveled = endingMileage - startingMileage;
                amountOwed = milesTraveled * reimburseRate;
                label4.Text = "$" + amountOwed;
            }
            else{
                MessageBox.Show("The initial kilometrage must be shorter than the final", "Não consigo calcular a milhagem");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Foram viajados: " + milesTraveled + "Kms");
        }
    }
}
