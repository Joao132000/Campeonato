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
    public partial class Frm_Jogador : MetroFramework.Forms.MetroForm
    {
        private JogadorDados Jogador;
        private EquipeDados Times;
        public Frm_Jogador()
        {
            InitializeComponent();
            Jogador = new JogadorDados();
            Times = new EquipeDados();
        }

        

        private void cmd_Processar_Click(object sender, EventArgs e)
        {
            if (cmd_Processar.Text == "Salvar")
            {
                Jogador.NomeJogador = txt_Nome.Text;
                Jogador.DataNascimento = Mtxt_Data.Text;
                Jogador.NumeroCamisa = int.Parse(txt_Numero.Text);
                Jogador.IdEquipe = int.Parse(cmb_Time.SelectedValue.ToString());
                Jogador.InlcuirDados();
                MessageBox.Show("Registro incluído com sucesso");
            }
            else if (cmd_Processar.Text == "Alterar")
            {
                Jogador.NomeJogador = txt_Nome.Text;
                Jogador.DataNascimento = Mtxt_Data.Text;
                Jogador.NumeroCamisa = int.Parse(txt_Numero.Text);
                Jogador.IdEquipe = int.Parse(cmb_Time.SelectedValue.ToString());
                if (DialogResult.Yes == MessageBox.Show("Deseja realmente alterar os dados deste jogador?", "Aviso", MessageBoxButtons.YesNo))
                {
                    Jogador.AlterarDados();
                    MessageBox.Show("Dados alterados com sucesso!");
                    cmdLocalizar.Enabled = true;
                    cmd_Excluir.Text = "Excluir";
                    cmdLocalizar.Text = "Localizar";
                }
            }
        }

        private void cmdLocalizar_Click(object sender, EventArgs e)
        {
            if (cmdLocalizar.Text == "Localizar")
            {
                Frm_EditarJogador J = new Frm_EditarJogador();
                J.ShowDialog();
                cmd_Processar.Text = "Alterar";
                Jogador.IdJogador = J.IdJogador;
                Jogador.ConsultarDados();
                txt_Nome.Text = Jogador.NomeJogador;
                txt_Numero.Text = Jogador.NumeroCamisa.ToString();
                Mtxt_Data.Text = Jogador.DataNascimento;
                Times.IdEquipe = Jogador.IdEquipe;
                Times.ConsultarDados();
                cmb_Time.Text = Times.NomeEquipe;
                cmd_Excluir.Text = "Cancelar";
                cmdLocalizar.Text = "Excluir";
            }
            else
            {
                if (DialogResult.Yes == MessageBox.Show("Deseja realmente deletar os dados deste jogador?", "Aviso", MessageBoxButtons.YesNo))
                {
                    Jogador.DeletarDados();
                    MessageBox.Show("Dados deletados com sucesso!");
                    txt_Nome.Text = "";
                    txt_Numero.Text = "";
                    Mtxt_Data.Text = "";
                    cmdLocalizar.Text = "Localizar";
                    cmd_Excluir.Text = "Excluir";
                }
            }
        }

        private void Frm_Jogador_Load(object sender, EventArgs e)
        {
            cmb_Time.DisplayMember = "nomeEquipe";
            cmb_Time.ValueMember = "idEquipe";
            cmb_Time.DataSource = Times.ListarDados().Tables[0];
        }

        private void cmd_Excluir_Click(object sender, EventArgs e)
        {
            if (cmd_Excluir.Text == "Excluir")
            {
                if (DialogResult.Yes == MessageBox.Show("Deseja realmente deletar os dados deste jogador?", "Aviso", MessageBoxButtons.YesNo))
                {
                    Jogador.DeletarDados();
                    MessageBox.Show("Dados deletados com sucesso!");
                    txt_Nome.Text = "";
                    txt_Numero.Text = "";
                    Mtxt_Data.Text = "";
                }
            }
            else
            {
                MessageBox.Show("Ação cancelada com sucesso!");
                cmd_Processar.Text = "Salvar";
                cmdLocalizar.Text = "Localizar";
                cmd_Excluir.Text = "Excluir";
                txt_Nome.Text = "";
                txt_Numero.Text = "";
                Mtxt_Data.Text = "";
            }
        }
    }
}
