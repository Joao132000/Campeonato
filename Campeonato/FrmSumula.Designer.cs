namespace Campeonato
{
    partial class FrmSumula
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
            this.cmbJogador = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.cmdEditar = new MetroFramework.Controls.MetroButton();
            this.cmdNovo = new MetroFramework.Controls.MetroButton();
            this.cmdSalvar = new MetroFramework.Controls.MetroButton();
            this.cmbJogo = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.cmbGols = new MetroFramework.Controls.MetroComboBox();
            this.cmbCartao = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // cmbJogador
            // 
            this.cmbJogador.Enabled = false;
            this.cmbJogador.FormattingEnabled = true;
            this.cmbJogador.ItemHeight = 23;
            this.cmbJogador.Location = new System.Drawing.Point(9, 98);
            this.cmbJogador.Name = "cmbJogador";
            this.cmbJogador.Size = new System.Drawing.Size(121, 29);
            this.cmbJogador.TabIndex = 0;
            this.cmbJogador.SelectedIndexChanged += new System.EventHandler(this.cmbJogador_SelectedIndexChanged);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(23, 76);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(58, 19);
            this.metroLabel1.TabIndex = 1;
            this.metroLabel1.Text = "Jogador";
            // 
            // cmdEditar
            // 
            this.cmdEditar.Location = new System.Drawing.Point(176, 237);
            this.cmdEditar.Name = "cmdEditar";
            this.cmdEditar.Size = new System.Drawing.Size(83, 31);
            this.cmdEditar.TabIndex = 28;
            this.cmdEditar.Text = "Editar";
            this.cmdEditar.Click += new System.EventHandler(this.cmdEditar_Click);
            // 
            // cmdNovo
            // 
            this.cmdNovo.Location = new System.Drawing.Point(6, 237);
            this.cmdNovo.Name = "cmdNovo";
            this.cmdNovo.Size = new System.Drawing.Size(75, 31);
            this.cmdNovo.TabIndex = 27;
            this.cmdNovo.Text = "Novo";
            this.cmdNovo.Click += new System.EventHandler(this.cmdNovo_Click);
            // 
            // cmdSalvar
            // 
            this.cmdSalvar.Enabled = false;
            this.cmdSalvar.Location = new System.Drawing.Point(87, 237);
            this.cmdSalvar.Name = "cmdSalvar";
            this.cmdSalvar.Size = new System.Drawing.Size(83, 31);
            this.cmdSalvar.TabIndex = 26;
            this.cmdSalvar.Text = "Salvar";
            this.cmdSalvar.Click += new System.EventHandler(this.cmdSalvar_Click);
            // 
            // cmbJogo
            // 
            this.cmbJogo.Enabled = false;
            this.cmbJogo.FormattingEnabled = true;
            this.cmbJogo.ItemHeight = 23;
            this.cmbJogo.Location = new System.Drawing.Point(136, 98);
            this.cmbJogo.Name = "cmbJogo";
            this.cmbJogo.Size = new System.Drawing.Size(121, 29);
            this.cmbJogo.TabIndex = 29;
            this.cmbJogo.SelectedIndexChanged += new System.EventHandler(this.cmbJogo_SelectedIndexChanged);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(164, 76);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(38, 19);
            this.metroLabel2.TabIndex = 30;
            this.metroLabel2.Text = "Jogo";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(447, 76);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(29, 19);
            this.metroLabel3.TabIndex = 31;
            this.metroLabel3.Text = "Gol";
            // 
            // cmbGols
            // 
            this.cmbGols.Enabled = false;
            this.cmbGols.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmbGols.FormattingEnabled = true;
            this.cmbGols.ItemHeight = 23;
            this.cmbGols.Items.AddRange(new object[] {
            "00",
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10"});
            this.cmbGols.Location = new System.Drawing.Point(432, 98);
            this.cmbGols.Name = "cmbGols";
            this.cmbGols.Size = new System.Drawing.Size(60, 29);
            this.cmbGols.TabIndex = 32;
            // 
            // cmbCartao
            // 
            this.cmbCartao.Enabled = false;
            this.cmbCartao.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmbCartao.FormattingEnabled = true;
            this.cmbCartao.ItemHeight = 23;
            this.cmbCartao.Items.AddRange(new object[] {
            "Amarelo",
            "Vermelho"});
            this.cmbCartao.Location = new System.Drawing.Point(498, 98);
            this.cmbCartao.Name = "cmbCartao";
            this.cmbCartao.Size = new System.Drawing.Size(93, 29);
            this.cmbCartao.TabIndex = 34;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(520, 76);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(50, 19);
            this.metroLabel4.TabIndex = 33;
            this.metroLabel4.Text = "Cartão";
            // 
            // FrmSumula
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(602, 291);
            this.Controls.Add(this.cmbCartao);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.cmbGols);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.cmbJogo);
            this.Controls.Add(this.cmdEditar);
            this.Controls.Add(this.cmdNovo);
            this.Controls.Add(this.cmdSalvar);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.cmbJogador);
            this.Name = "FrmSumula";
            this.Text = "Súmula";
            this.Load += new System.EventHandler(this.FrmSumula_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroComboBox cmbJogador;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroButton cmdEditar;
        private MetroFramework.Controls.MetroButton cmdNovo;
        private MetroFramework.Controls.MetroButton cmdSalvar;
        private MetroFramework.Controls.MetroComboBox cmbJogo;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroComboBox cmbGols;
        private MetroFramework.Controls.MetroComboBox cmbCartao;
        private MetroFramework.Controls.MetroLabel metroLabel4;
    }
}