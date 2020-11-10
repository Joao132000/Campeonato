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
    public partial class FrmClassificacao : MetroFramework.Forms.MetroForm
    {
        public FrmClassificacao()
        {
            InitializeComponent();
        }

        CampeonatoDados dadosCampenato = new CampeonatoDados();
        Organizacao_CampeonatoDados dados = new Organizacao_CampeonatoDados();
       
        private void cmdPesquisar_Click(object sender, EventArgs e)
        {
            dados.NomeCampeonato = cmbCampeonato.Text;
            dataGridView1.DataSource = dados.ListarDadosParaConsulta().Tables[0];

            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].Visible = false;
            dataGridView1.Columns[2].Visible = false;

            dataGridView1.ReadOnly = true;
            dataGridView1.MultiSelect = false;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

        }

        private void FrmClassificacao_Load(object sender, EventArgs e)
        {
            cmbCampeonato.ValueMember = "idCampeonato";
            cmbCampeonato.DisplayMember = "nomeCampeonato";
            cmbCampeonato.DataSource = dadosCampenato.ListarDados().Tables[0];



            
        }
    }
}
