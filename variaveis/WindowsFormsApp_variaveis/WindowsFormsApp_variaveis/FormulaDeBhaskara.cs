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

namespace WindowsFormsApp_variaveis
{
    [TestFixture]
    public partial class FormulaDeBhaskara : Form
    {
        public FormulaDeBhaskara()
        {
            InitializeComponent();
        }
        [Test]
        private void button1_Click(object sender, EventArgs e)
        {
            int a, b, c;
            try
            {
                a = int.Parse(textBox1.Text);
                b = int.Parse(textBox2.Text); 
                c = int.Parse(textBox3.Text);
           
            double delta;
            double a1;
            double a2;


            delta = b * b - 4 * a * c;
            a1 = (-b + Math.Sqrt(delta)) / (2 * a);
            a2 = (-b - Math.Sqrt(delta)) / (2 * a);

            //MessageBox.Show("Resultado 1: " + a1);
            //MessageBox.Show("Resultado 2: " + a2);

            resultado.ForeColor = Color.Red;
            resultado.Text = "";
            resultado.Text += "A1 : " + a1 + "\nA2 : " + a2;

            }
            catch (Exception) { }
            

        }
    }
}
