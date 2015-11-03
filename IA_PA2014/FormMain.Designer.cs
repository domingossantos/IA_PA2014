namespace IA_PA2015
{
    partial class FormMain
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.gerarArquivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.parearDadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ordenadorDespesasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.empenhoVsReciboMuralToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.históricoPadrãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eventoHistoricoFolhaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lançamentoNãoPAdrãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.eventoTCMToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.históricoTCMToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.confgurarBancoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.contaPCAContaTCMToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gerarArquivoToolStripMenuItem,
            this.parearDadosToolStripMenuItem,
            this.confgurarBancoToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(819, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // gerarArquivoToolStripMenuItem
            // 
            this.gerarArquivoToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("gerarArquivoToolStripMenuItem.Image")));
            this.gerarArquivoToolStripMenuItem.Name = "gerarArquivoToolStripMenuItem";
            this.gerarArquivoToolStripMenuItem.Size = new System.Drawing.Size(102, 20);
            this.gerarArquivoToolStripMenuItem.Text = "Gerar Arquivo";
            this.gerarArquivoToolStripMenuItem.Click += new System.EventHandler(this.gerarArquivoToolStripMenuItem_Click);
            // 
            // parearDadosToolStripMenuItem
            // 
            this.parearDadosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ordenadorDespesasToolStripMenuItem,
            this.empenhoVsReciboMuralToolStripMenuItem,
            this.históricoPadrãoToolStripMenuItem,
            this.eventoHistoricoFolhaToolStripMenuItem,
            this.lançamentoNãoPAdrãoToolStripMenuItem,
            this.toolStripMenuItem1,
            this.eventoTCMToolStripMenuItem,
            this.históricoTCMToolStripMenuItem,
            this.contaPCAContaTCMToolStripMenuItem});
            this.parearDadosToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("parearDadosToolStripMenuItem.Image")));
            this.parearDadosToolStripMenuItem.Name = "parearDadosToolStripMenuItem";
            this.parearDadosToolStripMenuItem.Size = new System.Drawing.Size(100, 20);
            this.parearDadosToolStripMenuItem.Text = "Parear Dados";
            // 
            // ordenadorDespesasToolStripMenuItem
            // 
            this.ordenadorDespesasToolStripMenuItem.Name = "ordenadorDespesasToolStripMenuItem";
            this.ordenadorDespesasToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.ordenadorDespesasToolStripMenuItem.Text = "Ordenador Despesas";
            this.ordenadorDespesasToolStripMenuItem.Click += new System.EventHandler(this.ordenadorDespesasToolStripMenuItem_Click);
            // 
            // empenhoVsReciboMuralToolStripMenuItem
            // 
            this.empenhoVsReciboMuralToolStripMenuItem.Name = "empenhoVsReciboMuralToolStripMenuItem";
            this.empenhoVsReciboMuralToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.empenhoVsReciboMuralToolStripMenuItem.Text = "Empenho vs Recibo Mural";
            this.empenhoVsReciboMuralToolStripMenuItem.Click += new System.EventHandler(this.empenhoVsReciboMuralToolStripMenuItem_Click);
            // 
            // históricoPadrãoToolStripMenuItem
            // 
            this.históricoPadrãoToolStripMenuItem.Name = "históricoPadrãoToolStripMenuItem";
            this.históricoPadrãoToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.históricoPadrãoToolStripMenuItem.Text = "Evento/Histórico";
            this.históricoPadrãoToolStripMenuItem.Click += new System.EventHandler(this.históricoPadrãoToolStripMenuItem_Click);
            // 
            // eventoHistoricoFolhaToolStripMenuItem
            // 
            this.eventoHistoricoFolhaToolStripMenuItem.Name = "eventoHistoricoFolhaToolStripMenuItem";
            this.eventoHistoricoFolhaToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.eventoHistoricoFolhaToolStripMenuItem.Text = "Evento/Historico Folha";
            this.eventoHistoricoFolhaToolStripMenuItem.Click += new System.EventHandler(this.eventoHistoricoFolhaToolStripMenuItem_Click);
            // 
            // lançamentoNãoPAdrãoToolStripMenuItem
            // 
            this.lançamentoNãoPAdrãoToolStripMenuItem.Name = "lançamentoNãoPAdrãoToolStripMenuItem";
            this.lançamentoNãoPAdrãoToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.lançamentoNãoPAdrãoToolStripMenuItem.Text = "Lançamento Não Padrão";
            this.lançamentoNãoPAdrãoToolStripMenuItem.Click += new System.EventHandler(this.lançamentoNãoPAdrãoToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(193, 6);
            // 
            // eventoTCMToolStripMenuItem
            // 
            this.eventoTCMToolStripMenuItem.Name = "eventoTCMToolStripMenuItem";
            this.eventoTCMToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.eventoTCMToolStripMenuItem.Text = "Evento TCM";
            // 
            // históricoTCMToolStripMenuItem
            // 
            this.históricoTCMToolStripMenuItem.Name = "históricoTCMToolStripMenuItem";
            this.históricoTCMToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.históricoTCMToolStripMenuItem.Text = "Histórico TCM";
            // 
            // confgurarBancoToolStripMenuItem
            // 
            this.confgurarBancoToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("confgurarBancoToolStripMenuItem.Image")));
            this.confgurarBancoToolStripMenuItem.Name = "confgurarBancoToolStripMenuItem";
            this.confgurarBancoToolStripMenuItem.Size = new System.Drawing.Size(116, 20);
            this.confgurarBancoToolStripMenuItem.Text = "Confgurar Banco";
            this.confgurarBancoToolStripMenuItem.Click += new System.EventHandler(this.confgurarBancoToolStripMenuItem_Click);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("sairToolStripMenuItem.Image")));
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // contaPCAContaTCMToolStripMenuItem
            // 
            this.contaPCAContaTCMToolStripMenuItem.Name = "contaPCAContaTCMToolStripMenuItem";
            this.contaPCAContaTCMToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.contaPCAContaTCMToolStripMenuItem.Text = "ContaPC a Conta TCM";
            this.contaPCAContaTCMToolStripMenuItem.Click += new System.EventHandler(this.contaPCAContaTCMToolStripMenuItem_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(819, 511);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Geração de Arquivo - TCM-PA Ano Base 2014";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem gerarArquivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem parearDadosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem confgurarBancoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ordenadorDespesasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem históricoPadrãoToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem eventoTCMToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem históricoTCMToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem empenhoVsReciboMuralToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eventoHistoricoFolhaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lançamentoNãoPAdrãoToolStripMenuItem;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ToolStripMenuItem contaPCAContaTCMToolStripMenuItem;
    }
}

