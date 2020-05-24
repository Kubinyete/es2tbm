namespace TBM.View
{
    partial class frmFecharComanda
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
            this.gbPagamentos = new System.Windows.Forms.GroupBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.btnRemover = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.dgvPagamentos = new System.Windows.Forms.DataGridView();
            this.gbPedidos = new System.Windows.Forms.GroupBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblDadosTotal = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dgvPedidos = new System.Windows.Forms.DataGridView();
            this.gbParametros = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpVencimento = new System.Windows.Forms.DateTimePicker();
            this.cbMesa = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.btnSelecionarCliente = new System.Windows.Forms.Button();
            this.cbCliente = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbGarcom = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbApelido = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbComanda = new System.Windows.Forms.TextBox();
            this.pbIcone = new System.Windows.Forms.PictureBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnAction = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.gbPagamento = new System.Windows.Forms.GroupBox();
            this.upValor = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.cbForma = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.con_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.con_valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.con_forma_recebimento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.con_data_vencimento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.con_data_recebimento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comanda_com_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemcardapio_itc_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pedido_ped_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ipe_quantidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ipc_valor_unitario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ipe_valor_subtotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.gbPagamentos.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPagamentos)).BeginInit();
            this.gbPedidos.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedidos)).BeginInit();
            this.gbParametros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbIcone)).BeginInit();
            this.panel2.SuspendLayout();
            this.gbPagamento.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.upValor)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.gbPagamentos);
            this.panel1.Controls.Add(this.gbPedidos);
            this.panel1.Controls.Add(this.gbParametros);
            this.panel1.Controls.Add(this.pbIcone);
            this.panel1.Controls.Add(this.lblTitulo);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(760, 619);
            this.panel1.TabIndex = 6;
            // 
            // gbPagamentos
            // 
            this.gbPagamentos.Controls.Add(this.panel5);
            this.gbPagamentos.Controls.Add(this.panel6);
            this.gbPagamentos.Location = new System.Drawing.Point(471, 164);
            this.gbPagamentos.Name = "gbPagamentos";
            this.gbPagamentos.Size = new System.Drawing.Size(286, 452);
            this.gbPagamentos.TabIndex = 14;
            this.gbPagamentos.TabStop = false;
            this.gbPagamentos.Text = "Pagamentos registrados";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Khaki;
            this.panel5.Controls.Add(this.btnAdicionar);
            this.panel5.Controls.Add(this.btnRemover);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5.Location = new System.Drawing.Point(3, 404);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(280, 45);
            this.panel5.TabIndex = 2;
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnAdicionar.Location = new System.Drawing.Point(130, 0);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(75, 45);
            this.btnAdicionar.TabIndex = 17;
            this.btnAdicionar.Text = "Registrar pagamento";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // btnRemover
            // 
            this.btnRemover.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnRemover.Location = new System.Drawing.Point(205, 0);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(75, 45);
            this.btnRemover.TabIndex = 16;
            this.btnRemover.Text = "Remover";
            this.btnRemover.UseVisualStyleBackColor = true;
            this.btnRemover.Click += new System.EventHandler(this.btnRemover_Click);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.gbPagamento);
            this.panel6.Controls.Add(this.dgvPagamentos);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(3, 16);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(280, 382);
            this.panel6.TabIndex = 2;
            // 
            // dgvPagamentos
            // 
            this.dgvPagamentos.AllowUserToAddRows = false;
            this.dgvPagamentos.AllowUserToDeleteRows = false;
            this.dgvPagamentos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPagamentos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPagamentos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.con_id,
            this.con_valor,
            this.con_forma_recebimento,
            this.con_data_vencimento,
            this.con_data_recebimento,
            this.comanda_com_id});
            this.dgvPagamentos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPagamentos.Location = new System.Drawing.Point(0, 0);
            this.dgvPagamentos.MultiSelect = false;
            this.dgvPagamentos.Name = "dgvPagamentos";
            this.dgvPagamentos.ReadOnly = true;
            this.dgvPagamentos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPagamentos.Size = new System.Drawing.Size(280, 382);
            this.dgvPagamentos.TabIndex = 2;
            // 
            // gbPedidos
            // 
            this.gbPedidos.Controls.Add(this.panel4);
            this.gbPedidos.Controls.Add(this.panel3);
            this.gbPedidos.Location = new System.Drawing.Point(3, 164);
            this.gbPedidos.Name = "gbPedidos";
            this.gbPedidos.Size = new System.Drawing.Size(462, 452);
            this.gbPedidos.TabIndex = 13;
            this.gbPedidos.TabStop = false;
            this.gbPedidos.Text = "Pedidos efetuados";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.lblDadosTotal);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(3, 404);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(456, 45);
            this.panel4.TabIndex = 2;
            // 
            // lblDadosTotal
            // 
            this.lblDadosTotal.BackColor = System.Drawing.Color.IndianRed;
            this.lblDadosTotal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDadosTotal.ForeColor = System.Drawing.Color.White;
            this.lblDadosTotal.Location = new System.Drawing.Point(0, 0);
            this.lblDadosTotal.Name = "lblDadosTotal";
            this.lblDadosTotal.Size = new System.Drawing.Size(456, 45);
            this.lblDadosTotal.TabIndex = 1;
            this.lblDadosTotal.Text = "Quantidade de pedidos: %qtd% - Valor total: R$ %total%";
            this.lblDadosTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dgvPedidos);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(3, 16);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(456, 382);
            this.panel3.TabIndex = 2;
            // 
            // dgvPedidos
            // 
            this.dgvPedidos.AllowUserToAddRows = false;
            this.dgvPedidos.AllowUserToDeleteRows = false;
            this.dgvPedidos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPedidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPedidos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.itemcardapio_itc_id,
            this.pedido_ped_id,
            this.ipe_quantidade,
            this.ipc_valor_unitario,
            this.ipe_valor_subtotal});
            this.dgvPedidos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPedidos.Enabled = false;
            this.dgvPedidos.Location = new System.Drawing.Point(0, 0);
            this.dgvPedidos.MultiSelect = false;
            this.dgvPedidos.Name = "dgvPedidos";
            this.dgvPedidos.ReadOnly = true;
            this.dgvPedidos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPedidos.Size = new System.Drawing.Size(456, 382);
            this.dgvPedidos.TabIndex = 2;
            // 
            // gbParametros
            // 
            this.gbParametros.Controls.Add(this.cbMesa);
            this.gbParametros.Controls.Add(this.label4);
            this.gbParametros.Controls.Add(this.checkBox1);
            this.gbParametros.Controls.Add(this.btnSelecionarCliente);
            this.gbParametros.Controls.Add(this.cbCliente);
            this.gbParametros.Controls.Add(this.label2);
            this.gbParametros.Controls.Add(this.cbGarcom);
            this.gbParametros.Controls.Add(this.label3);
            this.gbParametros.Controls.Add(this.tbApelido);
            this.gbParametros.Controls.Add(this.label9);
            this.gbParametros.Controls.Add(this.label1);
            this.gbParametros.Controls.Add(this.tbComanda);
            this.gbParametros.Location = new System.Drawing.Point(3, 56);
            this.gbParametros.Name = "gbParametros";
            this.gbParametros.Size = new System.Drawing.Size(754, 102);
            this.gbParametros.TabIndex = 12;
            this.gbParametros.TabStop = false;
            this.gbParametros.Text = "Detalhes";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 97);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 13);
            this.label5.TabIndex = 32;
            this.label5.Text = "Data de vencimento*";
            // 
            // dtpVencimento
            // 
            this.dtpVencimento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpVencimento.Location = new System.Drawing.Point(6, 113);
            this.dtpVencimento.Name = "dtpVencimento";
            this.dtpVencimento.Size = new System.Drawing.Size(268, 20);
            this.dtpVencimento.TabIndex = 31;
            // 
            // cbMesa
            // 
            this.cbMesa.Enabled = false;
            this.cbMesa.FormattingEnabled = true;
            this.cbMesa.Location = new System.Drawing.Point(9, 71);
            this.cbMesa.Name = "cbMesa";
            this.cbMesa.Size = new System.Drawing.Size(101, 21);
            this.cbMesa.TabIndex = 30;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 29;
            this.label4.Text = "Mesa";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(471, 35);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(176, 17);
            this.checkBox1.TabIndex = 28;
            this.checkBox1.Text = "Cliente não informou um registro";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // btnSelecionarCliente
            // 
            this.btnSelecionarCliente.Location = new System.Drawing.Point(673, 16);
            this.btnSelecionarCliente.Name = "btnSelecionarCliente";
            this.btnSelecionarCliente.Size = new System.Drawing.Size(75, 80);
            this.btnSelecionarCliente.TabIndex = 27;
            this.btnSelecionarCliente.Text = "Selecionar";
            this.btnSelecionarCliente.UseVisualStyleBackColor = true;
            this.btnSelecionarCliente.Click += new System.EventHandler(this.btnSelecionarCliente_Click);
            // 
            // cbCliente
            // 
            this.cbCliente.Enabled = false;
            this.cbCliente.FormattingEnabled = true;
            this.cbCliente.Location = new System.Drawing.Point(471, 71);
            this.cbCliente.Name = "cbCliente";
            this.cbCliente.Size = new System.Drawing.Size(199, 21);
            this.cbCliente.TabIndex = 26;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(468, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 25;
            this.label2.Text = "Cliente associado";
            // 
            // cbGarcom
            // 
            this.cbGarcom.Enabled = false;
            this.cbGarcom.FormattingEnabled = true;
            this.cbGarcom.Location = new System.Drawing.Point(116, 71);
            this.cbGarcom.Name = "cbGarcom";
            this.cbGarcom.Size = new System.Drawing.Size(343, 21);
            this.cbGarcom.TabIndex = 24;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(113, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 13);
            this.label3.TabIndex = 23;
            this.label3.Text = "Garçom responsável";
            // 
            // tbApelido
            // 
            this.tbApelido.Enabled = false;
            this.tbApelido.Location = new System.Drawing.Point(116, 32);
            this.tbApelido.Name = "tbApelido";
            this.tbApelido.Size = new System.Drawing.Size(343, 20);
            this.tbApelido.TabIndex = 20;
            this.tbApelido.Text = "Nenhum apelido específicado";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(113, 16);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(42, 13);
            this.label9.TabIndex = 19;
            this.label9.Text = "Apelido";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Comanda";
            // 
            // tbComanda
            // 
            this.tbComanda.Enabled = false;
            this.tbComanda.Location = new System.Drawing.Point(9, 32);
            this.tbComanda.Name = "tbComanda";
            this.tbComanda.Size = new System.Drawing.Size(101, 20);
            this.tbComanda.TabIndex = 0;
            // 
            // pbIcone
            // 
            this.pbIcone.BackColor = System.Drawing.Color.Transparent;
            this.pbIcone.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbIcone.Image = global::TBM.Properties.Resources.comanda_icon;
            this.pbIcone.Location = new System.Drawing.Point(0, 0);
            this.pbIcone.Name = "pbIcone";
            this.pbIcone.Size = new System.Drawing.Size(50, 50);
            this.pbIcone.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbIcone.TabIndex = 9;
            this.pbIcone.TabStop = false;
            // 
            // lblTitulo
            // 
            this.lblTitulo.BackColor = System.Drawing.Color.IndianRed;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(0, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(760, 50);
            this.lblTitulo.TabIndex = 2;
            this.lblTitulo.Text = "Fechar comanda em aberto";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnAction);
            this.panel2.Controls.Add(this.btnCancelar);
            this.panel2.Location = new System.Drawing.Point(12, 637);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(760, 80);
            this.panel2.TabIndex = 7;
            // 
            // btnAction
            // 
            this.btnAction.Location = new System.Drawing.Point(601, 3);
            this.btnAction.Name = "btnAction";
            this.btnAction.Size = new System.Drawing.Size(75, 74);
            this.btnAction.TabIndex = 3;
            this.btnAction.Text = "Fechar";
            this.btnAction.UseVisualStyleBackColor = true;
            this.btnAction.Click += new System.EventHandler(this.btnAction_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(682, 3);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 74);
            this.btnCancelar.TabIndex = 2;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // gbPagamento
            // 
            this.gbPagamento.BackColor = System.Drawing.Color.Khaki;
            this.gbPagamento.Controls.Add(this.label5);
            this.gbPagamento.Controls.Add(this.dtpVencimento);
            this.gbPagamento.Controls.Add(this.cbForma);
            this.gbPagamento.Controls.Add(this.label7);
            this.gbPagamento.Controls.Add(this.upValor);
            this.gbPagamento.Controls.Add(this.label6);
            this.gbPagamento.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gbPagamento.Location = new System.Drawing.Point(0, 230);
            this.gbPagamento.Name = "gbPagamento";
            this.gbPagamento.Size = new System.Drawing.Size(280, 152);
            this.gbPagamento.TabIndex = 3;
            this.gbPagamento.TabStop = false;
            this.gbPagamento.Text = "Registrar pagamento";
            // 
            // upValor
            // 
            this.upValor.DecimalPlaces = 2;
            this.upValor.Location = new System.Drawing.Point(6, 32);
            this.upValor.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.upValor.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.upValor.Name = "upValor";
            this.upValor.Size = new System.Drawing.Size(268, 20);
            this.upValor.TabIndex = 26;
            this.upValor.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.upValor.Value = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 13);
            this.label6.TabIndex = 25;
            this.label6.Text = "Valor pago*";
            // 
            // cbForma
            // 
            this.cbForma.FormattingEnabled = true;
            this.cbForma.Location = new System.Drawing.Point(6, 73);
            this.cbForma.Name = "cbForma";
            this.cbForma.Size = new System.Drawing.Size(268, 21);
            this.cbForma.TabIndex = 28;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 57);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(111, 13);
            this.label7.TabIndex = 27;
            this.label7.Text = "Forma de pagamento*";
            // 
            // con_id
            // 
            this.con_id.DataPropertyName = "Id";
            this.con_id.HeaderText = "Id";
            this.con_id.Name = "con_id";
            this.con_id.ReadOnly = true;
            this.con_id.Visible = false;
            // 
            // con_valor
            // 
            this.con_valor.DataPropertyName = "Valor";
            this.con_valor.HeaderText = "Valor";
            this.con_valor.Name = "con_valor";
            this.con_valor.ReadOnly = true;
            // 
            // con_forma_recebimento
            // 
            this.con_forma_recebimento.DataPropertyName = "Forma_recebimento";
            this.con_forma_recebimento.HeaderText = "Forma de Recebimento";
            this.con_forma_recebimento.Name = "con_forma_recebimento";
            this.con_forma_recebimento.ReadOnly = true;
            // 
            // con_data_vencimento
            // 
            this.con_data_vencimento.DataPropertyName = "Data_vencimento";
            this.con_data_vencimento.HeaderText = "Data de Vencimento";
            this.con_data_vencimento.Name = "con_data_vencimento";
            this.con_data_vencimento.ReadOnly = true;
            // 
            // con_data_recebimento
            // 
            this.con_data_recebimento.DataPropertyName = "Data_recebimento";
            this.con_data_recebimento.HeaderText = "Data de Recebimento";
            this.con_data_recebimento.Name = "con_data_recebimento";
            this.con_data_recebimento.ReadOnly = true;
            this.con_data_recebimento.Visible = false;
            // 
            // comanda_com_id
            // 
            this.comanda_com_id.DataPropertyName = "Comanda";
            this.comanda_com_id.HeaderText = "Comanda";
            this.comanda_com_id.Name = "comanda_com_id";
            this.comanda_com_id.ReadOnly = true;
            this.comanda_com_id.Visible = false;
            // 
            // itemcardapio_itc_id
            // 
            this.itemcardapio_itc_id.DataPropertyName = "ItemCardapio";
            this.itemcardapio_itc_id.HeaderText = "Item";
            this.itemcardapio_itc_id.Name = "itemcardapio_itc_id";
            this.itemcardapio_itc_id.ReadOnly = true;
            // 
            // pedido_ped_id
            // 
            this.pedido_ped_id.DataPropertyName = "Pedido";
            this.pedido_ped_id.HeaderText = "Pedido";
            this.pedido_ped_id.Name = "pedido_ped_id";
            this.pedido_ped_id.ReadOnly = true;
            this.pedido_ped_id.Visible = false;
            // 
            // ipe_quantidade
            // 
            this.ipe_quantidade.DataPropertyName = "Quantidade";
            this.ipe_quantidade.HeaderText = "Quantidade";
            this.ipe_quantidade.Name = "ipe_quantidade";
            this.ipe_quantidade.ReadOnly = true;
            // 
            // ipc_valor_unitario
            // 
            this.ipc_valor_unitario.DataPropertyName = "Valor_unitario";
            this.ipc_valor_unitario.HeaderText = "Valor unitário";
            this.ipc_valor_unitario.Name = "ipc_valor_unitario";
            this.ipc_valor_unitario.ReadOnly = true;
            // 
            // ipe_valor_subtotal
            // 
            this.ipe_valor_subtotal.DataPropertyName = "Valor_subtotal";
            this.ipe_valor_subtotal.HeaderText = "Subtotal";
            this.ipe_valor_subtotal.Name = "ipe_valor_subtotal";
            this.ipe_valor_subtotal.ReadOnly = true;
            // 
            // frmFecharComanda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 729);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.MaximumSize = new System.Drawing.Size(800, 768);
            this.MinimumSize = new System.Drawing.Size(800, 768);
            this.Name = "frmFecharComanda";
            this.Text = "Fechar comanda em aberto";
            this.Load += new System.EventHandler(this.frmFecharComanda_Load);
            this.panel1.ResumeLayout(false);
            this.gbPagamentos.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPagamentos)).EndInit();
            this.gbPedidos.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedidos)).EndInit();
            this.gbParametros.ResumeLayout(false);
            this.gbParametros.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbIcone)).EndInit();
            this.panel2.ResumeLayout(false);
            this.gbPagamento.ResumeLayout(false);
            this.gbPagamento.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.upValor)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox gbParametros;
        private System.Windows.Forms.ComboBox cbGarcom;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbApelido;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbComanda;
        private System.Windows.Forms.PictureBox pbIcone;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnAction;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.GroupBox gbPedidos;
        private System.Windows.Forms.Label lblDadosTotal;
        private System.Windows.Forms.GroupBox gbPagamentos;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.Button btnRemover;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.DataGridView dgvPagamentos;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dgvPedidos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button btnSelecionarCliente;
        private System.Windows.Forms.ComboBox cbCliente;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbMesa;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpVencimento;
        private System.Windows.Forms.GroupBox gbPagamento;
        private System.Windows.Forms.NumericUpDown upValor;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbForma;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridViewTextBoxColumn con_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn con_valor;
        private System.Windows.Forms.DataGridViewTextBoxColumn con_forma_recebimento;
        private System.Windows.Forms.DataGridViewTextBoxColumn con_data_vencimento;
        private System.Windows.Forms.DataGridViewTextBoxColumn con_data_recebimento;
        private System.Windows.Forms.DataGridViewTextBoxColumn comanda_com_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemcardapio_itc_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn pedido_ped_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn ipe_quantidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn ipc_valor_unitario;
        private System.Windows.Forms.DataGridViewTextBoxColumn ipe_valor_subtotal;
    }
}