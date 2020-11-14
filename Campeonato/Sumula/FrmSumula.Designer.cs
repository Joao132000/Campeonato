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
            this.cmdExcluir = new MetroFramework.Controls.MetroButton();
            this.cmbCartao = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.cmdEditar = new MetroFramework.Controls.MetroButton();
            this.cmdNovo = new MetroFramework.Controls.MetroButton();
            this.cmdSalvar = new MetroFramework.Controls.MetroButton();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.cmbJogador = new MetroFramework.Controls.MetroComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cmbGols = new MetroFramework.Controls.MetroComboBox();
            this.txtJogo = new MetroFramework.Controls.MetroTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // cmdExcluir
            // 
            this.cmdExcluir.Enabled = false;
            this.cmdExcluir.Location = new System.Drawing.Point(265, 221);
            this.cmdExcluir.Name = "cmdExcluir";
            this.cmdExcluir.Size = new System.Drawing.Size(83, 31);
            this.cmdExcluir.TabIndex = 47;
            this.cmdExcluir.Text = "Excluir";
            this.cmdExcluir.Click += new System.EventHandler(this.cmdExcluir_Click);
            // 
            // cmbCartao
            // 
            this.cmbCartao.Enabled = false;
            this.cmbCartao.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmbCartao.FormattingEnabled = true;
            this.cmbCartao.ItemHeight = 23;
            this.cmbCartao.Items.AddRange(new object[] {
            "Sem Cartão",
            "Amarelo",
            "Vermelho"});
            this.cmbCartao.Location = new System.Drawing.Point(475, 82);
            this.cmbCartao.Name = "cmbCartao";
            this.cmbCartao.Size = new System.Drawing.Size(100, 29);
            this.cmbCartao.TabIndex = 46;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(501, 60);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(50, 19);
            this.metroLabel4.TabIndex = 45;
            this.metroLabel4.Text = "Cartão";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(418, 60);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(42, 19);
            this.metroLabel3.TabIndex = 43;
            this.metroLabel3.Text = "Gol(s)";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(242, 60);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(38, 19);
            this.metroLabel2.TabIndex = 42;
            this.metroLabel2.Text = "Jogo";
            // 
            // cmdEditar
            // 
            this.cmdEditar.Location = new System.Drawing.Point(176, 221);
            this.cmdEditar.Name = "cmdEditar";
            this.cmdEditar.Size = new System.Drawing.Size(83, 31);
            this.cmdEditar.TabIndex = 40;
            this.cmdEditar.Text = "Editar";
            this.cmdEditar.Click += new System.EventHandler(this.cmdEditar_Click);
            // 
            // cmdNovo
            // 
            this.cmdNovo.Location = new System.Drawing.Point(6, 221);
            this.cmdNovo.Name = "cmdNovo";
            this.cmdNovo.Size = new System.Drawing.Size(75, 31);
            this.cmdNovo.TabIndex = 39;
            this.cmdNovo.Text = "Novo";
            this.cmdNovo.Click += new System.EventHandler(this.cmdNovo_Click);
            // 
            // cmdSalvar
            // 
            this.cmdSalvar.Enabled = false;
            this.cmdSalvar.Location = new System.Drawing.Point(87, 221);
            this.cmdSalvar.Name = "cmdSalvar";
            this.cmdSalvar.Size = new System.Drawing.Size(83, 31);
            this.cmdSalvar.TabIndex = 38;
            this.cmdSalvar.Text = "Salvar";
            this.cmdSalvar.Click += new System.EventHandler(this.cmdSalvar_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(23, 60);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(58, 19);
            this.metroLabel1.TabIndex = 37;
            this.metroLabel1.Text = "Jogador";
            // 
            // cmbJogador
            // 
            this.cmbJogador.Enabled = false;
            this.cmbJogador.FormattingEnabled = true;
            this.cmbJogador.ItemHeight = 23;
            this.cmbJogador.Location = new System.Drawing.Point(9, 82);
            this.cmbJogador.Name = "cmbJogador";
            this.cmbJogador.Size = new System.Drawing.Size(121, 29);
            this.cmbJogador.TabIndex = 36;
            this.cmbJogador.SelectedIndexChanged += new System.EventHandler(this.cmbJogador_SelectedIndexChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Campeonato.Properties.Resources.Sumula;
            this.pictureBox1.Location = new System.Drawing.Point(409, 117);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(166, 135);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 48;
            this.pictureBox1.TabStop = false;
            // 
            // cmbGols
            // 
            this.cmbGols.FormattingEnabled = true;
            this.cmbGols.ItemHeight = 23;
            this.cmbGols.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.cmbGols.Location = new System.Drawing.Point(409, 82);
            this.cmbGols.Name = "cmbGols";
            this.cmbGols.Size = new System.Drawing.Size(60, 29);
            this.cmbGols.TabIndex = 49;
            // 
            // txtJogo
            // 
            this.txtJogo.BackColor = System.Drawing.SystemColors.MenuBar;
            this.txtJogo.Enabled = false;
            this.txtJogo.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtJogo.Location = new System.Drawing.Point(147, 82);
            this.txtJogo.Name = "txtJogo";
            this.txtJogo.Size = new System.Drawing.Size(244, 29);
            this.txtJogo.TabIndex = 50;
            this.txtJogo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // FrmSumula
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(603, 294);
            this.Controls.Add(this.txtJogo);
            this.Controls.Add(this.cmbGols);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.cmdExcluir);
            this.Controls.Add(this.cmbCartao);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.cmdEditar);
            this.Controls.Add(this.cmdNovo);
            this.Controls.Add(this.cmdSalvar);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.cmbJogador);
            this.Name = "FrmSumula";
            this.Text = "Súmula";
            this.Load += new System.EventHandler(this.FrmSumula_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton cmdExcluir;
        private MetroFramework.Controls.MetroComboBox cmbCartao;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroButton cmdEditar;
        private MetroFramework.Controls.MetroButton cmdNovo;
        private MetroFramework.Controls.MetroButton cmdSalvar;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroComboBox cmbJogador;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroFramework.Controls.MetroComboBox cmbGols;
        private MetroFramework.Controls.MetroTextBox txtJogo;
    }
}