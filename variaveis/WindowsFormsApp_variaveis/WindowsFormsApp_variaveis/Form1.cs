using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NUnit.Framework;

/// <summary>
/// Simulando teste TDD  
/// </summary>

namespace WindowsFormsApp_variaveis
{
    [TestFixture]
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        [Test]
        private void button1_Click(object sender, EventArgs e)
        {
            int numeroConta = 0001;
            double saldo = 1000.00;
            
            //Somando com shortcut
            saldo += 500.00;
            double saldoAtual = saldo - 100.00;
            
            //Saldo esperado para teste
            double saldoEsperado = 1400.00;
            
            //com exito
            Assert.AreEqual(saldoEsperado, saldoAtual);
            
            //com falha
            //Assert.AreEqual(1500, saldoAtual);
            MessageBox.Show("Meu saldo atual da conta " + numeroConta +" é R$ " + saldoAtual);
        }
    }
}
