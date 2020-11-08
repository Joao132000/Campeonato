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
    public partial class FrmPrincipal : MetroFramework.Forms.MetroForm
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

       

        private void jogadorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Jogador J = new Frm_Jogador();
            J.ShowDialog();
        }

        private void estadioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmEstadio E = new FrmEstadio();
            E.ShowDialog();
        }
        private void equipeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmTime T = new FrmTime();
            T.ShowDialog();
        }

        private void jogoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_SeleçãoJogo Jogo = new frm_SeleçãoJogo();
            Jogo.ShowDialog();
        }
    }
}
