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

        private void cmdCriarCampeonato_Click(object sender, EventArgs e)
        {
            FrmOrganizaçaoCampeonato forg = new FrmOrganizaçaoCampeonato();
            forg.ShowDialog();
        }

        private void cmdJogo_Click(object sender, EventArgs e)
        {
            frm_EscolhaJogo Escolha = new frm_EscolhaJogo();
            Escolha.ShowDialog();
        }

        private void cmdClassificaçao_Click(object sender, EventArgs e)
        {
            FrmClassificacao fc = new FrmClassificacao();
            fc.ShowDialog();
        }

        private void cmdCriarJogo_Click(object sender, EventArgs e)
        {
            frm_SeleçãoJogo Jogo = new frm_SeleçãoJogo();
            Jogo.ShowDialog();
        }
    }
}
