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
    public partial class FrmEditarCampeonato : MetroFramework.Forms.MetroForm
    {
        public FrmEditarCampeonato()
        {
            InitializeComponent();
        }
        CampeonatoDados dados = new CampeonatoDados();

        private void FrmEditarCampeonato_Load(object sender, EventArgs e)
        {
            dados.NomeCampeonato = "";
            dataGridView1.DataSource = dados.ListarDados().Tables[0];

            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[4].Visible = false;
            dataGridView1.Columns[5].Visible = false;



            dataGridView1.ReadOnly = true;
            dataGridView1.MultiSelect = false;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Rows[0].Selected = true;
        }

        private void cmdPesquisar_Click(object sender, EventArgs e)
        {
            dados.NomeCampeonato = txtNomeCamp.Text;
            dataGridView1.DataSource = dados.ListarDadosParaConsulta().Tables[0];
        }

        private int id;
        public int Id { get => id; set => id = value; }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            Id = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Close();
        }

       
    }
}
