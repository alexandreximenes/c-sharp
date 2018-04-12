using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WindowsFormsApp_Estrutura_de_controle
{
    public partial class saldo : Form
    {
        public saldo()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Modo 1
            double saldo = 100.0;
            double valorSaque = 10.0;

            bool realmentePodeSacar = (saldo >= valorSaque) && (valorSaque > 0);
            if (realmentePodeSacar)
            {
                // código do saque
                saldo -= valorSaque;
                MessageBox.Show("Saldo realizado com sucesso");
                MessageBox.Show("Seu novo saldo é: " + saldo);
            }
            else
            {
                MessageBox.Show("Saldo Insuficiente");
            }

            // Modo 2
            double resultado = (saldo >= valorSaque) ? saldo -= valorSaque : 0;

            MessageBox.Show("Resultado =="+resultado);
        }
    }
}
