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
        public FrmSumula(int id)
        {
            InitializeComponent();
            idJogo = id;
        }

        SumulaDados dados = new SumulaDados();
        JogadorDados dadosjogador = new JogadorDados();
        JogoDados dadosjogo = new JogoDados();
        EquipeDados dadosequipe = new EquipeDados();

        private int idJogo;
        private int idjogador;

        private string status = "Inserindo";
        private void FrmSumula_Load(object sender, EventArgs e)
        {
            dados.IdJogo = idJogo;
            dados.ConsultarDadosJogo();
            txtJogo.Text = dados.Pesquisa;

            dadosjogo.IdJogo = idJogo;
            dadosjogo.ConsultarDados();

            cmbTime.DisplayMember = "nomeEquipe";
            cmbTime.ValueMember = "idEquipe";
            cmbTime.DataSource = dadosjogo.ListarDadosEquipeJogo().Tables[0];

        }
        private void cmbTime_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbJogador.DisplayMember = "nomeJogador";
            cmbJogador.ValueMember = "idJogador";
            dadosjogador.IdEquipe = int.Parse(cmbTime.SelectedValue.ToString());
            cmbJogador.DataSource = dadosjogador.ListarDadosJogadorporEquipe().Tables[0];
        }
        private void cmbJogador_SelectedIndexChanged(object sender, EventArgs e)
        {
            idjogador = int.Parse(cmbJogador.SelectedValue.ToString());
            dados.IdJogador = idjogador;
        }
        private void cmdNovo_Click(object sender, EventArgs e)
        {
            cmdSalvar.Enabled = true;
            cmdNovo.Enabled = false;
            cmbJogador.Enabled = true;
            cmbTime.Enabled = true;
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
            cmbTime.Enabled = true;
            cmbGols.Enabled = true;
            cmbCartao.Enabled = true;

            FrmEditarSumula ES = new FrmEditarSumula();
            ES.ShowDialog();
            dados.IdSumula = ES.Id;

            dados.ConsultarDados();
            
            cmbCartao.Text = dados.Cartao;
            cmbGols.Text = dados.Gol.ToString();

            dadosjogador.IdJogador = dados.IdJogador;
            dadosjogador.ConsultarDados();
            cmbTime.Text = dadosjogador.NomeJogador;
            

            dados.ConsultarDados();
            dadosjogo.IdJogo = dados.IdJogo;
            dadosjogo.ConsultarDados();
            dadosjogo.ConsultarDadosJogo();

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
