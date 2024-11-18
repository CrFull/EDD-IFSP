namespace Projeto_Atendimento
{
    partial class Form1
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
            this.btnGerar = new System.Windows.Forms.Button();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.btnChamar = new System.Windows.Forms.Button();
            this.btnListarSenhas = new System.Windows.Forms.Button();
            this.btnListar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblQtdGuichesTxt = new System.Windows.Forms.Label();
            this.lblQtdeGuiches = new System.Windows.Forms.Label();
            this.listBoxSenhas = new System.Windows.Forms.ListBox();
            this.lblGuiche = new System.Windows.Forms.Label();
            this.txtGuiche = new System.Windows.Forms.TextBox();
            this.listBoxAtendimentos = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnGerar
            // 
            this.btnGerar.Location = new System.Drawing.Point(124, 59);
            this.btnGerar.Name = "btnGerar";
            this.btnGerar.Size = new System.Drawing.Size(75, 23);
            this.btnGerar.TabIndex = 0;
            this.btnGerar.Text = "Gerar";
            this.btnGerar.UseVisualStyleBackColor = true;
            this.btnGerar.Click += new System.EventHandler(this.btnGerar_Click);
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Location = new System.Drawing.Point(323, 221);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(106, 22);
            this.btnAdicionar.TabIndex = 1;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // btnChamar
            // 
            this.btnChamar.Location = new System.Drawing.Point(669, 55);
            this.btnChamar.Name = "btnChamar";
            this.btnChamar.Size = new System.Drawing.Size(75, 23);
            this.btnChamar.TabIndex = 2;
            this.btnChamar.Text = "Chamar";
            this.btnChamar.UseVisualStyleBackColor = true;
            this.btnChamar.Click += new System.EventHandler(this.btnChamar_Click);
            // 
            // btnListarSenhas
            // 
            this.btnListarSenhas.Location = new System.Drawing.Point(70, 322);
            this.btnListarSenhas.Name = "btnListarSenhas";
            this.btnListarSenhas.Size = new System.Drawing.Size(202, 23);
            this.btnListarSenhas.TabIndex = 3;
            this.btnListarSenhas.Text = "Listar Senhas";
            this.btnListarSenhas.UseVisualStyleBackColor = true;
            this.btnListarSenhas.Click += new System.EventHandler(this.btnListarSenhas_Click);
            // 
            // btnListar
            // 
            this.btnListar.Location = new System.Drawing.Point(516, 322);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(212, 23);
            this.btnListar.TabIndex = 4;
            this.btnListar.Text = "Listar Atendimentos";
            this.btnListar.UseVisualStyleBackColor = true;
            this.btnListar.Click += new System.EventHandler(this.btnListar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(359, 202);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 16);
            this.label1.TabIndex = 5;
            // 
            // lblQtdGuichesTxt
            // 
            this.lblQtdGuichesTxt.AutoSize = true;
            this.lblQtdGuichesTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.969231F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQtdGuichesTxt.Location = new System.Drawing.Point(319, 145);
            this.lblQtdGuichesTxt.Name = "lblQtdGuichesTxt";
            this.lblQtdGuichesTxt.Size = new System.Drawing.Size(120, 22);
            this.lblQtdGuichesTxt.TabIndex = 6;
            this.lblQtdGuichesTxt.Text = "Qtde Guichês";
            // 
            // lblQtdeGuiches
            // 
            this.lblQtdeGuiches.AutoSize = true;
            this.lblQtdeGuiches.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.06154F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQtdeGuiches.Location = new System.Drawing.Point(357, 176);
            this.lblQtdeGuiches.Name = "lblQtdeGuiches";
            this.lblQtdeGuiches.Size = new System.Drawing.Size(33, 36);
            this.lblQtdeGuiches.TabIndex = 7;
            this.lblQtdeGuiches.Text = "0";
            // 
            // listBoxSenhas
            // 
            this.listBoxSenhas.FormattingEnabled = true;
            this.listBoxSenhas.ItemHeight = 16;
            this.listBoxSenhas.Location = new System.Drawing.Point(52, 102);
            this.listBoxSenhas.Name = "listBoxSenhas";
            this.listBoxSenhas.Size = new System.Drawing.Size(242, 196);
            this.listBoxSenhas.TabIndex = 8;
            // 
            // lblGuiche
            // 
            this.lblGuiche.AutoSize = true;
            this.lblGuiche.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.753846F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGuiche.Location = new System.Drawing.Point(486, 61);
            this.lblGuiche.Name = "lblGuiche";
            this.lblGuiche.Size = new System.Drawing.Size(57, 17);
            this.lblGuiche.TabIndex = 9;
            this.lblGuiche.Text = "Guichê:";
            // 
            // txtGuiche
            // 
            this.txtGuiche.Location = new System.Drawing.Point(549, 55);
            this.txtGuiche.Name = "txtGuiche";
            this.txtGuiche.Size = new System.Drawing.Size(100, 22);
            this.txtGuiche.TabIndex = 10;
            // 
            // listBoxAtendimentos
            // 
            this.listBoxAtendimentos.FormattingEnabled = true;
            this.listBoxAtendimentos.ItemHeight = 16;
            this.listBoxAtendimentos.Location = new System.Drawing.Point(489, 102);
            this.listBoxAtendimentos.Name = "listBoxAtendimentos";
            this.listBoxAtendimentos.Size = new System.Drawing.Size(255, 196);
            this.listBoxAtendimentos.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listBoxAtendimentos);
            this.Controls.Add(this.txtGuiche);
            this.Controls.Add(this.lblGuiche);
            this.Controls.Add(this.listBoxSenhas);
            this.Controls.Add(this.lblQtdeGuiches);
            this.Controls.Add(this.lblQtdGuichesTxt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnListar);
            this.Controls.Add(this.btnListarSenhas);
            this.Controls.Add(this.btnChamar);
            this.Controls.Add(this.btnAdicionar);
            this.Controls.Add(this.btnGerar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGerar;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.Button btnChamar;
        private System.Windows.Forms.Button btnListarSenhas;
        private System.Windows.Forms.Button btnListar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblQtdGuichesTxt;
        private System.Windows.Forms.Label lblQtdeGuiches;
        private System.Windows.Forms.ListBox listBoxSenhas;
        private System.Windows.Forms.Label lblGuiche;
        private System.Windows.Forms.TextBox txtGuiche;
        private System.Windows.Forms.ListBox listBoxAtendimentos;
    }
}

