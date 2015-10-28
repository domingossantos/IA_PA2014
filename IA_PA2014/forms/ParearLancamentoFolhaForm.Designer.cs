namespace IA_PA2015.forms
{
    partial class ParearLancamentoFolhaForm
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
            this.gridConta = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbOrgao = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.btGrava = new System.Windows.Forms.Button();
            this.cbHistorico = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbEvento = new System.Windows.Forms.ComboBox();
            this.cbFornecedor = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbTipoLAncamentoPadrao = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gridConta)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridConta
            // 
            this.gridConta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridConta.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gridConta.Location = new System.Drawing.Point(0, 165);
            this.gridConta.Name = "gridConta";
            this.gridConta.Size = new System.Drawing.Size(887, 297);
            this.gridConta.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cbTipoLAncamentoPadrao);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.cbOrgao);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.btGrava);
            this.panel1.Controls.Add(this.cbHistorico);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.cbEvento);
            this.panel1.Controls.Add(this.cbFornecedor);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(887, 165);
            this.panel1.TabIndex = 1;
            // 
            // cbOrgao
            // 
            this.cbOrgao.FormattingEnabled = true;
            this.cbOrgao.Location = new System.Drawing.Point(325, 25);
            this.cbOrgao.Name = "cbOrgao";
            this.cbOrgao.Size = new System.Drawing.Size(234, 21);
            this.cbOrgao.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(322, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Órgão";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(99, 136);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 13;
            this.button2.Text = "Excluir";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btGrava
            // 
            this.btGrava.Location = new System.Drawing.Point(18, 136);
            this.btGrava.Name = "btGrava";
            this.btGrava.Size = new System.Drawing.Size(75, 23);
            this.btGrava.TabIndex = 12;
            this.btGrava.Text = "Gravar";
            this.btGrava.UseVisualStyleBackColor = true;
            this.btGrava.Click += new System.EventHandler(this.btGrava_Click);
            // 
            // cbHistorico
            // 
            this.cbHistorico.FormattingEnabled = true;
            this.cbHistorico.Location = new System.Drawing.Point(15, 109);
            this.cbHistorico.Name = "cbHistorico";
            this.cbHistorico.Size = new System.Drawing.Size(812, 21);
            this.cbHistorico.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Histórico Padrão";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Evento";
            // 
            // cbEvento
            // 
            this.cbEvento.FormattingEnabled = true;
            this.cbEvento.Location = new System.Drawing.Point(15, 69);
            this.cbEvento.Name = "cbEvento";
            this.cbEvento.Size = new System.Drawing.Size(812, 21);
            this.cbEvento.TabIndex = 8;
            this.cbEvento.DropDown += new System.EventHandler(this.cbEvento_DropDown);
            this.cbEvento.ValueMemberChanged += new System.EventHandler(this.cbEvento_ValueMemberChanged);
            // 
            // cbFornecedor
            // 
            this.cbFornecedor.FormattingEnabled = true;
            this.cbFornecedor.Location = new System.Drawing.Point(15, 25);
            this.cbFornecedor.Name = "cbFornecedor";
            this.cbFornecedor.Size = new System.Drawing.Size(292, 21);
            this.cbFornecedor.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Fornecedor";
            // 
            // cbTipoLAncamentoPadrao
            // 
            this.cbTipoLAncamentoPadrao.FormattingEnabled = true;
            this.cbTipoLAncamentoPadrao.Location = new System.Drawing.Point(571, 25);
            this.cbTipoLAncamentoPadrao.Name = "cbTipoLAncamentoPadrao";
            this.cbTipoLAncamentoPadrao.Size = new System.Drawing.Size(256, 21);
            this.cbTipoLAncamentoPadrao.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(568, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Lançamento Padrão";
            // 
            // ParearLancamentoFolhaForm
            // 
            this.ClientSize = new System.Drawing.Size(887, 462);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.gridConta);
            this.Name = "ParearLancamentoFolhaForm";
            this.Text = "Parear Contas Folha de Pagamento";
            this.Load += new System.EventHandler(this.ParearLancamentoFolhaForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridConta)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView gridConta;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cbFornecedor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbHistorico;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbEvento;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btGrava;
        private System.Windows.Forms.ComboBox cbOrgao;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbTipoLAncamentoPadrao;
        private System.Windows.Forms.Label label5;
    }
}
