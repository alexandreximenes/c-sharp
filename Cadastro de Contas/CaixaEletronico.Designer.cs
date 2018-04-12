namespace MinhasContas
{
    partial class FormConta
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.tbNumero = new System.Windows.Forms.TextBox();
            this.tbTitular = new System.Windows.Forms.TextBox();
            this.tbSaldo = new System.Windows.Forms.TextBox();
            this.tbValorSaque = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSacar = new System.Windows.Forms.Button();
            this.btCadastrarCliente = new System.Windows.Forms.Button();
            this.comboboxCliente = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbNumero
            // 
            this.tbNumero.Location = new System.Drawing.Point(111, 63);
            this.tbNumero.Name = "tbNumero";
            this.tbNumero.Size = new System.Drawing.Size(142, 20);
            this.tbNumero.TabIndex = 0;
            // 
            // tbTitular
            // 
            this.tbTitular.Location = new System.Drawing.Point(111, 98);
            this.tbTitular.Name = "tbTitular";
            this.tbTitular.Size = new System.Drawing.Size(142, 20);
            this.tbTitular.TabIndex = 1;
            // 
            // tbSaldo
            // 
            this.tbSaldo.Location = new System.Drawing.Point(111, 133);
            this.tbSaldo.Name = "tbSaldo";
            this.tbSaldo.Size = new System.Drawing.Size(142, 20);
            this.tbSaldo.TabIndex = 2;
            // 
            // tbValorSaque
            // 
            this.tbValorSaque.Location = new System.Drawing.Point(111, 198);
            this.tbValorSaque.Name = "tbValorSaque";
            this.tbValorSaque.Size = new System.Drawing.Size(142, 20);
            this.tbValorSaque.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Numero da Conta";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Titular";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Saldo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 201);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Valor do Saque";
            // 
            // btnSacar
            // 
            this.btnSacar.Location = new System.Drawing.Point(134, 246);
            this.btnSacar.Name = "btnSacar";
            this.btnSacar.Size = new System.Drawing.Size(119, 26);
            this.btnSacar.TabIndex = 8;
            this.btnSacar.Text = "Sacar";
            this.btnSacar.UseVisualStyleBackColor = true;
            this.btnSacar.Click += new System.EventHandler(this.btnSacar_Click);
            // 
            // btCadastrarCliente
            // 
            this.btCadastrarCliente.Location = new System.Drawing.Point(18, 246);
            this.btCadastrarCliente.Name = "btCadastrarCliente";
            this.btCadastrarCliente.Size = new System.Drawing.Size(110, 26);
            this.btCadastrarCliente.TabIndex = 9;
            this.btCadastrarCliente.Text = "Cadastrar Cliente";
            this.btCadastrarCliente.UseVisualStyleBackColor = true;
            this.btCadastrarCliente.Click += new System.EventHandler(this.btCadastrarCliente_Click);
            // 
            // comboboxCliente
            // 
            this.comboboxCliente.FormattingEnabled = true;
            this.comboboxCliente.Location = new System.Drawing.Point(111, 30);
            this.comboboxCliente.Name = "comboboxCliente";
            this.comboboxCliente.Size = new System.Drawing.Size(142, 21);
            this.comboboxCliente.TabIndex = 10;
            this.comboboxCliente.SelectedIndexChanged += new System.EventHandler(this.comboboxCliente_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Escolha a conta";
            // 
            // FormConta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(276, 362);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboboxCliente);
            this.Controls.Add(this.btCadastrarCliente);
            this.Controls.Add(this.btnSacar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbValorSaque);
            this.Controls.Add(this.tbSaldo);
            this.Controls.Add(this.tbTitular);
            this.Controls.Add(this.tbNumero);
            this.Name = "FormConta";
            this.Text = "Simulador de saque";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbNumero;
        private System.Windows.Forms.TextBox tbTitular;
        private System.Windows.Forms.TextBox tbSaldo;
        private System.Windows.Forms.TextBox tbValorSaque;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSacar;
        private System.Windows.Forms.Button btCadastrarCliente;
        private System.Windows.Forms.ComboBox comboboxCliente;
        private System.Windows.Forms.Label label5;
    }
}

