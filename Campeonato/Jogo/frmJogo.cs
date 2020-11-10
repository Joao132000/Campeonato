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
        private int tempo = 4500;
        private int id;
        public frmJogo(int id)
        {
            InitializeComponent();
            Id = id;
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
            tempo--;
            if (tempo == 0)
            {
                MessageBox.Show("Partida Encerrada");
            }
            else
            {
                lbl_Tempo.Text = tempo.ToString();
            }
           
        }

        private void cmd_Iniciar_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}
