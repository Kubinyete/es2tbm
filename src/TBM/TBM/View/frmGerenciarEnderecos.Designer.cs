namespace TBM.View
{
    partial class frmGerenciarEnderecos
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnBairroNovo = new System.Windows.Forms.Button();
            this.btnBairroEditar = new System.Windows.Forms.Button();
            this.dgvBairros = new System.Windows.Forms.DataGridView();
            this.gbFiltros = new System.Windows.Forms.GroupBox();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.tbLogradouro = new System.Windows.Forms.TextBox();
            this.tbBairro = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbEstado = new System.Windows.Forms.ComboBox();
            this.cbCidade = new System.Windows.Forms.ComboBox();
            this.pbIcone = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.bai_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bai_nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bai_cidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.end_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.end_logradouro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.end_numero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.end_observacoes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.end_bairro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.gbDados.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEnderecos)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBairros)).BeginInit();
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
            this.panel1.TabIndex = 4;
            // 
            // gbDados
            // 
            this.gbDados.Controls.Add(this.panel5);
            this.gbDados.Controls.Add(this.panel3);
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
            this.panel5.Location = new System.Drawing.Point(266, 16);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(707, 434);
            this.panel5.TabIndex = 3;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.btnEnderecoNovo);
            this.panel6.Controls.Add(this.btnEnderecoEditar);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel6.Location = new System.Drawing.Point(0, 384);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(707, 50);
            this.panel6.TabIndex = 1;
            // 
            // btnEnderecoNovo
            // 
            this.btnEnderecoNovo.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnEnderecoNovo.Location = new System.Drawing.Point(557, 0);
            this.btnEnderecoNovo.Name = "btnEnderecoNovo";
            this.btnEnderecoNovo.Size = new System.Drawing.Size(75, 50);
            this.btnEnderecoNovo.TabIndex = 2;
            this.btnEnderecoNovo.Text = "Novo";
            this.btnEnderecoNovo.UseVisualStyleBackColor = true;
            // 
            // btnEnderecoEditar
            // 
            this.btnEnderecoEditar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnEnderecoEditar.Location = new System.Drawing.Point(632, 0);
            this.btnEnderecoEditar.Name = "btnEnderecoEditar";
            this.btnEnderecoEditar.Size = new System.Drawing.Size(75, 50);
            this.btnEnderecoEditar.TabIndex = 1;
            this.btnEnderecoEditar.Text = "Editar";
            this.btnEnderecoEditar.UseVisualStyleBackColor = true;
            // 
            // dgvEnderecos
            // 
            this.dgvEnderecos.AllowUserToAddRows = false;
            this.dgvEnderecos.AllowUserToDeleteRows = false;
            this.dgvEnderecos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvEnderecos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEnderecos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.end_id,
            this.end_logradouro,
            this.end_numero,
            this.end_observacoes,
            this.end_bairro});
            this.dgvEnderecos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvEnderecos.Location = new System.Drawing.Point(0, 0);
            this.dgvEnderecos.MultiSelect = false;
            this.dgvEnderecos.Name = "dgvEnderecos";
            this.dgvEnderecos.ReadOnly = true;
            this.dgvEnderecos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEnderecos.Size = new System.Drawing.Size(707, 434);
            this.dgvEnderecos.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.dgvBairros);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(3, 16);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(263, 434);
            this.panel3.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnBairroNovo);
            this.panel4.Controls.Add(this.btnBairroEditar);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 384);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(263, 50);
            this.panel4.TabIndex = 1;
            // 
            // btnBairroNovo
            // 
            this.btnBairroNovo.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnBairroNovo.Location = new System.Drawing.Point(113, 0);
            this.btnBairroNovo.Name = "btnBairroNovo";
            this.btnBairroNovo.Size = new System.Drawing.Size(75, 50);
            this.btnBairroNovo.TabIndex = 1;
            this.btnBairroNovo.Text = "Novo";
            this.btnBairroNovo.UseVisualStyleBackColor = true;
            this.btnBairroNovo.Click += new System.EventHandler(this.btnBairroNovo_Click);
            // 
            // btnBairroEditar
            // 
            this.btnBairroEditar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnBairroEditar.Location = new System.Drawing.Point(188, 0);
            this.btnBairroEditar.Name = "btnBairroEditar";
            this.btnBairroEditar.Size = new System.Drawing.Size(75, 50);
            this.btnBairroEditar.TabIndex = 0;
            this.btnBairroEditar.Text = "Editar";
            this.btnBairroEditar.UseVisualStyleBackColor = true;
            this.btnBairroEditar.Click += new System.EventHandler(this.btnBairroEditar_Click);
            // 
            // dgvBairros
            // 
            this.dgvBairros.AllowUserToAddRows = false;
            this.dgvBairros.AllowUserToDeleteRows = false;
            this.dgvBairros.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBairros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBairros.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.bai_id,
            this.bai_nome,
            this.bai_cidade});
            this.dgvBairros.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvBairros.Location = new System.Drawing.Point(0, 0);
            this.dgvBairros.MultiSelect = false;
            this.dgvBairros.Name = "dgvBairros";
            this.dgvBairros.ReadOnly = true;
            this.dgvBairros.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBairros.Size = new System.Drawing.Size(263, 434);
            this.dgvBairros.TabIndex = 0;
            this.dgvBairros.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dgvBairros_MouseDoubleClick);
            // 
            // gbFiltros
            // 
            this.gbFiltros.Controls.Add(this.btnPesquisar);
            this.gbFiltros.Controls.Add(this.label5);
            this.gbFiltros.Controls.Add(this.tbLogradouro);
            this.gbFiltros.Controls.Add(this.tbBairro);
            this.gbFiltros.Controls.Add(this.label4);
            this.gbFiltros.Controls.Add(this.label3);
            this.gbFiltros.Controls.Add(this.label1);
            this.gbFiltros.Controls.Add(this.cbEstado);
            this.gbFiltros.Controls.Add(this.cbCidade);
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
            this.label5.Location = new System.Drawing.Point(272, 57);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Procurar por logradouro";
            // 
            // tbLogradouro
            // 
            this.tbLogradouro.Location = new System.Drawing.Point(275, 73);
            this.tbLogradouro.Name = "tbLogradouro";
            this.tbLogradouro.Size = new System.Drawing.Size(589, 20);
            this.tbLogradouro.TabIndex = 6;
            // 
            // tbBairro
            // 
            this.tbBairro.Location = new System.Drawing.Point(6, 73);
            this.tbBairro.Name = "tbBairro";
            this.tbBairro.Size = new System.Drawing.Size(263, 20);
            this.tbBairro.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Procurar por bairro";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Cidade";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(226, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "UF";
            // 
            // cbEstado
            // 
            this.cbEstado.FormattingEnabled = true;
            this.cbEstado.Location = new System.Drawing.Point(229, 33);
            this.cbEstado.Name = "cbEstado";
            this.cbEstado.Size = new System.Drawing.Size(40, 21);
            this.cbEstado.TabIndex = 1;
            this.cbEstado.SelectedIndexChanged += new System.EventHandler(this.cbEstado_SelectedIndexChanged);
            // 
            // cbCidade
            // 
            this.cbCidade.FormattingEnabled = true;
            this.cbCidade.Location = new System.Drawing.Point(6, 33);
            this.cbCidade.Name = "cbCidade";
            this.cbCidade.Size = new System.Drawing.Size(217, 21);
            this.cbCidade.TabIndex = 0;
            // 
            // pbIcone
            // 
            this.pbIcone.BackColor = System.Drawing.Color.Transparent;
            this.pbIcone.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbIcone.Image = global::TBM.Properties.Resources.location_icon;
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
            this.label2.Text = "Gerenciar endereços";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
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
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnConfirmar);
            this.panel2.Controls.Add(this.btnCancelar);
            this.panel2.Location = new System.Drawing.Point(12, 637);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(984, 80);
            this.panel2.TabIndex = 5;
            // 
            // bai_id
            // 
            this.bai_id.DataPropertyName = "Id";
            this.bai_id.HeaderText = "Código";
            this.bai_id.Name = "bai_id";
            this.bai_id.ReadOnly = true;
            this.bai_id.Visible = false;
            // 
            // bai_nome
            // 
            this.bai_nome.DataPropertyName = "Nome";
            this.bai_nome.HeaderText = "Bairro";
            this.bai_nome.Name = "bai_nome";
            this.bai_nome.ReadOnly = true;
            // 
            // bai_cidade
            // 
            this.bai_cidade.DataPropertyName = "Cidade";
            this.bai_cidade.HeaderText = "Cidade";
            this.bai_cidade.Name = "bai_cidade";
            this.bai_cidade.ReadOnly = true;
            this.bai_cidade.Visible = false;
            // 
            // end_id
            // 
            this.end_id.DataPropertyName = "Id";
            this.end_id.HeaderText = "Código";
            this.end_id.Name = "end_id";
            this.end_id.ReadOnly = true;
            this.end_id.Visible = false;
            // 
            // end_logradouro
            // 
            this.end_logradouro.DataPropertyName = "Logradouro";
            this.end_logradouro.HeaderText = "Logradouro";
            this.end_logradouro.Name = "end_logradouro";
            this.end_logradouro.ReadOnly = true;
            // 
            // end_numero
            // 
            this.end_numero.DataPropertyName = "Numero";
            this.end_numero.HeaderText = "Número";
            this.end_numero.Name = "end_numero";
            this.end_numero.ReadOnly = true;
            // 
            // end_observacoes
            // 
            this.end_observacoes.DataPropertyName = "Observacoes";
            this.end_observacoes.HeaderText = "Observações";
            this.end_observacoes.Name = "end_observacoes";
            this.end_observacoes.ReadOnly = true;
            // 
            // end_bairro
            // 
            this.end_bairro.DataPropertyName = "Bairro";
            this.end_bairro.HeaderText = "Bairro";
            this.end_bairro.Name = "end_bairro";
            this.end_bairro.ReadOnly = true;
            // 
            // frmGerenciarEnderecos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.MaximumSize = new System.Drawing.Size(1024, 768);
            this.MinimumSize = new System.Drawing.Size(1024, 768);
            this.Name = "frmGerenciarEnderecos";
            this.Text = "Gerenciar endereços";
            this.Load += new System.EventHandler(this.frmGerenciarEnderecos_Load);
            this.panel1.ResumeLayout(false);
            this.gbDados.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEnderecos)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBairros)).EndInit();
            this.gbFiltros.ResumeLayout(false);
            this.gbFiltros.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbIcone)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pbIcone;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox gbFiltros;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox cbCidade;
        private System.Windows.Forms.ComboBox cbEstado;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbLogradouro;
        private System.Windows.Forms.TextBox tbBairro;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox gbDados;
        private System.Windows.Forms.DataGridView dgvEnderecos;
        private System.Windows.Forms.DataGridView dgvBairros;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnEnderecoNovo;
        private System.Windows.Forms.Button btnEnderecoEditar;
        private System.Windows.Forms.Button btnBairroNovo;
        private System.Windows.Forms.Button btnBairroEditar;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.DataGridViewTextBoxColumn bai_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn bai_nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn bai_cidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn end_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn end_logradouro;
        private System.Windows.Forms.DataGridViewTextBoxColumn end_numero;
        private System.Windows.Forms.DataGridViewTextBoxColumn end_observacoes;
        private System.Windows.Forms.DataGridViewTextBoxColumn end_bairro;
    }
}