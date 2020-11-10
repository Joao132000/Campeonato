namespace Campeonato
{
    partial class frm_EditarJogo
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
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.cmb_Campeonato = new MetroFramework.Controls.MetroComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(23, 127);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(754, 138);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            this.dataGridView1.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEnter);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(23, 79);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(172, 19);
            this.metroLabel1.TabIndex = 5;
            this.metroLabel1.Text = "Pesquisar por Campeonato:";
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(361, 79);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(91, 24);
            this.metroButton1.TabIndex = 7;
            this.metroButton1.Text = "Pesquisar";
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // cmb_Campeonato
            // 
            this.cmb_Campeonato.FormattingEnabled = true;
            this.cmb_Campeonato.ItemHeight = 23;
            this.cmb_Campeonato.Location = new System.Drawing.Point(201, 73);
            this.cmb_Campeonato.Name = "cmb_Campeonato";
            this.cmb_Campeonato.Size = new System.Drawing.Size(133, 29);
            this.cmb_Campeonato.TabIndex = 8;
            // 
            // frm_EditarJogo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cmb_Campeonato);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "frm_EditarJogo";
            this.Text = "Localizar Jogo";
            this.Load += new System.EventHandler(this.frm_EditarJogo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroComboBox cmb_Campeonato;
    }
}