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
    public partial class FrmClassificacao : MetroFramework.Forms.MetroForm
    {
        public FrmClassificacao()
        {
            InitializeComponent();
        }

        CampeonatoDados dadosCampenato = new CampeonatoDados();
        Organizacao_CampeonatoDados dados = new Organizacao_CampeonatoDados();
       
        private void cmdPesquisar_Click(object sender, EventArgs e)
        {
            dados.IdCampeonato = int.Parse(cmbCampeonato.SelectedValue.ToString());
            dataGridView1.DataSource = dados.ListarDadosParaConsulta().Tables[0];

            dadosCampenato.IdCampeonato = dados.IdCampeonato;
            dadosCampenato.ConsultarDados();

            if((dadosCampenato.Campeao!="") && (dadosCampenato.ViceCampeao != ""))
            {
                metroLabel2.Visible = true;
                metroLabel4.Visible = true;
                lblVice.Visible = true;
                lblCamp.Visible = true;
                lblCamp.Text = dadosCampenato.Campeao;
                lblVice.Text = dadosCampenato.ViceCampeao;
            }
            else
            {
                metroLabel2.Visible = false;
                metroLabel4.Visible = false;
                lblVice.Visible = false;
                lblCamp.Visible = false;
            }

            dataGridView1.ReadOnly = true;
            dataGridView1.MultiSelect = false;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

        }

        private void FrmClassificacao_Load(object sender, EventArgs e)
        {
            metroLabel2.Visible = false;
            metroLabel4.Visible = false;
            lblVice.Visible = false;
            lblCamp.Visible = false;
            cmbCampeonato.ValueMember = "idCampeonato";
            cmbCampeonato.DisplayMember = "nomeCampeonato";
            cmbCampeonato.DataSource = dadosCampenato.ListarDados().Tables[0];
        }

        private int i;

        private void cmdImprimir_Click(object sender, EventArgs e)
        {
            PrintDocument pd = new PrintDocument();
            pd.DocumentName = "Relatorio de Categorias";
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

        private void Imprimir(object sender, PrintPageEventArgs e)
        {
            //Config page
            float linhaPorPagina = 0;
            float posicaoVertical = 0;
            float contador = 0;
            float margemEsq = 20;
            float margemSup = 20;
            float alturaFonte = 0;
            string linha = "";

            Font fonte = new Font("Times New Roman", 20);
            Font fonteTitulo = new Font("Times New Roman", 25);
            alturaFonte = fonte.GetHeight(e.Graphics);
            linhaPorPagina = Convert.ToInt32(e.MarginBounds.Height / alturaFonte);

            //Titulo
            linha = "Classificação";
            posicaoVertical = margemSup + contador * alturaFonte;
            e.Graphics.DrawString(linha, fonteTitulo , Brushes.Black, margemEsq, posicaoVertical);

            contador += 3;

            //Subtitulo
            linha = "Posiçao";
            posicaoVertical = margemSup + contador * alturaFonte;
            e.Graphics.DrawString(linha, fonte, Brushes.Black, margemEsq, posicaoVertical);

            linha = "Time";
            posicaoVertical = margemSup + contador * alturaFonte;
            e.Graphics.DrawString(linha, fonte, Brushes.Black, margemEsq + 120, posicaoVertical);

            linha = "Pontos";
            posicaoVertical = margemSup + contador * alturaFonte;
            e.Graphics.DrawString(linha, fonte, Brushes.Black, margemEsq + 300, posicaoVertical);

            contador += 2;

            int c = 1;

            DataSet ds = dados.ListarDadosParaConsulta();
            

            if (ds.Tables[0] != null)
            {
                while (i < ds.Tables[0].Rows.Count && contador < linhaPorPagina)
                {
                    DataRow item = ds.Tables[0].Rows[i];

                    linha = c.ToString() + "º";
                    posicaoVertical = margemSup + contador * alturaFonte;
                    e.Graphics.DrawString(linha, fonte, Brushes.Black, margemEsq + 30, posicaoVertical);

                    linha = item["nomeEquipe"].ToString();
                    posicaoVertical = margemSup + contador * alturaFonte;
                    e.Graphics.DrawString(linha, fonte, Brushes.Black, margemEsq + 120, posicaoVertical);

                    linha = item["pontos"].ToString();
                    posicaoVertical = margemSup + contador * alturaFonte;
                    e.Graphics.DrawString(linha, fonte, Brushes.Black, margemEsq + 300, posicaoVertical);

                    contador ++;
                    i++;
                    c++;

                }

                contador+=2;

                //Campeao:
                linha = "Campeão:";
                posicaoVertical = margemSup + contador * alturaFonte;
                e.Graphics.DrawString(linha, fonte, Brushes.Black, margemEsq, posicaoVertical);
                

                dadosCampenato.IdCampeonato = dados.IdCampeonato;
                dadosCampenato.ConsultarDados();
                if (dadosCampenato.Campeao != "")
                {
                    linha = dadosCampenato.Campeao;
                    posicaoVertical = margemSup + contador * alturaFonte;
                    e.Graphics.DrawString(linha, fonte, Brushes.Black, margemEsq + 200, posicaoVertical);
                }
                else
                {
                    linha = "Indefinido";
                    posicaoVertical = margemSup + contador * alturaFonte;
                    e.Graphics.DrawString(linha, fonte, Brushes.Black, margemEsq + 200, posicaoVertical);
                }

                contador++;

                //Vice Campeão:
                linha = "Vice Campeão:";
                posicaoVertical = margemSup + contador * alturaFonte;
                e.Graphics.DrawString(linha, fonte, Brushes.Black, margemEsq, posicaoVertical);

                
               
                if (dadosCampenato.ViceCampeao!="") 
                {
                    linha = dadosCampenato.ViceCampeao;
                    posicaoVertical = margemSup + contador * alturaFonte;
                    e.Graphics.DrawString(linha, fonte, Brushes.Black, margemEsq + 200, posicaoVertical);
                }
                else
                {
                    linha = "Indefinido";
                    posicaoVertical = margemSup + contador * alturaFonte;
                    e.Graphics.DrawString(linha, fonte, Brushes.Black, margemEsq + 200, posicaoVertical);
                }

            }
            else MessageBox.Show("Tabela Vazia");

            if (contador > linhaPorPagina)
            {
                e.HasMorePages = true;
            }
            else
            {
                e.HasMorePages = false;
            }


        }
        private void cmdAddResult_Click(object sender, EventArgs e)
        {
            FrmCampeao_ViceCampeao cv = new FrmCampeao_ViceCampeao();
            cv.ShowDialog();
        }

        ///-------------------------------------------------------------------------------------------------------------------


        private void cmd_relatorio_Click(object sender, EventArgs e)
        {
            PrintDocument pd = new PrintDocument();
            pd.DocumentName = "Relatório de jogos por Campeonato";
            pd.BeginPrint += Pd_BeginPrint1;
            pd.PrintPage += Imprimir1;

            PrintPreviewDialog PPD = new PrintPreviewDialog();
            PPD.Document = pd;
            PPD.ShowDialog();
        }
        private void Pd_BeginPrint1(object sender, PrintEventArgs e)
        {
            i = 0;
        }

        private void Imprimir1(object sender, PrintPageEventArgs ev)
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
            Linha = "Resultado dos Jogos por Campeonato:";
            PosicaoHorizontal = MargemSuperior + ContadordeLinhas * AlturadaFonte;
            ev.Graphics.DrawString(Linha, fonte, Brushes.Red, MargemEsquerda, PosicaoHorizontal);
            ContadordeLinhas += 4;

            //Dados

            DataSet ds = dadosCampenato.RelatorioJogos();
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
                        dadosCampenato.IdCampeonato = int.Parse(item["idCampeonato"].ToString());
                        dadosCampenato.ConsultarDados();
                        Linha = "Campeonato: " + dadosCampenato.NomeCampeonato;
                        PosicaoHorizontal = MargemSuperior + ContadordeLinhas * AlturadaFonte;
                        ev.Graphics.DrawString(Linha, fonte, Brushes.Blue, MargemEsquerda, PosicaoHorizontal);
                        ContadordeLinhas += 3;

                        Linha = "Jogo";
                        PosicaoHorizontal = MargemSuperior + ContadordeLinhas * AlturadaFonte;
                        ev.Graphics.DrawString(Linha, fonte, Brushes.DarkGray, MargemEsquerda, PosicaoHorizontal);
                        Linha = "Resultado:";
                        PosicaoHorizontal = MargemSuperior + ContadordeLinhas * AlturadaFonte;
                        ev.Graphics.DrawString(Linha, fonte, Brushes.DarkGray, MargemEsquerda + 320, PosicaoHorizontal);
                       

                        ContadordeLinhas += 1;
                        auxiliar = int.Parse(item["idCampeonato"].ToString());
                        ContadordeLinhas++;
                    }

                    Linha = item["Jogo"].ToString();
                    PosicaoHorizontal = MargemSuperior + ContadordeLinhas * AlturadaFonte;
                    ev.Graphics.DrawString(Linha, fonte, Brushes.Black, MargemEsquerda, PosicaoHorizontal);

                    
                    Linha =item["resultadoEquipe1"].ToString();
                    PosicaoHorizontal = MargemSuperior + ContadordeLinhas * AlturadaFonte;
                    ev.Graphics.DrawString(Linha, fonte, Brushes.Black, MargemEsquerda + 320, PosicaoHorizontal);

                    Linha = "  x " + item["resultadoEquipe2"].ToString();
                    PosicaoHorizontal = MargemSuperior + ContadordeLinhas * AlturadaFonte;
                    ev.Graphics.DrawString(Linha, fonte, Brushes.Black, MargemEsquerda + 326, PosicaoHorizontal);
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
