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
        public FrmEditarSumula(int a)
        {
            InitializeComponent();
            this.a = a;
        }

        private int a;
        
        SumulaDados dados = new SumulaDados();
        private int id;

        public int Id { get => id; set => id = value; }

        private void FrmEditarSumula_Load(object sender, EventArgs e)
        {
            dados.IdJogo = a;
            dataGridView1.DataSource = dados.ListarDadosJogadorParaEditar().Tables[0];
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.ReadOnly = true;
            dataGridView1.MultiSelect = false;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Rows[0].Selected = true;
        }

        private void cmdPesquisar_Click(object sender, EventArgs e)
        {
            dados.AuxNomeJogador = txtNome.Text;
            dataGridView1.DataSource = dados.ListarDadosJogador().Tables[0];
        }


        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            id = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            MessageBox.Show("Dados selecionados!");
            Close();
        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
           
        }
    }
}
