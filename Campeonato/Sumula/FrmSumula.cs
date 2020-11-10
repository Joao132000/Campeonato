using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Campeonato
{
    public partial class FrmSumula : MetroFramework.Forms.MetroForm
    {
        public FrmSumula()
        {
            InitializeComponent();
        }

        SumulaDados dados = new SumulaDados();
        JogadorDados dadosjogador = new JogadorDados();
        JogoDados dadosjogo = new JogoDados();

        private int idJogador;
        private int idJogo;

        private string status = "Inserindo";
        private void FrmSumula_Load(object sender, EventArgs e)
        {
            cmbJogador.DisplayMember = "nomeJogador";
            cmbJogador.ValueMember = "idJogador";
            cmbJogador.DataSource = dadosjogador.ListarDados().Tables[0];

            cmbJogo.DisplayMember = "Jogo";
            cmbJogo.ValueMember = "idJogo";
            cmbJogo.DataSource = dadosjogo.ListarDadosJogo().Tables[0];
        }

        private void cmbJogador_SelectedIndexChanged(object sender, EventArgs e)
        {
            idJogador = int.Parse(cmbJogador.SelectedValue.ToString());
            dados.IdJogador = idJogador;
        }

        private void cmbJogo_SelectedIndexChanged(object sender, EventArgs e)
        {
            idJogo = int.Parse(cmbJogo.SelectedValue.ToString());
            dados.IdJogo = idJogo;
        }

        private void cmdNovo_Click(object sender, EventArgs e)
        {
            cmdSalvar.Enabled = true;
            cmdNovo.Enabled = false;
            cmbJogador.Enabled = true;
            cmbJogo.Enabled = true;
            cmbGols.Enabled = true;
            cmbCartao.Enabled = true;
        }

        private void cmdSalvar_Click(object sender, EventArgs e)
        {
            cmdNovo.Enabled = true;
            cmdSalvar.Enabled = false;

            if (status == "Inserindo")
            {
                if (DialogResult.OK == MessageBox.Show("Deseja realmente salvar?", "Alerta", MessageBoxButtons.OKCancel))
                {
                    dados.Cartao = cmbCartao.SelectedItem.ToString();
                    dados.Gol = int.Parse(cmbGols.SelectedIndex.ToString());

                    dados.InlcuirDados();
                    MessageBox.Show("Registro incluído com sucesso!!!!");
                }
            }
            if (status == "Editando")
            {
                if (DialogResult.OK == MessageBox.Show("Deseja realmente salvar?", "Alerta", MessageBoxButtons.OKCancel))
                {
                    dados.Cartao = cmbCartao.SelectedItem.ToString();
                    dados.Gol = int.Parse(cmbGols.SelectedIndex.ToString());

                    dados.AlterarDados();
                    MessageBox.Show("Registro alterado com sucesso!!!!");
                }
            }

        }

        private void cmdEditar_Click(object sender, EventArgs e)
        {
            cmdSalvar.Enabled = true;
            cmdNovo.Enabled = false;
            cmdExcluir.Enabled = true;
            cmbJogador.Enabled = true;
            cmbJogo.Enabled = true;
            cmbGols.Enabled = true;
            cmbCartao.Enabled = true;

            FrmEditarSumula ES = new FrmEditarSumula();
            ES.ShowDialog();
            dados.IdSumula = ES.Id;

            dados.ConsultarDados();

            dadosjogador.IdJogador = dados.IdJogador;
            dadosjogador.ConsultarDados();
            cmbJogador.Text = dadosjogador.NomeJogador;

            dados.ConsultarDados();
            dadosjogo.IdJogo = dados.IdJogo;
            dadosjogo.ConsultarDados();
            dadosjogo.ConsultarDadosJogo();
            cmbJogo.Text = dadosjogo.AuxJogo;

            status = "Editando";
        }

        private void cmdExcluir_Click(object sender, EventArgs e)
        {
            if (DialogResult.OK == MessageBox.Show("Deseja realmente excluir?", "Alerta", MessageBoxButtons.OKCancel))
            {
                dados.DeletarDados();
                MessageBox.Show("Registro excluído com sucesso!!!!");
            }
        }

       
    }
}
