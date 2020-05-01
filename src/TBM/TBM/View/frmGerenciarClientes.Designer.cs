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
            this.btnClienteNovo = new System.Windows.Forms.Button();
            this.btnClienteEditar = new System.Windows.Forms.Button();
            this.dgvClientes = new System.Windows.Forms.DataGridView();
            this.gbFiltros = new System.Windows.Forms.GroupBox();
            this.tbRg = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbCpf = new System.Windows.Forms.MaskedTextBox();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.tbNome = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pbIcone = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.cli_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CPFHidden = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RGHidden = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cli_cpf = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cli_rg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cli_nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cli_endereco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cli_data_nascimento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cli_telefone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cli_email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cli_divida_acumulada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cli_ativado = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.panel1.SuspendLayout();
            this.gbDados.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).BeginInit();
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
            this.panel5.Controls.Add(this.dgvClientes);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(3, 16);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(970, 434);
            this.panel5.TabIndex = 3;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.btnClienteNovo);
            this.panel6.Controls.Add(this.btnClienteEditar);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel6.Location = new System.Drawing.Point(0, 384);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(970, 50);
            this.panel6.TabIndex = 1;
            // 
            // btnClienteNovo
            // 
            this.btnClienteNovo.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnClienteNovo.Location = new System.Drawing.Point(820, 0);
            this.btnClienteNovo.Name = "btnClienteNovo";
            this.btnClienteNovo.Size = new System.Drawing.Size(75, 50);
            this.btnClienteNovo.TabIndex = 2;
            this.btnClienteNovo.Text = "Novo";
            this.btnClienteNovo.UseVisualStyleBackColor = true;
            this.btnClienteNovo.Click += new System.EventHandler(this.btnClienteNovo_Click);
            // 
            // btnClienteEditar
            // 
            this.btnClienteEditar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnClienteEditar.Location = new System.Drawing.Point(895, 0);
            this.btnClienteEditar.Name = "btnClienteEditar";
            this.btnClienteEditar.Size = new System.Drawing.Size(75, 50);
            this.btnClienteEditar.TabIndex = 1;
            this.btnClienteEditar.Text = "Editar";
            this.btnClienteEditar.UseVisualStyleBackColor = true;
            this.btnClienteEditar.Click += new System.EventHandler(this.btnClienteEditar_Click);
            // 
            // dgvClientes
            // 
            this.dgvClientes.AllowUserToAddRows = false;
            this.dgvClientes.AllowUserToDeleteRows = false;
            this.dgvClientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cli_id,
            this.CPFHidden,
            this.RGHidden,
            this.cli_cpf,
            this.cli_rg,
            this.cli_nome,
            this.cli_endereco,
            this.cli_data_nascimento,
            this.cli_telefone,
            this.cli_email,
            this.cli_divida_acumulada,
            this.cli_ativado});
            this.dgvClientes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvClientes.Location = new System.Drawing.Point(0, 0);
            this.dgvClientes.MultiSelect = false;
            this.dgvClientes.Name = "dgvClientes";
            this.dgvClientes.ReadOnly = true;
            this.dgvClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvClientes.Size = new System.Drawing.Size(970, 434);
            this.dgvClientes.TabIndex = 1;
            // 
            // gbFiltros
            // 
            this.gbFiltros.Controls.Add(this.tbRg);
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
            // tbRg
            // 
            this.tbRg.Location = new System.Drawing.Point(112, 71);
            this.tbRg.Mask = "00.000.000-0";
            this.tbRg.Name = "tbRg";
            this.tbRg.Size = new System.Drawing.Size(100, 20);
            this.tbRg.TabIndex = 11;
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
            // tbCpf
            // 
            this.tbCpf.Location = new System.Drawing.Point(6, 71);
            this.tbCpf.Mask = "000.000.000-00";
            this.tbCpf.Name = "tbCpf";
            this.tbCpf.Size = new System.Drawing.Size(100, 20);
            this.tbCpf.TabIndex = 9;
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
            // cli_id
            // 
            this.cli_id.DataPropertyName = "Id";
            this.cli_id.HeaderText = "Código";
            this.cli_id.Name = "cli_id";
            this.cli_id.ReadOnly = true;
            this.cli_id.Visible = false;
            // 
            // CPFHidden
            // 
            this.CPFHidden.DataPropertyName = "Cpf";
            this.CPFHidden.HeaderText = "CPF";
            this.CPFHidden.Name = "CPFHidden";
            this.CPFHidden.ReadOnly = true;
            this.CPFHidden.Visible = false;
            // 
            // RGHidden
            // 
            this.RGHidden.DataPropertyName = "Rg";
            this.RGHidden.HeaderText = "RG";
            this.RGHidden.Name = "RGHidden";
            this.RGHidden.ReadOnly = true;
            this.RGHidden.Visible = false;
            // 
            // cli_cpf
            // 
            this.cli_cpf.DataPropertyName = "CpfMascarado";
            this.cli_cpf.FillWeight = 40F;
            this.cli_cpf.HeaderText = "CPF";
            this.cli_cpf.Name = "cli_cpf";
            this.cli_cpf.ReadOnly = true;
            // 
            // cli_rg
            // 
            this.cli_rg.DataPropertyName = "RgMascarado";
            this.cli_rg.FillWeight = 40F;
            this.cli_rg.HeaderText = "RG";
            this.cli_rg.Name = "cli_rg";
            this.cli_rg.ReadOnly = true;
            this.cli_rg.Visible = false;
            // 
            // cli_nome
            // 
            this.cli_nome.DataPropertyName = "Nome";
            this.cli_nome.FillWeight = 70F;
            this.cli_nome.HeaderText = "Nome completo";
            this.cli_nome.Name = "cli_nome";
            this.cli_nome.ReadOnly = true;
            // 
            // cli_endereco
            // 
            this.cli_endereco.DataPropertyName = "Endereco";
            this.cli_endereco.FillWeight = 70F;
            this.cli_endereco.HeaderText = "Endereço";
            this.cli_endereco.Name = "cli_endereco";
            this.cli_endereco.ReadOnly = true;
            // 
            // cli_data_nascimento
            // 
            this.cli_data_nascimento.DataPropertyName = "Data_nascimento";
            this.cli_data_nascimento.FillWeight = 40F;
            this.cli_data_nascimento.HeaderText = "Data de nascimento";
            this.cli_data_nascimento.Name = "cli_data_nascimento";
            this.cli_data_nascimento.ReadOnly = true;
            this.cli_data_nascimento.Visible = false;
            // 
            // cli_telefone
            // 
            this.cli_telefone.DataPropertyName = "Telefone";
            this.cli_telefone.FillWeight = 40F;
            this.cli_telefone.HeaderText = "Telefone";
            this.cli_telefone.Name = "cli_telefone";
            this.cli_telefone.ReadOnly = true;
            // 
            // cli_email
            // 
            this.cli_email.DataPropertyName = "Email";
            this.cli_email.FillWeight = 40F;
            this.cli_email.HeaderText = "Email";
            this.cli_email.Name = "cli_email";
            this.cli_email.ReadOnly = true;
            this.cli_email.Visible = false;
            // 
            // cli_divida_acumulada
            // 
            this.cli_divida_acumulada.DataPropertyName = "Divida_acumulada";
            this.cli_divida_acumulada.FillWeight = 15.22843F;
            this.cli_divida_acumulada.HeaderText = "Dívida acumulada";
            this.cli_divida_acumulada.Name = "cli_divida_acumulada";
            this.cli_divida_acumulada.ReadOnly = true;
            this.cli_divida_acumulada.Visible = false;
            // 
            // cli_ativado
            // 
            this.cli_ativado.DataPropertyName = "Ativado";
            this.cli_ativado.HeaderText = "Ativado";
            this.cli_ativado.Name = "cli_ativado";
            this.cli_ativado.ReadOnly = true;
            this.cli_ativado.Visible = false;
            // 
            // frmGerenciarClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1024, 768);
            this.MinimumSize = new System.Drawing.Size(1024, 768);
            this.Name = "frmGerenciarClientes";
            this.Text = "Gerenciar clientes";
            this.Load += new System.EventHandler(this.frmGerenciarClientes_Load);
            this.panel1.ResumeLayout(false);
            this.gbDados.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).EndInit();
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
        private System.Windows.Forms.Button btnClienteNovo;
        private System.Windows.Forms.Button btnClienteEditar;
        private System.Windows.Forms.DataGridView dgvClientes;
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
        private System.Windows.Forms.MaskedTextBox tbRg;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox tbCpf;
        private System.Windows.Forms.DataGridViewTextBoxColumn cli_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn CPFHidden;
        private System.Windows.Forms.DataGridViewTextBoxColumn RGHidden;
        private System.Windows.Forms.DataGridViewTextBoxColumn cli_cpf;
        private System.Windows.Forms.DataGridViewTextBoxColumn cli_rg;
        private System.Windows.Forms.DataGridViewTextBoxColumn cli_nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn cli_endereco;
        private System.Windows.Forms.DataGridViewTextBoxColumn cli_data_nascimento;
        private System.Windows.Forms.DataGridViewTextBoxColumn cli_telefone;
        private System.Windows.Forms.DataGridViewTextBoxColumn cli_email;
        private System.Windows.Forms.DataGridViewTextBoxColumn cli_divida_acumulada;
        private System.Windows.Forms.DataGridViewCheckBoxColumn cli_ativado;
    }
}