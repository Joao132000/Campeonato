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
    public partial class Frm_Jogador : MetroFramework.Forms.MetroForm
    {
        public Frm_Jogador()
        {
            InitializeComponent();
        }

        private JogadorDados dados = new JogadorDados();

        private void cmd_Processar_Click(object sender, EventArgs e)
        {
            dados.NomeJogador = txt_Nome.Text;
            dados.IdEquipe = 1;
            dados.InlcuirDados();
            MessageBox.Show("Registro incluído com sucesso");

        }

       
    }
}
