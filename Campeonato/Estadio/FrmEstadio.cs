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
    public partial class FrmEstadio : MetroFramework.Forms.MetroForm
    {
        public FrmEstadio()
        {
            InitializeComponent();
        }

        private EstadioDados dados = new EstadioDados();

        private void cmdSalvar_Click(object sender, EventArgs e)
        {
            dados.NomeEstadio = txtEstadio.Text;
            dados.Estado = cmbEstado.Text;

            if (status == 1)
            {
                dados.IncluirDados();
                txtEstadio.Clear();
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

        int status = 0;
        private void cmdNovo_Click(object sender, EventArgs e)
        {
            status = 1;
            cmdLocalizar.Enabled = false;
            cmdExcluir.Enabled = false;
            cmdNovo.Enabled = false;
            cmdSalvar.Enabled = true;
        }

        private void cmdLocalizar_Click(object sender, EventArgs e)
        {
            FrmLocalizarEstadio loc = new FrmLocalizarEstadio();
            loc.ShowDialog();
            dados.IdEstadio = loc.Id;
            dados.ConsultarDados();
            txtEstadio.Text = dados.NomeEstadio;
            cmbEstado.Text = dados.Estado;
            cmdLocalizar.Enabled = true;
            cmdExcluir.Enabled = true;
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

            cmbEstado.SelectedIndex = -1;
        }

        private void FrmEstadio_Load(object sender, EventArgs e)
        {
            cmdLocalizar.Enabled = true;
            cmdExcluir.Enabled = false;
            cmdNovo.Enabled = true;
            cmdSalvar.Enabled = false;
        }

       
    }
}
