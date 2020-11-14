namespace Campeonato
{
    partial class frm_EscolhaJogo
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
            this.cmb_Campeonato = new MetroFramework.Controls.MetroComboBox();
            this.cmb_jogo = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.nud_tempo = new System.Windows.Forms.NumericUpDown();
            this.cmd_Iniciar = new MetroFramework.Controls.MetroButton();
            this.cmd_Voltar = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.nud_tempo)).BeginInit();
            this.SuspendLayout();
            // 
            // cmb_Campeonato
            // 
            this.cmb_Campeonato.FormattingEnabled = true;
            this.cmb_Campeonato.ItemHeight = 23;
            this.cmb_Campeonato.Location = new System.Drawing.Point(233, 74);
            this.cmb_Campeonato.Name = "cmb_Campeonato";
            this.cmb_Campeonato.Size = new System.Drawing.Size(149, 29);
            this.cmb_Campeonato.TabIndex = 4;
            this.cmb_Campeonato.SelectedIndexChanged += new System.EventHandler(this.cmb_Campeonato_SelectedIndexChanged);
            // 
            // cmb_jogo
            // 
            this.cmb_jogo.Enabled = false;
            this.cmb_jogo.FormattingEnabled = true;
            this.cmb_jogo.ItemHeight = 23;
            this.cmb_jogo.Location = new System.Drawing.Point(233, 109);
            this.cmb_jogo.Name = "cmb_jogo";
            this.cmb_jogo.Size = new System.Drawing.Size(149, 29);
            this.cmb_jogo.TabIndex = 5;
            this.cmb_jogo.SelectedIndexChanged += new System.EventHandler(this.cmb_jogo_SelectedIndexChanged);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(22, 74);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(205, 19);
            this.metroLabel1.TabIndex = 6;
            this.metroLabel1.Text = "Escolha o Campeonato desejado:";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(23, 109);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(110, 19);
            this.metroLabel2.TabIndex = 7;
            this.metroLabel2.Text = "Selecione o jogo:";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(23, 159);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(185, 19);
            this.metroLabel3.TabIndex = 8;
            this.metroLabel3.Text = "Defina a duração dos tempos:";
            // 
            // nud_tempo
            // 
            this.nud_tempo.Enabled = false;
            this.nud_tempo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.nud_tempo.Location = new System.Drawing.Point(233, 152);
            this.nud_tempo.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.nud_tempo.Name = "nud_tempo";
            this.nud_tempo.Size = new System.Drawing.Size(149, 26);
            this.nud_tempo.TabIndex = 9;
            this.nud_tempo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nud_tempo.ValueChanged += new System.EventHandler(this.nud_tempo_ValueChanged);
            // 
            // cmd_Iniciar
            // 
            this.cmd_Iniciar.Enabled = false;
            this.cmd_Iniciar.Location = new System.Drawing.Point(256, 217);
            this.cmd_Iniciar.Name = "cmd_Iniciar";
            this.cmd_Iniciar.Size = new System.Drawing.Size(95, 35);
            this.cmd_Iniciar.TabIndex = 10;
            this.cmd_Iniciar.Text = "Iniciar Jogo";
            this.cmd_Iniciar.Click += new System.EventHandler(this.cmd_Iniciar_Click);
            // 
            // cmd_Voltar
            // 
            this.cmd_Voltar.Location = new System.Drawing.Point(50, 217);
            this.cmd_Voltar.Name = "cmd_Voltar";
            this.cmd_Voltar.Size = new System.Drawing.Size(95, 35);
            this.cmd_Voltar.TabIndex = 11;
            this.cmd_Voltar.Text = "Voltar";
            this.cmd_Voltar.Click += new System.EventHandler(this.cmd_Voltar_Click);
            // 
            // frm_EscolhaJogo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 290);
            this.Controls.Add(this.cmd_Voltar);
            this.Controls.Add(this.cmd_Iniciar);
            this.Controls.Add(this.nud_tempo);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.cmb_jogo);
            this.Controls.Add(this.cmb_Campeonato);
            this.Name = "frm_EscolhaJogo";
            this.Text = "Escolha qual jogo iniciar:";
            this.Load += new System.EventHandler(this.frm_EscolhaJogo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nud_tempo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroComboBox cmb_Campeonato;
        private MetroFramework.Controls.MetroComboBox cmb_jogo;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private System.Windows.Forms.NumericUpDown nud_tempo;
        private MetroFramework.Controls.MetroButton cmd_Iniciar;
        private MetroFramework.Controls.MetroButton cmd_Voltar;
    }
}