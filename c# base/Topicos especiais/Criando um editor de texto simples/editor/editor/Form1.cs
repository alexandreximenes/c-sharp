using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace editor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (File.Exists("entrada.txt"))
            {
                Stream entrada = null;
                StreamReader leitor = null;
                try
                {
                    entrada = File.Open("entrada.txt", FileMode.Open);
                    leitor = new StreamReader(entrada);
                    string linha = leitor.ReadLine();

                    while (linha != null)
                    {
                        texto.Text += linha;
                        linha = leitor.ReadLine();
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Problemas ao ler o arquivo!");
                }
                finally { 
                    leitor.Close();
                    entrada.Close();
                }
            }
            else {
                MessageBox.Show("arquivo inexistente!");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Stream saida = null;
            StreamWriter escritor = null;
            try
            {
                saida = File.Open("entrada.txt", FileMode.Create);
                escritor = new StreamWriter(saida);
                escritor.Write(texto.Text);

                MessageBox.Show("Arquivo gravado com sucesso");

            }
            catch (Exception)
            {
                MessageBox.Show("Erro ao gravar arquivo!");
            }
            finally {
                escritor.Close();
                saida.Close();
            }

        }
    }
}
