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
            this.metroButton2 = new MetroFramework.Controls.MetroButton();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.jogadorToolStripMenuItem,
            this.equipeToolStripMenuItem,
            this.jogoToolStripMenuItem,
            this.campeonatoToolStripMenuItem,
            this.estadioToolStripMenuItem,
            this.sumulaToolStripMenuItem});
            this.menuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.menuStrip1.Location = new System.Drawing.Point(20, 60);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(760, 29);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // jogadorToolStripMenuItem
            // 
            this.jogadorToolStripMenuItem.Name = "jogadorToolStripMenuItem";
            this.jogadorToolStripMenuItem.Size = new System.Drawing.Size(78, 25);
            this.jogadorToolStripMenuItem.Text = "Jogador";
            this.jogadorToolStripMenuItem.Click += new System.EventHandler(this.jogadorToolStripMenuItem_Click);
            // 
            // equipeToolStripMenuItem
            // 
            this.equipeToolStripMenuItem.Name = "equipeToolStripMenuItem";
            this.equipeToolStripMenuItem.Size = new System.Drawing.Size(69, 25);
            this.equipeToolStripMenuItem.Text = "Equipe";
            this.equipeToolStripMenuItem.Click += new System.EventHandler(this.equipeToolStripMenuItem_Click);
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
            this.campeonatoToolStripMenuItem.Click += new System.EventHandler(this.campeonatoToolStripMenuItem_Click);
            // 
            // estadioToolStripMenuItem
            // 
            this.estadioToolStripMenuItem.Name = "estadioToolStripMenuItem";
            this.estadioToolStripMenuItem.Size = new System.Drawing.Size(72, 25);
            this.estadioToolStripMenuItem.Text = "Estadio";
            this.estadioToolStripMenuItem.Click += new System.EventHandler(this.estadioToolStripMenuItem_Click);
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
            // metroButton2
            // 
            this.metroButton2.Location = new System.Drawing.Point(71, 169);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(75, 23);
            this.metroButton2.TabIndex = 1;
            this.metroButton2.Text = "metroButton2";
            this.metroButton2.Click += new System.EventHandler(this.metroButton2_Click);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.metroButton2);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmPrincipal";
            this.Text = "Futebol";
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
        private MetroFramework.Controls.MetroButton metroButton2;
    }
}

