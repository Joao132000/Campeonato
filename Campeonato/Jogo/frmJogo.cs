using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Campeonato
{
    public partial class frmJogo : MetroFramework.Forms.MetroForm
    {
        private JogoDados Jogo = new JogoDados();
        private EquipeDados Equipe1 = new EquipeDados();
        private EquipeDados Equipe2 = new EquipeDados();
        private Organizacao_CampeonatoDados Org = new Organizacao_CampeonatoDados();
        private CampeonatoDados C = new CampeonatoDados();
        private int[] Tempo;
        private int id, aux = 0, R = 0;

        private int pontosDentro;
        private int equipeDentro;
        private int equipeFora;
        private int pontosFora;
        
        public frmJogo(int id,int D)
        {
            InitializeComponent();
            Id = id;
            Tempo = new int[2];
            R = D-1;
            Tempo[0] =D-1;
            Tempo[1] =59;
        }

        public int Id { get => id; set => id = value; }
        public int PontosDentro { get => pontosDentro; set => pontosDentro = value; }
        public int EquipeDentro { get => equipeDentro; set => equipeDentro = value; }
        public int EquipeFora { get => equipeFora; set => equipeFora = value; }
        public int PontosFora { get => pontosFora; set => pontosFora = value; }

        private void frmJogo_Load(object sender, EventArgs e)
        {
            Jogo.IdJogo=Id;
            Jogo.ConsultarDados();
            C.IdCampeonato = Jogo.IdCampeonato;
            C.ConsultarDados();
            lbl_Campeonato.Text = C.NomeCampeonato;
            Equipe1.IdEquipe = Jogo.IdEquipe1;
            Equipe2.IdEquipe = Jogo.IdEquipe2;
            Equipe1.ConsultarFoto();
            Equipe2.ConsultarFoto();
            txt_Time1.Text = Equipe1.NomeEquipe;
            txt_Time2.Text = Equipe2.NomeEquipe;
            if (!(Equipe1.Foto is null))
            {
                MemoryStream ms = new MemoryStream();
                ms.Write(Equipe1.Foto, 0, Equipe1.Foto.Length);
                pb_Time1.Image = Image.FromStream(ms);
            }
            if (!(Equipe2.Foto is null))
            {
                MemoryStream ms = new MemoryStream();
                ms.Write(Equipe2.Foto, 0, Equipe2.Foto.Length);
                pb_Imagem2.Image = Image.FromStream(ms);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Tempo[1]--;
            if ((Tempo[0] == 0) && (Tempo[1] == 0))
            {
                timer1.Stop();
                lbl_Tempo.Text = "00:00";
                if (aux == 2)
                {
                    MessageBox.Show("Partida Encerrada");
                    cmd_Iniciar.Enabled = true;
                    cmd_Iniciar.Text = "Sair";
                }else if (aux == 1)
                {
                    cmd_Iniciar.Enabled = true;
                    cmd_Iniciar.Text = "Iniciar 2º Tempo";
                }
            }
            else if (Tempo[1] == 0)
            {
                Tempo[0]--;
                Tempo[1] = 59;
                if (Tempo[0] < 10)
                {
                    lbl_Tempo.Text = "0" + Tempo[0].ToString() + ":" + Tempo[1].ToString();
                }
                else
                {
                    lbl_Tempo.Text = Tempo[0].ToString() + ":" + Tempo[1].ToString();
                }
            }
            else
            {
                if ((Tempo[0] < 10) && (Tempo[1] < 10))
                {
                    lbl_Tempo.Text = "0" + Tempo[0].ToString() + ":" + "0" + Tempo[1].ToString();
                }
                else if ((Tempo[0] < 10) && (Tempo[1] >= 10))
                {
                    lbl_Tempo.Text = "0" + Tempo[0].ToString() + ":" + Tempo[1].ToString();
                }
                else if ((Tempo[0] >= 10) && (Tempo[1] < 10))
                {
                    lbl_Tempo.Text = Tempo[0].ToString() + ":" + "0" + Tempo[1].ToString();
                }
                else
                {
                    lbl_Tempo.Text = Tempo[0].ToString() + ":" + Tempo[1].ToString();
                }
            }
        }

        private void cmd_Iniciar_Click(object sender, EventArgs e)
        {
            if (cmd_Iniciar.Text == "Iniciar 2º Tempo")
            {
                Tempo[0] = R;
                Tempo[1] = 59;
            }
            if (cmd_Iniciar.Text == "Jogo em Andamento")
            {
                timer1.Stop();
                cmd_Iniciar.Text = "Continuar";
            }
            if (cmd_Iniciar.Text == "Sair")
            {
                Jogo.IdJogo = Id;
                Jogo.ConsultarDados();
                Jogo.ResultadoEquipe1 = int.Parse(txt_gols1.Text);
                Jogo.ResultadoEquipe2 = int.Parse(txt_gols2.Text);
                Jogo.AlterarDados();

                Org.IdCampeonato = Jogo.IdCampeonato;
                Org.ConsultarDados();

                
                if ((int.Parse(txt_gols1.Text)) > (int.Parse(txt_gols2.Text)))
                {
                    
                    PontosDentro = 3;
                    Org.IdEquipe = Equipe1.IdEquipe;
                    Org.ConsultarDadosCampeonatoEquipe();
                    Org.Pontos += PontosDentro;
                    Org.AlterarDados();
                }
                else if((int.Parse(txt_gols2.Text)) > (int.Parse(txt_gols1.Text)))
                {
                    
                    PontosFora = 3;
                    Org.IdEquipe = Equipe2.IdEquipe;
                    Org.ConsultarDadosCampeonatoEquipe();
                    Org.Pontos += PontosFora;
                    Org.AlterarDados();
                }
                else 
                {
                    
                    Org.IdEquipe = Equipe1.IdEquipe;
                    Org.ConsultarDadosCampeonatoEquipe();
                    PontosDentro = 1;
                    Org.Pontos += PontosDentro;
                    Org.AlterarDados();
                    
                    Org.IdEquipe = Equipe2.IdEquipe;
                    Org.ConsultarDadosCampeonatoEquipe();
                    PontosFora = 1;
                    Org.Pontos += PontosFora;
                    Org.AlterarDados();
                }
                Close();
            }
            if (aux == 0)
            {
                aux++;
                lbl_tempos.Text = aux+"º Tempo";
                timer1.Start();
                cmd_Iniciar.Text = "Jogo em Andamento";
                cmd_Iniciar.Enabled = false;

            }
            else
            {
                aux++;
                lbl_tempos.Text = aux + "º Tempo";
                cmd_Iniciar.Text = "Jogo em Andamento";
                cmd_Iniciar.Enabled = false;

                timer1.Start();
            }
        }

        private void cmd_PreencherSumula_Click(object sender, EventArgs e)
        {
            FrmSumula S = new FrmSumula(id);
            S.ShowDialog();
            int aux1 = S.AuxEquipe;
            int gol = S.Gols;
            if (Equipe1.IdEquipe == aux1)
            {
                if(S.Identificador==1)
                    txt_gols1.Text = (int.Parse(txt_gols1.Text) + gol).ToString();
                else if (S.Identificador == 2)
                    txt_gols1.Text = (int.Parse(txt_gols1.Text) + gol).ToString();
            }
            else
            {
                if (S.Identificador == 1)
                    txt_gols2.Text = (int.Parse(txt_gols2.Text) + gol).ToString();
                else if (S.Identificador == 2)
                    txt_gols2.Text = (int.Parse(txt_gols2.Text) + gol).ToString();
            }
        }
    }
}
