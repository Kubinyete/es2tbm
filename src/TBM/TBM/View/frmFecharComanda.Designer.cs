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
            this.gbParametros = new System.Windows.Forms.GroupBox();
            this.cbGarcom = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbApelido = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbNumero = new System.Windows.Forms.TextBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnAction = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.gbPedidos = new System.Windows.Forms.GroupBox();
            this.lblDadosTotal = new System.Windows.Forms.Label();
            this.pbIcone = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dgvPedidos = new System.Windows.Forms.DataGridView();
            this.gbPagamentos = new System.Windows.Forms.GroupBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.dgvPagamentos = new System.Windows.Forms.DataGridView();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.btnRemover = new System.Windows.Forms.Button();
            this.btnEstornar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btnSelecionarCliente = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.panel1.SuspendLayout();
            this.gbParametros.SuspendLayout();
            this.panel2.SuspendLayout();
            this.gbPedidos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbIcone)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedidos)).BeginInit();
            this.gbPagamentos.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPagamentos)).BeginInit();
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
            // gbParametros
            // 
            this.gbParametros.Controls.Add(this.checkBox1);
            this.gbParametros.Controls.Add(this.btnSelecionarCliente);
            this.gbParametros.Controls.Add(this.comboBox1);
            this.gbParametros.Controls.Add(this.label2);
            this.gbParametros.Controls.Add(this.cbGarcom);
            this.gbParametros.Controls.Add(this.label3);
            this.gbParametros.Controls.Add(this.tbApelido);
            this.gbParametros.Controls.Add(this.label9);
            this.gbParametros.Controls.Add(this.label1);
            this.gbParametros.Controls.Add(this.tbNumero);
            this.gbParametros.Location = new System.Drawing.Point(3, 56);
            this.gbParametros.Name = "gbParametros";
            this.gbParametros.Size = new System.Drawing.Size(754, 102);
            this.gbParametros.TabIndex = 12;
            this.gbParametros.TabStop = false;
            this.gbParametros.Text = "Detalhes";
            // 
            // cbGarcom
            // 
            this.cbGarcom.Enabled = false;
            this.cbGarcom.FormattingEnabled = true;
            this.cbGarcom.Location = new System.Drawing.Point(9, 71);
            this.cbGarcom.Name = "cbGarcom";
            this.cbGarcom.Size = new System.Drawing.Size(450, 21);
            this.cbGarcom.TabIndex = 24;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 55);
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
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Número";
            // 
            // tbNumero
            // 
            this.tbNumero.Enabled = false;
            this.tbNumero.Location = new System.Drawing.Point(9, 32);
            this.tbNumero.Name = "tbNumero";
            this.tbNumero.Size = new System.Drawing.Size(101, 20);
            this.tbNumero.TabIndex = 0;
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
            this.panel2.Controls.Add(this.btnEstornar);
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
            this.btnAction.Text = "Fechar comanda";
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
            // panel3
            // 
            this.panel3.Controls.Add(this.dgvPedidos);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(3, 16);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(456, 382);
            this.panel3.TabIndex = 2;
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
            // dgvPedidos
            // 
            this.dgvPedidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPedidos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPedidos.Location = new System.Drawing.Point(0, 0);
            this.dgvPedidos.Name = "dgvPedidos";
            this.dgvPedidos.Size = new System.Drawing.Size(456, 382);
            this.dgvPedidos.TabIndex = 2;
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
            this.panel5.BackColor = System.Drawing.Color.IndianRed;
            this.panel5.Controls.Add(this.btnAdicionar);
            this.panel5.Controls.Add(this.btnRemover);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5.Location = new System.Drawing.Point(3, 404);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(280, 45);
            this.panel5.TabIndex = 2;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.dgvPagamentos);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(3, 16);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(280, 382);
            this.panel6.TabIndex = 2;
            // 
            // dgvPagamentos
            // 
            this.dgvPagamentos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPagamentos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPagamentos.Location = new System.Drawing.Point(0, 0);
            this.dgvPagamentos.Name = "dgvPagamentos";
            this.dgvPagamentos.Size = new System.Drawing.Size(280, 382);
            this.dgvPagamentos.TabIndex = 2;
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnAdicionar.Location = new System.Drawing.Point(130, 0);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(75, 45);
            this.btnAdicionar.TabIndex = 17;
            this.btnAdicionar.Text = "Adicionar pagamento";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            // 
            // btnRemover
            // 
            this.btnRemover.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnRemover.Location = new System.Drawing.Point(205, 0);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(75, 45);
            this.btnRemover.TabIndex = 16;
            this.btnRemover.Text = "Cancelar";
            this.btnRemover.UseVisualStyleBackColor = true;
            // 
            // btnEstornar
            // 
            this.btnEstornar.Enabled = false;
            this.btnEstornar.Location = new System.Drawing.Point(520, 3);
            this.btnEstornar.Name = "btnEstornar";
            this.btnEstornar.Size = new System.Drawing.Size(75, 74);
            this.btnEstornar.TabIndex = 4;
            this.btnEstornar.Text = "Estornar comanda";
            this.btnEstornar.UseVisualStyleBackColor = true;
            this.btnEstornar.Click += new System.EventHandler(this.btnEstornar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(468, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 25;
            this.label2.Text = "Cliente associado";
            // 
            // comboBox1
            // 
            this.comboBox1.Enabled = false;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(471, 32);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(199, 21);
            this.comboBox1.TabIndex = 26;
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
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(471, 75);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(176, 17);
            this.checkBox1.TabIndex = 28;
            this.checkBox1.Text = "Cliente não informou um registro";
            this.checkBox1.UseVisualStyleBackColor = true;
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
            this.gbParametros.ResumeLayout(false);
            this.gbParametros.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.gbPedidos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbIcone)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedidos)).EndInit();
            this.gbPagamentos.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPagamentos)).EndInit();
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
        private System.Windows.Forms.TextBox tbNumero;
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
        private System.Windows.Forms.Button btnEstornar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button btnSelecionarCliente;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}