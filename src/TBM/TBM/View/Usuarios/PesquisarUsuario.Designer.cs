namespace TBM.View.Usuarios
{
    partial class PesquisarUsuario
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.cbFiltros = new System.Windows.Forms.ComboBox();
            this.tbSrc = new System.Windows.Forms.TextBox();
            this.btnPequisa = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvUsuarios = new System.Windows.Forms.DataGridView();
            this.col_usuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_nome_func = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(13, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(571, 50);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::TBM.Properties.Resources.user;
            this.pictureBox1.Location = new System.Drawing.Point(-1, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(62, 52);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.IndianRed;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.label2.ForeColor = System.Drawing.SystemColors.Window;
            this.label2.Location = new System.Drawing.Point(-2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(574, 50);
            this.label2.TabIndex = 10;
            this.label2.Text = "Gerenciar Usuário";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panel2);
            this.groupBox1.Location = new System.Drawing.Point(13, 70);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(571, 100);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pesquisar";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.cbFiltros);
            this.panel2.Controls.Add(this.tbSrc);
            this.panel2.Controls.Add(this.btnPequisa);
            this.panel2.Location = new System.Drawing.Point(7, 14);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(556, 73);
            this.panel2.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(366, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Pesquisar Por :";
            // 
            // cbFiltros
            // 
            this.cbFiltros.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFiltros.FormattingEnabled = true;
            this.cbFiltros.Items.AddRange(new object[] {
            "Username",
            "Nome Do Funcionário"});
            this.cbFiltros.Location = new System.Drawing.Point(369, 23);
            this.cbFiltros.Name = "cbFiltros";
            this.cbFiltros.Size = new System.Drawing.Size(118, 21);
            this.cbFiltros.TabIndex = 2;
            // 
            // tbSrc
            // 
            this.tbSrc.Location = new System.Drawing.Point(16, 23);
            this.tbSrc.Name = "tbSrc";
            this.tbSrc.Size = new System.Drawing.Size(347, 20);
            this.tbSrc.TabIndex = 0;
            this.tbSrc.TextChanged += new System.EventHandler(this.tbSrc_TextChanged);
            // 
            // btnPequisa
            // 
            this.btnPequisa.Location = new System.Drawing.Point(493, 17);
            this.btnPequisa.Name = "btnPequisa";
            this.btnPequisa.Size = new System.Drawing.Size(37, 31);
            this.btnPequisa.TabIndex = 1;
            this.btnPequisa.Text = "SRC";
            this.btnPequisa.UseVisualStyleBackColor = true;
            this.btnPequisa.Click += new System.EventHandler(this.btnPequisa_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvUsuarios);
            this.groupBox2.Location = new System.Drawing.Point(13, 177);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(573, 233);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Dados do Usuário";
            // 
            // dgvUsuarios
            // 
            this.dgvUsuarios.AllowUserToAddRows = false;
            this.dgvUsuarios.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsuarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_usuario,
            this.col_nome_func,
            this.col_status});
            this.dgvUsuarios.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgvUsuarios.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dgvUsuarios.Location = new System.Drawing.Point(13, 20);
            this.dgvUsuarios.Name = "dgvUsuarios";
            this.dgvUsuarios.ReadOnly = true;
            this.dgvUsuarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUsuarios.Size = new System.Drawing.Size(552, 192);
            this.dgvUsuarios.TabIndex = 0;
            // 
            // col_usuario
            // 
            this.col_usuario.HeaderText = "Username";
            this.col_usuario.Name = "col_usuario";
            this.col_usuario.ReadOnly = true;
            this.col_usuario.Width = 140;
            // 
            // col_nome_func
            // 
            this.col_nome_func.HeaderText = "Funcionário";
            this.col_nome_func.Name = "col_nome_func";
            this.col_nome_func.ReadOnly = true;
            this.col_nome_func.Width = 250;
            // 
            // col_status
            // 
            this.col_status.HeaderText = "Status";
            this.col_status.Name = "col_status";
            this.col_status.ReadOnly = true;
            this.col_status.Width = 120;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Location = new System.Drawing.Point(10, 416);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(574, 69);
            this.panel3.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnAdd);
            this.panel4.Controls.Add(this.btnExcluir);
            this.panel4.Controls.Add(this.btnAlterar);
            this.panel4.Location = new System.Drawing.Point(311, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(255, 59);
            this.panel4.TabIndex = 6;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(10, 3);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 53);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "ADD";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(172, 3);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(75, 53);
            this.btnExcluir.TabIndex = 3;
            this.btnExcluir.Text = "EXC";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.Location = new System.Drawing.Point(91, 3);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(75, 53);
            this.btnAlterar.TabIndex = 2;
            this.btnAlterar.Text = "ALT";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // PesquisarUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(596, 488);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Name = "PesquisarUsuario";
            this.Text = "Gerenciar Usuário";
            this.Load += new System.EventHandler(this.PesquisarUsuario_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvUsuarios;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbFiltros;
        private System.Windows.Forms.TextBox tbSrc;
        private System.Windows.Forms.Button btnPequisa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_usuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_nome_func;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_status;
    }
}