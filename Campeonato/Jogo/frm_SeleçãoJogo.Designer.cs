namespace Campeonato
{
    partial class frm_SeleçãoJogo
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
            this.cmd_Ok = new MetroFramework.Controls.MetroButton();
            this.cmb_Campeonato = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.cmb_TimeCasa = new MetroFramework.Controls.MetroComboBox();
            this.cmb_Time2 = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.cmb_Estadio = new MetroFramework.Controls.MetroComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.cmd_Localizar = new MetroFramework.Controls.MetroButton();
            this.cmd_Excluir = new MetroFramework.Controls.MetroButton();
            this.txt_Pontos1 = new MetroFramework.Controls.MetroTextBox();
            this.txt_Pontos2 = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // cmd_Ok
            // 
            this.cmd_Ok.Location = new System.Drawing.Point(38, 289);
            this.cmd_Ok.Name = "cmd_Ok";
            this.cmd_Ok.Size = new System.Drawing.Size(113, 28);
            this.cmd_Ok.TabIndex = 0;
            this.cmd_Ok.Text = "Adicionar";
            this.cmd_Ok.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // cmb_Campeonato
            // 
            this.cmb_Campeonato.FormattingEnabled = true;
            this.cmb_Campeonato.ItemHeight = 23;
            this.cmb_Campeonato.Location = new System.Drawing.Point(150, 84);
            this.cmb_Campeonato.Name = "cmb_Campeonato";
            this.cmb_Campeonato.Size = new System.Drawing.Size(121, 29);
            this.cmb_Campeonato.TabIndex = 1;
            this.cmb_Campeonato.SelectedIndexChanged += new System.EventHandler(this.cmb_Campeonato_SelectedIndexChanged);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel1.Location = new System.Drawing.Point(38, 119);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(74, 19);
            this.metroLabel1.TabIndex = 2;
            this.metroLabel1.Text = "Time Casa:";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel4.Location = new System.Drawing.Point(38, 158);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(108, 19);
            this.metroLabel4.TabIndex = 5;
            this.metroLabel4.Text = "Time adversário:";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel5.Location = new System.Drawing.Point(38, 84);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(91, 19);
            this.metroLabel5.TabIndex = 6;
            this.metroLabel5.Text = "Campeonato:";
            // 
            // cmb_TimeCasa
            // 
            this.cmb_TimeCasa.FormattingEnabled = true;
            this.cmb_TimeCasa.ItemHeight = 23;
            this.cmb_TimeCasa.Location = new System.Drawing.Point(150, 119);
            this.cmb_TimeCasa.Name = "cmb_TimeCasa";
            this.cmb_TimeCasa.Size = new System.Drawing.Size(121, 29);
            this.cmb_TimeCasa.TabIndex = 7;
            // 
            // cmb_Time2
            // 
            this.cmb_Time2.FormattingEnabled = true;
            this.cmb_Time2.ItemHeight = 23;
            this.cmb_Time2.Location = new System.Drawing.Point(150, 158);
            this.cmb_Time2.Name = "cmb_Time2";
            this.cmb_Time2.Size = new System.Drawing.Size(121, 29);
            this.cmb_Time2.TabIndex = 8;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel2.Location = new System.Drawing.Point(385, 57);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(94, 19);
            this.metroLabel2.TabIndex = 9;
            this.metroLabel2.Text = "Data do Jogo:";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel3.Location = new System.Drawing.Point(38, 211);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(56, 19);
            this.metroLabel3.TabIndex = 11;
            this.metroLabel3.Text = "Estadio:";
            // 
            // cmb_Estadio
            // 
            this.cmb_Estadio.FormattingEnabled = true;
            this.cmb_Estadio.ItemHeight = 23;
            this.cmb_Estadio.Location = new System.Drawing.Point(150, 201);
            this.cmb_Estadio.Name = "cmb_Estadio";
            this.cmb_Estadio.Size = new System.Drawing.Size(121, 29);
            this.cmb_Estadio.TabIndex = 12;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(382, 84);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(269, 20);
            this.dateTimePicker1.TabIndex = 13;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // cmd_Localizar
            // 
            this.cmd_Localizar.Location = new System.Drawing.Point(168, 289);
            this.cmd_Localizar.Name = "cmd_Localizar";
            this.cmd_Localizar.Size = new System.Drawing.Size(103, 28);
            this.cmd_Localizar.TabIndex = 14;
            this.cmd_Localizar.Text = "Editar";
            this.cmd_Localizar.Click += new System.EventHandler(this.cmd_Localizar_Click);
            // 
            // cmd_Excluir
            // 
            this.cmd_Excluir.Location = new System.Drawing.Point(282, 289);
            this.cmd_Excluir.Name = "cmd_Excluir";
            this.cmd_Excluir.Size = new System.Drawing.Size(103, 28);
            this.cmd_Excluir.TabIndex = 15;
            this.cmd_Excluir.Text = "Excluir";
            this.cmd_Excluir.Visible = false;
            this.cmd_Excluir.Click += new System.EventHandler(this.cmd_Excluir_Click);
            // 
            // txt_Pontos1
            // 
            this.txt_Pontos1.BackColor = System.Drawing.Color.White;
            this.txt_Pontos1.CustomBackground = true;
            this.txt_Pontos1.Location = new System.Drawing.Point(536, 142);
            this.txt_Pontos1.Name = "txt_Pontos1";
            this.txt_Pontos1.Size = new System.Drawing.Size(41, 23);
            this.txt_Pontos1.TabIndex = 16;
            // 
            // txt_Pontos2
            // 
            this.txt_Pontos2.BackColor = System.Drawing.Color.White;
            this.txt_Pontos2.CustomBackground = true;
            this.txt_Pontos2.Location = new System.Drawing.Point(536, 186);
            this.txt_Pontos2.Name = "txt_Pontos2";
            this.txt_Pontos2.Size = new System.Drawing.Size(41, 23);
            this.txt_Pontos2.TabIndex = 17;
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel6.Location = new System.Drawing.Point(375, 146);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(142, 19);
            this.metroLabel6.TabIndex = 18;
            this.metroLabel6.Text = "Pontuação Time Casa:";
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel7.Location = new System.Drawing.Point(375, 190);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(140, 19);
            this.metroLabel7.TabIndex = 19;
            this.metroLabel7.Text = "Pontuação Time Fora:";
            // 
            // frm_SeleçãoJogo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(676, 365);
            this.Controls.Add(this.metroLabel7);
            this.Controls.Add(this.metroLabel6);
            this.Controls.Add(this.txt_Pontos2);
            this.Controls.Add(this.txt_Pontos1);
            this.Controls.Add(this.cmd_Excluir);
            this.Controls.Add(this.cmd_Localizar);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.cmb_Estadio);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.cmb_Time2);
            this.Controls.Add(this.cmb_TimeCasa);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.cmb_Campeonato);
            this.Controls.Add(this.cmd_Ok);
            this.Name = "frm_SeleçãoJogo";
            this.Text = "Jogo";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton cmd_Ok;
        private MetroFramework.Controls.MetroComboBox cmb_Campeonato;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroComboBox cmb_TimeCasa;
        private MetroFramework.Controls.MetroComboBox cmb_Time2;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroComboBox cmb_Estadio;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private MetroFramework.Controls.MetroButton cmd_Localizar;
        private MetroFramework.Controls.MetroButton cmd_Excluir;
        private MetroFramework.Controls.MetroTextBox txt_Pontos1;
        private MetroFramework.Controls.MetroTextBox txt_Pontos2;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel7;
    }
}