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

        CampeonatoDados dadosCampeonato = new CampeonatoDados();
        private EquipeDados dadosEquipe = new EquipeDados();
        Organizacao_CampeonatoDados dadosOrganizaçao = new Organizacao_CampeonatoDados();


        private int id;
        public int Id { get => id; set => id = value; }


        private void cmdAdicionar_Click(object sender, EventArgs e)
        {
            
            if(cmbCampeao.Text != cmbViceCampeao.Text)
            {
                dadosCampeonato.Campeao = cmbCampeao.Text;
                dadosCampeonato.ViceCampeao = cmbViceCampeao.Text;
                dadosCampeonato.AlterarDadosCampeao_Vice();
                MessageBox.Show("Atualizado com sucesso");
                cmbViceCampeao.SelectedValue = -1;
                cmbCampeao.SelectedValue = -1;
            }
            else
            {
                MessageBox.Show("Campeão e Vice nao podem ser os mesmos.");
            }
          
        }


        private void FrmCampeao_ViceCampeao_Load(object sender, EventArgs e)
        {
            dadosCampeonato.NomeCampeonato = "";
            dataGridView1.DataSource = dadosCampeonato.ListarDados().Tables[0];

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
            dadosCampeonato.IdCampeonato = Id;
            dadosCampeonato.ConsultarDados();

            dadosOrganizaçao.IdCampeonato = id;
            
            cmbCampeao.DisplayMember = "nomeEquipe";
            cmbCampeao.ValueMember = "idEquipe";
            cmbCampeao.DataSource = dadosOrganizaçao.ListarDadosParaComboBox().Tables[0];

            cmbViceCampeao.DisplayMember = "nomeEquipe";
            cmbViceCampeao.ValueMember = "idEquipe";
            cmbViceCampeao.DataSource = dadosOrganizaçao.ListarDadosParaComboBox().Tables[0];


        }

    private void cmdPesquisar_Click_1(object sender, EventArgs e)
        {
            dadosCampeonato.NomeCampeonato = txtNomeCamp.Text;
            dataGridView1.DataSource = dadosCampeonato.ListarDadosParaConsulta().Tables[0];
        }
    }
}
