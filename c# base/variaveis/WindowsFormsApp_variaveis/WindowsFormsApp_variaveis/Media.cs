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
    public partial class Media : Form
    {
        public Media()
        {
            InitializeComponent();
        }

        [Test]
        private void button1_Click(object sender, EventArgs e)
        {
            double valor1, valor2, valor3;
            
            //incializando com zero 0
            valor1 = valor2 = valor3 = 0;

            try
            {
                valor1 = double.Parse(textBox1.Text);
                valor2 = double.Parse(textBox2.Text);
                valor3 = double.Parse(textBox3.Text);
            }
            catch (Exception) {  }

            double media = (valor1 + valor2 + valor3) / 3;

            //cast
            int mediaInt = (int)media;
            Console.WriteLine("Media INT : "+mediaInt);
            //Assert.AreEqual(typeof(Int16).Equals(typeof(mediaInt)), mediaInt);
            //MessageBox.Show("A média dos valores é: " + media);
            resultado.BackColor = Color.Red;
            resultado.Text = ""+media;

            // valor preenchido com numeros
            //Assert.AreEqual(valor1>0, valor1);

            //Verifica se todos os campos foram preenchidos com numeros
           // Assert.AreEqual(media>0, media);

            //Verifica a media é 100 - valor simbolico 
            Assert.AreEqual(100, media);

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Media_Load(object sender, EventArgs e)
        {

        }

        private void resultado_Click(object sender, EventArgs e)
        {

        }
    }
}
