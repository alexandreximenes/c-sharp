using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrabalhandoComCombobox
{
    public partial class Form1 : Form
    {
        Conta[] contas;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            contas = new Conta[3];
            Cliente alexandre = new Cliente("Alexandre Ximenes");
            contas[0] = new Conta();
            contas[0].Numero = 1;
            contas[0].Cliente = alexandre;

            contas[1] = new Conta();
            Cliente arthur = new Cliente("Arthur Ximenes");
            contas[1].Numero = 2;
            contas[1].Cliente = arthur;

            contas[2] = new Conta();
            Cliente vitoria = new Cliente("Vitoria Barros");
            contas[2].Numero = 1;
            contas[2].Cliente = vitoria;

            //For Enhanced 
            foreach (Conta conta in contas) {
                comboContas.Items.Add(conta.Cliente.Nome);
            }

        }

        private void comboContas_SelectedIndexChanged(object sender, EventArgs e)
        {
            Conta conta = contas[comboContas.SelectedIndex];
            textBox1.Text = conta.Cliente.Nome;
            textBox2.Text = Convert.ToString(conta.Numero);
            textBox3.Text = Convert.ToString(conta.Saldo);
        }
    }
}
