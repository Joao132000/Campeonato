namespace Campeonato
{
    partial class Frm_Jogador
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
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.cmb_Time = new MetroFramework.Controls.MetroComboBox();
            this.txt_Nome = new MetroFramework.Controls.MetroTextBox();
            this.txt_Numero = new MetroFramework.Controls.MetroTextBox();
            this.cmd_Processar = new MetroFramework.Controls.MetroButton();
            this.cmdLocalizar = new MetroFramework.Controls.MetroButton();
            this.cmd_Excluir = new MetroFramework.Controls.MetroButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel1.Location = new System.Drawing.Point(23, 123);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(49, 19);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Nome:";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel2.Location = new System.Drawing.Point(23, 160);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(136, 19);
            this.metroLabel2.TabIndex = 1;
            this.metroLabel2.Text = "Data de Nascimento:";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel3.Location = new System.Drawing.Point(23, 188);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(129, 19);
            this.metroLabel3.TabIndex = 2;
            this.metroLabel3.Text = "Número da Camisa:";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel4.Location = new System.Drawing.Point(23, 226);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(41, 19);
            this.metroLabel4.TabIndex = 3;
            this.metroLabel4.Text = "Time:";
            // 
            // cmb_Time
            // 
            this.cmb_Time.FormattingEnabled = true;
            this.cmb_Time.ItemHeight = 23;
            this.cmb_Time.Location = new System.Drawing.Point(170, 216);
            this.cmb_Time.Name = "cmb_Time";
            this.cmb_Time.Size = new System.Drawing.Size(121, 29);
            this.cmb_Time.TabIndex = 4;
            // 
            // txt_Nome
            // 
            this.txt_Nome.BackColor = System.Drawing.Color.White;
            this.txt_Nome.CustomBackground = true;
            this.txt_Nome.Location = new System.Drawing.Point(101, 119);
            this.txt_Nome.Name = "txt_Nome";
            this.txt_Nome.Size = new System.Drawing.Size(220, 23);
            this.txt_Nome.TabIndex = 5;
            // 
            // txt_Numero
            // 
            this.txt_Numero.BackColor = System.Drawing.Color.White;
            this.txt_Numero.CustomBackground = true;
            this.txt_Numero.Location = new System.Drawing.Point(170, 184);
            this.txt_Numero.Name = "txt_Numero";
            this.txt_Numero.Size = new System.Drawing.Size(77, 23);
            this.txt_Numero.TabIndex = 7;
            // 
            // cmd_Processar
            // 
            this.cmd_Processar.Location = new System.Drawing.Point(113, 299);
            this.cmd_Processar.Name = "cmd_Processar";
            this.cmd_Processar.Size = new System.Drawing.Size(83, 31);
            this.cmd_Processar.TabIndex = 8;
            this.cmd_Processar.Text = "Salvar";
            // 
            // cmdLocalizar
            // 
            this.cmdLocalizar.Location = new System.Drawing.Point(23, 299);
            this.cmdLocalizar.Name = "cmdLocalizar";
            this.cmdLocalizar.Size = new System.Drawing.Size(75, 31);
            this.cmdLocalizar.TabIndex = 10;
            this.cmdLocalizar.Text = "Localizar";
            // 
            // cmd_Excluir
            // 
            this.cmd_Excluir.Location = new System.Drawing.Point(224, 299);
            this.cmd_Excluir.Name = "cmd_Excluir";
            this.cmd_Excluir.Size = new System.Drawing.Size(83, 31);
            this.cmd_Excluir.TabIndex = 11;
            this.cmd_Excluir.Text = "Excluir";
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::Campeonato.Properties.Resources.Jogador_de_Futebol_1;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Location = new System.Drawing.Point(359, 35);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(205, 335);
            this.panel1.TabIndex = 12;
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(170, 158);
            this.maskedTextBox1.Mask = "00/00/0000";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(77, 20);
            this.maskedTextBox1.TabIndex = 14;
            this.maskedTextBox1.ValidatingType = typeof(System.DateTime);
            // 
            // Frm_Jogador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(569, 393);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.cmd_Excluir);
            this.Controls.Add(this.cmdLocalizar);
            this.Controls.Add(this.cmd_Processar);
            this.Controls.Add(this.txt_Numero);
            this.Controls.Add(this.txt_Nome);
            this.Controls.Add(this.cmb_Time);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Name = "Frm_Jogador";
            this.Text = "Jogador";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroComboBox cmb_Time;
        private MetroFramework.Controls.MetroTextBox txt_Nome;
        private MetroFramework.Controls.MetroTextBox txt_Numero;
        private MetroFramework.Controls.MetroButton cmd_Processar;
        private MetroFramework.Controls.MetroButton cmdLocalizar;
        private MetroFramework.Controls.MetroButton cmd_Excluir;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
    }
}