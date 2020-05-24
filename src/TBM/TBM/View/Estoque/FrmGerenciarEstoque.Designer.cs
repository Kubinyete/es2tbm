namespace TBM.View.Estoque
{
    partial class FrmGerenciarEstoque
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGerenciarEstoque));
            this.lblTitulo = new System.Windows.Forms.Label();
            this.tbProdutosEstoque = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnEfetuarBaixa = new System.Windows.Forms.Button();
            this.btnRegistrarCompra = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cbMostrarProdutosSemEstoque = new System.Windows.Forms.CheckBox();
            this.dgvProdutosEstoque = new System.Windows.Forms.DataGridView();
            this.prod_nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prod_marca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prod_categoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qtde_minima = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qtde_estq = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pro_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Unidademedida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.tbPesquisa = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbFiltrarMarca = new System.Windows.Forms.CheckBox();
            this.cbMarca = new System.Windows.Forms.ComboBox();
            this.cbFiltrarCategoria = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbCategoria = new System.Windows.Forms.ComboBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnCancelarBaixa = new System.Windows.Forms.Button();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.dgvBaixasEfetuadas = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Reg_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Reg_descricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Reg_quantidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnPesquisarBaixa = new System.Windows.Forms.Button();
            this.tbPesquisaBaixa = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.cbFiltrarDataBaixa = new System.Windows.Forms.CheckBox();
            this.cbFiltrarMarcaBaixa = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dtpBaixaDataFinal = new System.Windows.Forms.DateTimePicker();
            this.cbFiltrarCategoriaBaixa = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpBaixaDataInicial = new System.Windows.Forms.DateTimePicker();
            this.cbMarcaBaixaEfetuada = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbCategoriaBaixasEfetuadas = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tbProdutosEstoque.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutosEstoque)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBaixasEfetuadas)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.BackColor = System.Drawing.Color.IndianRed;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.lblTitulo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblTitulo.Location = new System.Drawing.Point(12, 12);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(856, 50);
            this.lblTitulo.TabIndex = 2;
            this.lblTitulo.Text = "Gerenciamento de Estoque";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbProdutosEstoque
            // 
            this.tbProdutosEstoque.Controls.Add(this.tabPage1);
            this.tbProdutosEstoque.Controls.Add(this.tabPage2);
            this.tbProdutosEstoque.Location = new System.Drawing.Point(12, 66);
            this.tbProdutosEstoque.Name = "tbProdutosEstoque";
            this.tbProdutosEstoque.SelectedIndex = 0;
            this.tbProdutosEstoque.Size = new System.Drawing.Size(865, 542);
            this.tbProdutosEstoque.TabIndex = 19;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage1.Controls.Add(this.btnEfetuarBaixa);
            this.tabPage1.Controls.Add(this.btnRegistrarCompra);
            this.tabPage1.Controls.Add(this.groupBox3);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(857, 516);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Estoque";
            // 
            // btnEfetuarBaixa
            // 
            this.btnEfetuarBaixa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEfetuarBaixa.Location = new System.Drawing.Point(609, 458);
            this.btnEfetuarBaixa.Name = "btnEfetuarBaixa";
            this.btnEfetuarBaixa.Size = new System.Drawing.Size(105, 52);
            this.btnEfetuarBaixa.TabIndex = 3;
            this.btnEfetuarBaixa.Text = "Efetuar Baixa";
            this.btnEfetuarBaixa.UseVisualStyleBackColor = true;
            this.btnEfetuarBaixa.Click += new System.EventHandler(this.btnEfetuarBaixa_Click);
            // 
            // btnRegistrarCompra
            // 
            this.btnRegistrarCompra.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegistrarCompra.Location = new System.Drawing.Point(720, 458);
            this.btnRegistrarCompra.Name = "btnRegistrarCompra";
            this.btnRegistrarCompra.Size = new System.Drawing.Size(105, 52);
            this.btnRegistrarCompra.TabIndex = 2;
            this.btnRegistrarCompra.Text = "Registrar Compra";
            this.btnRegistrarCompra.UseVisualStyleBackColor = true;
            this.btnRegistrarCompra.Click += new System.EventHandler(this.btnRegistrarCompra_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cbMostrarProdutosSemEstoque);
            this.groupBox3.Controls.Add(this.dgvProdutosEstoque);
            this.groupBox3.Location = new System.Drawing.Point(7, 147);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(844, 305);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Produtos em Estoque";
            // 
            // cbMostrarProdutosSemEstoque
            // 
            this.cbMostrarProdutosSemEstoque.AutoSize = true;
            this.cbMostrarProdutosSemEstoque.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbMostrarProdutosSemEstoque.Location = new System.Drawing.Point(7, 20);
            this.cbMostrarProdutosSemEstoque.Name = "cbMostrarProdutosSemEstoque";
            this.cbMostrarProdutosSemEstoque.Size = new System.Drawing.Size(172, 17);
            this.cbMostrarProdutosSemEstoque.TabIndex = 1;
            this.cbMostrarProdutosSemEstoque.Text = "Mostrar Produtos Sem Estoque";
            this.cbMostrarProdutosSemEstoque.UseVisualStyleBackColor = true;
            this.cbMostrarProdutosSemEstoque.CheckedChanged += new System.EventHandler(this.cbMostrarProdutosSemEstoque_CheckedChanged);
            // 
            // dgvProdutosEstoque
            // 
            this.dgvProdutosEstoque.AllowUserToAddRows = false;
            this.dgvProdutosEstoque.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvProdutosEstoque.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProdutosEstoque.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.prod_nome,
            this.prod_marca,
            this.prod_categoria,
            this.qtde_minima,
            this.qtde_estq,
            this.Pro_id,
            this.Unidademedida});
            this.dgvProdutosEstoque.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgvProdutosEstoque.Location = new System.Drawing.Point(7, 43);
            this.dgvProdutosEstoque.Name = "dgvProdutosEstoque";
            this.dgvProdutosEstoque.ReadOnly = true;
            this.dgvProdutosEstoque.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProdutosEstoque.Size = new System.Drawing.Size(811, 245);
            this.dgvProdutosEstoque.TabIndex = 0;
            // 
            // prod_nome
            // 
            this.prod_nome.DataPropertyName = "Pro_nome";
            this.prod_nome.HeaderText = "Nome";
            this.prod_nome.Name = "prod_nome";
            this.prod_nome.ReadOnly = true;
            this.prod_nome.Width = 200;
            // 
            // prod_marca
            // 
            this.prod_marca.DataPropertyName = "Marca";
            this.prod_marca.HeaderText = "Marca";
            this.prod_marca.Name = "prod_marca";
            this.prod_marca.ReadOnly = true;
            this.prod_marca.Width = 120;
            // 
            // prod_categoria
            // 
            this.prod_categoria.DataPropertyName = "Categoriaproduto";
            this.prod_categoria.HeaderText = "Categoria";
            this.prod_categoria.Name = "prod_categoria";
            this.prod_categoria.ReadOnly = true;
            this.prod_categoria.Width = 160;
            // 
            // qtde_minima
            // 
            this.qtde_minima.DataPropertyName = "Pro_quantidade_minima";
            this.qtde_minima.HeaderText = "Quantidade Mínima";
            this.qtde_minima.Name = "qtde_minima";
            this.qtde_minima.ReadOnly = true;
            this.qtde_minima.Width = 140;
            // 
            // qtde_estq
            // 
            this.qtde_estq.DataPropertyName = "Pro_quantidade";
            this.qtde_estq.HeaderText = "Quantidade em Estoque";
            this.qtde_estq.Name = "qtde_estq";
            this.qtde_estq.ReadOnly = true;
            this.qtde_estq.Width = 147;
            // 
            // Pro_id
            // 
            this.Pro_id.DataPropertyName = "Pro_id";
            this.Pro_id.HeaderText = "Pro_id";
            this.Pro_id.Name = "Pro_id";
            this.Pro_id.ReadOnly = true;
            this.Pro_id.Visible = false;
            // 
            // Unidademedida
            // 
            this.Unidademedida.DataPropertyName = "Unidademedida";
            this.Unidademedida.HeaderText = "Unidademedida";
            this.Unidademedida.Name = "Unidademedida";
            this.Unidademedida.ReadOnly = true;
            this.Unidademedida.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnPesquisar);
            this.groupBox1.Controls.Add(this.tbPesquisa);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Location = new System.Drawing.Point(6, 7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(845, 133);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pesquisar";
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPesquisar.Image = global::TBM.Properties.Resources.search;
            this.btnPesquisar.Location = new System.Drawing.Point(744, 23);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(75, 78);
            this.btnPesquisar.TabIndex = 4;
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // tbPesquisa
            // 
            this.tbPesquisa.Location = new System.Drawing.Point(429, 57);
            this.tbPesquisa.Name = "tbPesquisa";
            this.tbPesquisa.Size = new System.Drawing.Size(294, 20);
            this.tbPesquisa.TabIndex = 3;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbFiltrarMarca);
            this.groupBox2.Controls.Add(this.cbMarca);
            this.groupBox2.Controls.Add(this.cbFiltrarCategoria);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.cbCategoria);
            this.groupBox2.Location = new System.Drawing.Point(6, 19);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(398, 105);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Filtros";
            // 
            // cbFiltrarMarca
            // 
            this.cbFiltrarMarca.AutoSize = true;
            this.cbFiltrarMarca.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbFiltrarMarca.Location = new System.Drawing.Point(235, 65);
            this.cbFiltrarMarca.Name = "cbFiltrarMarca";
            this.cbFiltrarMarca.Size = new System.Drawing.Size(84, 17);
            this.cbFiltrarMarca.TabIndex = 6;
            this.cbFiltrarMarca.Text = "Filtrar Marca";
            this.cbFiltrarMarca.UseVisualStyleBackColor = true;
            // 
            // cbMarca
            // 
            this.cbMarca.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbMarca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMarca.FormattingEnabled = true;
            this.cbMarca.Location = new System.Drawing.Point(235, 38);
            this.cbMarca.Name = "cbMarca";
            this.cbMarca.Size = new System.Drawing.Size(141, 21);
            this.cbMarca.TabIndex = 3;
            // 
            // cbFiltrarCategoria
            // 
            this.cbFiltrarCategoria.AutoSize = true;
            this.cbFiltrarCategoria.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbFiltrarCategoria.Location = new System.Drawing.Point(19, 65);
            this.cbFiltrarCategoria.Name = "cbFiltrarCategoria";
            this.cbFiltrarCategoria.Size = new System.Drawing.Size(99, 17);
            this.cbFiltrarCategoria.TabIndex = 5;
            this.cbFiltrarCategoria.Text = "Filtrar Categoria";
            this.cbFiltrarCategoria.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(232, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Marca";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Categoria";
            // 
            // cbCategoria
            // 
            this.cbCategoria.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCategoria.FormattingEnabled = true;
            this.cbCategoria.Location = new System.Drawing.Point(19, 38);
            this.cbCategoria.Name = "cbCategoria";
            this.cbCategoria.Size = new System.Drawing.Size(168, 21);
            this.cbCategoria.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage2.Controls.Add(this.btnCancelarBaixa);
            this.tabPage2.Controls.Add(this.groupBox6);
            this.tabPage2.Controls.Add(this.groupBox4);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(857, 516);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Baixas Efetuadas";
            // 
            // btnCancelarBaixa
            // 
            this.btnCancelarBaixa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelarBaixa.Location = new System.Drawing.Point(724, 458);
            this.btnCancelarBaixa.Name = "btnCancelarBaixa";
            this.btnCancelarBaixa.Size = new System.Drawing.Size(105, 52);
            this.btnCancelarBaixa.TabIndex = 3;
            this.btnCancelarBaixa.Text = "Cancelar Baixa";
            this.btnCancelarBaixa.UseVisualStyleBackColor = true;
            this.btnCancelarBaixa.Click += new System.EventHandler(this.btnCancelarBaixa_Click);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.dgvBaixasEfetuadas);
            this.groupBox6.Location = new System.Drawing.Point(7, 192);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(844, 260);
            this.groupBox6.TabIndex = 2;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Baixas Efetuadas";
            // 
            // dgvBaixasEfetuadas
            // 
            this.dgvBaixasEfetuadas.AllowUserToAddRows = false;
            this.dgvBaixasEfetuadas.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvBaixasEfetuadas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBaixasEfetuadas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn4,
            this.Reg_id,
            this.Reg_descricao,
            this.Reg_quantidade});
            this.dgvBaixasEfetuadas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgvBaixasEfetuadas.GridColor = System.Drawing.SystemColors.Control;
            this.dgvBaixasEfetuadas.Location = new System.Drawing.Point(7, 20);
            this.dgvBaixasEfetuadas.Name = "dgvBaixasEfetuadas";
            this.dgvBaixasEfetuadas.ReadOnly = true;
            this.dgvBaixasEfetuadas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBaixasEfetuadas.Size = new System.Drawing.Size(815, 234);
            this.dgvBaixasEfetuadas.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Produto";
            this.dataGridViewTextBoxColumn1.HeaderText = "Nome";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 200;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "ProdutoMarca";
            this.dataGridViewTextBoxColumn2.HeaderText = "Marca";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 120;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "ProdutoCategoria";
            this.dataGridViewTextBoxColumn3.HeaderText = "Categoria";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 160;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Data_efetuada";
            this.dataGridViewTextBoxColumn5.HeaderText = "Data";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 140;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "QuantidadeFormatada";
            this.dataGridViewTextBoxColumn4.HeaderText = "Quantidade da Baixa";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 150;
            // 
            // Reg_id
            // 
            this.Reg_id.DataPropertyName = "Reg_id";
            this.Reg_id.HeaderText = "Reg_id";
            this.Reg_id.Name = "Reg_id";
            this.Reg_id.ReadOnly = true;
            this.Reg_id.Visible = false;
            // 
            // Reg_descricao
            // 
            this.Reg_descricao.DataPropertyName = "Reg_descricao";
            this.Reg_descricao.HeaderText = "Reg_descricao";
            this.Reg_descricao.Name = "Reg_descricao";
            this.Reg_descricao.ReadOnly = true;
            this.Reg_descricao.Visible = false;
            // 
            // Reg_quantidade
            // 
            this.Reg_quantidade.DataPropertyName = "Reg_quantidade";
            this.Reg_quantidade.HeaderText = "reg_quantidade";
            this.Reg_quantidade.Name = "Reg_quantidade";
            this.Reg_quantidade.ReadOnly = true;
            this.Reg_quantidade.Visible = false;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnPesquisarBaixa);
            this.groupBox4.Controls.Add(this.tbPesquisaBaixa);
            this.groupBox4.Controls.Add(this.groupBox5);
            this.groupBox4.Location = new System.Drawing.Point(6, 6);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(845, 180);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Pesquisar";
            // 
            // btnPesquisarBaixa
            // 
            this.btnPesquisarBaixa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPesquisarBaixa.Image = global::TBM.Properties.Resources.search;
            this.btnPesquisarBaixa.Location = new System.Drawing.Point(748, 51);
            this.btnPesquisarBaixa.Name = "btnPesquisarBaixa";
            this.btnPesquisarBaixa.Size = new System.Drawing.Size(75, 78);
            this.btnPesquisarBaixa.TabIndex = 4;
            this.btnPesquisarBaixa.UseVisualStyleBackColor = true;
            this.btnPesquisarBaixa.Click += new System.EventHandler(this.btnPesquisarBaixa_Click);
            // 
            // tbPesquisaBaixa
            // 
            this.tbPesquisaBaixa.Location = new System.Drawing.Point(422, 81);
            this.tbPesquisaBaixa.Name = "tbPesquisaBaixa";
            this.tbPesquisaBaixa.Size = new System.Drawing.Size(294, 20);
            this.tbPesquisaBaixa.TabIndex = 3;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.cbFiltrarDataBaixa);
            this.groupBox5.Controls.Add(this.cbFiltrarMarcaBaixa);
            this.groupBox5.Controls.Add(this.label6);
            this.groupBox5.Controls.Add(this.dtpBaixaDataFinal);
            this.groupBox5.Controls.Add(this.cbFiltrarCategoriaBaixa);
            this.groupBox5.Controls.Add(this.label5);
            this.groupBox5.Controls.Add(this.dtpBaixaDataInicial);
            this.groupBox5.Controls.Add(this.cbMarcaBaixaEfetuada);
            this.groupBox5.Controls.Add(this.label3);
            this.groupBox5.Controls.Add(this.label4);
            this.groupBox5.Controls.Add(this.cbCategoriaBaixasEfetuadas);
            this.groupBox5.Location = new System.Drawing.Point(6, 19);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(410, 155);
            this.groupBox5.TabIndex = 1;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Filtros";
            // 
            // cbFiltrarDataBaixa
            // 
            this.cbFiltrarDataBaixa.AutoSize = true;
            this.cbFiltrarDataBaixa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbFiltrarDataBaixa.Location = new System.Drawing.Point(19, 132);
            this.cbFiltrarDataBaixa.Name = "cbFiltrarDataBaixa";
            this.cbFiltrarDataBaixa.Size = new System.Drawing.Size(77, 17);
            this.cbFiltrarDataBaixa.TabIndex = 9;
            this.cbFiltrarDataBaixa.Text = "Filtrar Data";
            this.cbFiltrarDataBaixa.UseVisualStyleBackColor = true;
            // 
            // cbFiltrarMarcaBaixa
            // 
            this.cbFiltrarMarcaBaixa.AutoSize = true;
            this.cbFiltrarMarcaBaixa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbFiltrarMarcaBaixa.Location = new System.Drawing.Point(251, 116);
            this.cbFiltrarMarcaBaixa.Name = "cbFiltrarMarcaBaixa";
            this.cbFiltrarMarcaBaixa.Size = new System.Drawing.Size(84, 17);
            this.cbFiltrarMarcaBaixa.TabIndex = 8;
            this.cbFiltrarMarcaBaixa.Text = "Filtrar Marca";
            this.cbFiltrarMarcaBaixa.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(248, 74);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Data Final";
            // 
            // dtpBaixaDataFinal
            // 
            this.dtpBaixaDataFinal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dtpBaixaDataFinal.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpBaixaDataFinal.Location = new System.Drawing.Point(251, 90);
            this.dtpBaixaDataFinal.Name = "dtpBaixaDataFinal";
            this.dtpBaixaDataFinal.Size = new System.Drawing.Size(141, 20);
            this.dtpBaixaDataFinal.TabIndex = 6;
            // 
            // cbFiltrarCategoriaBaixa
            // 
            this.cbFiltrarCategoriaBaixa.AutoSize = true;
            this.cbFiltrarCategoriaBaixa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbFiltrarCategoriaBaixa.Location = new System.Drawing.Point(19, 116);
            this.cbFiltrarCategoriaBaixa.Name = "cbFiltrarCategoriaBaixa";
            this.cbFiltrarCategoriaBaixa.Size = new System.Drawing.Size(99, 17);
            this.cbFiltrarCategoriaBaixa.TabIndex = 2;
            this.cbFiltrarCategoriaBaixa.Text = "Filtrar Categoria";
            this.cbFiltrarCategoriaBaixa.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 74);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Data Inicial";
            // 
            // dtpBaixaDataInicial
            // 
            this.dtpBaixaDataInicial.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dtpBaixaDataInicial.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpBaixaDataInicial.Location = new System.Drawing.Point(19, 90);
            this.dtpBaixaDataInicial.Name = "dtpBaixaDataInicial";
            this.dtpBaixaDataInicial.Size = new System.Drawing.Size(141, 20);
            this.dtpBaixaDataInicial.TabIndex = 4;
            // 
            // cbMarcaBaixaEfetuada
            // 
            this.cbMarcaBaixaEfetuada.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbMarcaBaixaEfetuada.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMarcaBaixaEfetuada.FormattingEnabled = true;
            this.cbMarcaBaixaEfetuada.Location = new System.Drawing.Point(251, 38);
            this.cbMarcaBaixaEfetuada.Name = "cbMarcaBaixaEfetuada";
            this.cbMarcaBaixaEfetuada.Size = new System.Drawing.Size(141, 21);
            this.cbMarcaBaixaEfetuada.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(248, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Marca";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Categoria";
            // 
            // cbCategoriaBaixasEfetuadas
            // 
            this.cbCategoriaBaixasEfetuadas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbCategoriaBaixasEfetuadas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCategoriaBaixasEfetuadas.FormattingEnabled = true;
            this.cbCategoriaBaixasEfetuadas.Location = new System.Drawing.Point(19, 38);
            this.cbCategoriaBaixasEfetuadas.Name = "cbCategoriaBaixasEfetuadas";
            this.cbCategoriaBaixasEfetuadas.Size = new System.Drawing.Size(177, 21);
            this.cbCategoriaBaixasEfetuadas.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 50);
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // FrmGerenciarEstoque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(880, 620);
            this.Controls.Add(this.tbProdutosEstoque);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblTitulo);
            this.Name = "FrmGerenciarEstoque";
            this.Text = "Gerenciar Estoque";
            this.Load += new System.EventHandler(this.FrmEfetuarBaixaDeProduto_Load);
            this.tbProdutosEstoque.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutosEstoque)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBaixasEfetuadas)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TabControl tbProdutosEstoque;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dgvProdutosEstoque;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.TextBox tbPesquisa;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cbMarca;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbCategoria;
        private System.Windows.Forms.Button btnEfetuarBaixa;
        private System.Windows.Forms.Button btnRegistrarCompra;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnPesquisarBaixa;
        private System.Windows.Forms.TextBox tbPesquisaBaixa;
        private System.Windows.Forms.CheckBox cbFiltrarCategoriaBaixa;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtpBaixaDataFinal;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpBaixaDataInicial;
        private System.Windows.Forms.ComboBox cbMarcaBaixaEfetuada;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbCategoriaBaixasEfetuadas;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.DataGridView dgvBaixasEfetuadas;
        private System.Windows.Forms.Button btnCancelarBaixa;
        private System.Windows.Forms.CheckBox cbFiltrarMarca;
        private System.Windows.Forms.CheckBox cbFiltrarCategoria;
        private System.Windows.Forms.CheckBox cbFiltrarDataBaixa;
        private System.Windows.Forms.CheckBox cbFiltrarMarcaBaixa;
        private System.Windows.Forms.DataGridViewTextBoxColumn prod_nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn prod_marca;
        private System.Windows.Forms.DataGridViewTextBoxColumn prod_categoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn qtde_minima;
        private System.Windows.Forms.DataGridViewTextBoxColumn qtde_estq;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pro_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Unidademedida;
        private System.Windows.Forms.CheckBox cbMostrarProdutosSemEstoque;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Reg_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Reg_descricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn Reg_quantidade;
    }
}