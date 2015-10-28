namespace IA_PA2015
{
    partial class dbConfig
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
            this.pnlSQL = new System.Windows.Forms.Panel();
            this.btnCriarBanco = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbPPA = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbAux = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbCPC = new System.Windows.Forms.ComboBox();
            this.lblCPI = new System.Windows.Forms.Label();
            this.cmbCPI = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbCPE = new System.Windows.Forms.ComboBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnGravar = new System.Windows.Forms.Button();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.cmbInstance = new System.Windows.Forms.ComboBox();
            this.cmbServer = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txPrefixoFornecedor = new System.Windows.Forms.TextBox();
            this.pnlSQL.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlSQL
            // 
            this.pnlSQL.Controls.Add(this.txPrefixoFornecedor);
            this.pnlSQL.Controls.Add(this.label9);
            this.pnlSQL.Controls.Add(this.btnCriarBanco);
            this.pnlSQL.Controls.Add(this.label8);
            this.pnlSQL.Controls.Add(this.cmbPPA);
            this.pnlSQL.Controls.Add(this.label7);
            this.pnlSQL.Controls.Add(this.cmbAux);
            this.pnlSQL.Controls.Add(this.label5);
            this.pnlSQL.Controls.Add(this.cmbCPC);
            this.pnlSQL.Controls.Add(this.lblCPI);
            this.pnlSQL.Controls.Add(this.cmbCPI);
            this.pnlSQL.Controls.Add(this.label6);
            this.pnlSQL.Controls.Add(this.cmbCPE);
            this.pnlSQL.Controls.Add(this.lblTitle);
            this.pnlSQL.Controls.Add(this.label4);
            this.pnlSQL.Controls.Add(this.label3);
            this.pnlSQL.Controls.Add(this.label2);
            this.pnlSQL.Controls.Add(this.label1);
            this.pnlSQL.Controls.Add(this.btnGravar);
            this.pnlSQL.Controls.Add(this.txtPassword);
            this.pnlSQL.Controls.Add(this.txtUserName);
            this.pnlSQL.Controls.Add(this.cmbInstance);
            this.pnlSQL.Controls.Add(this.cmbServer);
            this.pnlSQL.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlSQL.Location = new System.Drawing.Point(0, 0);
            this.pnlSQL.Name = "pnlSQL";
            this.pnlSQL.Size = new System.Drawing.Size(478, 309);
            this.pnlSQL.TabIndex = 4;
            // 
            // btnCriarBanco
            // 
            this.btnCriarBanco.Location = new System.Drawing.Point(66, 269);
            this.btnCriarBanco.Margin = new System.Windows.Forms.Padding(2);
            this.btnCriarBanco.Name = "btnCriarBanco";
            this.btnCriarBanco.Size = new System.Drawing.Size(114, 29);
            this.btnCriarBanco.TabIndex = 20;
            this.btnCriarBanco.Text = "Criar Banco Auxiliar";
            this.btnCriarBanco.UseVisualStyleBackColor = true;
            this.btnCriarBanco.Click += new System.EventHandler(this.btnCriarBanco_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(29, 147);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(111, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "Banco de Dados PPA";
            // 
            // cmbPPA
            // 
            this.cmbPPA.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPPA.FormattingEnabled = true;
            this.cmbPPA.Location = new System.Drawing.Point(29, 163);
            this.cmbPPA.Name = "cmbPPA";
            this.cmbPPA.Size = new System.Drawing.Size(220, 21);
            this.cmbPPA.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(29, 227);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(139, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Banco de Dados AUXILIAR";
            // 
            // cmbAux
            // 
            this.cmbAux.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAux.FormattingEnabled = true;
            this.cmbAux.Location = new System.Drawing.Point(29, 243);
            this.cmbAux.Name = "cmbAux";
            this.cmbAux.Size = new System.Drawing.Size(220, 21);
            this.cmbAux.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 187);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Banco de Dados CPC";
            // 
            // cmbCPC
            // 
            this.cmbCPC.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCPC.FormattingEnabled = true;
            this.cmbCPC.Location = new System.Drawing.Point(29, 203);
            this.cmbCPC.Name = "cmbCPC";
            this.cmbCPC.Size = new System.Drawing.Size(220, 21);
            this.cmbCPC.TabIndex = 14;
            // 
            // lblCPI
            // 
            this.lblCPI.AutoSize = true;
            this.lblCPI.Location = new System.Drawing.Point(255, 187);
            this.lblCPI.Name = "lblCPI";
            this.lblCPI.Size = new System.Drawing.Size(107, 13);
            this.lblCPI.TabIndex = 13;
            this.lblCPI.Text = "Banco de Dados CPI";
            // 
            // cmbCPI
            // 
            this.cmbCPI.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCPI.FormattingEnabled = true;
            this.cmbCPI.Location = new System.Drawing.Point(255, 203);
            this.cmbCPI.Name = "cmbCPI";
            this.cmbCPI.Size = new System.Drawing.Size(220, 21);
            this.cmbCPI.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(255, 147);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(111, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Banco de Dados CPE";
            // 
            // cmbCPE
            // 
            this.cmbCPE.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCPE.FormattingEnabled = true;
            this.cmbCPE.Location = new System.Drawing.Point(255, 163);
            this.cmbCPE.Name = "cmbCPE";
            this.cmbCPE.Size = new System.Drawing.Size(220, 21);
            this.cmbCPE.TabIndex = 10;
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblTitle.Location = new System.Drawing.Point(3, 5);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(278, 23);
            this.lblTitle.TabIndex = 9;
            this.lblTitle.Text = "Configução Acesso a Banco";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(142, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Senha";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Usuário";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Instância";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Servidor";
            // 
            // btnGravar
            // 
            this.btnGravar.Location = new System.Drawing.Point(279, 270);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(114, 28);
            this.btnGravar.TabIndex = 4;
            this.btnGravar.Text = "Gravar";
            this.btnGravar.UseVisualStyleBackColor = true;
            this.btnGravar.Click += new System.EventHandler(this.btnGravar_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(142, 121);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(108, 20);
            this.txtPassword.TabIndex = 3;
            this.txtPassword.Leave += new System.EventHandler(this.txtPassword_Leave);
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(31, 121);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(104, 20);
            this.txtUserName.TabIndex = 2;
            // 
            // cmbInstance
            // 
            this.cmbInstance.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbInstance.FormattingEnabled = true;
            this.cmbInstance.Location = new System.Drawing.Point(31, 81);
            this.cmbInstance.Name = "cmbInstance";
            this.cmbInstance.Size = new System.Drawing.Size(218, 21);
            this.cmbInstance.TabIndex = 1;
            // 
            // cmbServer
            // 
            this.cmbServer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbServer.FormattingEnabled = true;
            this.cmbServer.Location = new System.Drawing.Point(32, 42);
            this.cmbServer.Name = "cmbServer";
            this.cmbServer.Size = new System.Drawing.Size(220, 21);
            this.cmbServer.TabIndex = 0;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(255, 227);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(96, 13);
            this.label9.TabIndex = 21;
            this.label9.Text = "Prefixo Fornecedor";
            // 
            // txPrefixoFornecedor
            // 
            this.txPrefixoFornecedor.Location = new System.Drawing.Point(255, 243);
            this.txPrefixoFornecedor.Name = "txPrefixoFornecedor";
            this.txPrefixoFornecedor.Size = new System.Drawing.Size(220, 20);
            this.txPrefixoFornecedor.TabIndex = 22;
            // 
            // dbConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 309);
            this.Controls.Add(this.pnlSQL);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "dbConfig";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Configuração de Acesso a Dados";
            this.Load += new System.EventHandler(this.dbConfig_Load);
            this.pnlSQL.ResumeLayout(false);
            this.pnlSQL.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlSQL;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbCPC;
        private System.Windows.Forms.Label lblCPI;
        private System.Windows.Forms.ComboBox cmbCPI;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbCPE;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGravar;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.ComboBox cmbInstance;
        private System.Windows.Forms.ComboBox cmbServer;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbAux;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmbPPA;
        private System.Windows.Forms.Button btnCriarBanco;
        private System.Windows.Forms.TextBox txPrefixoFornecedor;
        private System.Windows.Forms.Label label9;
    }
}