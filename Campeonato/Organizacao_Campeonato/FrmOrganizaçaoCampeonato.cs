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
    public partial class FrmOrganizaçaoCampeonato : MetroFramework.Forms.MetroForm
    {
        public FrmOrganizaçaoCampeonato()
        {
            InitializeComponent();
        }

        private CampeonatoDados dadosCampeonato = new CampeonatoDados();
        private EquipeDados dadosEquipe = new EquipeDados();
        private Organizacao_CampeonatoDados dados = new Organizacao_CampeonatoDados();
        private int idCampeonato;
        private int idEquipe;

        private void OrganizaçaoCampeonato_Load(object sender, EventArgs e)
        {
            listTimes.Items.Clear();

            cmbCampeonatos.DisplayMember = "nomeCampeonato";
            cmbCampeonatos.ValueMember = "idCampeonato";
            cmbCampeonatos.DataSource = dadosCampeonato.ListarDados().Tables[0];

            cmbTimes.DisplayMember = "nomeEquipe";
            cmbTimes.ValueMember = "idEquipe";
            cmbTimes.DataSource = dadosEquipe.ListarDados().Tables[0];
        }

        private void cmdAdicionar_Click(object sender, EventArgs e)
        {
            dadosCampeonato.NomeCampeonato = cmbCampeonatos.Text;
            dadosEquipe.NomeEquipe = cmbTimes.Text;
            dados.IncluirDados();
            listTimes.Items.Add(dadosEquipe.NomeEquipe);
        }

        private void cmbCampeonatos_SelectedIndexChanged(object sender, EventArgs e)
        {
            idCampeonato = int.Parse(cmbCampeonatos.SelectedValue.ToString());
            dados.IdCampeonato = idCampeonato;
            listTimes.Items.Clear();

        }

        private void cmbTimes_SelectedIndexChanged(object sender, EventArgs e)
        {
            idEquipe = int.Parse(cmbTimes.SelectedValue.ToString());
            dados.IdEquipe = idEquipe;
        }

        private void cmdTabela_Click(object sender, EventArgs e)
        {
            FrmClassificacao fc = new FrmClassificacao();
            fc.ShowDialog();
        }
    }
}
