namespace IA_PA2015.forms
{
    partial class ParearForm
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
            this.s = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.cbOperacao = new System.Windows.Forms.ComboBox();
            this.cbNivelContabil = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.ckTodosOrgaos = new System.Windows.Forms.CheckBox();
            this.cbOrgao = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cbEmenta = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.cbTipoLicitacao = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbHistorico = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbNatureza = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbTipoLAncamentoPadrao = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbEvento = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gridPareados = new System.Windows.Forms.DataGridView();
            this.s.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridPareados)).BeginInit();
            this.SuspendLayout();
            // 
            // s
            // 
            this.s.Controls.Add(this.label9);
            this.s.Controls.Add(this.cbOperacao);
            this.s.Controls.Add(this.cbNivelContabil);
            this.s.Controls.Add(this.label8);
            this.s.Controls.Add(this.ckTodosOrgaos);
            this.s.Controls.Add(this.cbOrgao);
            this.s.Controls.Add(this.label7);
            this.s.Controls.Add(this.cbEmenta);
            this.s.Controls.Add(this.label6);
            this.s.Controls.Add(this.button2);
            this.s.Controls.Add(this.button1);
            this.s.Controls.Add(this.cbTipoLicitacao);
            this.s.Controls.Add(this.label5);
            this.s.Controls.Add(this.cbHistorico);
            this.s.Controls.Add(this.label4);
            this.s.Controls.Add(this.cbNatureza);
            this.s.Controls.Add(this.label3);
            this.s.Controls.Add(this.cbTipoLAncamentoPadrao);
            this.s.Controls.Add(this.label2);
            this.s.Controls.Add(this.label1);
            this.s.Controls.Add(this.cbEvento);
            this.s.Dock = System.Windows.Forms.DockStyle.Top;
            this.s.Location = new System.Drawing.Point(0, 0);
            this.s.Name = "s";
            this.s.Size = new System.Drawing.Size(916, 237);
            this.s.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(393, 89);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(78, 13);
            this.label9.TabIndex = 22;
            this.label9.Text = "Tipo Operação";
            // 
            // cbOperacao
            // 
            this.cbOperacao.FormattingEnabled = true;
            this.cbOperacao.Items.AddRange(new object[] {
            "0 - Não se Aplica",
            "C - Crédito",
            "D - Debito"});
            this.cbOperacao.Location = new System.Drawing.Point(396, 103);
            this.cbOperacao.Name = "cbOperacao";
            this.cbOperacao.Size = new System.Drawing.Size(251, 21);
            this.cbOperacao.TabIndex = 21;
            // 
            // cbNivelContabil
            // 
            this.cbNivelContabil.FormattingEnabled = true;
            this.cbNivelContabil.Location = new System.Drawing.Point(15, 103);
            this.cbNivelContabil.Name = "cbNivelContabil";
            this.cbNivelContabil.Size = new System.Drawing.Size(347, 21);
            this.cbNivelContabil.TabIndex = 20;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(17, 89);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "Conta Contabil";
            // 
            // ckTodosOrgaos
            // 
            this.ckTodosOrgaos.AutoSize = true;
            this.ckTodosOrgaos.Location = new System.Drawing.Point(187, 214);
            this.ckTodosOrgaos.Name = "ckTodosOrgaos";
            this.ckTodosOrgaos.Size = new System.Drawing.Size(241, 17);
            this.ckTodosOrgaos.TabIndex = 18;
            this.ckTodosOrgaos.Text = "Parea Evento/Historico para todos os Orgãos";
            this.ckTodosOrgaos.UseVisualStyleBackColor = true;
            // 
            // cbOrgao
            // 
            this.cbOrgao.FormattingEnabled = true;
            this.cbOrgao.Location = new System.Drawing.Point(663, 65);
            this.cbOrgao.Name = "cbOrgao";
            this.cbOrgao.Size = new System.Drawing.Size(217, 21);
            this.cbOrgao.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(660, 49);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Órgão";
            // 
            // cbEmenta
            // 
            this.cbEmenta.FormattingEnabled = true;
            this.cbEmenta.Location = new System.Drawing.Point(663, 25);
            this.cbEmenta.Name = "cbEmenta";
            this.cbEmenta.Size = new System.Drawing.Size(217, 21);
            this.cbEmenta.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(660, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Ementa";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(95, 210);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "Excluir";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(14, 210);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Gravar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cbTipoLicitacao
            // 
            this.cbTipoLicitacao.FormattingEnabled = true;
            this.cbTipoLicitacao.Location = new System.Drawing.Point(396, 25);
            this.cbTipoLicitacao.Name = "cbTipoLicitacao";
            this.cbTipoLicitacao.Size = new System.Drawing.Size(251, 21);
            this.cbTipoLicitacao.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(393, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Tipo Licitação";
            // 
            // cbHistorico
            // 
            this.cbHistorico.FormattingEnabled = true;
            this.cbHistorico.Location = new System.Drawing.Point(11, 183);
            this.cbHistorico.Name = "cbHistorico";
            this.cbHistorico.Size = new System.Drawing.Size(777, 21);
            this.cbHistorico.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 167);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Histórico Padrão";
            // 
            // cbNatureza
            // 
            this.cbNatureza.FormattingEnabled = true;
            this.cbNatureza.Location = new System.Drawing.Point(15, 65);
            this.cbNatureza.Name = "cbNatureza";
            this.cbNatureza.Size = new System.Drawing.Size(632, 21);
            this.cbNatureza.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Natureza da Despesa";
            // 
            // cbTipoLAncamentoPadrao
            // 
            this.cbTipoLAncamentoPadrao.FormattingEnabled = true;
            this.cbTipoLAncamentoPadrao.Location = new System.Drawing.Point(15, 25);
            this.cbTipoLAncamentoPadrao.Name = "cbTipoLAncamentoPadrao";
            this.cbTipoLAncamentoPadrao.Size = new System.Drawing.Size(361, 21);
            this.cbTipoLAncamentoPadrao.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Lançamento Padrão";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 127);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Evento";
            // 
            // cbEvento
            // 
            this.cbEvento.FormattingEnabled = true;
            this.cbEvento.Location = new System.Drawing.Point(11, 143);
            this.cbEvento.Name = "cbEvento";
            this.cbEvento.Size = new System.Drawing.Size(777, 21);
            this.cbEvento.TabIndex = 0;
            this.cbEvento.DropDownClosed += new System.EventHandler(this.cbEvento_DropDownClosed);
            this.cbEvento.ValueMemberChanged += new System.EventHandler(this.cbEvento_ValueMemberChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.gridPareados);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 237);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(916, 227);
            this.panel1.TabIndex = 2;
            // 
            // gridPareados
            // 
            this.gridPareados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridPareados.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridPareados.Location = new System.Drawing.Point(0, 0);
            this.gridPareados.Name = "gridPareados";
            this.gridPareados.Size = new System.Drawing.Size(916, 227);
            this.gridPareados.TabIndex = 1;
            // 
            // ParearForm
            // 
            this.ClientSize = new System.Drawing.Size(916, 464);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.s);
            this.Name = "ParearForm";
            this.Text = "Parametrização";
            this.Load += new System.EventHandler(this.ParearForm_Load);
            this.s.ResumeLayout(false);
            this.s.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridPareados)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel s;
        private System.Windows.Forms.ComboBox cbTipoLAncamentoPadrao;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbEvento;
        private System.Windows.Forms.ComboBox cbHistorico;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbNatureza;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbTipoLicitacao;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView gridPareados;
        private System.Windows.Forms.ComboBox cbEmenta;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbOrgao;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox ckTodosOrgaos;
        private System.Windows.Forms.ComboBox cbNivelContabil;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cbOperacao;
    }
}
