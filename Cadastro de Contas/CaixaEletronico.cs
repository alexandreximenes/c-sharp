using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MinhasContas
{
    public partial class FormConta : Form
    {
        private Conta conta;
        private List<Conta> contas = new List<Conta>();
        

        public FormConta()
        {
            InitializeComponent();
        }

        
        private void btnSacar_Click(object sender, EventArgs e)
        {

            Cliente cliente = new Cliente(Convert.ToInt32(tbNumero.Text), tbTitular.Text);
            conta = new ContaCorrente(cliente, Convert.ToDouble(tbSaldo.Text) );
            contas.Add(conta);
            try {
                conta.Saca(Convert.ToDouble(tbValorSaque.Text));
                MessageBox.Show("Dinheiro liberado");
                tbSaldo.Text = Convert.ToString(conta.Saldo);
            }
            catch (Exception) {
                MessageBox.Show("Saldo Insuficiente");
            }
        }

        internal void AdicionaConta(Conta conta)
        {
            contas.Add(conta);
            contas.ForEach(c => comboboxCliente.Items.Add(c.Cliente.Nome));

            //Trabalhando com HashSet
         /*   var contas2 = new HashSet<Conta>(contas);
            foreach (Conta c in contas2) {
                MessageBox.Show(""+c);
            }
         */ 
        }

        private void btCadastrarCliente_Click(object sender, EventArgs e)
        {
            new CadastroContas(this).ShowDialog();
        }

        private void comboboxCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboboxCliente.SelectedIndex >= 0)
            {
                MessageBox.Show(""+contas.Count());
                Conta conta = contas[comboboxCliente.SelectedIndex];
                tbTitular.Text = conta.Cliente.Nome;
                tbNumero.Text = Convert.ToString(conta.Cliente.Numero);
                tbSaldo.Text = Convert.ToString(conta.Saldo);
            }
            else
            {
                MessageBox.Show("Não capturou o indice corretamente");
            }
        }
    }

}
