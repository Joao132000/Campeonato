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
    public partial class FrmCampeao_ViceCampeao : MetroFramework.Forms.MetroForm
    {
        public FrmCampeao_ViceCampeao()
        {
            InitializeComponent();
        }

        CampeonatoDados dados = new CampeonatoDados();


        private int id;
        public int Id { get => id; set => id = value; }


        private void cmdAdicionar_Click(object sender, EventArgs e)
        {
            dados.Campeao = txtCamp.Text;
            dados.ViceCampeao = txtVice.Text;
            dados.AlterarDadosCampeao_Vice();
            MessageBox.Show("Atualizado com sucesso");
            txtVice.Clear();
            txtCamp.Clear();
        }


        private void FrmCampeao_ViceCampeao_Load(object sender, EventArgs e)
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

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Id = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            dados.IdCampeonato = Id;
            dados.ConsultarDados();
            txtCamp.Text = dados.Campeao;
            txtVice.Text = dados.ViceCampeao;
        }

        private void cmdPesquisar_Click_1(object sender, EventArgs e)
        {
            dados.NomeCampeonato = txtNomeCamp.Text;
            dataGridView1.DataSource = dados.ListarDadosParaConsulta().Tables[0];
        }
    }
}
