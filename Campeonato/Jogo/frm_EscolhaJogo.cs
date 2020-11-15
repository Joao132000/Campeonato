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
    public partial class frm_EscolhaJogo : MetroFramework.Forms.MetroForm
    {
        private CampeonatoDados Campeonato;
        private JogoDados Jogo;
        public frm_EscolhaJogo()
        {
            InitializeComponent();
            Campeonato = new CampeonatoDados();
            Jogo = new JogoDados();
        }
        private void frm_EscolhaJogo_Load(object sender, EventArgs e)
        {
            cmb_Campeonato.ValueMember = "idCampeonato";
            cmb_Campeonato.DisplayMember = "nomeCampeonato";
            cmb_Campeonato.DataSource = Campeonato.ListarDados().Tables[0];
        }

        private void cmb_Campeonato_SelectedIndexChanged(object sender, EventArgs e)
        {
            Jogo.IdCampeonato = int.Parse(cmb_Campeonato.SelectedValue.ToString());
            cmb_jogo.ValueMember = "idJogo";
            cmb_jogo.DisplayMember = "Jogo";
            cmb_jogo.DataSource = Jogo.ListarDadosNomeJogo().Tables[0];
            cmb_jogo.Enabled = true;
        }

        private void cmb_jogo_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmd_Iniciar.Enabled = true;
            nud_tempo.Enabled = true;
        }

        private void cmd_Voltar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cmd_Iniciar_Click(object sender, EventArgs e)
        {
            if (nud_tempo.Value == 0)
            {
                MessageBox.Show("Favor inserir a duração dos tempos!!!");
            }
            else
            {
                frmJogo J1 = new frmJogo(int.Parse(cmb_jogo.SelectedValue.ToString()),int.Parse(nud_tempo.Value.ToString()));
                J1.ShowDialog();
            }
        }

        private void nud_tempo_ValueChanged(object sender, EventArgs e)
        {
            if (nud_tempo.Value >= 60)
            {
                MessageBox.Show("O tempo máximo é de 60 minutos!!");
                nud_tempo.Value = 60;
            }
        }
    }
}
