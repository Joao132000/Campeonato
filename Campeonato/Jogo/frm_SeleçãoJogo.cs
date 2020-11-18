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
    public partial class frm_SeleçãoJogo : MetroFramework.Forms.MetroForm
    {
        Organizacao_CampeonatoDados dadosOrganizaçao = new Organizacao_CampeonatoDados();
        private CampeonatoDados Campeonato;
        private EquipeDados EquipeCasa;
        private EquipeDados EquipeFora;
        private EstadioDados Estadio;
        private JogoDados Jogo;
        private int id, i=0;
        DateTime D;
        public int Id { get => id; set => id = value; }

        public frm_SeleçãoJogo()
        {
            InitializeComponent();
            Campeonato= new CampeonatoDados();
            EquipeCasa = new EquipeDados();
            EquipeFora = new EquipeDados();
            Estadio = new EstadioDados();
            Jogo = new JogoDados();
            D = new DateTime();
        }
        private void metroButton1_Click(object sender, EventArgs e)
        {
            if (cmd_Ok.Text == "Adicionar")

            {
                string x = cmb_Time2.SelectedValue.ToString();
                if (cmb_Time2.SelectedValue.ToString() == cmb_TimeCasa.SelectedValue.ToString())
                {
                    MessageBox.Show("Não é possível confirmar a seleção!\n\tTimes iguais!!");
                }
                else
                {
                    Jogo.IdEquipe1 = int.Parse(cmb_TimeCasa.SelectedValue.ToString());
                    Jogo.IdEquipe2 = int.Parse(cmb_Time2.SelectedValue.ToString());
                    Jogo.IdEstadio = int.Parse(cmb_Estadio.SelectedValue.ToString());
                    Jogo.IdCampeonato = int.Parse(cmb_Campeonato.SelectedValue.ToString());
                    Jogo.DataJogo = dateTimePicker1.Value.ToString();
                    Jogo.ResultadoEquipe1 = 0;
                    Jogo.ResultadoEquipe2 = 0;
                    Jogo.InlcuirDados();
                    MessageBox.Show("Adicionado com sucesso!");
                }
            } else if (cmd_Ok.Text == "Salvar")
            {
                Jogo.IdEquipe1 = int.Parse(cmb_TimeCasa.SelectedValue.ToString());
                Jogo.IdEquipe2 = int.Parse(cmb_Time2.SelectedValue.ToString());
                Jogo.IdEstadio = int.Parse(cmb_Estadio.SelectedValue.ToString());
                Jogo.IdCampeonato = int.Parse(cmb_Campeonato.SelectedValue.ToString());
                Jogo.DataJogo = dateTimePicker1.Value.ToString();
               
                Jogo.AlterarDados();
                cmd_Ok.Text = "Adicionar";
                cmd_Localizar.Text = "Editar";
                cmd_Excluir.Visible = false;
                
                MessageBox.Show("Alterações salvas com sucesso");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmb_Campeonato.ValueMember = "idCampeonato";
            cmb_Campeonato.DisplayMember = "nomeCampeonato";
            cmb_Campeonato.DataSource = Campeonato.ListarDados().Tables[0];


            cmb_Estadio.ValueMember = "idEstadio";
            cmb_Estadio.DisplayMember = "nomeEstadio";
            cmb_Estadio.DataSource = Estadio.ListarDados().Tables[0];
            
            }

        private void cmd_Localizar_Click(object sender, EventArgs e)
        {
            if (cmd_Localizar.Text == "Editar")
            {
                frm_EditarJogo EJ = new frm_EditarJogo();
                EJ.ShowDialog();
                Jogo.IdJogo = EJ.Id;
                Jogo.ConsultarDados();
                cmd_Localizar.Text = "Cancelar";
                dateTimePicker1.Text = Jogo.DataJogo;
               
                cmd_Ok.Text = "Salvar";
                cmd_Excluir.Visible = true;

                Campeonato.IdCampeonato = Jogo.IdCampeonato;
                Campeonato.ConsultarDados();
                cmb_Campeonato.Text = Campeonato.NomeCampeonato;

                EquipeCasa.IdEquipe = Jogo.IdEquipe1;
                EquipeCasa.ConsultarDados();
                cmb_TimeCasa.Text = EquipeCasa.NomeEquipe;

                EquipeFora.IdEquipe = Jogo.IdEquipe2;
                EquipeFora.ConsultarDados();
                cmb_Time2.Text = EquipeFora.NomeEquipe;

                Estadio.IdEstadio = Jogo.IdEstadio;
                Estadio.ConsultarDados();
                cmb_Estadio.Text = Estadio.NomeEstadio;
            }
            else
            {
                MessageBox.Show("Ação cancelada com sucesso!");
                cmd_Ok.Text = "Adicionar";
                cmd_Localizar.Text = "Editar";
                cmd_Excluir.Visible = false;
               
            }
        }

        private void cmd_Excluir_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Deseja realmente deletar os dados deste jogo?", "Aviso", MessageBoxButtons.YesNo))
            {
                Jogo.DeletarDados();
                MessageBox.Show("Deletado com sucesso!");
                cmd_Excluir.Visible = false;
                cmd_Localizar.Text = "Editar";
                cmd_Ok.Text = "Adicionar";
            }
            else
            {
                MessageBox.Show("Ação Cancelada com sucesso!");
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            D = DateTime.Now;
            DateTime aux = dateTimePicker1.Value;
            TimeSpan Tempo = D-aux;
            if ((cmd_Localizar.Text != "Cancelar")||(cmd_Ok.Text=="Salvar"))
            {
                if (Tempo.TotalDays > 1)
                {
                    MessageBox.Show("Data menor que a data atual, insira uma data futura!!!");
                    if (cmd_Ok.Text == "Salvar")
                    {
                        dateTimePicker1.Text = Jogo.DataJogo;
                    }
                    else 
                    {
                        dateTimePicker1.Value = DateTime.Now;
                    }
                }
                else
                {
                    cmd_Ok.Enabled = true;
                }
            }
        }

        private void cmb_Campeonato_SelectedIndexChanged(object sender, EventArgs e)
        {
            Id = int.Parse(cmb_Campeonato.SelectedValue.ToString());
            Campeonato.IdCampeonato = Id;
            Campeonato.ConsultarDados();

            dadosOrganizaçao.IdCampeonato = Id;

            cmb_TimeCasa.ValueMember = "idEquipe";
            cmb_TimeCasa.DisplayMember = "nomeEquipe";
            cmb_TimeCasa.DataSource = dadosOrganizaçao.ListarDadosParaComboBox().Tables[0];

            cmb_Time2.ValueMember = "idEquipe";
            cmb_Time2.DisplayMember = "nomeEquipe";
            cmb_Time2.DataSource = dadosOrganizaçao.ListarDadosParaComboBox().Tables[0];
        }
        private void Pd_BeginPrint(object sender, PrintEventArgs e)
        {
            i = 0;
        }

        private void cmd_relatorio_Click(object sender, EventArgs e)
        {
            PrintDocument pd = new PrintDocument();
            pd.DocumentName = "Relatório de jogos por Campeonato";
            pd.BeginPrint += Pd_BeginPrint;
            pd.PrintPage += Imprimir;

            PrintPreviewDialog PPD = new PrintPreviewDialog();
            PPD.Document = pd;
            PPD.ShowDialog();
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
            Linha = "Jogos cadastrados por campeonato:";
            PosicaoHorizontal = MargemSuperior + ContadordeLinhas * AlturadaFonte;
            ev.Graphics.DrawString(Linha, fonte, Brushes.Red, MargemEsquerda, PosicaoHorizontal);
            ContadordeLinhas += 4;

            //Dados

            DataSet ds = Campeonato.RelatorioJogos();
            if (ds.Tables[0] != null)
            {
                while ((i < ds.Tables[0].Rows.Count) && (ContadordeLinhas < linhaPorPagina))
                {
                    DataRow item = ds.Tables[0].Rows[i];
                    if (auxiliar != int.Parse(item["idCampeonato"].ToString()))
                    {
                        ContadordeLinhas += 2;
                    }
                    if (auxiliar != int.Parse(item["idCampeonato"].ToString()))
                    {
                        Campeonato.IdCampeonato = int.Parse(item["idCampeonato"].ToString());
                        Campeonato.ConsultarDados();
                        Linha = "Campeonato: " + Campeonato.NomeCampeonato;
                        PosicaoHorizontal = MargemSuperior + ContadordeLinhas * AlturadaFonte;
                        ev.Graphics.DrawString(Linha, fonte, Brushes.Blue, MargemEsquerda, PosicaoHorizontal);
                        ContadordeLinhas += 3;

                        Linha = "Jogo";
                        PosicaoHorizontal = MargemSuperior + ContadordeLinhas * AlturadaFonte;
                        ev.Graphics.DrawString(Linha, fonte, Brushes.DarkGray, MargemEsquerda, PosicaoHorizontal);
                        Linha = "Data:";
                        PosicaoHorizontal = MargemSuperior + ContadordeLinhas * AlturadaFonte;
                        ev.Graphics.DrawString(Linha, fonte, Brushes.DarkGray, MargemEsquerda + 320, PosicaoHorizontal);
                        Linha = "Estadio";
                        PosicaoHorizontal = MargemSuperior + ContadordeLinhas * AlturadaFonte;
                        ev.Graphics.DrawString(Linha, fonte, Brushes.DarkGray, MargemEsquerda + 450, PosicaoHorizontal);

                        ContadordeLinhas += 1;
                        auxiliar = int.Parse(item["idCampeonato"].ToString());
                        ContadordeLinhas++;
                    }

                    Linha = item["Jogo"].ToString();
                    PosicaoHorizontal = MargemSuperior + ContadordeLinhas * AlturadaFonte;
                    ev.Graphics.DrawString(Linha, fonte, Brushes.Black, MargemEsquerda, PosicaoHorizontal);

                    DateTime D = new DateTime();
                    D = DateTime.Parse(item["Data"].ToString());
                    Linha = D.ToString("d");
                    PosicaoHorizontal = MargemSuperior + ContadordeLinhas * AlturadaFonte;
                    ev.Graphics.DrawString(Linha, fonte, Brushes.Black, MargemEsquerda + 320, PosicaoHorizontal);

                    Linha = item["Estadio"].ToString();
                    PosicaoHorizontal = MargemSuperior + ContadordeLinhas * AlturadaFonte;
                    ev.Graphics.DrawString(Linha, fonte, Brushes.Black, MargemEsquerda + 450, PosicaoHorizontal);
                    ContadordeLinhas += 2;

                    i++;
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
