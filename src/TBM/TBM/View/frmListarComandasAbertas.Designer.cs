namespace TBM.View
{
    partial class frmListarComandasAbertas
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
            this.dgvComandas = new System.Windows.Forms.DataGridView();
            this.gbFiltros = new System.Windows.Forms.GroupBox();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pbIcone = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.tbNome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbMesa = new System.Windows.Forms.ComboBox();
            this.com_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.com_apelido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.com_observacoes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.com_valor_total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.com_data_abertura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.com_data_fechamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.com_garcom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.com_cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.com_mesa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.gbDados.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvComandas)).BeginInit();
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
            this.panel1.TabIndex = 6;
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
            this.panel5.Controls.Add(this.dgvComandas);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(3, 16);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(970, 434);
            this.panel5.TabIndex = 3;
            // 
            // dgvComandas
            // 
            this.dgvComandas.AllowUserToAddRows = false;
            this.dgvComandas.AllowUserToDeleteRows = false;
            this.dgvComandas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvComandas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvComandas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.com_id,
            this.com_apelido,
            this.com_observacoes,
            this.com_valor_total,
            this.com_data_abertura,
            this.com_data_fechamento,
            this.com_garcom,
            this.com_cliente,
            this.com_mesa});
            this.dgvComandas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvComandas.Location = new System.Drawing.Point(0, 0);
            this.dgvComandas.MultiSelect = false;
            this.dgvComandas.Name = "dgvComandas";
            this.dgvComandas.ReadOnly = true;
            this.dgvComandas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvComandas.Size = new System.Drawing.Size(970, 434);
            this.dgvComandas.TabIndex = 1;
            // 
            // gbFiltros
            // 
            this.gbFiltros.Controls.Add(this.cbMesa);
            this.gbFiltros.Controls.Add(this.label1);
            this.gbFiltros.Controls.Add(this.btnPesquisar);
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
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(150, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Nome do Garçom responsável";
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
            this.label2.Text = "Listagem de comandas abertas";
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
            this.panel2.TabIndex = 7;
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Location = new System.Drawing.Point(825, 3);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(75, 74);
            this.btnConfirmar.TabIndex = 1;
            this.btnConfirmar.Text = "Fechar comanda";
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
            // tbNome
            // 
            this.tbNome.Location = new System.Drawing.Point(6, 73);
            this.tbNome.Name = "tbNome";
            this.tbNome.Size = new System.Drawing.Size(321, 20);
            this.tbNome.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Mesa*";
            // 
            // cbMesa
            // 
            this.cbMesa.FormattingEnabled = true;
            this.cbMesa.Location = new System.Drawing.Point(6, 32);
            this.cbMesa.Name = "cbMesa";
            this.cbMesa.Size = new System.Drawing.Size(101, 21);
            this.cbMesa.TabIndex = 31;
            // 
            // com_id
            // 
            this.com_id.DataPropertyName = "Com_id";
            this.com_id.HeaderText = "Código";
            this.com_id.Name = "com_id";
            this.com_id.ReadOnly = true;
            // 
            // com_apelido
            // 
            this.com_apelido.DataPropertyName = "Com_apelido";
            this.com_apelido.HeaderText = "Apelido";
            this.com_apelido.Name = "com_apelido";
            this.com_apelido.ReadOnly = true;
            // 
            // com_observacoes
            // 
            this.com_observacoes.DataPropertyName = "Com_observacoes";
            this.com_observacoes.HeaderText = "Observações";
            this.com_observacoes.Name = "com_observacoes";
            this.com_observacoes.ReadOnly = true;
            this.com_observacoes.Visible = false;
            // 
            // com_valor_total
            // 
            this.com_valor_total.DataPropertyName = "Com_valor_total";
            this.com_valor_total.HeaderText = "Valor total";
            this.com_valor_total.Name = "com_valor_total";
            this.com_valor_total.ReadOnly = true;
            this.com_valor_total.Visible = false;
            // 
            // com_data_abertura
            // 
            this.com_data_abertura.DataPropertyName = "Com_data_abertura";
            this.com_data_abertura.HeaderText = "Data de abertura";
            this.com_data_abertura.Name = "com_data_abertura";
            this.com_data_abertura.ReadOnly = true;
            // 
            // com_data_fechamento
            // 
            this.com_data_fechamento.DataPropertyName = "Com_data_fechamento";
            this.com_data_fechamento.HeaderText = "Data de fechamento";
            this.com_data_fechamento.Name = "com_data_fechamento";
            this.com_data_fechamento.ReadOnly = true;
            this.com_data_fechamento.Visible = false;
            // 
            // com_garcom
            // 
            this.com_garcom.DataPropertyName = "Funcionario";
            this.com_garcom.HeaderText = "Garçom responsável";
            this.com_garcom.Name = "com_garcom";
            this.com_garcom.ReadOnly = true;
            // 
            // com_cliente
            // 
            this.com_cliente.DataPropertyName = "Cliente";
            this.com_cliente.HeaderText = "Cliente vinculado";
            this.com_cliente.Name = "com_cliente";
            this.com_cliente.ReadOnly = true;
            this.com_cliente.Visible = false;
            // 
            // com_mesa
            // 
            this.com_mesa.DataPropertyName = "Mesa";
            this.com_mesa.HeaderText = "Mesa";
            this.com_mesa.Name = "com_mesa";
            this.com_mesa.ReadOnly = true;
            // 
            // frmListarComandasAbertas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.MaximumSize = new System.Drawing.Size(1024, 768);
            this.MinimumSize = new System.Drawing.Size(1024, 768);
            this.Name = "frmListarComandasAbertas";
            this.Text = "Listagem de comandas abertas";
            this.Load += new System.EventHandler(this.frmListarComandasAbertas_Load);
            this.panel1.ResumeLayout(false);
            this.gbDados.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvComandas)).EndInit();
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
        private System.Windows.Forms.DataGridView dgvComandas;
        private System.Windows.Forms.GroupBox gbFiltros;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pbIcone;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbNome;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.ComboBox cbMesa;
        private System.Windows.Forms.DataGridViewTextBoxColumn com_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn com_apelido;
        private System.Windows.Forms.DataGridViewTextBoxColumn com_observacoes;
        private System.Windows.Forms.DataGridViewTextBoxColumn com_valor_total;
        private System.Windows.Forms.DataGridViewTextBoxColumn com_data_abertura;
        private System.Windows.Forms.DataGridViewTextBoxColumn com_data_fechamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn com_garcom;
        private System.Windows.Forms.DataGridViewTextBoxColumn com_cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn com_mesa;
    }
}