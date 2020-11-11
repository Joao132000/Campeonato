namespace Campeonato
{
    partial class FrmPrincipal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.cmdTime = new System.Windows.Forms.Button();
            this.cmdJogador = new System.Windows.Forms.Button();
            this.cmdEstadio = new System.Windows.Forms.Button();
            this.cmdCampeonato = new System.Windows.Forms.Button();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.cmdCriarCampeonato = new System.Windows.Forms.Button();
            this.cmdJogo = new System.Windows.Forms.Button();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.metroPanel2 = new MetroFramework.Controls.MetroPanel();
            this.cmdClassificaçao = new System.Windows.Forms.Button();
            this.cmdCriarJogo = new System.Windows.Forms.Button();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel10 = new MetroFramework.Controls.MetroLabel();
            this.metroPanel1.SuspendLayout();
            this.metroPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(0, 0);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(75, 23);
            this.metroButton1.TabIndex = 0;
            // 
            // cmdTime
            // 
            this.cmdTime.BackColor = System.Drawing.Color.Transparent;
            this.cmdTime.BackgroundImage = global::Campeonato.Properties.Resources.camisa;
            this.cmdTime.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cmdTime.Location = new System.Drawing.Point(23, 109);
            this.cmdTime.Name = "cmdTime";
            this.cmdTime.Size = new System.Drawing.Size(106, 94);
            this.cmdTime.TabIndex = 3;
            this.cmdTime.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.cmdTime.UseVisualStyleBackColor = false;
            this.cmdTime.Click += new System.EventHandler(this.cmdTime_Click);
            // 
            // cmdJogador
            // 
            this.cmdJogador.BackgroundImage = global::Campeonato.Properties.Resources.JogadorMenu;
            this.cmdJogador.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cmdJogador.Location = new System.Drawing.Point(24, 251);
            this.cmdJogador.Name = "cmdJogador";
            this.cmdJogador.Size = new System.Drawing.Size(105, 94);
            this.cmdJogador.TabIndex = 4;
            this.cmdJogador.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.cmdJogador.UseVisualStyleBackColor = true;
            this.cmdJogador.Click += new System.EventHandler(this.cmdJogador_Click);
            // 
            // cmdEstadio
            // 
            this.cmdEstadio.BackColor = System.Drawing.Color.Transparent;
            this.cmdEstadio.BackgroundImage = global::Campeonato.Properties.Resources.EstadioMenu;
            this.cmdEstadio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cmdEstadio.Location = new System.Drawing.Point(24, 388);
            this.cmdEstadio.Name = "cmdEstadio";
            this.cmdEstadio.Size = new System.Drawing.Size(105, 94);
            this.cmdEstadio.TabIndex = 5;
            this.cmdEstadio.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.cmdEstadio.UseVisualStyleBackColor = false;
            this.cmdEstadio.Click += new System.EventHandler(this.cmdEstadio_Click);
            // 
            // cmdCampeonato
            // 
            this.cmdCampeonato.BackgroundImage = global::Campeonato.Properties.Resources.CampeonatoMenu;
            this.cmdCampeonato.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cmdCampeonato.Location = new System.Drawing.Point(24, 533);
            this.cmdCampeonato.Name = "cmdCampeonato";
            this.cmdCampeonato.Size = new System.Drawing.Size(105, 94);
            this.cmdCampeonato.TabIndex = 6;
            this.cmdCampeonato.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.cmdCampeonato.UseVisualStyleBackColor = true;
            this.cmdCampeonato.Click += new System.EventHandler(this.cmdCampeonato_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(46, 229);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(58, 19);
            this.metroLabel1.TabIndex = 8;
            this.metroLabel1.Text = "Jogador";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(34, 511);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(86, 19);
            this.metroLabel2.TabIndex = 9;
            this.metroLabel2.Text = "Campeonato";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(53, 366);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(51, 19);
            this.metroLabel3.TabIndex = 10;
            this.metroLabel3.Text = "Estadio";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(53, 87);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(38, 19);
            this.metroLabel4.TabIndex = 11;
            this.metroLabel4.Text = "Time";
            // 
            // metroLabel5
            // 
            this.metroLabel5.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel5.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel5.ForeColor = System.Drawing.Color.Black;
            this.metroLabel5.Location = new System.Drawing.Point(-1, 16);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(157, 63);
            this.metroLabel5.TabIndex = 12;
            this.metroLabel5.Text = "Cadastros";
            this.metroLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmdCriarCampeonato
            // 
            this.cmdCriarCampeonato.BackgroundImage = global::Campeonato.Properties.Resources.OrgCampMenu;
            this.cmdCriarCampeonato.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cmdCriarCampeonato.Location = new System.Drawing.Point(24, 109);
            this.cmdCriarCampeonato.Name = "cmdCriarCampeonato";
            this.cmdCriarCampeonato.Size = new System.Drawing.Size(105, 94);
            this.cmdCriarCampeonato.TabIndex = 13;
            this.cmdCriarCampeonato.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.cmdCriarCampeonato.UseVisualStyleBackColor = true;
            this.cmdCriarCampeonato.Click += new System.EventHandler(this.cmdCriarCampeonato_Click);
            // 
            // cmdJogo
            // 
            this.cmdJogo.BackgroundImage = global::Campeonato.Properties.Resources.BolaMenu;
            this.cmdJogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cmdJogo.Location = new System.Drawing.Point(24, 388);
            this.cmdJogo.Name = "cmdJogo";
            this.cmdJogo.Size = new System.Drawing.Size(105, 94);
            this.cmdJogo.TabIndex = 14;
            this.cmdJogo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.cmdJogo.UseVisualStyleBackColor = true;
            this.cmdJogo.Click += new System.EventHandler(this.cmdJogo_Click);
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(53, 366);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(38, 19);
            this.metroLabel6.TabIndex = 15;
            this.metroLabel6.Text = "Jogo";
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(20, 87);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(119, 19);
            this.metroLabel7.TabIndex = 16;
            this.metroLabel7.Text = "Criar Campeonato";
            // 
            // metroPanel1
            // 
            this.metroPanel1.BackColor = System.Drawing.Color.Black;
            this.metroPanel1.Controls.Add(this.metroLabel5);
            this.metroPanel1.Controls.Add(this.cmdCampeonato);
            this.metroPanel1.Controls.Add(this.metroLabel2);
            this.metroPanel1.Controls.Add(this.cmdTime);
            this.metroPanel1.Controls.Add(this.metroLabel3);
            this.metroPanel1.Controls.Add(this.metroLabel4);
            this.metroPanel1.Controls.Add(this.metroLabel1);
            this.metroPanel1.Controls.Add(this.cmdJogador);
            this.metroPanel1.Controls.Add(this.cmdEstadio);
            this.metroPanel1.ForeColor = System.Drawing.Color.Black;
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(0, -4);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(158, 744);
            this.metroPanel1.TabIndex = 17;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // metroPanel2
            // 
            this.metroPanel2.BackColor = System.Drawing.Color.Black;
            this.metroPanel2.Controls.Add(this.cmdClassificaçao);
            this.metroPanel2.Controls.Add(this.cmdCriarJogo);
            this.metroPanel2.Controls.Add(this.cmdJogo);
            this.metroPanel2.Controls.Add(this.metroLabel6);
            this.metroPanel2.Controls.Add(this.metroLabel8);
            this.metroPanel2.Controls.Add(this.metroLabel7);
            this.metroPanel2.Controls.Add(this.metroLabel9);
            this.metroPanel2.Controls.Add(this.cmdCriarCampeonato);
            this.metroPanel2.Controls.Add(this.metroLabel10);
            this.metroPanel2.ForeColor = System.Drawing.Color.Black;
            this.metroPanel2.HorizontalScrollbarBarColor = true;
            this.metroPanel2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel2.HorizontalScrollbarSize = 10;
            this.metroPanel2.Location = new System.Drawing.Point(1217, 0);
            this.metroPanel2.Name = "metroPanel2";
            this.metroPanel2.Size = new System.Drawing.Size(158, 744);
            this.metroPanel2.TabIndex = 18;
            this.metroPanel2.VerticalScrollbarBarColor = true;
            this.metroPanel2.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel2.VerticalScrollbarSize = 10;
            // 
            // cmdClassificaçao
            // 
            this.cmdClassificaçao.BackgroundImage = global::Campeonato.Properties.Resources.StatsMenu;
            this.cmdClassificaçao.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cmdClassificaçao.Location = new System.Drawing.Point(24, 533);
            this.cmdClassificaçao.Name = "cmdClassificaçao";
            this.cmdClassificaçao.Size = new System.Drawing.Size(105, 94);
            this.cmdClassificaçao.TabIndex = 18;
            this.cmdClassificaçao.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.cmdClassificaçao.UseVisualStyleBackColor = true;
            this.cmdClassificaçao.Click += new System.EventHandler(this.cmdClassificaçao_Click);
            // 
            // cmdCriarJogo
            // 
            this.cmdCriarJogo.BackgroundImage = global::Campeonato.Properties.Resources.CriaçaoJogo;
            this.cmdCriarJogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cmdCriarJogo.Location = new System.Drawing.Point(24, 248);
            this.cmdCriarJogo.Name = "cmdCriarJogo";
            this.cmdCriarJogo.Size = new System.Drawing.Size(105, 94);
            this.cmdCriarJogo.TabIndex = 17;
            this.cmdCriarJogo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.cmdCriarJogo.UseVisualStyleBackColor = true;
            this.cmdCriarJogo.Click += new System.EventHandler(this.cmdCriarJogo_Click);
            // 
            // metroLabel8
            // 
            this.metroLabel8.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel8.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel8.ForeColor = System.Drawing.Color.Black;
            this.metroLabel8.Location = new System.Drawing.Point(3, 12);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(157, 63);
            this.metroLabel8.TabIndex = 12;
            this.metroLabel8.Text = "Organização";
            this.metroLabel8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.Location = new System.Drawing.Point(39, 503);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(82, 19);
            this.metroLabel9.TabIndex = 9;
            this.metroLabel9.Text = "Classificação";
            // 
            // metroLabel10
            // 
            this.metroLabel10.AutoSize = true;
            this.metroLabel10.Location = new System.Drawing.Point(43, 229);
            this.metroLabel10.Name = "metroLabel10";
            this.metroLabel10.Size = new System.Drawing.Size(71, 19);
            this.metroLabel10.TabIndex = 10;
            this.metroLabel10.Text = "Criar Jogo";
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Campeonato.Properties.Resources.MINEIRÃO_VAZIO;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1369, 740);
            this.Controls.Add(this.metroPanel2);
            this.Controls.Add(this.metroPanel1);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "FrmPrincipal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            this.metroPanel2.ResumeLayout(false);
            this.metroPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private MetroFramework.Controls.MetroButton metroButton1;
        private System.Windows.Forms.Button cmdTime;
        private System.Windows.Forms.Button cmdJogador;
        private System.Windows.Forms.Button cmdEstadio;
        private System.Windows.Forms.Button cmdCampeonato;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private System.Windows.Forms.Button cmdCriarCampeonato;
        private System.Windows.Forms.Button cmdJogo;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroPanel metroPanel2;
        private System.Windows.Forms.Button cmdCriarJogo;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private MetroFramework.Controls.MetroLabel metroLabel10;
        private System.Windows.Forms.Button cmdClassificaçao;
    }
}

