namespace TBM.View.Comanda
{
    partial class frmGerenciarPedidos
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbCategoria = new System.Windows.Forms.ComboBox();
            this.btnNovoPedido = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvCardapio = new System.Windows.Forms.DataGridView();
            this.cardapio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itc_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itc_descricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itc_disponivel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoria_cardapio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.preco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Itc_preco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbOcultarPedidosCancelados = new System.Windows.Forms.CheckBox();
            this.lblValorTotal = new System.Windows.Forms.Label();
            this.btnCancelarPedido = new System.Windows.Forms.Button();
            this.dgvPedido = new System.Windows.Forms.DataGridView();
            this.lblAcao = new System.Windows.Forms.Label();
            this.Com_apelido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pedido_comanda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ped_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.data_solic = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.preco_item = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ped_valor_total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qtde = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.item_status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCardapio)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedido)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Location = new System.Drawing.Point(12, 70);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(353, 542);
            this.panel1.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbCategoria);
            this.groupBox2.Controls.Add(this.btnNovoPedido);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.dgvCardapio);
            this.groupBox2.Location = new System.Drawing.Point(3, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(347, 517);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Cardápio";
            // 
            // cbCategoria
            // 
            this.cbCategoria.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCategoria.FormattingEnabled = true;
            this.cbCategoria.Location = new System.Drawing.Point(15, 46);
            this.cbCategoria.Name = "cbCategoria";
            this.cbCategoria.Size = new System.Drawing.Size(311, 21);
            this.cbCategoria.TabIndex = 2;
            this.cbCategoria.SelectionChangeCommitted += new System.EventHandler(this.cbCategoria_SelectionChangeCommitted);
            // 
            // btnNovoPedido
            // 
            this.btnNovoPedido.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNovoPedido.Location = new System.Drawing.Point(87, 468);
            this.btnNovoPedido.Name = "btnNovoPedido";
            this.btnNovoPedido.Size = new System.Drawing.Size(178, 40);
            this.btnNovoPedido.TabIndex = 0;
            this.btnNovoPedido.Text = "Registrar Novo Pedido";
            this.btnNovoPedido.UseVisualStyleBackColor = true;
            this.btnNovoPedido.Click += new System.EventHandler(this.btnNovoPedido_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Categoria";
            // 
            // dgvCardapio
            // 
            this.dgvCardapio.AllowUserToAddRows = false;
            this.dgvCardapio.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvCardapio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCardapio.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cardapio,
            this.itc_id,
            this.itc_descricao,
            this.itc_disponivel,
            this.categoria_cardapio,
            this.preco,
            this.Itc_preco});
            this.dgvCardapio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgvCardapio.Location = new System.Drawing.Point(15, 83);
            this.dgvCardapio.Name = "dgvCardapio";
            this.dgvCardapio.ReadOnly = true;
            this.dgvCardapio.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCardapio.Size = new System.Drawing.Size(311, 379);
            this.dgvCardapio.TabIndex = 1;
            // 
            // cardapio
            // 
            this.cardapio.DataPropertyName = "Itc_nome";
            this.cardapio.HeaderText = "Prato";
            this.cardapio.Name = "cardapio";
            this.cardapio.ReadOnly = true;
            this.cardapio.Width = 168;
            // 
            // itc_id
            // 
            this.itc_id.DataPropertyName = "Itc_id";
            this.itc_id.HeaderText = "Codigo do Item";
            this.itc_id.Name = "itc_id";
            this.itc_id.ReadOnly = true;
            this.itc_id.Visible = false;
            // 
            // itc_descricao
            // 
            this.itc_descricao.DataPropertyName = "Itc_descricao";
            this.itc_descricao.HeaderText = "Descrição do Item";
            this.itc_descricao.Name = "itc_descricao";
            this.itc_descricao.ReadOnly = true;
            this.itc_descricao.Visible = false;
            // 
            // itc_disponivel
            // 
            this.itc_disponivel.DataPropertyName = "Itc_disponivel";
            this.itc_disponivel.HeaderText = "Disponilidade do Item";
            this.itc_disponivel.Name = "itc_disponivel";
            this.itc_disponivel.ReadOnly = true;
            this.itc_disponivel.Visible = false;
            // 
            // categoria_cardapio
            // 
            this.categoria_cardapio.DataPropertyName = "Cac";
            this.categoria_cardapio.HeaderText = "Categoria Cardapio";
            this.categoria_cardapio.Name = "categoria_cardapio";
            this.categoria_cardapio.ReadOnly = true;
            this.categoria_cardapio.Visible = false;
            // 
            // preco
            // 
            this.preco.DataPropertyName = "ItcPrecoFormatado";
            this.preco.HeaderText = "Preço";
            this.preco.Name = "preco";
            this.preco.ReadOnly = true;
            // 
            // Itc_preco
            // 
            this.Itc_preco.DataPropertyName = "Itc_preco";
            this.Itc_preco.HeaderText = "Itc_preco";
            this.Itc_preco.Name = "Itc_preco";
            this.Itc_preco.ReadOnly = true;
            this.Itc_preco.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbOcultarPedidosCancelados);
            this.groupBox1.Controls.Add(this.lblValorTotal);
            this.groupBox1.Controls.Add(this.btnCancelarPedido);
            this.groupBox1.Controls.Add(this.dgvPedido);
            this.groupBox1.Location = new System.Drawing.Point(375, 83);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(664, 517);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lista de Pedidos da Comanda";
            // 
            // cbOcultarPedidosCancelados
            // 
            this.cbOcultarPedidosCancelados.AutoSize = true;
            this.cbOcultarPedidosCancelados.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbOcultarPedidosCancelados.Location = new System.Drawing.Point(9, 19);
            this.cbOcultarPedidosCancelados.Name = "cbOcultarPedidosCancelados";
            this.cbOcultarPedidosCancelados.Size = new System.Drawing.Size(161, 17);
            this.cbOcultarPedidosCancelados.TabIndex = 3;
            this.cbOcultarPedidosCancelados.Text = "Mostrar Pedidos Cancelados";
            this.cbOcultarPedidosCancelados.UseVisualStyleBackColor = true;
            this.cbOcultarPedidosCancelados.CheckedChanged += new System.EventHandler(this.cbOcultarPedidosCancelados_CheckedChanged);
            // 
            // lblValorTotal
            // 
            this.lblValorTotal.BackColor = System.Drawing.Color.IndianRed;
            this.lblValorTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblValorTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorTotal.ForeColor = System.Drawing.Color.White;
            this.lblValorTotal.Location = new System.Drawing.Point(9, 452);
            this.lblValorTotal.Name = "lblValorTotal";
            this.lblValorTotal.Size = new System.Drawing.Size(541, 56);
            this.lblValorTotal.TabIndex = 2;
            this.lblValorTotal.Text = "Total : R$ %total%";
            this.lblValorTotal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblValorTotal.Click += new System.EventHandler(this.lblValorTotal_Click);
            // 
            // btnCancelarPedido
            // 
            this.btnCancelarPedido.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelarPedido.Location = new System.Drawing.Point(556, 452);
            this.btnCancelarPedido.Name = "btnCancelarPedido";
            this.btnCancelarPedido.Size = new System.Drawing.Size(95, 56);
            this.btnCancelarPedido.TabIndex = 1;
            this.btnCancelarPedido.Text = "Cancelar Pedido";
            this.btnCancelarPedido.UseVisualStyleBackColor = true;
            this.btnCancelarPedido.Click += new System.EventHandler(this.btnCancelarPedido_Click);
            // 
            // dgvPedido
            // 
            this.dgvPedido.AllowUserToAddRows = false;
            this.dgvPedido.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvPedido.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPedido.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Com_apelido,
            this.Pedido_comanda,
            this.ped_id,
            this.data_solic,
            this.preco_item,
            this.Ped_valor_total,
            this.qtde,
            this.item_status});
            this.dgvPedido.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgvPedido.Location = new System.Drawing.Point(9, 46);
            this.dgvPedido.Name = "dgvPedido";
            this.dgvPedido.ReadOnly = true;
            this.dgvPedido.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPedido.Size = new System.Drawing.Size(642, 400);
            this.dgvPedido.TabIndex = 0;
            // 
            // lblAcao
            // 
            this.lblAcao.BackColor = System.Drawing.Color.IndianRed;
            this.lblAcao.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAcao.ForeColor = System.Drawing.Color.White;
            this.lblAcao.Location = new System.Drawing.Point(12, 9);
            this.lblAcao.Name = "lblAcao";
            this.lblAcao.Size = new System.Drawing.Size(1027, 58);
            this.lblAcao.TabIndex = 5;
            this.lblAcao.Text = "Gerenciar Pedidos - %cmd%";
            this.lblAcao.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Com_apelido
            // 
            this.Com_apelido.DataPropertyName = "Item_pedido";
            this.Com_apelido.HeaderText = "Item";
            this.Com_apelido.Name = "Com_apelido";
            this.Com_apelido.ReadOnly = true;
            this.Com_apelido.Width = 168;
            // 
            // Pedido_comanda
            // 
            this.Pedido_comanda.DataPropertyName = "Pedido_comanda";
            this.Pedido_comanda.HeaderText = "Pedido_comanda";
            this.Pedido_comanda.Name = "Pedido_comanda";
            this.Pedido_comanda.ReadOnly = true;
            this.Pedido_comanda.Visible = false;
            // 
            // ped_id
            // 
            this.ped_id.DataPropertyName = "Ped_id";
            this.ped_id.HeaderText = "Ped_id";
            this.ped_id.Name = "ped_id";
            this.ped_id.ReadOnly = true;
            this.ped_id.Visible = false;
            // 
            // data_solic
            // 
            this.data_solic.DataPropertyName = "Ped_data_efetuado";
            this.data_solic.HeaderText = "Data Da Solicitação";
            this.data_solic.Name = "data_solic";
            this.data_solic.ReadOnly = true;
            this.data_solic.Width = 130;
            // 
            // preco_item
            // 
            this.preco_item.DataPropertyName = "PedidoPrecoFormatado";
            this.preco_item.HeaderText = "Preço";
            this.preco_item.Name = "preco_item";
            this.preco_item.ReadOnly = true;
            // 
            // Ped_valor_total
            // 
            this.Ped_valor_total.DataPropertyName = "Ped_valor_total";
            this.Ped_valor_total.HeaderText = "Ped_valor_total";
            this.Ped_valor_total.Name = "Ped_valor_total";
            this.Ped_valor_total.ReadOnly = true;
            this.Ped_valor_total.Visible = false;
            // 
            // qtde
            // 
            this.qtde.DataPropertyName = "Ped_quantidade";
            this.qtde.HeaderText = "Quantidade";
            this.qtde.Name = "qtde";
            this.qtde.ReadOnly = true;
            // 
            // item_status
            // 
            this.item_status.DataPropertyName = "Pedido_estado";
            this.item_status.HeaderText = "Status";
            this.item_status.Name = "item_status";
            this.item_status.ReadOnly = true;
            // 
            // frmGerenciarPedidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1047, 612);
            this.Controls.Add(this.lblAcao);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Name = "frmGerenciarPedidos";
            this.Text = "Gerenciar Pedidos - Comanda - %cmd%";
            this.Load += new System.EventHandler(this.frmGerenciarPedidos_Load);
            this.panel1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCardapio)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedido)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvCardapio;
        private System.Windows.Forms.Button btnNovoPedido;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblValorTotal;
        private System.Windows.Forms.Button btnCancelarPedido;
        private System.Windows.Forms.DataGridView dgvPedido;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbCategoria;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblAcao;
        private System.Windows.Forms.CheckBox cbOcultarPedidosCancelados;
        private System.Windows.Forms.DataGridViewTextBoxColumn cardapio;
        private System.Windows.Forms.DataGridViewTextBoxColumn itc_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn itc_descricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn itc_disponivel;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoria_cardapio;
        private System.Windows.Forms.DataGridViewTextBoxColumn preco;
        private System.Windows.Forms.DataGridViewTextBoxColumn Itc_preco;
        private System.Windows.Forms.DataGridViewTextBoxColumn Com_apelido;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pedido_comanda;
        private System.Windows.Forms.DataGridViewTextBoxColumn ped_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn data_solic;
        private System.Windows.Forms.DataGridViewTextBoxColumn preco_item;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ped_valor_total;
        private System.Windows.Forms.DataGridViewTextBoxColumn qtde;
        private System.Windows.Forms.DataGridViewTextBoxColumn item_status;
    }
}