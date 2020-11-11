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
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void jogoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_SeleçãoJogo Jogo = new frm_SeleçãoJogo();
            Jogo.ShowDialog();
        }

        private void sumulaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmSumula S = new FrmSumula();
            S.ShowDialog();
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            FrmOrganizaçaoCampeonato forg = new FrmOrganizaçaoCampeonato();
            forg.ShowDialog();
        }
        //---------------------------------------------------------------
        private void cmdTime_Click(object sender, EventArgs e)
        {
            FrmTime T = new FrmTime();
            T.ShowDialog();
        }

        private void cmdJogador_Click(object sender, EventArgs e)
        {
            Frm_Jogador J = new Frm_Jogador();
            J.ShowDialog();
        }

        private void cmdEstadio_Click(object sender, EventArgs e)
        {
            FrmEstadio E = new FrmEstadio();
            E.ShowDialog();
        }

        private void cmdCampeonato_Click(object sender, EventArgs e)
        {
            FrmCampeonato Camp = new FrmCampeonato();
            Camp.ShowDialog();
        }
    }
}
