namespace TBM.View
{
    partial class frmParametrizacao
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
            this.tbNomeFantasia = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gbParametros = new System.Windows.Forms.GroupBox();
            this.btnLogo = new System.Windows.Forms.Button();
            this.btnEndereco = new System.Windows.Forms.Button();
            this.cbEndereco = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tbCaminhoLogo = new System.Windows.Forms.TextBox();
            this.tbTelefone = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbInscricaoEstadual = new System.Windows.Forms.MaskedTextBox();
            this.tbRazaoSocial = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbCnpj = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.ofdAlterar = new System.Windows.Forms.OpenFileDialog();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.pbIcone = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.gbParametros.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbIcone)).BeginInit();
            this.SuspendLayout();
            // 
            // tbNomeFantasia
            // 
            this.tbNomeFantasia.Location = new System.Drawing.Point(9, 32);
            this.tbNomeFantasia.Name = "tbNomeFantasia";
            this.tbNomeFantasia.Size = new System.Drawing.Size(432, 20);
            this.tbNomeFantasia.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nome fantasia";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.IndianRed;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(759, 50);
            this.label2.TabIndex = 2;
            this.label2.Text = "Parametrização do sistema";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.gbParametros);
            this.panel1.Controls.Add(this.pbIcone);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(759, 454);
            this.panel1.TabIndex = 3;
            // 
            // gbParametros
            // 
            this.gbParametros.Controls.Add(this.btnLogo);
            this.gbParametros.Controls.Add(this.pbLogo);
            this.gbParametros.Controls.Add(this.btnEndereco);
            this.gbParametros.Controls.Add(this.cbEndereco);
            this.gbParametros.Controls.Add(this.label9);
            this.gbParametros.Controls.Add(this.label8);
            this.gbParametros.Controls.Add(this.tbCaminhoLogo);
            this.gbParametros.Controls.Add(this.tbTelefone);
            this.gbParametros.Controls.Add(this.label7);
            this.gbParametros.Controls.Add(this.label6);
            this.gbParametros.Controls.Add(this.tbEmail);
            this.gbParametros.Controls.Add(this.label1);
            this.gbParametros.Controls.Add(this.label5);
            this.gbParametros.Controls.Add(this.tbNomeFantasia);
            this.gbParametros.Controls.Add(this.tbInscricaoEstadual);
            this.gbParametros.Controls.Add(this.tbRazaoSocial);
            this.gbParametros.Controls.Add(this.label3);
            this.gbParametros.Controls.Add(this.tbCnpj);
            this.gbParametros.Controls.Add(this.label4);
            this.gbParametros.Location = new System.Drawing.Point(3, 56);
            this.gbParametros.Name = "gbParametros";
            this.gbParametros.Size = new System.Drawing.Size(753, 394);
            this.gbParametros.TabIndex = 12;
            this.gbParametros.TabStop = false;
            this.gbParametros.Text = "Parâmetros";
            // 
            // btnLogo
            // 
            this.btnLogo.Location = new System.Drawing.Point(447, 338);
            this.btnLogo.Name = "btnLogo";
            this.btnLogo.Size = new System.Drawing.Size(300, 50);
            this.btnLogo.TabIndex = 23;
            this.btnLogo.Text = "Alterar";
            this.btnLogo.UseVisualStyleBackColor = true;
            this.btnLogo.Click += new System.EventHandler(this.btnLogo_Click);
            // 
            // btnEndereco
            // 
            this.btnEndereco.Location = new System.Drawing.Point(366, 214);
            this.btnEndereco.Name = "btnEndereco";
            this.btnEndereco.Size = new System.Drawing.Size(75, 38);
            this.btnEndereco.TabIndex = 21;
            this.btnEndereco.Text = "Procurar";
            this.btnEndereco.UseVisualStyleBackColor = true;
            this.btnEndereco.Click += new System.EventHandler(this.btnEndereco_Click);
            // 
            // cbEndereco
            // 
            this.cbEndereco.Enabled = false;
            this.cbEndereco.FormattingEnabled = true;
            this.cbEndereco.Location = new System.Drawing.Point(9, 231);
            this.cbEndereco.Name = "cbEndereco";
            this.cbEndereco.Size = new System.Drawing.Size(351, 21);
            this.cbEndereco.TabIndex = 20;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 215);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(99, 13);
            this.label9.TabIndex = 19;
            this.label9.Text = "Endereço completo";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(121, 172);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(148, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "Caminho para logo do sistema";
            // 
            // tbCaminhoLogo
            // 
            this.tbCaminhoLogo.Enabled = false;
            this.tbCaminhoLogo.Location = new System.Drawing.Point(124, 188);
            this.tbCaminhoLogo.Name = "tbCaminhoLogo";
            this.tbCaminhoLogo.Size = new System.Drawing.Size(317, 20);
            this.tbCaminhoLogo.TabIndex = 16;
            // 
            // tbTelefone
            // 
            this.tbTelefone.Location = new System.Drawing.Point(9, 188);
            this.tbTelefone.Mask = "(00)00000-0000";
            this.tbTelefone.Name = "tbTelefone";
            this.tbTelefone.Size = new System.Drawing.Size(109, 20);
            this.tbTelefone.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 172);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Telefone";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 133);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "E-mail";
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(9, 149);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(432, 20);
            this.tbEmail.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(121, 94);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Inscrição Estadual";
            // 
            // tbInscricaoEstadual
            // 
            this.tbInscricaoEstadual.Location = new System.Drawing.Point(124, 110);
            this.tbInscricaoEstadual.Mask = "000.000.000.000";
            this.tbInscricaoEstadual.Name = "tbInscricaoEstadual";
            this.tbInscricaoEstadual.Size = new System.Drawing.Size(317, 20);
            this.tbInscricaoEstadual.TabIndex = 10;
            // 
            // tbRazaoSocial
            // 
            this.tbRazaoSocial.Location = new System.Drawing.Point(9, 71);
            this.tbRazaoSocial.Name = "tbRazaoSocial";
            this.tbRazaoSocial.Size = new System.Drawing.Size(432, 20);
            this.tbRazaoSocial.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Razão social";
            // 
            // tbCnpj
            // 
            this.tbCnpj.Location = new System.Drawing.Point(9, 110);
            this.tbCnpj.Mask = "00.000.000/0000-00";
            this.tbCnpj.Name = "tbCnpj";
            this.tbCnpj.Size = new System.Drawing.Size(109, 20);
            this.tbCnpj.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "CNPJ";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnConfirmar);
            this.panel2.Controls.Add(this.btnCancelar);
            this.panel2.Location = new System.Drawing.Point(12, 469);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(759, 80);
            this.panel2.TabIndex = 4;
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Location = new System.Drawing.Point(594, 3);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(75, 74);
            this.btnConfirmar.TabIndex = 1;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = true;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(675, 3);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 74);
            this.btnCancelar.TabIndex = 0;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // ofdAlterar
            // 
            this.ofdAlterar.Filter = "Arquivos PNG|*.png|Arquivos JPEG|*.jpeg|Arquivos JPG|*.jpg|Todos os arquivos|*.*";
            // 
            // pbLogo
            // 
            this.pbLogo.Location = new System.Drawing.Point(447, 32);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(300, 300);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLogo.TabIndex = 22;
            this.pbLogo.TabStop = false;
            // 
            // pbIcone
            // 
            this.pbIcone.BackColor = System.Drawing.Color.Transparent;
            this.pbIcone.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbIcone.Image = global::TBM.Properties.Resources.settings_icon;
            this.pbIcone.Location = new System.Drawing.Point(0, 0);
            this.pbIcone.Name = "pbIcone";
            this.pbIcone.Size = new System.Drawing.Size(50, 50);
            this.pbIcone.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbIcone.TabIndex = 9;
            this.pbIcone.TabStop = false;
            // 
            // frmParametrizacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(800, 600);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "frmParametrizacao";
            this.Text = "Parametrização do sistema";
            this.Load += new System.EventHandler(this.frmParametrizacao_Load);
            this.panel1.ResumeLayout(false);
            this.gbParametros.ResumeLayout(false);
            this.gbParametros.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbIcone)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox tbNomeFantasia;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MaskedTextBox tbCnpj;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbRazaoSocial;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pbIcone;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox tbInscricaoEstadual;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox gbParametros;
        private System.Windows.Forms.MaskedTextBox tbTelefone;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.Button btnLogo;
        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.Button btnEndereco;
        private System.Windows.Forms.ComboBox cbEndereco;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbCaminhoLogo;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.OpenFileDialog ofdAlterar;
    }
}