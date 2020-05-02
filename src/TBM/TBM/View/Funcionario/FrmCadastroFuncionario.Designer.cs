namespace TBM.View
{
    partial class FrmCadastroFuncionario
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.dtpDtNasc = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.tbSalario = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cbCargo = new System.Windows.Forms.ComboBox();
            this.btnEndereco = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.cbEndereco = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbNome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbRG = new System.Windows.Forms.MaskedTextBox();
            this.tbCPF = new System.Windows.Forms.MaskedTextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dtpDtNasc);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.tbSalario);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.cbCargo);
            this.panel1.Controls.Add(this.btnEndereco);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.cbEndereco);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.tbNome);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.tbRG);
            this.panel1.Controls.Add(this.tbCPF);
            this.panel1.Location = new System.Drawing.Point(12, 62);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(504, 230);
            this.panel1.TabIndex = 0;
            // 
            // dtpDtNasc
            // 
            this.dtpDtNasc.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDtNasc.Location = new System.Drawing.Point(112, 102);
            this.dtpDtNasc.Name = "dtpDtNasc";
            this.dtpDtNasc.Size = new System.Drawing.Size(98, 20);
            this.dtpDtNasc.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 102);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(106, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Data De Nascimento";
            // 
            // tbSalario
            // 
            this.tbSalario.Location = new System.Drawing.Point(358, 179);
            this.tbSalario.Name = "tbSalario";
            this.tbSalario.Size = new System.Drawing.Size(114, 20);
            this.tbSalario.TabIndex = 12;
            this.tbSalario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbSalario_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(313, 182);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Salário";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(71, 182);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Cargo";
            // 
            // cbCargo
            // 
            this.cbCargo.BackColor = System.Drawing.SystemColors.Info;
            this.cbCargo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCargo.FormattingEnabled = true;
            this.cbCargo.Location = new System.Drawing.Point(112, 178);
            this.cbCargo.Name = "cbCargo";
            this.cbCargo.Size = new System.Drawing.Size(159, 21);
            this.cbCargo.TabIndex = 9;
            this.cbCargo.SelectedIndexChanged += new System.EventHandler(this.cbCargo_SelectedIndexChanged);
            // 
            // btnEndereco
            // 
            this.btnEndereco.Location = new System.Drawing.Point(445, 134);
            this.btnEndereco.Name = "btnEndereco";
            this.btnEndereco.Size = new System.Drawing.Size(27, 23);
            this.btnEndereco.TabIndex = 8;
            this.btnEndereco.Text = "+";
            this.btnEndereco.UseVisualStyleBackColor = true;
            this.btnEndereco.Click += new System.EventHandler(this.btnEndereco_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(56, 139);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Endereço";
            // 
            // cbEndereco
            // 
            this.cbEndereco.BackColor = System.Drawing.SystemColors.Info;
            this.cbEndereco.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEndereco.FormattingEnabled = true;
            this.cbEndereco.Location = new System.Drawing.Point(112, 136);
            this.cbEndereco.Name = "cbEndereco";
            this.cbEndereco.Size = new System.Drawing.Size(327, 21);
            this.cbEndereco.TabIndex = 6;
            this.cbEndereco.SelectedIndexChanged += new System.EventHandler(this.cbEndereco_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Nome Completo";
            // 
            // tbNome
            // 
            this.tbNome.Location = new System.Drawing.Point(112, 28);
            this.tbNome.Name = "tbNome";
            this.tbNome.Size = new System.Drawing.Size(360, 20);
            this.tbNome.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(329, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "RG";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(79, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "CPF";
            // 
            // tbRG
            // 
            this.tbRG.Location = new System.Drawing.Point(358, 64);
            this.tbRG.Name = "tbRG";
            this.tbRG.Size = new System.Drawing.Size(114, 20);
            this.tbRG.TabIndex = 1;
            // 
            // tbCPF
            // 
            this.tbCPF.Location = new System.Drawing.Point(112, 64);
            this.tbCPF.Mask = "000.000.000-00";
            this.tbCPF.Name = "tbCPF";
            this.tbCPF.Size = new System.Drawing.Size(152, 20);
            this.tbCPF.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.btnCancelar);
            this.panel3.Controls.Add(this.btnConfirmar);
            this.panel3.Location = new System.Drawing.Point(13, 298);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(503, 68);
            this.panel3.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(181, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Obs: todos os dados são obrigatórios";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(444, 13);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(46, 41);
            this.btnCancelar.TabIndex = 3;
            this.btnCancelar.Text = "CANC";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Location = new System.Drawing.Point(387, 13);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(51, 41);
            this.btnConfirmar.TabIndex = 1;
            this.btnConfirmar.Text = "CONF";
            this.btnConfirmar.UseVisualStyleBackColor = true;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.lblTitulo);
            this.panel2.Location = new System.Drawing.Point(13, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(503, 53);
            this.panel2.TabIndex = 10;
            // 
            // lblTitulo
            // 
            this.lblTitulo.BackColor = System.Drawing.Color.IndianRed;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.lblTitulo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblTitulo.Location = new System.Drawing.Point(0, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(502, 53);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "% action %";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::TBM.Properties.Resources.user;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(55, 53);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // FrmCadastroFuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(572, 391);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Name = "FrmCadastroFuncionario";
            this.Text = "% action %";
            this.Load += new System.EventHandler(this.FrmCadastroFuncionario_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MaskedTextBox tbRG;
        private System.Windows.Forms.MaskedTextBox tbCPF;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbNome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnEndereco;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbEndereco;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DateTimePicker dtpDtNasc;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.MaskedTextBox tbSalario;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbCargo;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
    }
}