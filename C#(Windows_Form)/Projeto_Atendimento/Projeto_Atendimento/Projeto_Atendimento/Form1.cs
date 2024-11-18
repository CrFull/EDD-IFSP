using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_Atendimento
{
    public partial class Form1 : Form
    {
        private Senhas senhas =  new Senhas();
        private Guiches guiches = new Guiches(0);
        public Form1()
        {
            InitializeComponent();
            listBoxAtendimentos.HorizontalScrollbar = true;
            listBoxSenhas.HorizontalScrollbar = true;
        }

        private void btnGerar_Click(object sender, EventArgs e)
        {
            senhas.gerar();

            MessageBox.Show("Senha de número: " + senhas.filaSenhas.LastOrDefault().id + " criada!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnListarSenhas_Click(object sender, EventArgs e)
        {
            bool existeSenha = senhas.filaSenhas != null;
            if(existeSenha)
            {
                listBoxSenhas.Items.Clear();
                foreach (Senha senha in senhas.filaSenhas)
                {
                    listBoxSenhas.Items.Add(senha.dadosParciais());
                }
            }
            else
            {
                MessageBox.Show("Não há senhas criadas!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            int numGuiche = int.Parse(lblQtdeGuiches.Text);
            numGuiche++;
            Guiche guiche = new Guiche(numGuiche);
            guiches.adicionar(guiche);

            lblQtdeGuiches.Text = numGuiche.ToString();

        }

        private void btnChamar_Click(object sender, EventArgs e)
        {
            bool digitouNumeroDoGuiche = txtGuiche.Text != null;

            if (digitouNumeroDoGuiche)
            {
                Guiche guicheEncontrado = guiches.listaGuiches.FirstOrDefault(guiche => guiche.id == int.Parse(txtGuiche.Text));
                if (guicheEncontrado != null)
                {       
                    if (guicheEncontrado.Chamar(senhas.filaSenhas))
                    {
                        int senhaDaVez = guicheEncontrado.atendimentos.LastOrDefault().id;
                        MessageBox.Show("Senha: " + senhaDaVez + " \nGuiche de número: " + guicheEncontrado.id, "Atendimento", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        MessageBox.Show("Não há senhas criadas!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show($"Nenhum Guichê encontrado com ID {txtGuiche.Text}.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Não há um guichê selecionado! Digite o número do Guichê primeiro!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
          listBoxAtendimentos.Items.Clear();
          foreach (Guiche guiche in guiches.listaGuiches)
          {
                foreach(Senha senha in guiche.atendimentos)
                {
                    listBoxAtendimentos.Items.Add("Guichê: "+ guiche.id + " |  " + senha.dadosCompletos());
                }
          }   
        }
    }
}
