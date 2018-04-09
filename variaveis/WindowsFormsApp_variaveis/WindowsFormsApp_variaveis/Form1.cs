using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp_variaveis
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int NumeroConta = 0001;
            double Saldo = 1000.00;
            double SaldoAtual = Saldo - 100.00;
            MessageBox.Show("Meu saldo atual da conta " + NumeroConta +" é R$ " + SaldoAtual);
        }
    }
}
