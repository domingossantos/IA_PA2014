namespace IA_PA2014.forms
{
    partial class DuplicarPadraoForm
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
            this.grid = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.cbLancamento = new System.Windows.Forms.ComboBox();
            this.txContaCredito = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txContaDebito = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnExclui = new System.Windows.Forms.Button();
            this.btnGrava = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnExclui);
            this.panel1.Controls.Add(this.btnGrava);
            this.panel1.Controls.Add(this.txContaCredito);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txContaDebito);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.cbLancamento);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(485, 118);
            this.panel1.TabIndex = 0;
            // 
            // grid
            // 
            this.grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grid.Location = new System.Drawing.Point(0, 118);
            this.grid.Name = "grid";
            this.grid.Size = new System.Drawing.Size(485, 268);
            this.grid.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Lançamento Padrão";
            // 
            // cbLancamento
            // 
            this.cbLancamento.FormattingEnabled = true;
            this.cbLancamento.Location = new System.Drawing.Point(12, 25);
            this.cbLancamento.Name = "cbLancamento";
            this.cbLancamento.Size = new System.Drawing.Size(389, 21);
            this.cbLancamento.TabIndex = 1;
            // 
            // txContaCredito
            // 
            this.txContaCredito.Location = new System.Drawing.Point(221, 65);
            this.txContaCredito.Name = "txContaCredito";
            this.txContaCredito.Size = new System.Drawing.Size(180, 20);
            this.txContaCredito.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(218, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Conta Crédito";
            // 
            // txContaDebito
            // 
            this.txContaDebito.Location = new System.Drawing.Point(12, 65);
            this.txContaDebito.Name = "txContaDebito";
            this.txContaDebito.Size = new System.Drawing.Size(180, 20);
            this.txContaDebito.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Conta Debito";
            // 
            // btnExclui
            // 
            this.btnExclui.Location = new System.Drawing.Point(117, 91);
            this.btnExclui.Name = "btnExclui";
            this.btnExclui.Size = new System.Drawing.Size(75, 23);
            this.btnExclui.TabIndex = 9;
            this.btnExclui.Text = "Excluir";
            this.btnExclui.UseVisualStyleBackColor = true;
            this.btnExclui.Click += new System.EventHandler(this.btnExclui_Click);
            // 
            // btnGrava
            // 
            this.btnGrava.Location = new System.Drawing.Point(12, 91);
            this.btnGrava.Name = "btnGrava";
            this.btnGrava.Size = new System.Drawing.Size(75, 23);
            this.btnGrava.TabIndex = 8;
            this.btnGrava.Text = "Gravar";
            this.btnGrava.UseVisualStyleBackColor = true;
            this.btnGrava.Click += new System.EventHandler(this.btnGrava_Click);
            // 
            // DuplicarPadraoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(485, 386);
            this.Controls.Add(this.grid);
            this.Controls.Add(this.panel1);
            this.Name = "DuplicarPadraoForm";
            this.Text = "Duplicar Lançamento Padrão";
            this.Load += new System.EventHandler(this.DuplicarPadraoForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView grid;
        private System.Windows.Forms.ComboBox cbLancamento;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txContaCredito;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txContaDebito;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnExclui;
        private System.Windows.Forms.Button btnGrava;
    }
}