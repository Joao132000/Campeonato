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
    public partial class frm_SeleçãoJogo : MetroFramework.Forms.MetroForm
    {
        private CampeonatoDados Campeonato;
        private EquipeDados EquipeCasa;
        private EquipeDados EquipeFora;
        private EstadioDados Estadio;
        private JogoDados Jogo;
        private int id;
        DateTime D;
        public int Id { get => id; set => id = value; }

        public frm_SeleçãoJogo()
        {
            InitializeComponent();
            Campeonato= new CampeonatoDados();
            EquipeCasa = new EquipeDados();
            EquipeFora = new EquipeDados();
            Estadio = new EstadioDados();
            Jogo = new JogoDados();
            D = new DateTime();
        }
        private void metroButton1_Click(object sender, EventArgs e)
        {
            if (cmd_Ok.Text == "Adicionar")
            {
                if (cmb_Time2.SelectedValue.ToString() == cmb_TimeCasa.SelectedValue.ToString())
                {
                    MessageBox.Show("Não é possível confirmar a seleção!\n\tTimes iguais!!");
                }
                else
                {
                    Jogo.IdEquipe1 = int.Parse(cmb_TimeCasa.SelectedValue.ToString());
                    Jogo.IdEquipe2 = int.Parse(cmb_Time2.SelectedValue.ToString());
                    Jogo.IdEstadio = int.Parse(cmb_Estadio.SelectedValue.ToString());
                    Jogo.IdCampeonato = int.Parse(cmb_Campeonato.SelectedValue.ToString());
                    Jogo.DataJogo = dateTimePicker1.Value.ToString();
                    Jogo.ResultadoEquipe1 = 0;
                    Jogo.ResultadoEquipe2 = 0;
                    Jogo.InlcuirDados();
                    MessageBox.Show("Adicionado com sucesso!");
                }
            } else if (cmd_Ok.Text == "Salvar")
            {
                Jogo.IdEquipe1 = int.Parse(cmb_TimeCasa.SelectedValue.ToString());
                Jogo.IdEquipe2 = int.Parse(cmb_Time2.SelectedValue.ToString());
                Jogo.IdEstadio = int.Parse(cmb_Estadio.SelectedValue.ToString());
                Jogo.IdCampeonato = int.Parse(cmb_Campeonato.SelectedValue.ToString());
                Jogo.DataJogo = dateTimePicker1.Value.ToString();
                Jogo.ResultadoEquipe1 = int.Parse(txt_Pontos1.Text);
                Jogo.ResultadoEquipe2 = int.Parse(txt_Pontos2.Text);
                Jogo.AlterarDados();
                cmd_Ok.Text = "Adicionar";
                cmd_Localizar.Text = "Editar";
                cmd_Excluir.Visible = false;
                txt_Pontos1.Enabled = false;
                txt_Pontos2.Enabled = false;
                txt_Pontos1.Text = "";
                txt_Pontos2.Text = "";
                MessageBox.Show("Alterações salvas com sucesso");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmb_Campeonato.ValueMember = "idCampeonato";
            cmb_Campeonato.DisplayMember = "nomeCampeonato";
            cmb_Campeonato.DataSource = Campeonato.ListarDados().Tables[0];

            cmb_Estadio.ValueMember = "idEstadio";
            cmb_Estadio.DisplayMember = "nomeEstadio";
            cmb_Estadio.DataSource = Estadio.ListarDados().Tables[0];
            
            }

        private void cmd_Localizar_Click(object sender, EventArgs e)
        {
            if (cmd_Localizar.Text == "Editar")
            {
                frm_EditarJogo EJ = new frm_EditarJogo();
                EJ.ShowDialog();
                Jogo.IdJogo = EJ.Id;
                Jogo.ConsultarDados();
                cmd_Localizar.Text = "Cancelar";
                dateTimePicker1.Text = Jogo.DataJogo;
                txt_Pontos1.Text = Jogo.ResultadoEquipe1.ToString();
                txt_Pontos2.Text = Jogo.ResultadoEquipe2.ToString();
                txt_Pontos1.Enabled = true;
                txt_Pontos2.Enabled = true;
                cmd_Ok.Text = "Salvar";
                cmd_Excluir.Visible = true;

                Campeonato.IdCampeonato = Jogo.IdCampeonato;
                Campeonato.ConsultarDados();
                cmb_Campeonato.Text = Campeonato.NomeCampeonato;

                EquipeCasa.IdEquipe = Jogo.IdEquipe1;
                EquipeCasa.ConsultarDados();
                cmb_TimeCasa.Text = EquipeCasa.NomeEquipe;

                EquipeFora.IdEquipe = Jogo.IdEquipe2;
                EquipeFora.ConsultarDados();
                cmb_Time2.Text = EquipeFora.NomeEquipe;

                Estadio.IdEstadio = Jogo.IdEstadio;
                Estadio.ConsultarDados();
                cmb_Estadio.Text = Estadio.NomeEstadio;
            }
            else
            {
                MessageBox.Show("Ação cancelada com sucesso!");
                cmd_Ok.Text = "Adicionar";
                cmd_Localizar.Text = "Editar";
                cmd_Excluir.Visible = false;
                txt_Pontos1.Enabled = false;
                txt_Pontos2.Enabled = false;
                txt_Pontos1.Text = "";
                txt_Pontos2.Text = "";
            }
        }

        private void cmd_Excluir_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Deseja realmente deletar os dados deste jogo?", "Aviso", MessageBoxButtons.YesNo))
            {
                Jogo.DeletarDados();
                MessageBox.Show("Deletado com sucesso!");
                cmd_Excluir.Visible = false;
                cmd_Localizar.Text = "Editar";
                cmd_Ok.Text = "Adicionar";
            }
            else
            {
                MessageBox.Show("Ação Cancelada com sucesso!");
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            D = DateTime.Now;
            DateTime aux = dateTimePicker1.Value;
            TimeSpan Tempo = D-aux;
            if ((cmd_Localizar.Text != "Cancelar")||(cmd_Ok.Text=="Salvar"))
            {
                if (Tempo.TotalDays > 1)
                {
                    MessageBox.Show("Data menor que a data atual, insira uma data futura!!!");
                    if (cmd_Ok.Text == "Salvar")
                    {
                        dateTimePicker1.Text = Jogo.DataJogo;
                    }
                    else 
                    {
                        dateTimePicker1.Value = DateTime.Now;
                    }
                }
                else
                {
                    cmd_Ok.Enabled = true;
                }
            }
        }

        private void cmb_Campeonato_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmb_TimeCasa.ValueMember = "idEquipe";
            cmb_TimeCasa.DisplayMember = "nomeEquipe";
            cmb_TimeCasa.DataSource = EquipeCasa.ListarDados().Tables[0];

            cmb_Time2.ValueMember = "idEquipe";
            cmb_Time2.DisplayMember = "nomeEquipe";
            cmb_Time2.DataSource = EquipeFora.ListarDados().Tables[0];
        }
    }
}
