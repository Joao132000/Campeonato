using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Campeonato
{
    public partial class FrmTime : MetroFramework.Forms.MetroForm
    {
        public FrmTime()
        {
            InitializeComponent();
        }

        EquipeDados dados = new EquipeDados();
        private string status = "Inserindo";

        private void cmdNovo_Click(object sender, EventArgs e)
        {
            txtCidade.Enabled = true;
            txtNome.Enabled = true;
            cmdSalvar.Enabled = true;
            cmdImagem.Enabled = true;
        }

        private void cmdSalvar_Click(object sender, EventArgs e)
        {
            if (status == "Inserindo")
            {
                if (DialogResult.OK == MessageBox.Show("Deseja realmente salvar?", "Alerta", MessageBoxButtons.OKCancel))
                {
                    dados.NomeEquipe = txtNome.Text;
                    dados.CidadeEquipe = txtCidade.Text;
                    dados.IncluirDados();
                    MessageBox.Show("Registro incluído com sucesso!!!!");

                    txtCidade.Text = "";
                    txtNome.Text = "";
                }
            }

            cmdSalvar.Enabled = false;

            if (status == "Editando")
            {
                if (DialogResult.OK == MessageBox.Show("Deseja realmente salvar?", "Alerta", MessageBoxButtons.OKCancel))
                {
                    dados.NomeEquipe = txtNome.Text;
                    dados.CidadeEquipe = txtCidade.Text;
                    dados.AlterarDados();
                    MessageBox.Show("Registro alterado com sucesso!!!!");

                    txtCidade.Text = "";
                    txtNome.Text = "";
                }
            }
        }
        private void cmdEditar_Click(object sender, EventArgs e)
        {
            txtCidade.Enabled = true;
            txtNome.Enabled = true;
            cmdSalvar.Enabled = true;
            cmdExcluir.Enabled = true;
            cmdImagem.Enabled = true;

            status = "Editando";

            FrmEditarTime ED = new FrmEditarTime();
            ED.ShowDialog();
            dados.IdEquipe = ED.Id;

            dados.ConsultarFoto();

            txtNome.Text = dados.NomeEquipe;
            txtCidade.Text = dados.CidadeEquipe;

            if (!(dados.Foto is null))
            {
                MemoryStream ms = new MemoryStream();
                ms.Write(dados.Foto, 0, dados.Foto.Length);
                pictureBox1.Image = Image.FromStream(ms);
            }
        }
        private void cmdExcluir_Click(object sender, EventArgs e)
        {
            if (DialogResult.OK == MessageBox.Show("Deseja realmente excluir?", "Alerta", MessageBoxButtons.OKCancel))
            {
                dados.DeletarDados();

                txtCidade.Text = "";
                txtNome.Text = "";
            }
        }
        private void ConverteFoto()
        {
            if (pictureBox1.Image != null)
            {
                MemoryStream ms = new MemoryStream();
                pictureBox1.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                byte[] foto_array = new byte[ms.Length];
                ms.Position = 0;
                ms.Read(foto_array, 0, foto_array.Length);
                dados.Foto = foto_array;
            }
        }
        private void cmdImagem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string nome = openFileDialog1.FileName;
                pictureBox1.Image = Image.FromFile(nome);
                ConverteFoto();
            }
        }
    }
}
