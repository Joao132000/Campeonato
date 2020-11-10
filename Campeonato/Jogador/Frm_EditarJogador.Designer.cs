namespace Campeonato
{
    partial class Frm_EditarJogador
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.txt_nomeJogador = new MetroFramework.Controls.MetroTextBox();
            this.cmd_Localizar = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(23, 115);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(487, 198);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            this.dataGridView1.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEnter);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(23, 79);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(162, 19);
            this.metroLabel1.TabIndex = 1;
            this.metroLabel1.Text = "Insira o jogador desejado:";
            // 
            // txt_nomeJogador
            // 
            this.txt_nomeJogador.BackColor = System.Drawing.Color.White;
            this.txt_nomeJogador.CustomBackground = true;
            this.txt_nomeJogador.Location = new System.Drawing.Point(191, 75);
            this.txt_nomeJogador.Name = "txt_nomeJogador";
            this.txt_nomeJogador.Size = new System.Drawing.Size(161, 23);
            this.txt_nomeJogador.TabIndex = 2;
            // 
            // cmd_Localizar
            // 
            this.cmd_Localizar.Location = new System.Drawing.Point(376, 75);
            this.cmd_Localizar.Name = "cmd_Localizar";
            this.cmd_Localizar.Size = new System.Drawing.Size(117, 22);
            this.cmd_Localizar.TabIndex = 3;
            this.cmd_Localizar.Text = "Localizar";
            this.cmd_Localizar.Click += new System.EventHandler(this.cmd_Localizar_Click);
            // 
            // Frm_EditarJogador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(601, 379);
            this.Controls.Add(this.cmd_Localizar);
            this.Controls.Add(this.txt_nomeJogador);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Frm_EditarJogador";
            this.Text = "Selecione o Jogador desejado:";
            this.Load += new System.EventHandler(this.Frm_EditarJogador_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox txt_nomeJogador;
        private MetroFramework.Controls.MetroButton cmd_Localizar;
    }
}