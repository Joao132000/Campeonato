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
        private int[] Tempo;
        private int id, aux = 0, R = 0;
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

        private void frmJogo_Load(object sender, EventArgs e)
        {
            Jogo.IdJogo=Id;
            Jogo.ConsultarDados();
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
                    cmd_Iniciar.Text = "Sair";
                }else if (aux == 1)
                {
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
            if (cmd_Iniciar.Text == "Pausar")
            {
                timer1.Stop();
                cmd_Iniciar.Text = "Continuar";
            }
            if (cmd_Iniciar.Text == "Sair")
            {
                Close();
            }
            if (aux == 0)
            {
                aux++;
                lbl_tempos.Text = aux+"º Tempo";
                timer1.Start();
                cmd_Iniciar.Text = "Pausar";
            }
            else
            {
                aux++;
                lbl_tempos.Text = aux + "º Tempo";
                cmd_Iniciar.Text = "Pausar";
                timer1.Start();
            }
        }

        private void cmd_PreencherSumula_Click(object sender, EventArgs e)
        {
            FrmSumula S = new FrmSumula(id);
            S.ShowDialog();
        }
    }
}
