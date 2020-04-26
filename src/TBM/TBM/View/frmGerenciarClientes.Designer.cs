namespace TBM.View
{
    partial class frmGerenciarClientes
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
            this.gbDados = new System.Windows.Forms.GroupBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.btnEnderecoNovo = new System.Windows.Forms.Button();
            this.btnEnderecoEditar = new System.Windows.Forms.Button();
            this.dgvEnderecos = new System.Windows.Forms.DataGridView();
            this.gbFiltros = new System.Windows.Forms.GroupBox();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.tbNome = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pbIcone = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.tbCpf = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cli_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cli_cpf = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cli_rg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cli_nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cli_data_nascimento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cli_endereco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.gbDados.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEnderecos)).BeginInit();
            this.gbFiltros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbIcone)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.gbDados);
            this.panel1.Controls.Add(this.gbFiltros);
            this.panel1.Controls.Add(this.pbIcone);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(984, 619);
            this.panel1.TabIndex = 5;
            // 
            // gbDados
            // 
            this.gbDados.Controls.Add(this.panel5);
            this.gbDados.Location = new System.Drawing.Point(5, 163);
            this.gbDados.Name = "gbDados";
            this.gbDados.Size = new System.Drawing.Size(976, 453);
            this.gbDados.TabIndex = 11;
            this.gbDados.TabStop = false;
            this.gbDados.Text = "Dados";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.panel6);
            this.panel5.Controls.Add(this.dgvEnderecos);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(3, 16);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(970, 434);
            this.panel5.TabIndex = 3;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.btnEnderecoNovo);
            this.panel6.Controls.Add(this.btnEnderecoEditar);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel6.Location = new System.Drawing.Point(0, 384);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(970, 50);
            this.panel6.TabIndex = 1;
            // 
            // btnEnderecoNovo
            // 
            this.btnEnderecoNovo.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnEnderecoNovo.Location = new System.Drawing.Point(820, 0);
            this.btnEnderecoNovo.Name = "btnEnderecoNovo";
            this.btnEnderecoNovo.Size = new System.Drawing.Size(75, 50);
            this.btnEnderecoNovo.TabIndex = 2;
            this.btnEnderecoNovo.Text = "Novo";
            this.btnEnderecoNovo.UseVisualStyleBackColor = true;
            this.btnEnderecoNovo.Click += new System.EventHandler(this.btnEnderecoNovo_Click);
            // 
            // btnEnderecoEditar
            // 
            this.btnEnderecoEditar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnEnderecoEditar.Location = new System.Drawing.Point(895, 0);
            this.btnEnderecoEditar.Name = "btnEnderecoEditar";
            this.btnEnderecoEditar.Size = new System.Drawing.Size(75, 50);
            this.btnEnderecoEditar.TabIndex = 1;
            this.btnEnderecoEditar.Text = "Editar";
            this.btnEnderecoEditar.UseVisualStyleBackColor = true;
            this.btnEnderecoEditar.Click += new System.EventHandler(this.btnEnderecoEditar_Click);
            // 
            // dgvEnderecos
            // 
            this.dgvEnderecos.AllowUserToAddRows = false;
            this.dgvEnderecos.AllowUserToDeleteRows = false;
            this.dgvEnderecos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvEnderecos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEnderecos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cli_id,
            this.cli_cpf,
            this.cli_rg,
            this.cli_nome,
            this.cli_data_nascimento,
            this.cli_endereco});
            this.dgvEnderecos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvEnderecos.Location = new System.Drawing.Point(0, 0);
            this.dgvEnderecos.MultiSelect = false;
            this.dgvEnderecos.Name = "dgvEnderecos";
            this.dgvEnderecos.ReadOnly = true;
            this.dgvEnderecos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEnderecos.Size = new System.Drawing.Size(970, 434);
            this.dgvEnderecos.TabIndex = 1;
            // 
            // gbFiltros
            // 
            this.gbFiltros.Controls.Add(this.maskedTextBox1);
            this.gbFiltros.Controls.Add(this.label1);
            this.gbFiltros.Controls.Add(this.tbCpf);
            this.gbFiltros.Controls.Add(this.btnPesquisar);
            this.gbFiltros.Controls.Add(this.label5);
            this.gbFiltros.Controls.Add(this.tbNome);
            this.gbFiltros.Controls.Add(this.label4);
            this.gbFiltros.Location = new System.Drawing.Point(5, 56);
            this.gbFiltros.Name = "gbFiltros";
            this.gbFiltros.Size = new System.Drawing.Size(976, 101);
            this.gbFiltros.TabIndex = 10;
            this.gbFiltros.TabStop = false;
            this.gbFiltros.Text = "Filtros de seleção";
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(870, 16);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(100, 77);
            this.btnPesquisar.TabIndex = 8;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 55);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Procurar por CPF";
            // 
            // tbNome
            // 
            this.tbNome.Location = new System.Drawing.Point(6, 32);
            this.tbNome.Name = "tbNome";
            this.tbNome.Size = new System.Drawing.Size(321, 20);
            this.tbNome.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Procurar por nome";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.IndianRed;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(984, 50);
            this.label2.TabIndex = 2;
            this.label2.Text = "Gerenciar clientes";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pbIcone
            // 
            this.pbIcone.BackColor = System.Drawing.Color.Transparent;
            this.pbIcone.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbIcone.Image = global::TBM.Properties.Resources.user_icon;
            this.pbIcone.Location = new System.Drawing.Point(0, 0);
            this.pbIcone.Name = "pbIcone";
            this.pbIcone.Size = new System.Drawing.Size(50, 50);
            this.pbIcone.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbIcone.TabIndex = 9;
            this.pbIcone.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnConfirmar);
            this.panel2.Controls.Add(this.btnCancelar);
            this.panel2.Location = new System.Drawing.Point(12, 637);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(984, 80);
            this.panel2.TabIndex = 6;
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Enabled = false;
            this.btnConfirmar.Location = new System.Drawing.Point(825, 3);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(75, 74);
            this.btnConfirmar.TabIndex = 1;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = true;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(906, 3);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 74);
            this.btnCancelar.TabIndex = 0;
            this.btnCancelar.Text = "Fechar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // tbCpf
            // 
            this.tbCpf.Location = new System.Drawing.Point(6, 71);
            this.tbCpf.Mask = "000.000.000-00";
            this.tbCpf.Name = "tbCpf";
            this.tbCpf.Size = new System.Drawing.Size(100, 20);
            this.tbCpf.TabIndex = 9;
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(112, 71);
            this.maskedTextBox1.Mask = "00.000.000-0";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(100, 20);
            this.maskedTextBox1.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(109, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Procurar por RG";
            // 
            // cli_id
            // 
            this.cli_id.DataPropertyName = "Id";
            this.cli_id.HeaderText = "Código";
            this.cli_id.Name = "cli_id";
            this.cli_id.ReadOnly = true;
            this.cli_id.Visible = false;
            // 
            // cli_cpf
            // 
            this.cli_cpf.DataPropertyName = "CpfMascarado";
            this.cli_cpf.HeaderText = "CPF";
            this.cli_cpf.Name = "cli_cpf";
            this.cli_cpf.ReadOnly = true;
            // 
            // cli_rg
            // 
            this.cli_rg.DataPropertyName = "RgMascarado";
            this.cli_rg.HeaderText = "RG";
            this.cli_rg.Name = "cli_rg";
            this.cli_rg.ReadOnly = true;
            // 
            // cli_nome
            // 
            this.cli_nome.DataPropertyName = "Nome";
            this.cli_nome.HeaderText = "Nome completo";
            this.cli_nome.Name = "cli_nome";
            this.cli_nome.ReadOnly = true;
            // 
            // cli_data_nascimento
            // 
            this.cli_data_nascimento.DataPropertyName = "DataNascimento";
            this.cli_data_nascimento.HeaderText = "Data de nascimento";
            this.cli_data_nascimento.Name = "cli_data_nascimento";
            this.cli_data_nascimento.ReadOnly = true;
            // 
            // cli_endereco
            // 
            this.cli_endereco.DataPropertyName = "Endereco";
            this.cli_endereco.HeaderText = "Endereço";
            this.cli_endereco.Name = "cli_endereco";
            this.cli_endereco.ReadOnly = true;
            // 
            // frmGerenciarClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "frmGerenciarClientes";
            this.Text = "Gerenciar clientes";
            this.panel1.ResumeLayout(false);
            this.gbDados.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEnderecos)).EndInit();
            this.gbFiltros.ResumeLayout(false);
            this.gbFiltros.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbIcone)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox gbDados;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button btnEnderecoNovo;
        private System.Windows.Forms.Button btnEnderecoEditar;
        private System.Windows.Forms.DataGridView dgvEnderecos;
        private System.Windows.Forms.GroupBox gbFiltros;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbNome;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pbIcone;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox tbCpf;
        private System.Windows.Forms.DataGridViewTextBoxColumn cli_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn cli_cpf;
        private System.Windows.Forms.DataGridViewTextBoxColumn cli_rg;
        private System.Windows.Forms.DataGridViewTextBoxColumn cli_nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn cli_data_nascimento;
        private System.Windows.Forms.DataGridViewTextBoxColumn cli_endereco;
    }
}