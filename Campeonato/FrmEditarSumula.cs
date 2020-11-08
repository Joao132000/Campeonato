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
    public partial class FrmEditarSumula : MetroFramework.Forms.MetroForm
    {
        public FrmEditarSumula()
        {
            InitializeComponent();
        }

        SumulaDados dados = new SumulaDados();
        private int id;
        public int Id { get => id; set => id = value; }

        private void FrmEditarSumula_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = dados.ListarDados().Tables[0];
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.ReadOnly = true;
            dataGridView1.MultiSelect = false;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Rows[0].Selected = true;
        }
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            MessageBox.Show("Dados selecionados, faovr inserir novos dados!");
            Close();
        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            id = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
        }

        private void cmdPesquisar_Click(object sender, EventArgs e)
        {

        }
    }
}
