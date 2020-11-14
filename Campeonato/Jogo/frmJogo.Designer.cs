namespace Campeonato
{
    partial class frmJogo
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
            this.components = new System.ComponentModel.Container();
            this.txt_Time1 = new MetroFramework.Controls.MetroTextBox();
            this.txt_Time2 = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.lbl_Tempo = new MetroFramework.Controls.MetroLabel();
            this.lbl_Campeonato = new MetroFramework.Controls.MetroLabel();
            this.cmd_Iniciar = new MetroFramework.Controls.MetroButton();
            this.cmd_PreencherSumula = new MetroFramework.Controls.MetroButton();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pb_Imagem2 = new System.Windows.Forms.PictureBox();
            this.pb_Time1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Imagem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Time1)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_Time1
            // 
            this.txt_Time1.BackColor = System.Drawing.Color.White;
            this.txt_Time1.CustomBackground = true;
            this.txt_Time1.Enabled = false;
            this.txt_Time1.Location = new System.Drawing.Point(31, 208);
            this.txt_Time1.Name = "txt_Time1";
            this.txt_Time1.Size = new System.Drawing.Size(90, 23);
            this.txt_Time1.TabIndex = 0;
            // 
            // txt_Time2
            // 
            this.txt_Time2.BackColor = System.Drawing.Color.White;
            this.txt_Time2.CustomBackground = true;
            this.txt_Time2.Enabled = false;
            this.txt_Time2.Location = new System.Drawing.Point(216, 208);
            this.txt_Time2.Name = "txt_Time2";
            this.txt_Time2.Size = new System.Drawing.Size(91, 23);
            this.txt_Time2.TabIndex = 1;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel1.Location = new System.Drawing.Point(137, 157);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(71, 19);
            this.metroLabel1.TabIndex = 4;
            this.metroLabel1.Text = "Tempo: 1";
            // 
            // lbl_Tempo
            // 
            this.lbl_Tempo.AutoSize = true;
            this.lbl_Tempo.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lbl_Tempo.Location = new System.Drawing.Point(137, 121);
            this.lbl_Tempo.Name = "lbl_Tempo";
            this.lbl_Tempo.Size = new System.Drawing.Size(65, 19);
            this.lbl_Tempo.TabIndex = 5;
            this.lbl_Tempo.Text = "00:00:00";
            // 
            // lbl_Campeonato
            // 
            this.lbl_Campeonato.AutoSize = true;
            this.lbl_Campeonato.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lbl_Campeonato.Location = new System.Drawing.Point(31, 69);
            this.lbl_Campeonato.Name = "lbl_Campeonato";
            this.lbl_Campeonato.Size = new System.Drawing.Size(163, 19);
            this.lbl_Campeonato.TabIndex = 6;
            this.lbl_Campeonato.Text = "Campeonato Brasileiro";
            // 
            // cmd_Iniciar
            // 
            this.cmd_Iniciar.Location = new System.Drawing.Point(100, 246);
            this.cmd_Iniciar.Name = "cmd_Iniciar";
            this.cmd_Iniciar.Size = new System.Drawing.Size(132, 23);
            this.cmd_Iniciar.TabIndex = 7;
            this.cmd_Iniciar.Text = "Iniciar Partida";
            this.cmd_Iniciar.Click += new System.EventHandler(this.cmd_Iniciar_Click);
            // 
            // cmd_PreencherSumula
            // 
            this.cmd_PreencherSumula.Location = new System.Drawing.Point(23, 287);
            this.cmd_PreencherSumula.Name = "cmd_PreencherSumula";
            this.cmd_PreencherSumula.Size = new System.Drawing.Size(116, 29);
            this.cmd_PreencherSumula.TabIndex = 8;
            this.cmd_PreencherSumula.Text = "Preencher Sumula";
            this.cmd_PreencherSumula.Click += new System.EventHandler(this.cmd_PreencherSumula_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Campeonato.Properties.Resources.Jogo;
            this.pictureBox1.Location = new System.Drawing.Point(323, 86);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(206, 210);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // pb_Imagem2
            // 
            this.pb_Imagem2.Enabled = false;
            this.pb_Imagem2.Location = new System.Drawing.Point(216, 106);
            this.pb_Imagem2.Name = "pb_Imagem2";
            this.pb_Imagem2.Size = new System.Drawing.Size(91, 81);
            this.pb_Imagem2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_Imagem2.TabIndex = 3;
            this.pb_Imagem2.TabStop = false;
            // 
            // pb_Time1
            // 
            this.pb_Time1.Enabled = false;
            this.pb_Time1.Location = new System.Drawing.Point(30, 106);
            this.pb_Time1.Name = "pb_Time1";
            this.pb_Time1.Size = new System.Drawing.Size(91, 81);
            this.pb_Time1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_Time1.TabIndex = 2;
            this.pb_Time1.TabStop = false;
            // 
            // frmJogo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(542, 338);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.cmd_PreencherSumula);
            this.Controls.Add(this.cmd_Iniciar);
            this.Controls.Add(this.lbl_Campeonato);
            this.Controls.Add(this.lbl_Tempo);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.pb_Imagem2);
            this.Controls.Add(this.pb_Time1);
            this.Controls.Add(this.txt_Time2);
            this.Controls.Add(this.txt_Time1);
            this.Name = "frmJogo";
            this.Text = "Jogo";
            this.Load += new System.EventHandler(this.frmJogo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Imagem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Time1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox txt_Time1;
        private MetroFramework.Controls.MetroTextBox txt_Time2;
        private System.Windows.Forms.PictureBox pb_Time1;
        private System.Windows.Forms.PictureBox pb_Imagem2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel lbl_Tempo;
        private MetroFramework.Controls.MetroLabel lbl_Campeonato;
        private MetroFramework.Controls.MetroButton cmd_Iniciar;
        private MetroFramework.Controls.MetroButton cmd_PreencherSumula;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}