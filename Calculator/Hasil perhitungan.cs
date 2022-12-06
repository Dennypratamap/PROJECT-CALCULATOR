using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void proses(int nilaiA, int nilaiB, string operasi, string operasiLabel, float hasil)
        {
            listBox.Items.Add(
                String.Format($"Hasil {operasiLabel} dari {nilaiA} {operasi} {nilaiB} = ") +
                String.Format(hasil % 1 == 0 ? "{0:0}" : "{0:0.00}", hasil)
            );
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Calculator formCalculator = new Calculator();
            formCalculator.prosesEvent += proses;
            formCalculator.ShowDialog();
        }
    }
}
