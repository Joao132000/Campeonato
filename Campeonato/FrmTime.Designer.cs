namespace Campeonato
{
    partial class FrmTime
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cmdImagem = new MetroFramework.Controls.MetroButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cmdEditar = new MetroFramework.Controls.MetroButton();
            this.cmdExcluir = new MetroFramework.Controls.MetroButton();
            this.cmdNovo = new MetroFramework.Controls.MetroButton();
            this.cmdSalvar = new MetroFramework.Controls.MetroButton();
            this.txtCidade = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.txtNome = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // cmdImagem
            // 
            this.cmdImagem.Enabled = false;
            this.cmdImagem.Location = new System.Drawing.Point(450, 181);
            this.cmdImagem.Name = "cmdImagem";
            this.cmdImagem.Size = new System.Drawing.Size(83, 31);
            this.cmdImagem.TabIndex = 27;
            this.cmdImagem.Text = "Carregar";
            this.cmdImagem.Click += new System.EventHandler(this.cmdImagem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Image = global::Campeonato.Properties.Resources._36601;
            this.pictureBox1.Location = new System.Drawing.Point(405, 31);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(177, 144);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 26;
            this.pictureBox1.TabStop = false;
            // 
            // cmdEditar
            // 
            this.cmdEditar.Location = new System.Drawing.Point(188, 226);
            this.cmdEditar.Name = "cmdEditar";
            this.cmdEditar.Size = new System.Drawing.Size(83, 31);
            this.cmdEditar.TabIndex = 25;
            this.cmdEditar.Text = "Editar";
            this.cmdEditar.Click += new System.EventHandler(this.cmdEditar_Click);
            // 
            // cmdExcluir
            // 
            this.cmdExcluir.Enabled = false;
            this.cmdExcluir.Location = new System.Drawing.Point(277, 226);
            this.cmdExcluir.Name = "cmdExcluir";
            this.cmdExcluir.Size = new System.Drawing.Size(83, 31);
            this.cmdExcluir.TabIndex = 24;
            this.cmdExcluir.Text = "Excluir";
            this.cmdExcluir.Click += new System.EventHandler(this.cmdExcluir_Click);
            // 
            // cmdNovo
            // 
            this.cmdNovo.Location = new System.Drawing.Point(18, 226);
            this.cmdNovo.Name = "cmdNovo";
            this.cmdNovo.Size = new System.Drawing.Size(75, 31);
            this.cmdNovo.TabIndex = 23;
            this.cmdNovo.Text = "Novo";
            this.cmdNovo.Click += new System.EventHandler(this.cmdNovo_Click);
            // 
            // cmdSalvar
            // 
            this.cmdSalvar.Enabled = false;
            this.cmdSalvar.Location = new System.Drawing.Point(99, 226);
            this.cmdSalvar.Name = "cmdSalvar";
            this.cmdSalvar.Size = new System.Drawing.Size(83, 31);
            this.cmdSalvar.TabIndex = 22;
            this.cmdSalvar.Text = "Salvar";
            this.cmdSalvar.Click += new System.EventHandler(this.cmdSalvar_Click);
            // 
            // txtCidade
            // 
            this.txtCidade.Enabled = false;
            this.txtCidade.Location = new System.Drawing.Point(78, 114);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(159, 23);
            this.txtCidade.TabIndex = 21;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(23, 114);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(54, 19);
            this.metroLabel1.TabIndex = 20;
            this.metroLabel1.Text = "Cidade:";
            // 
            // txtNome
            // 
            this.txtNome.Enabled = false;
            this.txtNome.Location = new System.Drawing.Point(78, 76);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(159, 23);
            this.txtNome.TabIndex = 19;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(23, 76);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(49, 19);
            this.metroLabel2.TabIndex = 18;
            this.metroLabel2.Text = "Nome:";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // FrmTime
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(603, 286);
            this.Controls.Add(this.cmdImagem);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.cmdEditar);
            this.Controls.Add(this.cmdExcluir);
            this.Controls.Add(this.cmdNovo);
            this.Controls.Add(this.cmdSalvar);
            this.Controls.Add(this.txtCidade);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.metroLabel2);
            this.Name = "FrmTime";
            this.Text = "FrmTime";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton cmdImagem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroFramework.Controls.MetroButton cmdEditar;
        private MetroFramework.Controls.MetroButton cmdExcluir;
        private MetroFramework.Controls.MetroButton cmdNovo;
        private MetroFramework.Controls.MetroButton cmdSalvar;
        private MetroFramework.Controls.MetroTextBox txtCidade;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox txtNome;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}