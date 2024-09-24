namespace WinFormsApp1
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
            btnSair = new Button();
            btnAdicionarCurso = new Button();
            btnRemoverCurso = new Button();
            btnPesquisarCurso = new Button();
            btnPesquisarDisciplina = new Button();
            btnAdicionarDisciplinaNoCurso = new Button();
            btnRemoverDisciplinaDoCurso = new Button();
            btnMatricularAlunoNaDisciplina = new Button();
            btnRemoverAlunoDaDisciplina = new Button();
            btnPesquisarAluno = new Button();
            label1 = new Label();
            textIdAluno = new TextBox();
            textNomeAluno = new TextBox();
            label2 = new Label();
            label3 = new Label();
            cmbCurso = new ComboBox();
            txtDescCurso = new TextBox();
            label4 = new Label();
            txtIdCurso = new TextBox();
            label5 = new Label();
            txtDescDisciplina = new TextBox();
            label6 = new Label();
            txtIdDisciplina = new TextBox();
            label7 = new Label();
            SuspendLayout();
            // 
            // btnSair
            // 
            btnSair.Location = new Point(537, 565);
            btnSair.Name = "btnSair";
            btnSair.Size = new Size(102, 31);
            btnSair.TabIndex = 0;
            btnSair.Text = "Sair";
            btnSair.UseVisualStyleBackColor = true;
            // 
            // btnAdicionarCurso
            // 
            btnAdicionarCurso.Location = new Point(113, 283);
            btnAdicionarCurso.Name = "btnAdicionarCurso";
            btnAdicionarCurso.Size = new Size(188, 31);
            btnAdicionarCurso.TabIndex = 1;
            btnAdicionarCurso.Text = "Adicionar curso";
            btnAdicionarCurso.UseVisualStyleBackColor = true;
            btnAdicionarCurso.Click += btnAdicionarCurso_Click;
            // 
            // btnRemoverCurso
            // 
            btnRemoverCurso.Location = new Point(113, 383);
            btnRemoverCurso.Name = "btnRemoverCurso";
            btnRemoverCurso.Size = new Size(188, 31);
            btnRemoverCurso.TabIndex = 3;
            btnRemoverCurso.Text = "Remover curso";
            btnRemoverCurso.UseVisualStyleBackColor = true;
            btnRemoverCurso.Click += btnRemoverCurso_Click;
            // 
            // btnPesquisarCurso
            // 
            btnPesquisarCurso.Location = new Point(113, 331);
            btnPesquisarCurso.Name = "btnPesquisarCurso";
            btnPesquisarCurso.Size = new Size(188, 31);
            btnPesquisarCurso.TabIndex = 2;
            btnPesquisarCurso.Text = "Pesquisar curso";
            btnPesquisarCurso.UseVisualStyleBackColor = true;
            btnPesquisarCurso.Click += btnPesquisarCurso_Click;
            // 
            // btnPesquisarDisciplina
            // 
            btnPesquisarDisciplina.Location = new Point(500, 394);
            btnPesquisarDisciplina.Name = "btnPesquisarDisciplina";
            btnPesquisarDisciplina.Size = new Size(240, 31);
            btnPesquisarDisciplina.TabIndex = 5;
            btnPesquisarDisciplina.Text = "Pesquisar disciplina";
            btnPesquisarDisciplina.UseVisualStyleBackColor = true;
            btnPesquisarDisciplina.Click += btnPesquisarDisciplina_Click;
            // 
            // btnAdicionarDisciplinaNoCurso
            // 
            btnAdicionarDisciplinaNoCurso.Location = new Point(500, 283);
            btnAdicionarDisciplinaNoCurso.Name = "btnAdicionarDisciplinaNoCurso";
            btnAdicionarDisciplinaNoCurso.Size = new Size(240, 31);
            btnAdicionarDisciplinaNoCurso.TabIndex = 4;
            btnAdicionarDisciplinaNoCurso.Text = "Adicionar disciplina no curso";
            btnAdicionarDisciplinaNoCurso.UseVisualStyleBackColor = true;
            btnAdicionarDisciplinaNoCurso.Click += btnAdicionarDisciplinaNoCurso_Click;
            // 
            // btnRemoverDisciplinaDoCurso
            // 
            btnRemoverDisciplinaDoCurso.Location = new Point(500, 341);
            btnRemoverDisciplinaDoCurso.Name = "btnRemoverDisciplinaDoCurso";
            btnRemoverDisciplinaDoCurso.Size = new Size(240, 31);
            btnRemoverDisciplinaDoCurso.TabIndex = 6;
            btnRemoverDisciplinaDoCurso.Text = "Remover disciplina do curso";
            btnRemoverDisciplinaDoCurso.UseVisualStyleBackColor = true;
            btnRemoverDisciplinaDoCurso.Click += btnRemoverDisciplinaDoCurso_Click;
            // 
            // btnMatricularAlunoNaDisciplina
            // 
            btnMatricularAlunoNaDisciplina.Location = new Point(905, 283);
            btnMatricularAlunoNaDisciplina.Name = "btnMatricularAlunoNaDisciplina";
            btnMatricularAlunoNaDisciplina.Size = new Size(247, 31);
            btnMatricularAlunoNaDisciplina.TabIndex = 7;
            btnMatricularAlunoNaDisciplina.Text = "Matricular aluno na disciplina";
            btnMatricularAlunoNaDisciplina.UseVisualStyleBackColor = true;
            btnMatricularAlunoNaDisciplina.Click += btnMatricularAlunoNaDisciplina_Click;
            // 
            // btnRemoverAlunoDaDisciplina
            // 
            btnRemoverAlunoDaDisciplina.Location = new Point(905, 341);
            btnRemoverAlunoDaDisciplina.Name = "btnRemoverAlunoDaDisciplina";
            btnRemoverAlunoDaDisciplina.Size = new Size(247, 31);
            btnRemoverAlunoDaDisciplina.TabIndex = 8;
            btnRemoverAlunoDaDisciplina.Text = "Remover aluno da disciplina";
            btnRemoverAlunoDaDisciplina.UseVisualStyleBackColor = true;
            btnRemoverAlunoDaDisciplina.Click += btnRemoverAlunoDaDisciplina_Click;
            // 
            // btnPesquisarAluno
            // 
            btnPesquisarAluno.Location = new Point(905, 394);
            btnPesquisarAluno.Name = "btnPesquisarAluno";
            btnPesquisarAluno.Size = new Size(247, 31);
            btnPesquisarAluno.TabIndex = 9;
            btnPesquisarAluno.Text = "Pesquisar aluno";
            btnPesquisarAluno.UseVisualStyleBackColor = true;
            btnPesquisarAluno.Click += btnPesquisarAluno_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(937, 22);
            label1.Name = "label1";
            label1.Size = new Size(73, 21);
            label1.TabIndex = 10;
            label1.Text = "ID Aluno:";
            // 
            // textIdAluno
            // 
            textIdAluno.Location = new Point(937, 46);
            textIdAluno.Name = "textIdAluno";
            textIdAluno.Size = new Size(135, 29);
            textIdAluno.TabIndex = 11;
            // 
            // textNomeAluno
            // 
            textNomeAluno.Location = new Point(937, 102);
            textNomeAluno.Name = "textNomeAluno";
            textNomeAluno.Size = new Size(135, 29);
            textNomeAluno.TabIndex = 13;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(937, 78);
            label2.Name = "label2";
            label2.Size = new Size(101, 21);
            label2.TabIndex = 12;
            label2.Text = "Nome Aluno:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(113, 159);
            label3.Name = "label3";
            label3.Size = new Size(51, 21);
            label3.TabIndex = 14;
            label3.Text = "Curso";
            // 
            // cmbCurso
            // 
            cmbCurso.FormattingEnabled = true;
            cmbCurso.Location = new Point(113, 192);
            cmbCurso.Name = "cmbCurso";
            cmbCurso.Size = new Size(164, 29);
            cmbCurso.TabIndex = 15;
            // 
            // txtDescCurso
            // 
            txtDescCurso.Location = new Point(113, 102);
            txtDescCurso.Name = "txtDescCurso";
            txtDescCurso.Size = new Size(135, 29);
            txtDescCurso.TabIndex = 19;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(113, 78);
            label4.Name = "label4";
            label4.Size = new Size(122, 21);
            label4.TabIndex = 18;
            label4.Text = "Descrição Curso";
            // 
            // txtIdCurso
            // 
            txtIdCurso.Location = new Point(113, 46);
            txtIdCurso.Name = "txtIdCurso";
            txtIdCurso.Size = new Size(135, 29);
            txtIdCurso.TabIndex = 17;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(113, 22);
            label5.Name = "label5";
            label5.Size = new Size(73, 21);
            label5.TabIndex = 16;
            label5.Text = "ID Curso:";
            // 
            // txtDescDisciplina
            // 
            txtDescDisciplina.Location = new Point(539, 102);
            txtDescDisciplina.Name = "txtDescDisciplina";
            txtDescDisciplina.Size = new Size(135, 29);
            txtDescDisciplina.TabIndex = 23;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(539, 78);
            label6.Name = "label6";
            label6.Size = new Size(148, 21);
            label6.TabIndex = 22;
            label6.Text = "Descrição Disciplina";
            // 
            // txtIdDisciplina
            // 
            txtIdDisciplina.Location = new Point(539, 46);
            txtIdDisciplina.Name = "txtIdDisciplina";
            txtIdDisciplina.Size = new Size(135, 29);
            txtIdDisciplina.TabIndex = 21;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(539, 22);
            label7.Name = "label7";
            label7.Size = new Size(99, 21);
            label7.TabIndex = 20;
            label7.Text = "ID Disciplina:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1266, 624);
            Controls.Add(txtDescDisciplina);
            Controls.Add(label6);
            Controls.Add(txtIdDisciplina);
            Controls.Add(label7);
            Controls.Add(txtDescCurso);
            Controls.Add(label4);
            Controls.Add(txtIdCurso);
            Controls.Add(label5);
            Controls.Add(cmbCurso);
            Controls.Add(label3);
            Controls.Add(textNomeAluno);
            Controls.Add(label2);
            Controls.Add(textIdAluno);
            Controls.Add(label1);
            Controls.Add(btnPesquisarAluno);
            Controls.Add(btnRemoverAlunoDaDisciplina);
            Controls.Add(btnMatricularAlunoNaDisciplina);
            Controls.Add(btnRemoverDisciplinaDoCurso);
            Controls.Add(btnPesquisarDisciplina);
            Controls.Add(btnAdicionarDisciplinaNoCurso);
            Controls.Add(btnRemoverCurso);
            Controls.Add(btnPesquisarCurso);
            Controls.Add(btnAdicionarCurso);
            Controls.Add(btnSair);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSair;
        private Button btnAdicionarCurso;
        private Button btnRemoverCurso;
        private Button btnPesquisarCurso;
        private Button btnPesquisarDisciplina;
        private Button btnAdicionarDisciplinaNoCurso;
        private Button btnRemoverDisciplinaDoCurso;
        private Button btnMatricularAlunoNaDisciplina;
        private Button btnRemoverAlunoDaDisciplina;
        private Button btnPesquisarAluno;
        private Label label1;
        private TextBox textIdAluno;
        private TextBox textNomeAluno;
        private Label label2;
        private Label label3;
        private ComboBox cmbCurso;
        private TextBox txtDescCurso;
        private Label label4;
        private TextBox txtIdCurso;
        private Label label5;
        private TextBox txtDescDisciplina;
        private Label label6;
        private TextBox txtIdDisciplina;
        private Label label7;
    }
}
