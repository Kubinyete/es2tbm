namespace TBM.View.Comanda
{
    partial class FrmGerenciarComandas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGerenciarComandas));
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tbBusca = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cbGarcom = new System.Windows.Forms.ComboBox();
            this.lblgarocm = new System.Windows.Forms.Label();
            this.cbMesa = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbFiltrosAtivados = new System.Windows.Forms.CheckBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvComandas = new System.Windows.Forms.DataGridView();
            this.com_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.com_data_abertura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.com_valor_total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.com_apelido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.funcionario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.com_observacoes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mesa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnFecharComanda = new System.Windows.Forms.Button();
            this.btnAlterarComanda = new System.Windows.Forms.Button();
            this.btnGerenciarPedidos = new System.Windows.Forms.Button();
            this.btnabrirComanda = new System.Windows.Forms.Button();
            this.lblAcao = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvComandas)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Location = new System.Drawing.Point(15, 59);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(848, 122);
            this.panel1.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tbBusca);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.cbFiltrosAtivados);
            this.groupBox2.Controls.Add(this.btnBuscar);
            this.groupBox2.Location = new System.Drawing.Point(9, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(829, 116);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Buscar";
            // 
            // tbBusca
            // 
            this.tbBusca.Location = new System.Drawing.Point(424, 50);
            this.tbBusca.Multiline = true;
            this.tbBusca.Name = "tbBusca";
            this.tbBusca.Size = new System.Drawing.Size(290, 22);
            this.tbBusca.TabIndex = 7;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cbGarcom);
            this.groupBox3.Controls.Add(this.lblgarocm);
            this.groupBox3.Controls.Add(this.cbMesa);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Location = new System.Drawing.Point(6, 19);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(402, 69);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Filtros";
            // 
            // cbGarcom
            // 
            this.cbGarcom.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbGarcom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbGarcom.FormattingEnabled = true;
            this.cbGarcom.Location = new System.Drawing.Point(6, 32);
            this.cbGarcom.Name = "cbGarcom";
            this.cbGarcom.Size = new System.Drawing.Size(198, 21);
            this.cbGarcom.TabIndex = 2;
            // 
            // lblgarocm
            // 
            this.lblgarocm.AutoSize = true;
            this.lblgarocm.Location = new System.Drawing.Point(6, 17);
            this.lblgarocm.Name = "lblgarocm";
            this.lblgarocm.Size = new System.Drawing.Size(44, 13);
            this.lblgarocm.TabIndex = 3;
            this.lblgarocm.Text = "Garçom";
            // 
            // cbMesa
            // 
            this.cbMesa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbMesa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMesa.FormattingEnabled = true;
            this.cbMesa.Location = new System.Drawing.Point(254, 32);
            this.cbMesa.Name = "cbMesa";
            this.cbMesa.Size = new System.Drawing.Size(122, 21);
            this.cbMesa.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(251, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mesa";
            // 
            // cbFiltrosAtivados
            // 
            this.cbFiltrosAtivados.AutoSize = true;
            this.cbFiltrosAtivados.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbFiltrosAtivados.Location = new System.Drawing.Point(6, 93);
            this.cbFiltrosAtivados.Name = "cbFiltrosAtivados";
            this.cbFiltrosAtivados.Size = new System.Drawing.Size(88, 17);
            this.cbFiltrosAtivados.TabIndex = 5;
            this.cbFiltrosAtivados.Text = "Aplicar Filtros";
            this.cbFiltrosAtivados.UseVisualStyleBackColor = true;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscar.Image = global::TBM.Properties.Resources.search;
            this.btnBuscar.Location = new System.Drawing.Point(730, 32);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(70, 56);
            this.btnBuscar.TabIndex = 4;
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvComandas);
            this.groupBox1.Location = new System.Drawing.Point(6, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(835, 250);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Comandas em Aberto";
            // 
            // dgvComandas
            // 
            this.dgvComandas.AllowUserToAddRows = false;
            this.dgvComandas.BackgroundColor = System.Drawing.Color.White;
            this.dgvComandas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvComandas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.com_id,
            this.com_data_abertura,
            this.com_valor_total,
            this.com_apelido,
            this.funcionario,
            this.com_observacoes,
            this.cliente,
            this.Mesa});
            this.dgvComandas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgvComandas.Location = new System.Drawing.Point(6, 19);
            this.dgvComandas.Name = "dgvComandas";
            this.dgvComandas.ReadOnly = true;
            this.dgvComandas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvComandas.Size = new System.Drawing.Size(818, 226);
            this.dgvComandas.TabIndex = 0;
            // 
            // com_id
            // 
            this.com_id.DataPropertyName = "com_id";
            this.com_id.HeaderText = "Número da comanda";
            this.com_id.Name = "com_id";
            this.com_id.ReadOnly = true;
            this.com_id.Width = 150;
            // 
            // com_data_abertura
            // 
            this.com_data_abertura.DataPropertyName = "Com_data_abertura";
            this.com_data_abertura.HeaderText = "Data de abertura";
            this.com_data_abertura.Name = "com_data_abertura";
            this.com_data_abertura.ReadOnly = true;
            this.com_data_abertura.Width = 150;
            // 
            // com_valor_total
            // 
            this.com_valor_total.DataPropertyName = "com_valor_total";
            this.com_valor_total.HeaderText = "Valor";
            this.com_valor_total.Name = "com_valor_total";
            this.com_valor_total.ReadOnly = true;
            this.com_valor_total.Width = 80;
            // 
            // com_apelido
            // 
            this.com_apelido.DataPropertyName = "com_apelido";
            this.com_apelido.HeaderText = "Nome de Identificação";
            this.com_apelido.Name = "com_apelido";
            this.com_apelido.ReadOnly = true;
            this.com_apelido.Width = 150;
            // 
            // funcionario
            // 
            this.funcionario.DataPropertyName = "Funcionario";
            this.funcionario.HeaderText = "Garçom";
            this.funcionario.Name = "funcionario";
            this.funcionario.ReadOnly = true;
            this.funcionario.Width = 144;
            // 
            // com_observacoes
            // 
            this.com_observacoes.DataPropertyName = "com_observacoes";
            this.com_observacoes.HeaderText = "Observacoes";
            this.com_observacoes.Name = "com_observacoes";
            this.com_observacoes.ReadOnly = true;
            this.com_observacoes.Visible = false;
            // 
            // cliente
            // 
            this.cliente.DataPropertyName = "Cliente";
            this.cliente.HeaderText = "Cliente";
            this.cliente.Name = "cliente";
            this.cliente.ReadOnly = true;
            this.cliente.Visible = false;
            // 
            // Mesa
            // 
            this.Mesa.DataPropertyName = "Mesa";
            this.Mesa.HeaderText = "Mesa";
            this.Mesa.Name = "Mesa";
            this.Mesa.ReadOnly = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Location = new System.Drawing.Point(18, 187);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(848, 258);
            this.panel2.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnFecharComanda);
            this.panel3.Controls.Add(this.btnAlterarComanda);
            this.panel3.Controls.Add(this.btnGerenciarPedidos);
            this.panel3.Controls.Add(this.btnabrirComanda);
            this.panel3.Location = new System.Drawing.Point(18, 453);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(848, 44);
            this.panel3.TabIndex = 3;
            // 
            // btnFecharComanda
            // 
            this.btnFecharComanda.Location = new System.Drawing.Point(354, 3);
            this.btnFecharComanda.Name = "btnFecharComanda";
            this.btnFecharComanda.Size = new System.Drawing.Size(109, 36);
            this.btnFecharComanda.TabIndex = 3;
            this.btnFecharComanda.Text = "Fechar Comanda";
            this.btnFecharComanda.UseVisualStyleBackColor = true;
            // 
            // btnAlterarComanda
            // 
            this.btnAlterarComanda.Location = new System.Drawing.Point(124, 3);
            this.btnAlterarComanda.Name = "btnAlterarComanda";
            this.btnAlterarComanda.Size = new System.Drawing.Size(109, 36);
            this.btnAlterarComanda.TabIndex = 2;
            this.btnAlterarComanda.Text = "Alterar Comanda";
            this.btnAlterarComanda.UseVisualStyleBackColor = true;
            this.btnAlterarComanda.Click += new System.EventHandler(this.btnAlterarComanda_Click);
            // 
            // btnGerenciarPedidos
            // 
            this.btnGerenciarPedidos.Location = new System.Drawing.Point(239, 3);
            this.btnGerenciarPedidos.Name = "btnGerenciarPedidos";
            this.btnGerenciarPedidos.Size = new System.Drawing.Size(109, 36);
            this.btnGerenciarPedidos.TabIndex = 1;
            this.btnGerenciarPedidos.Text = "Gerenciar Pedidos";
            this.btnGerenciarPedidos.UseVisualStyleBackColor = true;
            this.btnGerenciarPedidos.Click += new System.EventHandler(this.btnGerenciarPedidos_Click);
            // 
            // btnabrirComanda
            // 
            this.btnabrirComanda.Location = new System.Drawing.Point(9, 3);
            this.btnabrirComanda.Name = "btnabrirComanda";
            this.btnabrirComanda.Size = new System.Drawing.Size(109, 36);
            this.btnabrirComanda.TabIndex = 0;
            this.btnabrirComanda.Text = "Abrir Comanda";
            this.btnabrirComanda.UseVisualStyleBackColor = true;
            this.btnabrirComanda.Click += new System.EventHandler(this.btnabrirComanda_Click);
            // 
            // lblAcao
            // 
            this.lblAcao.BackColor = System.Drawing.Color.IndianRed;
            this.lblAcao.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAcao.ForeColor = System.Drawing.Color.White;
            this.lblAcao.Location = new System.Drawing.Point(16, 9);
            this.lblAcao.Name = "lblAcao";
            this.lblAcao.Size = new System.Drawing.Size(847, 47);
            this.lblAcao.TabIndex = 4;
            this.lblAcao.Text = "Gerenciar Comandas";
            this.lblAcao.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(15, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(47, 47);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // FrmGerenciarComandas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(872, 509);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblAcao);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FrmGerenciarComandas";
            this.Text = "Gerenciamento de Comandas";
            this.Load += new System.EventHandler(this.FrmGerenciarComandas_Load);
            this.panel1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvComandas)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbMesa;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvComandas;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnFecharComanda;
        private System.Windows.Forms.Button btnAlterarComanda;
        private System.Windows.Forms.Button btnGerenciarPedidos;
        private System.Windows.Forms.Button btnabrirComanda;
        private System.Windows.Forms.Label lblAcao;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblgarocm;
        private System.Windows.Forms.ComboBox cbGarcom;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.DataGridViewTextBoxColumn com_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn com_data_abertura;
        private System.Windows.Forms.DataGridViewTextBoxColumn com_valor_total;
        private System.Windows.Forms.DataGridViewTextBoxColumn com_apelido;
        private System.Windows.Forms.DataGridViewTextBoxColumn funcionario;
        private System.Windows.Forms.DataGridViewTextBoxColumn com_observacoes;
        private System.Windows.Forms.DataGridViewTextBoxColumn cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mesa;
        private System.Windows.Forms.CheckBox cbFiltrosAtivados;
        private System.Windows.Forms.TextBox tbBusca;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}