namespace IA_PA2015.forms
{
    partial class NaoPadraoForm
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
            this.ckTodosOrgaos = new System.Windows.Forms.CheckBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.cbHistoricoDebito = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbEventoDebito = new System.Windows.Forms.ComboBox();
            this.cbUnidadeGestora = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cbHistoricoCredito = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbTipoLAncamentoPadrao = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbEventoCredito = new System.Windows.Forms.ComboBox();
            this.dgPareados = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgPareados)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.ckTodosOrgaos);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.cbHistoricoDebito);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.cbEventoDebito);
            this.panel1.Controls.Add(this.cbUnidadeGestora);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.cbHistoricoCredito);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.cbTipoLAncamentoPadrao);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.cbEventoCredito);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(775, 479);
            this.panel1.TabIndex = 0;
            // 
            // ckTodosOrgaos
            // 
            this.ckTodosOrgaos.AutoSize = true;
            this.ckTodosOrgaos.Location = new System.Drawing.Point(179, 220);
            this.ckTodosOrgaos.Name = "ckTodosOrgaos";
            this.ckTodosOrgaos.Size = new System.Drawing.Size(297, 17);
            this.ckTodosOrgaos.TabIndex = 40;
            this.ckTodosOrgaos.Text = "Parea Evento/Historico para todos as Unidades Gestoras";
            this.ckTodosOrgaos.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(87, 216);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 39;
            this.button2.Text = "Excluir";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 216);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 38;
            this.button1.Text = "Gravar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cbHistoricoDebito
            // 
            this.cbHistoricoDebito.FormattingEnabled = true;
            this.cbHistoricoDebito.Location = new System.Drawing.Point(6, 189);
            this.cbHistoricoDebito.Name = "cbHistoricoDebito";
            this.cbHistoricoDebito.Size = new System.Drawing.Size(751, 21);
            this.cbHistoricoDebito.TabIndex = 35;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 13);
            this.label3.TabIndex = 37;
            this.label3.Text = "Histórico Padrão - Debito";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 133);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 13);
            this.label5.TabIndex = 36;
            this.label5.Text = "Evento Débito";
            // 
            // cbEventoDebito
            // 
            this.cbEventoDebito.FormattingEnabled = true;
            this.cbEventoDebito.Location = new System.Drawing.Point(6, 149);
            this.cbEventoDebito.Name = "cbEventoDebito";
            this.cbEventoDebito.Size = new System.Drawing.Size(751, 21);
            this.cbEventoDebito.TabIndex = 34;
            this.cbEventoDebito.DropDown += new System.EventHandler(this.cbEventoDebito_DropDown);
            this.cbEventoDebito.ValueMemberChanged += new System.EventHandler(this.cbEventoDebito_ValueMemberChanged);
            // 
            // cbUnidadeGestora
            // 
            this.cbUnidadeGestora.FormattingEnabled = true;
            this.cbUnidadeGestora.Location = new System.Drawing.Point(424, 25);
            this.cbUnidadeGestora.Name = "cbUnidadeGestora";
            this.cbUnidadeGestora.Size = new System.Drawing.Size(330, 21);
            this.cbUnidadeGestora.TabIndex = 33;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(421, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(90, 13);
            this.label9.TabIndex = 32;
            this.label9.Text = "Unidade Gestora:";
            // 
            // cbHistoricoCredito
            // 
            this.cbHistoricoCredito.FormattingEnabled = true;
            this.cbHistoricoCredito.Location = new System.Drawing.Point(3, 105);
            this.cbHistoricoCredito.Name = "cbHistoricoCredito";
            this.cbHistoricoCredito.Size = new System.Drawing.Size(751, 21);
            this.cbHistoricoCredito.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Histórico Padrão - Crédito";
            // 
            // cbTipoLAncamentoPadrao
            // 
            this.cbTipoLAncamentoPadrao.FormattingEnabled = true;
            this.cbTipoLAncamentoPadrao.Location = new System.Drawing.Point(6, 25);
            this.cbTipoLAncamentoPadrao.Name = "cbTipoLAncamentoPadrao";
            this.cbTipoLAncamentoPadrao.Size = new System.Drawing.Size(412, 21);
            this.cbTipoLAncamentoPadrao.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Lançamento Não Padrão";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Evento Crédito";
            // 
            // cbEventoCredito
            // 
            this.cbEventoCredito.FormattingEnabled = true;
            this.cbEventoCredito.Location = new System.Drawing.Point(3, 65);
            this.cbEventoCredito.Name = "cbEventoCredito";
            this.cbEventoCredito.Size = new System.Drawing.Size(751, 21);
            this.cbEventoCredito.TabIndex = 8;
            this.cbEventoCredito.DropDownClosed += new System.EventHandler(this.cbEventoCredito_DropDownClosed);
            this.cbEventoCredito.ValueMemberChanged += new System.EventHandler(this.cbEventoCredito_ValueMemberChanged);
            // 
            // dgPareados
            // 
            this.dgPareados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgPareados.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.dgPareados.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgPareados.Location = new System.Drawing.Point(0, 246);
            this.dgPareados.Name = "dgPareados";
            this.dgPareados.Size = new System.Drawing.Size(775, 233);
            this.dgPareados.TabIndex = 1;
            // 
            // NaoPadraoForm
            // 
            this.ClientSize = new System.Drawing.Size(775, 479);
            this.Controls.Add(this.dgPareados);
            this.Controls.Add(this.panel1);
            this.Name = "NaoPadraoForm";
            this.Text = "Parear Lançamentos Não Padrão";
            this.Load += new System.EventHandler(this.NaoPadraoForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgPareados)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cbHistoricoCredito;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbTipoLAncamentoPadrao;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbEventoCredito;
        private System.Windows.Forms.ComboBox cbHistoricoDebito;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbEventoDebito;
        private System.Windows.Forms.ComboBox cbUnidadeGestora;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.CheckBox ckTodosOrgaos;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dgPareados;
    }
}
