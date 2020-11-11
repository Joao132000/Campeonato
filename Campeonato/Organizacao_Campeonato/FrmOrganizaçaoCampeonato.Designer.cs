namespace Campeonato
{
    partial class FrmOrganizaçaoCampeonato
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
            this.cmbCampeonatos = new MetroFramework.Controls.MetroComboBox();
            this.cmbTimes = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.cmdAdicionar = new MetroFramework.Controls.MetroButton();
            this.listTimes = new System.Windows.Forms.ListBox();
            this.cmdTabela = new MetroFramework.Controls.MetroButton();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // cmbCampeonatos
            // 
            this.cmbCampeonatos.FormattingEnabled = true;
            this.cmbCampeonatos.ItemHeight = 23;
            this.cmbCampeonatos.Location = new System.Drawing.Point(64, 127);
            this.cmbCampeonatos.Name = "cmbCampeonatos";
            this.cmbCampeonatos.Size = new System.Drawing.Size(140, 29);
            this.cmbCampeonatos.TabIndex = 0;
            this.cmbCampeonatos.SelectedIndexChanged += new System.EventHandler(this.cmbCampeonatos_SelectedIndexChanged);
            // 
            // cmbTimes
            // 
            this.cmbTimes.FormattingEnabled = true;
            this.cmbTimes.ItemHeight = 23;
            this.cmbTimes.Location = new System.Drawing.Point(64, 233);
            this.cmbTimes.Name = "cmbTimes";
            this.cmbTimes.Size = new System.Drawing.Size(140, 29);
            this.cmbTimes.TabIndex = 1;
            this.cmbTimes.SelectedIndexChanged += new System.EventHandler(this.cmbTimes_SelectedIndexChanged);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(64, 96);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(160, 19);
            this.metroLabel1.TabIndex = 2;
            this.metroLabel1.Text = "Selecione o Campeonato:";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(64, 200);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(119, 19);
            this.metroLabel2.TabIndex = 3;
            this.metroLabel2.Text = "Selecione os times:";
            // 
            // cmdAdicionar
            // 
            this.cmdAdicionar.Location = new System.Drawing.Point(210, 233);
            this.cmdAdicionar.Name = "cmdAdicionar";
            this.cmdAdicionar.Size = new System.Drawing.Size(95, 29);
            this.cmdAdicionar.TabIndex = 4;
            this.cmdAdicionar.Text = "Adicionar";
            this.cmdAdicionar.Click += new System.EventHandler(this.cmdAdicionar_Click);
            // 
            // listTimes
            // 
            this.listTimes.FormattingEnabled = true;
            this.listTimes.Location = new System.Drawing.Point(341, 109);
            this.listTimes.Name = "listTimes";
            this.listTimes.Size = new System.Drawing.Size(252, 277);
            this.listTimes.TabIndex = 5;
            // 
            // cmdTabela
            // 
            this.cmdTabela.Location = new System.Drawing.Point(91, 305);
            this.cmdTabela.Name = "cmdTabela";
            this.cmdTabela.Size = new System.Drawing.Size(181, 51);
            this.cmdTabela.TabIndex = 7;
            this.cmdTabela.Text = "Finalizar";
            this.cmdTabela.Click += new System.EventHandler(this.cmdTabela_Click);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(341, 76);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(171, 19);
            this.metroLabel3.TabIndex = 8;
            this.metroLabel3.Text = "Lista de Times Selecionados";
            // 
            // FrmOrganizaçaoCampeonato
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.cmdTabela);
            this.Controls.Add(this.listTimes);
            this.Controls.Add(this.cmdAdicionar);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.cmbTimes);
            this.Controls.Add(this.cmbCampeonatos);
            this.Name = "FrmOrganizaçaoCampeonato";
            this.Text = "Organizaçao Campeonato";
            this.Load += new System.EventHandler(this.OrganizaçaoCampeonato_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroComboBox cmbCampeonatos;
        private MetroFramework.Controls.MetroComboBox cmbTimes;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroButton cmdAdicionar;
        private System.Windows.Forms.ListBox listTimes;
        private MetroFramework.Controls.MetroButton cmdTabela;
        private MetroFramework.Controls.MetroLabel metroLabel3;
    }
}