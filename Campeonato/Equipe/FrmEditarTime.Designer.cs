namespace Campeonato
{
    partial class FrmEditarTime
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
            this.txtNome = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // cmdPesquisar
            // 
            this.cmdPesquisar.Location = new System.Drawing.Point(277, 58);
            this.cmdPesquisar.Name = "cmdPesquisar";
            this.cmdPesquisar.Size = new System.Drawing.Size(93, 35);
            this.cmdPesquisar.TabIndex = 12;
            this.cmdPesquisar.Text = "Pesquisar";
            this.cmdPesquisar.Click += new System.EventHandler(this.cmdPesquisar_Click);
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(78, 70);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(159, 23);
            this.txtNome.TabIndex = 11;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(23, 70);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(49, 19);
            this.metroLabel2.TabIndex = 10;
            this.metroLabel2.Text = "Nome:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(23, 113);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(229, 150);
            this.dataGridView1.TabIndex = 9;
            this.dataGridView1.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEnter);
            this.dataGridView1.DoubleClick += new System.EventHandler(this.dataGridView1_DoubleClick);
            // 
            // FrmEditarTime
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(388, 279);
            this.Controls.Add(this.cmdPesquisar);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FrmEditarTime";
            this.Text = "Localizar Time";
            this.Load += new System.EventHandler(this.FrmEditarTime_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton cmdPesquisar;
        private MetroFramework.Controls.MetroTextBox txtNome;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}