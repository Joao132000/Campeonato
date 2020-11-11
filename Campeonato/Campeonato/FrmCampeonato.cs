using MetroFramework.Controls;
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
    public partial class FrmCampeonato : MetroFramework.Forms.MetroForm
    {
        public FrmCampeonato()
        {
            InitializeComponent();
        }
        CampeonatoDados dados = new CampeonatoDados();
        int status;

        
        private void cmdNovo_Click(object sender, EventArgs e)
        {
            status = 1;
            cmdLocalizar.Enabled = false;
            cmdExcluir.Enabled = false;
            cmdNovo.Enabled = false;
            cmdSalvar.Enabled = true;
        }

        private void limpaControle()
        {
            foreach (Control item in this.Controls)
            {
                if (item is MetroTextBox)
                    item.Text = "";
            }

            cmbAno.SelectedIndex = -1;
            cmbTipo.SelectedIndex = -1;

        }

        private void cmdExcluir_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Deseja realmente excluir?", "Alerta", MessageBoxButtons.YesNo))
            {
                dados.DeletarDados();
                limpaControle();
                cmdLocalizar.Enabled = true;
                cmdExcluir.Enabled = false;
                cmdNovo.Enabled = true;
                cmdSalvar.Enabled = false;
            }
        }

        private void cmdSalvar_Click(object sender, EventArgs e)
        {
            dados.NomeCampeonato = txtNome.Text;
            dados.Ano = cmbAno.Text;
            dados.TipoCampeonato = cmbTipo.Text;

            if (status == 1)
            {
                dados.InlcuirDados();
                MessageBox.Show("Estadio Adicionado com sucesso");
            }
            else
            {
                dados.AlterarDados();
                MessageBox.Show("Registro Alterado com sucesso!!!");
            }
            status = 0;
            limpaControle();
            cmdLocalizar.Enabled = true;
            cmdExcluir.Enabled = false;
            cmdNovo.Enabled = true;
            cmdSalvar.Enabled = false;
        }

        private void FrmCampeonato_Load(object sender, EventArgs e)
        {
            cmdLocalizar.Enabled = true;
            cmdExcluir.Enabled = false;
            cmdNovo.Enabled = true;
            cmdSalvar.Enabled = false;
        }

        private void cmdLocalizar_Click(object sender, EventArgs e)
        {
            FrmEditarCampeonato edit = new FrmEditarCampeonato();
            edit.ShowDialog();
            dados.IdCampeonato = edit.Id;
            dados.ConsultarDados();
            txtNome.Text = dados.NomeCampeonato;
            cmbAno.Text = dados.Ano;
            cmbTipo.Text = dados.TipoCampeonato;
            cmdLocalizar.Enabled = true;
            cmdExcluir.Enabled = true;
            cmdNovo.Enabled = false;
            cmdSalvar.Enabled = true;
        }

       
    }
}
