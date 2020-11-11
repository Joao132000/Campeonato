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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.jogadorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.equipeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.jogoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.campeonatoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.estadioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sumulaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.cmdTime = new System.Windows.Forms.Button();
            this.metroButton2 = new MetroFramework.Controls.MetroButton();
            this.cmdJogador = new System.Windows.Forms.Button();
            this.cmdEstadio = new System.Windows.Forms.Button();
            this.cmdCampeonato = new System.Windows.Forms.Button();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.White;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.jogadorToolStripMenuItem,
            this.equipeToolStripMenuItem,
            this.jogoToolStripMenuItem,
            this.campeonatoToolStripMenuItem,
            this.estadioToolStripMenuItem,
            this.sumulaToolStripMenuItem});
            this.menuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(807, 29);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // jogadorToolStripMenuItem
            // 
            this.jogadorToolStripMenuItem.Name = "jogadorToolStripMenuItem";
            this.jogadorToolStripMenuItem.Size = new System.Drawing.Size(78, 25);
            this.jogadorToolStripMenuItem.Text = "Jogador";
            // 
            // equipeToolStripMenuItem
            // 
            this.equipeToolStripMenuItem.Name = "equipeToolStripMenuItem";
            this.equipeToolStripMenuItem.Size = new System.Drawing.Size(69, 25);
            this.equipeToolStripMenuItem.Text = "Equipe";
            // 
            // jogoToolStripMenuItem
            // 
            this.jogoToolStripMenuItem.Name = "jogoToolStripMenuItem";
            this.jogoToolStripMenuItem.Size = new System.Drawing.Size(55, 25);
            this.jogoToolStripMenuItem.Text = "Jogo";
            this.jogoToolStripMenuItem.Click += new System.EventHandler(this.jogoToolStripMenuItem_Click);
            // 
            // campeonatoToolStripMenuItem
            // 
            this.campeonatoToolStripMenuItem.Name = "campeonatoToolStripMenuItem";
            this.campeonatoToolStripMenuItem.Size = new System.Drawing.Size(111, 25);
            this.campeonatoToolStripMenuItem.Text = "Campeonato";
            // 
            // estadioToolStripMenuItem
            // 
            this.estadioToolStripMenuItem.Name = "estadioToolStripMenuItem";
            this.estadioToolStripMenuItem.Size = new System.Drawing.Size(72, 25);
            this.estadioToolStripMenuItem.Text = "Estadio";
            // 
            // sumulaToolStripMenuItem
            // 
            this.sumulaToolStripMenuItem.Name = "sumulaToolStripMenuItem";
            this.sumulaToolStripMenuItem.Size = new System.Drawing.Size(75, 25);
            this.sumulaToolStripMenuItem.Text = "Súmula";
            this.sumulaToolStripMenuItem.Click += new System.EventHandler(this.sumulaToolStripMenuItem_Click);
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
            this.cmdTime.Location = new System.Drawing.Point(35, 198);
            this.cmdTime.Name = "cmdTime";
            this.cmdTime.Size = new System.Drawing.Size(106, 94);
            this.cmdTime.TabIndex = 3;
            this.cmdTime.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.cmdTime.UseVisualStyleBackColor = false;
            this.cmdTime.Click += new System.EventHandler(this.cmdTime_Click);
            // 
            // metroButton2
            // 
            this.metroButton2.Location = new System.Drawing.Point(615, 32);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(159, 93);
            this.metroButton2.TabIndex = 1;
            this.metroButton2.Text = "metroButton2";
            this.metroButton2.Click += new System.EventHandler(this.metroButton2_Click);
            // 
            // cmdJogador
            // 
            this.cmdJogador.BackgroundImage = global::Campeonato.Properties.Resources.JogadorMenu;
            this.cmdJogador.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cmdJogador.Location = new System.Drawing.Point(150, 198);
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
            this.cmdEstadio.Location = new System.Drawing.Point(261, 198);
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
            this.cmdCampeonato.Location = new System.Drawing.Point(375, 198);
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
            this.metroLabel1.Location = new System.Drawing.Point(178, 295);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(58, 19);
            this.metroLabel1.TabIndex = 8;
            this.metroLabel1.Text = "Jogador";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(387, 295);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(86, 19);
            this.metroLabel2.TabIndex = 9;
            this.metroLabel2.Text = "Campeonato";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(287, 295);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(51, 19);
            this.metroLabel3.TabIndex = 10;
            this.metroLabel3.Text = "Estadio";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(68, 295);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(38, 19);
            this.metroLabel4.TabIndex = 11;
            this.metroLabel4.Text = "Time";
            // 
            // metroLabel5
            // 
            this.metroLabel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.metroLabel5.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel5.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel5.ForeColor = System.Drawing.Color.Black;
            this.metroLabel5.Location = new System.Drawing.Point(178, 123);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(160, 55);
            this.metroLabel5.TabIndex = 12;
            this.metroLabel5.Text = "Cadastros";
            this.metroLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Campeonato.Properties.Resources.MINEIRÃO_VAZIO;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(807, 405);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.cmdCampeonato);
            this.Controls.Add(this.cmdEstadio);
            this.Controls.Add(this.cmdJogador);
            this.Controls.Add(this.cmdTime);
            this.Controls.Add(this.metroButton2);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmPrincipal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem jogadorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem equipeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem jogoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem campeonatoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem estadioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sumulaToolStripMenuItem;
        private MetroFramework.Controls.MetroButton metroButton1;
        private System.Windows.Forms.Button cmdTime;
        private MetroFramework.Controls.MetroButton metroButton2;
        private System.Windows.Forms.Button cmdJogador;
        private System.Windows.Forms.Button cmdEstadio;
        private System.Windows.Forms.Button cmdCampeonato;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel5;
    }
}

