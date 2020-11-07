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
    public partial class FrmEditarTime : MetroFramework.Forms.MetroForm
    {
        public FrmEditarTime()
        {
            InitializeComponent();
        }

        EquipeDados dados = new EquipeDados();
        private int id;
        public int Id { get => id; set => id = value; }

        private void cmdPesquisar_Click(object sender, EventArgs e)
        {
            dados.NomeEquipe = txtNome.Text;
            dataGridView1.DataSource = dados.ListarDados().Tables[0];
        }

        private void FrmEditarTime_Load(object sender, EventArgs e)
        {
            dados.NomeEquipe = "";
            dataGridView1.DataSource = dados.ListarDados().Tables[0];
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.ReadOnly = true;
            dataGridView1.MultiSelect = false;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Rows[0].Selected = true;
        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            id = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            Close();
        }
    }
}
