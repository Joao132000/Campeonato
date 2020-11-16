using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Printing;

namespace Campeonato
{
    public partial class Frm_Jogador : MetroFramework.Forms.MetroForm
    {
        private JogadorDados Jogador;
        private EquipeDados Times;
        int i = 0;
        public Frm_Jogador()
        {
            InitializeComponent();
            Jogador = new JogadorDados();
            Times = new EquipeDados();
        }



        private void cmd_Processar_Click(object sender, EventArgs e)
        {
            if (cmd_Processar.Text == "Salvar")
            {
                Jogador.NomeJogador = txt_Nome.Text;
                Jogador.DataNascimento = Mtxt_Data.Text;
                Jogador.NumeroCamisa = int.Parse(txt_Numero.Text);
                Jogador.IdEquipe = int.Parse(cmb_Time.SelectedValue.ToString());
                Jogador.InlcuirDados();
                MessageBox.Show("Registro incluído com sucesso");
                txt_Nome.Text = "";
                txt_Numero.Text = "";
                Mtxt_Data.Text = "";

            }
            else if (cmd_Processar.Text == "Alterar")
            {
                Jogador.NomeJogador = txt_Nome.Text;
                Jogador.DataNascimento = Mtxt_Data.Text;
                Jogador.NumeroCamisa = int.Parse(txt_Numero.Text);
                Jogador.IdEquipe = int.Parse(cmb_Time.SelectedValue.ToString());
                if (DialogResult.Yes == MessageBox.Show("Deseja realmente alterar os dados deste jogador?", "Aviso", MessageBoxButtons.YesNo))
                {
                    Jogador.AlterarDados();
                    MessageBox.Show("Dados alterados com sucesso!");
                    cmdLocalizar.Enabled = true;
                    cmd_Excluir.Text = "Excluir";
                    cmdLocalizar.Text = "Localizar";
                }
            }
        }

        private void cmdLocalizar_Click(object sender, EventArgs e)
        {
            if (cmdLocalizar.Text == "Localizar")
            {
                Frm_EditarJogador J = new Frm_EditarJogador();
                J.ShowDialog();
                cmd_Processar.Text = "Alterar";
                Jogador.IdJogador = J.IdJogador;
                Jogador.ConsultarDados();
                txt_Nome.Text = Jogador.NomeJogador;
                txt_Numero.Text = Jogador.NumeroCamisa.ToString();
                Mtxt_Data.Text = Jogador.DataNascimento;
                Times.IdEquipe = Jogador.IdEquipe;
                Times.ConsultarDados();
                cmb_Time.Text = Times.NomeEquipe;
                cmd_Excluir.Text = "Cancelar";
                cmdLocalizar.Text = "Excluir";
            }
            else
            {
                if (DialogResult.Yes == MessageBox.Show("Deseja realmente deletar os dados deste jogador?", "Aviso", MessageBoxButtons.YesNo))
                {
                    Jogador.DeletarDados();
                    MessageBox.Show("Dados deletados com sucesso!");
                    txt_Nome.Text = "";
                    txt_Numero.Text = "";
                    Mtxt_Data.Text = "";
                    cmb_Time.SelectedIndex = -1;

                    cmdLocalizar.Text = "Localizar";
                    cmd_Excluir.Text = "Excluir";
                }
            }
        }

        private void Frm_Jogador_Load(object sender, EventArgs e)
        {
            cmb_Time.DisplayMember = "nomeEquipe";
            cmb_Time.ValueMember = "idEquipe";
            cmb_Time.DataSource = Times.ListarDados().Tables[0];
            cmb_Time.SelectedIndex = -1;

        }

        private void cmd_Excluir_Click(object sender, EventArgs e)
        {
            if (cmd_Excluir.Text == "Excluir")
            {
                if (DialogResult.Yes == MessageBox.Show("Deseja realmente deletar os dados deste jogador?", "Aviso", MessageBoxButtons.YesNo))
                {
                    Jogador.DeletarDados();
                    MessageBox.Show("Dados deletados com sucesso!");
                    txt_Nome.Text = "";
                    txt_Numero.Text = "";
                    Mtxt_Data.Text = "";
                    cmb_Time.SelectedIndex = -1;

                }
            }
            else
            {
                MessageBox.Show("Ação cancelada com sucesso!");
                cmd_Processar.Text = "Salvar";
                cmdLocalizar.Text = "Localizar";
                cmd_Excluir.Text = "Excluir";
                txt_Nome.Text = "";
                txt_Numero.Text = "";
                Mtxt_Data.Text = "";
                cmb_Time.SelectedItem = null;
            }
        }

        private void cmdImprimir_Click(object sender, EventArgs e)
        {
            PrintDocument pd = new PrintDocument();
            pd.DocumentName = "Relatorio de Jogadores";
            pd.BeginPrint += Pd_BeginPrint;
            pd.PrintPage += Imprimir;

            PrintPreviewDialog ppd = new PrintPreviewDialog();
            ppd.Document = pd;
            ppd.ShowDialog();
        }
        private void Pd_BeginPrint(object sender, PrintEventArgs e)
        {
            i = 0;
        }
        private void Imprimir(object sender, PrintPageEventArgs ev)
        {
            //Configurações da Página
            float linhaPorPagina = 0;
            float PosicaoHorizontal = 0;
            float ContadordeLinhas = 0;
            float MargemEsquerda = 20;
            float MargemDireita = 20;
            float MargemSuperior = 20;
            float AlturadaFonte = 0;
            string Linha = "";
            Font fonte = new Font("Arial", 14);
            AlturadaFonte = fonte.GetHeight(ev.Graphics);//Retorna a altura da linha em pixels::Ev graphics trata-se da pagina
            linhaPorPagina = Convert.ToInt32(ev.MarginBounds.Height / AlturadaFonte);

            int auxiliar = 0;

            ///Título:
            Linha = "Lista de Jogadores";
            PosicaoHorizontal = MargemSuperior + ContadordeLinhas * AlturadaFonte;
            ev.Graphics.DrawString(Linha, fonte, Brushes.Black, MargemEsquerda, PosicaoHorizontal);
            ContadordeLinhas += 4;

            DataSet ds = Jogador.ListarDadosJogador();

            if (ds.Tables[0] != null)
            {
                while ((i < ds.Tables[0].Rows.Count) && (ContadordeLinhas < linhaPorPagina))
                {
                    DataRow item = ds.Tables[0].Rows[i];

                    //Subtítulo
                    if (auxiliar != int.Parse(item["idEquipe"].ToString()))
                    {
                        Times.IdEquipe = int.Parse(item["idEquipe"].ToString());
                        Times.ConsultarDados();

                        Linha = "Time: " + Times.NomeEquipe;
                        PosicaoHorizontal = MargemSuperior + ContadordeLinhas * AlturadaFonte;
                        ev.Graphics.DrawString(Linha, fonte, Brushes.Blue, MargemEsquerda, PosicaoHorizontal);
                        ContadordeLinhas += 2;

                        Linha = "Camisa";
                        PosicaoHorizontal = MargemSuperior + ContadordeLinhas * AlturadaFonte;
                        ev.Graphics.DrawString(Linha, fonte, Brushes.Red, MargemEsquerda, PosicaoHorizontal);

                        Linha = "Jogador";
                        PosicaoHorizontal = MargemSuperior + ContadordeLinhas * AlturadaFonte;
                        ev.Graphics.DrawString(Linha, fonte, Brushes.Red, MargemEsquerda + 200, PosicaoHorizontal);

                        auxiliar = int.Parse(item["idEquipe"].ToString());

                        ContadordeLinhas += 2;
                    }

                    //Dados
                    Linha = item["numeroCamisa"].ToString();
                    PosicaoHorizontal = MargemSuperior + ContadordeLinhas * AlturadaFonte;
                    ev.Graphics.DrawString(Linha, fonte, Brushes.Black, MargemEsquerda, PosicaoHorizontal);

                    Linha = item["nomeJogador"].ToString();
                    PosicaoHorizontal = MargemSuperior + ContadordeLinhas * AlturadaFonte;
                    ev.Graphics.DrawString(Linha, fonte, Brushes.Black, MargemEsquerda + 200, PosicaoHorizontal);

                    ContadordeLinhas += 2;
                    i++;//Contador de Registros
                }
            }
            else
            {
                MessageBox.Show("Não há registros");
            }
            if (ContadordeLinhas > linhaPorPagina)
            {
                ev.HasMorePages = true;
            }
            else
            {
                ev.HasMorePages = false;
            }
        }
    }
}
 