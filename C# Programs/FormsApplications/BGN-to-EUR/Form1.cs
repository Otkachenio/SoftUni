using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BGN_to_EUR
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Convert();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDownBGNtoEUR_ValueChanged(object sender, EventArgs e)
        {
            Convert();
        }

        private void labelConvertedMoney_Click(object sender, EventArgs e)
        {
           
        }

        void Convert()
        {
            var amount = numericUpDownBGNtoEUR.Value;
            var amountInEuro = amount / 1.95583m;
            labelConvertedMoney.Text = (amount + " leva" + " = " + 
                Math.Round(amountInEuro, 2) + " Euro");
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            Convert();
        }
    }
}
