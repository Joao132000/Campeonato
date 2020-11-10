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
    public partial class Frm_EditarJogador : MetroFramework.Forms.MetroForm
    {
        private JogadorDados Jogador;
        private int idJogador;
        public Frm_EditarJogador()
        {
            InitializeComponent();
            Jogador = new JogadorDados();
        }
        public int IdJogador { get => idJogador; set => idJogador = value; }
        private void Frm_EditarJogador_Load(object sender, EventArgs e)
        {
            Jogador.NomeJogador = "";
            dataGridView1.DataSource = Jogador.ListarDados().Tables[0];
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].Visible = false;
            dataGridView1.ReadOnly = true;
            dataGridView1.MultiSelect = false;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Rows[0].Selected = true;
        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            IdJogador = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Close();
        }

        private void cmd_Localizar_Click(object sender, EventArgs e)
        {
            Jogador.NomeJogador = txt_nomeJogador.Text;
            dataGridView1.DataSource = Jogador.PesquisarJogador().Tables[0];
        }
    }
}
