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
    public partial class CadastroContas : Form
    {
        private FormConta AplicacaoPrincipal;
        public CadastroContas(FormConta formConta)
        {
            InitializeComponent();
            this.AplicacaoPrincipal = formConta;
        }

        private void btCadastrar_Click(object sender, EventArgs e)
        {
            string titular = tbTitular.Text;
            int numero = 0;
            double saldo = 0;
            try
            {
                numero = Convert.ToInt32(tbNumero.Text);
            }
            catch (Exception) {
                Console.WriteLine("Não conseguiu converter o numero da conta " );
            }

            try
            {
                saldo = Convert.ToDouble(tbSaldoInicial.Text);
            }
            catch (Exception)
            {
                Console.WriteLine("Não conseguiu converter o saldo inicial da conta ");
            }

            Conta conta = new ContaCorrente(new Cliente(numero, titular), saldo);
            AplicacaoPrincipal.AdicionaConta(conta);

        }

        private void btTelaPrincipal_Click(object sender, EventArgs e)
        {
            new FormConta().Show();
        }
    }
}
