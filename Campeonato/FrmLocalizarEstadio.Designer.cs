namespace Campeonato
{
    partial class FrmLocalizarEstadio
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
            this.cmdPesquisar = new MetroFramework.Controls.MetroButton();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.txtNomeEstadio = new MetroFramework.Controls.MetroTextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // cmdPesquisar
            // 
            this.cmdPesquisar.Location = new System.Drawing.Point(268, 73);
            this.cmdPesquisar.Name = "cmdPesquisar";
            this.cmdPesquisar.Size = new System.Drawing.Size(105, 23);
            this.cmdPesquisar.TabIndex = 0;
            this.cmdPesquisar.Text = "Pesquisar";
            this.cmdPesquisar.Click += new System.EventHandler(this.cmdPesquisar_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(75, 77);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(54, 19);
            this.metroLabel1.TabIndex = 1;
            this.metroLabel1.Text = "Estadio:";
            // 
            // txtNomeEstadio
            // 
            this.txtNomeEstadio.Location = new System.Drawing.Point(135, 73);
            this.txtNomeEstadio.Name = "txtNomeEstadio";
            this.txtNomeEstadio.Size = new System.Drawing.Size(127, 23);
            this.txtNomeEstadio.TabIndex = 2;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(75, 136);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(298, 167);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEnter);
            this.dataGridView1.DoubleClick += new System.EventHandler(this.dataGridView1_DoubleClick_1);
            // 
            // FrmLocalizarEstadio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 362);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtNomeEstadio);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.cmdPesquisar);
            this.Name = "FrmLocalizarEstadio";
            this.Text = "Localizar Estadio";
            this.Load += new System.EventHandler(this.FrmLocalizarEstadio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton cmdPesquisar;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox txtNomeEstadio;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}