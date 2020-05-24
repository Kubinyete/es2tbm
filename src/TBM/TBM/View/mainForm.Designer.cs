namespace TBM.View
{
    partial class mainForm
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.gerenciaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.parametrizaçãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuárioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.funcionárioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.financeiroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comandaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abrirComandaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.telaGerenciarComandaExperimentalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.estoqueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.efetuarBaixaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deliveryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tbcPrincipal = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.lblNomeInferior = new System.Windows.Forms.Label();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.debugToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fecharComandaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.tbcPrincipal.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gerenciaToolStripMenuItem,
            this.financeiroToolStripMenuItem,
            this.comandaToolStripMenuItem,
            this.estoqueToolStripMenuItem,
            this.deliveryToolStripMenuItem,
            this.debugToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1008, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // gerenciaToolStripMenuItem
            // 
            this.gerenciaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.parametrizaçãoToolStripMenuItem,
            this.usuárioToolStripMenuItem,
            this.funcionárioToolStripMenuItem,
            this.clienteToolStripMenuItem});
            this.gerenciaToolStripMenuItem.Name = "gerenciaToolStripMenuItem";
            this.gerenciaToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.gerenciaToolStripMenuItem.Text = "Gerência";
            // 
            // parametrizaçãoToolStripMenuItem
            // 
            this.parametrizaçãoToolStripMenuItem.Name = "parametrizaçãoToolStripMenuItem";
            this.parametrizaçãoToolStripMenuItem.Size = new System.Drawing.Size(215, 22);
            this.parametrizaçãoToolStripMenuItem.Text = "Configurar parametrização";
            this.parametrizaçãoToolStripMenuItem.Click += new System.EventHandler(this.parametrizaçãoToolStripMenuItem_Click);
            // 
            // usuárioToolStripMenuItem
            // 
            this.usuárioToolStripMenuItem.Name = "usuárioToolStripMenuItem";
            this.usuárioToolStripMenuItem.Size = new System.Drawing.Size(215, 22);
            this.usuárioToolStripMenuItem.Text = "Usuário";
            this.usuárioToolStripMenuItem.Click += new System.EventHandler(this.usuárioToolStripMenuItem_Click);
            // 
            // funcionárioToolStripMenuItem
            // 
            this.funcionárioToolStripMenuItem.Name = "funcionárioToolStripMenuItem";
            this.funcionárioToolStripMenuItem.Size = new System.Drawing.Size(215, 22);
            this.funcionárioToolStripMenuItem.Text = "Funcionário";
            this.funcionárioToolStripMenuItem.Click += new System.EventHandler(this.funcionárioToolStripMenuItem_Click);
            // 
            // clienteToolStripMenuItem
            // 
            this.clienteToolStripMenuItem.Name = "clienteToolStripMenuItem";
            this.clienteToolStripMenuItem.Size = new System.Drawing.Size(215, 22);
            this.clienteToolStripMenuItem.Text = "Cliente";
            this.clienteToolStripMenuItem.Click += new System.EventHandler(this.clienteToolStripMenuItem_Click);
            // 
            // financeiroToolStripMenuItem
            // 
            this.financeiroToolStripMenuItem.Name = "financeiroToolStripMenuItem";
            this.financeiroToolStripMenuItem.Size = new System.Drawing.Size(74, 20);
            this.financeiroToolStripMenuItem.Text = "Financeiro";
            // 
            // comandaToolStripMenuItem
            // 
            this.comandaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.abrirComandaToolStripMenuItem,
            this.telaGerenciarComandaExperimentalToolStripMenuItem});
            this.comandaToolStripMenuItem.Name = "comandaToolStripMenuItem";
            this.comandaToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.comandaToolStripMenuItem.Text = "Comanda";
            this.comandaToolStripMenuItem.Click += new System.EventHandler(this.comandaToolStripMenuItem_Click);
            // 
            // abrirComandaToolStripMenuItem
            // 
            this.abrirComandaToolStripMenuItem.Name = "abrirComandaToolStripMenuItem";
            this.abrirComandaToolStripMenuItem.Size = new System.Drawing.Size(291, 22);
            this.abrirComandaToolStripMenuItem.Text = "Tela Abertura de Comanda(Experimental)";
            this.abrirComandaToolStripMenuItem.Click += new System.EventHandler(this.abrirComandaToolStripMenuItem_Click);
            // 
            // telaGerenciarComandaExperimentalToolStripMenuItem
            // 
            this.telaGerenciarComandaExperimentalToolStripMenuItem.Name = "telaGerenciarComandaExperimentalToolStripMenuItem";
            this.telaGerenciarComandaExperimentalToolStripMenuItem.Size = new System.Drawing.Size(291, 22);
            this.telaGerenciarComandaExperimentalToolStripMenuItem.Text = "Tela Gerenciar Comanda(Experimental)";
            this.telaGerenciarComandaExperimentalToolStripMenuItem.Click += new System.EventHandler(this.telaGerenciarComandaExperimentalToolStripMenuItem_Click);
            // 
            // estoqueToolStripMenuItem
            // 
            this.estoqueToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.efetuarBaixaToolStripMenuItem});
            this.estoqueToolStripMenuItem.Name = "estoqueToolStripMenuItem";
            this.estoqueToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.estoqueToolStripMenuItem.Text = "Estoque";
            // 
            // efetuarBaixaToolStripMenuItem
            // 
            this.efetuarBaixaToolStripMenuItem.Name = "efetuarBaixaToolStripMenuItem";
            this.efetuarBaixaToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.efetuarBaixaToolStripMenuItem.Text = "Efetuar Baixa";
            this.efetuarBaixaToolStripMenuItem.Click += new System.EventHandler(this.efetuarBaixaToolStripMenuItem_Click);
            // 
            // deliveryToolStripMenuItem
            // 
            this.deliveryToolStripMenuItem.Name = "deliveryToolStripMenuItem";
            this.deliveryToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.deliveryToolStripMenuItem.Text = "Delivery";
            // 
            // tbcPrincipal
            // 
            this.tbcPrincipal.Controls.Add(this.tabPage1);
            this.tbcPrincipal.Controls.Add(this.tabPage2);
            this.tbcPrincipal.Controls.Add(this.tabPage3);
            this.tbcPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbcPrincipal.Location = new System.Drawing.Point(0, 24);
            this.tbcPrincipal.Name = "tbcPrincipal";
            this.tbcPrincipal.SelectedIndex = 0;
            this.tbcPrincipal.Size = new System.Drawing.Size(1008, 705);
            this.tbcPrincipal.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.lblNomeInferior);
            this.tabPage1.Controls.Add(this.pbLogo);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1000, 679);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Início";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // lblNomeInferior
            // 
            this.lblNomeInferior.BackColor = System.Drawing.Color.IndianRed;
            this.lblNomeInferior.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblNomeInferior.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeInferior.ForeColor = System.Drawing.Color.White;
            this.lblNomeInferior.Location = new System.Drawing.Point(3, 656);
            this.lblNomeInferior.Name = "lblNomeInferior";
            this.lblNomeInferior.Size = new System.Drawing.Size(994, 20);
            this.lblNomeInferior.TabIndex = 1;
            this.lblNomeInferior.Text = "%nome% - %cnpj% - %hoje%";
            this.lblNomeInferior.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pbLogo
            // 
            this.pbLogo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbLogo.Location = new System.Drawing.Point(3, 3);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(994, 673);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbLogo.TabIndex = 0;
            this.pbLogo.TabStop = false;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1000, 679);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Visualização de mesas";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1000, 679);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Visualização de pedidos";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // debugToolStripMenuItem
            // 
            this.debugToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fecharComandaToolStripMenuItem});
            this.debugToolStripMenuItem.Name = "debugToolStripMenuItem";
            this.debugToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.debugToolStripMenuItem.Text = "Debug";
            // 
            // fecharComandaToolStripMenuItem
            // 
            this.fecharComandaToolStripMenuItem.Name = "fecharComandaToolStripMenuItem";
            this.fecharComandaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.fecharComandaToolStripMenuItem.Text = "Fechar comanda";
            this.fecharComandaToolStripMenuItem.Click += new System.EventHandler(this.fecharComandaToolStripMenuItem_Click);
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.tbcPrincipal);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "mainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "%nome% - Sistema TBM";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.mainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tbcPrincipal.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        public System.Windows.Forms.ToolStripMenuItem gerenciaToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem parametrizaçãoToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem funcionárioToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem clienteToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem usuárioToolStripMenuItem;
        public System.Windows.Forms.TabControl tbcPrincipal;
        public System.Windows.Forms.TabPage tabPage1;
        public System.Windows.Forms.TabPage tabPage2;
        public System.Windows.Forms.TabPage tabPage3;
        public System.Windows.Forms.PictureBox pbLogo;
        public System.Windows.Forms.Label lblNomeInferior;
        private System.Windows.Forms.ToolStripMenuItem financeiroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem comandaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem abrirComandaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem estoqueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem efetuarBaixaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deliveryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem telaGerenciarComandaExperimentalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem debugToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fecharComandaToolStripMenuItem;
    }
}

