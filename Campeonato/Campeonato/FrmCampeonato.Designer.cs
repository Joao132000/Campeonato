namespace Campeonato
{
    partial class FrmCampeonato
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
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.cmdAddResult = new MetroFramework.Controls.MetroButton();
            this.txtNome = new MetroFramework.Controls.MetroTextBox();
            this.cmbTipo = new MetroFramework.Controls.MetroComboBox();
            this.cmbAno = new MetroFramework.Controls.MetroComboBox();
            this.cmdNovo = new MetroFramework.Controls.MetroButton();
            this.cmdExcluir = new MetroFramework.Controls.MetroButton();
            this.cmdSalvar = new MetroFramework.Controls.MetroButton();
            this.cmdLocalizar = new MetroFramework.Controls.MetroButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(108, 104);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(150, 19);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Nome do Campeonato:";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(108, 156);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(137, 19);
            this.metroLabel2.TabIndex = 1;
            this.metroLabel2.Text = "Ano do Campeonato:";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(108, 216);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(136, 19);
            this.metroLabel3.TabIndex = 2;
            this.metroLabel3.Text = "Tipo do Campeonato";
            // 
            // cmdAddResult
            // 
            this.cmdAddResult.Location = new System.Drawing.Point(400, 289);
            this.cmdAddResult.Name = "cmdAddResult";
            this.cmdAddResult.Size = new System.Drawing.Size(204, 48);
            this.cmdAddResult.TabIndex = 3;
            this.cmdAddResult.Text = "Campeão/Vice-Campeão";
            this.cmdAddResult.Click += new System.EventHandler(this.cmdAddResult_Click);
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(261, 100);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(121, 23);
            this.txtNome.TabIndex = 4;
            // 
            // cmbTipo
            // 
            this.cmbTipo.FormattingEnabled = true;
            this.cmbTipo.ItemHeight = 23;
            this.cmbTipo.Items.AddRange(new object[] {
            "Brasileiro",
            "Estadual",
            "Regional"});
            this.cmbTipo.Location = new System.Drawing.Point(261, 216);
            this.cmbTipo.Name = "cmbTipo";
            this.cmbTipo.Size = new System.Drawing.Size(121, 29);
            this.cmbTipo.TabIndex = 6;
            // 
            // cmbAno
            // 
            this.cmbAno.FormattingEnabled = true;
            this.cmbAno.ItemHeight = 23;
            this.cmbAno.Items.AddRange(new object[] {
            "2020",
            "2021",
            "2022",
            "2023",
            "2024",
            "2025",
            "2026"});
            this.cmbAno.Location = new System.Drawing.Point(261, 153);
            this.cmbAno.Name = "cmbAno";
            this.cmbAno.Size = new System.Drawing.Size(121, 29);
            this.cmbAno.TabIndex = 7;
            // 
            // cmdNovo
            // 
            this.cmdNovo.Location = new System.Drawing.Point(108, 272);
            this.cmdNovo.Name = "cmdNovo";
            this.cmdNovo.Size = new System.Drawing.Size(121, 23);
            this.cmdNovo.TabIndex = 12;
            this.cmdNovo.Text = "Novo";
            this.cmdNovo.Click += new System.EventHandler(this.cmdNovo_Click);
            // 
            // cmdExcluir
            // 
            this.cmdExcluir.Location = new System.Drawing.Point(260, 329);
            this.cmdExcluir.Name = "cmdExcluir";
            this.cmdExcluir.Size = new System.Drawing.Size(122, 23);
            this.cmdExcluir.TabIndex = 11;
            this.cmdExcluir.Text = "Excluir";
            this.cmdExcluir.Click += new System.EventHandler(this.cmdExcluir_Click);
            // 
            // cmdSalvar
            // 
            this.cmdSalvar.Location = new System.Drawing.Point(108, 329);
            this.cmdSalvar.Name = "cmdSalvar";
            this.cmdSalvar.Size = new System.Drawing.Size(121, 23);
            this.cmdSalvar.TabIndex = 10;
            this.cmdSalvar.Text = "Salvar";
            this.cmdSalvar.Click += new System.EventHandler(this.cmdSalvar_Click);
            // 
            // cmdLocalizar
            // 
            this.cmdLocalizar.Location = new System.Drawing.Point(260, 272);
            this.cmdLocalizar.Name = "cmdLocalizar";
            this.cmdLocalizar.Size = new System.Drawing.Size(122, 23);
            this.cmdLocalizar.TabIndex = 9;
            this.cmdLocalizar.Text = "Editar";
            this.cmdLocalizar.Click += new System.EventHandler(this.cmdLocalizar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Campeonato.Properties.Resources.Trofeu;
            this.pictureBox1.Location = new System.Drawing.Point(400, 63);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(204, 220);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // FrmCampeonato
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(741, 398);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.cmdNovo);
            this.Controls.Add(this.cmdExcluir);
            this.Controls.Add(this.cmdSalvar);
            this.Controls.Add(this.cmdLocalizar);
            this.Controls.Add(this.cmbAno);
            this.Controls.Add(this.cmbTipo);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.cmdAddResult);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Name = "FrmCampeonato";
            this.Text = "Campeonato";
            this.Load += new System.EventHandler(this.FrmCampeonato_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroButton cmdAddResult;
        private MetroFramework.Controls.MetroTextBox txtNome;
        private MetroFramework.Controls.MetroComboBox cmbTipo;
        private MetroFramework.Controls.MetroComboBox cmbAno;
        private MetroFramework.Controls.MetroButton cmdNovo;
        private MetroFramework.Controls.MetroButton cmdExcluir;
        private MetroFramework.Controls.MetroButton cmdSalvar;
        private MetroFramework.Controls.MetroButton cmdLocalizar;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}