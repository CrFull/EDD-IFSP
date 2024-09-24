namespace Proj.MVC_Vendedores
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            btnCadastrar = new Button();
            btnConsultar = new Button();
            btnExcluir = new Button();
            btnRegistrarVenda = new Button();
            btnListarVendedores = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtIdVendedor = new TextBox();
            txtDia = new TextBox();
            txtQtde = new TextBox();
            label5 = new Label();
            txtValor = new TextBox();
            label6 = new Label();
            txtComissao = new TextBox();
            label7 = new Label();
            txtNomeVendedor = new TextBox();
            label8 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(475, 476);
            button1.Name = "button1";
            button1.Size = new Size(205, 43);
            button1.TabIndex = 0;
            button1.Text = "Sair";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // btnCadastrar
            // 
            btnCadastrar.Location = new Point(131, 266);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(205, 43);
            btnCadastrar.TabIndex = 1;
            btnCadastrar.Text = "Cadastrar Vendedor";
            btnCadastrar.UseVisualStyleBackColor = true;
            btnCadastrar.Click += btnCadastrar_Click_1;
            // 
            // btnConsultar
            // 
            btnConsultar.Location = new Point(131, 328);
            btnConsultar.Name = "btnConsultar";
            btnConsultar.Size = new Size(205, 43);
            btnConsultar.TabIndex = 2;
            btnConsultar.Text = "Consultar vendedor";
            btnConsultar.UseVisualStyleBackColor = true;
            btnConsultar.Click += btnConsultar_Click;
            // 
            // btnExcluir
            // 
            btnExcluir.Location = new Point(131, 395);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(205, 43);
            btnExcluir.TabIndex = 3;
            btnExcluir.Text = "Excluir vendedor ";
            btnExcluir.UseVisualStyleBackColor = true;
            btnExcluir.Click += btnExcluir_Click;
            // 
            // btnRegistrarVenda
            // 
            btnRegistrarVenda.Location = new Point(771, 299);
            btnRegistrarVenda.Name = "btnRegistrarVenda";
            btnRegistrarVenda.Size = new Size(205, 43);
            btnRegistrarVenda.TabIndex = 4;
            btnRegistrarVenda.Text = "Registrar venda";
            btnRegistrarVenda.UseVisualStyleBackColor = true;
            btnRegistrarVenda.Click += btnRegistrarVenda_Click;
            // 
            // btnListarVendedores
            // 
            btnListarVendedores.Location = new Point(131, 463);
            btnListarVendedores.Name = "btnListarVendedores";
            btnListarVendedores.Size = new Size(205, 43);
            btnListarVendedores.TabIndex = 5;
            btnListarVendedores.Text = "Listar vendedores ";
            btnListarVendedores.UseVisualStyleBackColor = true;
            btnListarVendedores.Click += btnListarVendedores_Click_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(844, 44);
            label1.Name = "label1";
            label1.Size = new Size(53, 21);
            label1.TabIndex = 6;
            label1.Text = "Venda";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(162, 27);
            label2.Name = "label2";
            label2.Size = new Size(77, 21);
            label2.TabIndex = 7;
            label2.Text = "Vendedor";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(66, 95);
            label3.Name = "label3";
            label3.Size = new Size(118, 21);
            label3.TabIndex = 8;
            label3.Text = "ID do Vendedor";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(738, 112);
            label4.Name = "label4";
            label4.Size = new Size(33, 21);
            label4.TabIndex = 9;
            label4.Text = "Dia";
            // 
            // txtIdVendedor
            // 
            txtIdVendedor.Location = new Point(201, 95);
            txtIdVendedor.Name = "txtIdVendedor";
            txtIdVendedor.Size = new Size(135, 29);
            txtIdVendedor.TabIndex = 10;
            // 
            // txtDia
            // 
            txtDia.Location = new Point(819, 112);
            txtDia.Name = "txtDia";
            txtDia.Size = new Size(135, 29);
            txtDia.TabIndex = 11;
            // 
            // txtQtde
            // 
            txtQtde.Location = new Point(819, 171);
            txtQtde.Name = "txtQtde";
            txtQtde.Size = new Size(135, 29);
            txtQtde.TabIndex = 13;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(738, 171);
            label5.Name = "label5";
            label5.Size = new Size(36, 21);
            label5.TabIndex = 12;
            label5.Text = "Qtd";
            // 
            // txtValor
            // 
            txtValor.Location = new Point(819, 225);
            txtValor.Name = "txtValor";
            txtValor.Size = new Size(135, 29);
            txtValor.TabIndex = 15;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(738, 225);
            label6.Name = "label6";
            label6.Size = new Size(46, 21);
            label6.TabIndex = 14;
            label6.Text = "Valor";
            // 
            // txtComissao
            // 
            txtComissao.Location = new Point(201, 165);
            txtComissao.Name = "txtComissao";
            txtComissao.Size = new Size(135, 29);
            txtComissao.TabIndex = 17;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(66, 165);
            label7.Name = "label7";
            label7.Size = new Size(78, 21);
            label7.TabIndex = 16;
            label7.Text = "Comissão";
            // 
            // txtNomeVendedor
            // 
            txtNomeVendedor.Location = new Point(201, 130);
            txtNomeVendedor.Name = "txtNomeVendedor";
            txtNomeVendedor.Size = new Size(135, 29);
            txtNomeVendedor.TabIndex = 19;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(66, 130);
            label8.Name = "label8";
            label8.Size = new Size(53, 21);
            label8.TabIndex = 18;
            label8.Text = "Nome";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1169, 565);
            Controls.Add(txtNomeVendedor);
            Controls.Add(label8);
            Controls.Add(txtComissao);
            Controls.Add(label7);
            Controls.Add(txtValor);
            Controls.Add(label6);
            Controls.Add(txtQtde);
            Controls.Add(label5);
            Controls.Add(txtDia);
            Controls.Add(txtIdVendedor);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnListarVendedores);
            Controls.Add(btnRegistrarVenda);
            Controls.Add(btnExcluir);
            Controls.Add(btnConsultar);
            Controls.Add(btnCadastrar);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button btnCadastrar;
        private Button btnConsultar;
        private Button btnExcluir;
        private Button btnRegistrarVenda;
        private Button btnListarVendedores;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtIdVendedor;
        private TextBox txtDia;
        private TextBox txtQtde;
        private Label label5;
        private TextBox txtValor;
        private Label label6;
        private TextBox txtComissao;
        private Label label7;
        private TextBox txtNomeVendedor;
        private Label label8;
    }
}
