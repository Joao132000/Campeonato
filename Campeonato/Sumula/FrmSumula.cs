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
        
        private int gols;
        private int auxEquipe;
        private int identificador;

        private string status = "Inserindo";
        //
        public int Gols { get => gols; set => gols = value; }
        public int AuxEquipe { get => auxEquipe; set => auxEquipe = value; }
        public int Identificador { get => identificador; set => identificador = value; }
        //
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
            AuxEquipe = int.Parse(cmbTime.SelectedValue.ToString());
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

                    Gols += int.Parse(cmbGols.SelectedIndex.ToString());
                    Identificador = 1;
                    
                    dados.InlcuirDados();
                    MessageBox.Show("Registro incluído com sucesso!!!!");
                }
            }
            if (status == "Editando")
            {
                if (DialogResult.OK == MessageBox.Show("Deseja realmente salvar?", "Alerta", MessageBoxButtons.OKCancel))
                {
                    dados.Cartao = cmbCartao.SelectedItem.ToString();
                    
                    Gols=dados.Gol;//
                    
                    dados.Gol = int.Parse(cmbGols.SelectedIndex.ToString());
                    //
                    if (Gols != dados.Gol)
                    {
                        if (Gols < dados.Gol)
                        {
                            Gols += dados.Gol;
                            identificador = 1;
                        }
                        else
                        {
                            Gols -= dados.Gol;
                            identificador = 0;
                        }
                    }
                    //
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
            cmbTime.Enabled = false;
            cmbGols.Enabled = true;
            cmbCartao.Enabled = true;

            FrmEditarSumula ES = new FrmEditarSumula(dados.IdJogo);
            ES.ShowDialog();
            dados.IdSumula = ES.Id;

            dados.ConsultarDados();

            dadosequipe.IdEquipe = dadosjogador.IdEquipe;
            dadosequipe.ConsultarDados();
            cmbTime.Text = dadosequipe.NomeEquipe;

            dados.ConsultarDados();

            dadosjogador.IdJogador = dados.IdJogador;
            dadosjogador.ConsultarDados();
            cmbJogador.Text = dadosjogador.NomeJogador;

            dados.IdSumula = ES.Id;
            dados.ConsultarDados();
            
            cmbCartao.Text = dados.Cartao;
            cmbGols.Text = dados.Gol.ToString();

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
