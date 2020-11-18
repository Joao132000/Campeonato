using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace Campeonato
{
    public partial class frm_EditarJogo : MetroFramework.Forms.MetroForm
    {
        private JogoDados Jogo;
        private CampeonatoDados Camp;
        private int id;

        public int Id { get => id; set => id = value; }

        public frm_EditarJogo()
        {
            InitializeComponent();
            Jogo = new JogoDados();
            Camp = new CampeonatoDados();
        }

        private void frm_EditarJogo_Load(object sender, EventArgs e)
        {
            cmb_Campeonato.ValueMember = "idCampeonato";
            cmb_Campeonato.DisplayMember = "nomeCampeonato";
            cmb_Campeonato.DataSource = Camp.ListarDados().Tables[0];
            dataGridView1.DataSource = Jogo.ListarDadosEdicao().Tables[0];
            dataGridView1.Columns[0].Visible = false;
            //dataGridView1.Columns[1].Visible = false;
            dataGridView1.ReadOnly = true;
            dataGridView1.MultiSelect = false;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Rows[0].Selected = true;

        }
        private void metroButton1_Click(object sender, EventArgs e)
        {
            Jogo.Pesquisa = cmb_Campeonato.Text;
            dataGridView1.DataSource = Jogo.PesquisarPorCampeonato().Tables[0];
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Close();
        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            Id = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
        }

        private void cmb_Campeonato_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
