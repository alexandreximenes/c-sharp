using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Alexandre.Cliente;
using Alexandre.Conta;

namespace FormularioContas
{
    public partial class FormConta : FormConta
    {
        public FormConta()
        {
            InitializeComponent();
        }
        
        private void btnSacar_Click(object sender, EventArgs e)
        {

            Cliente cliente = new Cliente(Convert.ToInt32(tbNumero.Text), tbTitular.Text);
            Conta conta = new Conta(cliente, Convert.ToDouble(tbSaldo.Text) );

            try {
                conta.Saca(Convert.ToDouble(tbValorSaque.Text));
                MessageBox.Show("Dinheiro liberado");
                tbSaldo.Text = Convert.ToString(conta.Saldo);
            }
            catch (Exception) {
                MessageBox.Show("Saldo Insuficiente");
            }
        }

    }
}
