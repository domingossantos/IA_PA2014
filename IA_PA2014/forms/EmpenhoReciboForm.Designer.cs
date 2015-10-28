namespace IA_PA2015.forms
{
    partial class EmpenhoReciboForm
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lbNrContrato = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbAno = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbNrEmpenho = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgEmpenho = new System.Windows.Forms.DataGridView();
            this.txRecibo = new System.Windows.Forms.TextBox();
            this.btGravar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgEmpenho)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btGravar);
            this.panel1.Controls.Add(this.txRecibo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 328);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(747, 94);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.dgEmpenho);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(747, 328);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.lbNrContrato);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.lbAno);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.lbNrEmpenho);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(544, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(203, 328);
            this.panel3.TabIndex = 1;
            // 
            // lbNrContrato
            // 
            this.lbNrContrato.AutoSize = true;
            this.lbNrContrato.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNrContrato.Location = new System.Drawing.Point(15, 189);
            this.lbNrContrato.Name = "lbNrContrato";
            this.lbNrContrato.Size = new System.Drawing.Size(29, 31);
            this.lbNrContrato.TabIndex = 5;
            this.lbNrContrato.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 162);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "No. Contrato";
            // 
            // lbAno
            // 
            this.lbAno.AutoSize = true;
            this.lbAno.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAno.Location = new System.Drawing.Point(12, 112);
            this.lbAno.Name = "lbAno";
            this.lbAno.Size = new System.Drawing.Size(29, 31);
            this.lbAno.TabIndex = 3;
            this.lbAno.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ano";
            // 
            // lbNrEmpenho
            // 
            this.lbNrEmpenho.AutoSize = true;
            this.lbNrEmpenho.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNrEmpenho.Location = new System.Drawing.Point(9, 31);
            this.lbNrEmpenho.Name = "lbNrEmpenho";
            this.lbNrEmpenho.Size = new System.Drawing.Size(29, 31);
            this.lbNrEmpenho.TabIndex = 1;
            this.lbNrEmpenho.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Empenho";
            // 
            // dgEmpenho
            // 
            this.dgEmpenho.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgEmpenho.Dock = System.Windows.Forms.DockStyle.Left;
            this.dgEmpenho.Location = new System.Drawing.Point(0, 0);
            this.dgEmpenho.Name = "dgEmpenho";
            this.dgEmpenho.Size = new System.Drawing.Size(544, 328);
            this.dgEmpenho.TabIndex = 0;
            this.dgEmpenho.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgEmpenho_CellEnter);
            // 
            // txRecibo
            // 
            this.txRecibo.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txRecibo.Location = new System.Drawing.Point(12, 26);
            this.txRecibo.Name = "txRecibo";
            this.txRecibo.Size = new System.Drawing.Size(634, 53);
            this.txRecibo.TabIndex = 0;
            // 
            // btGravar
            // 
            this.btGravar.Location = new System.Drawing.Point(652, 26);
            this.btGravar.Name = "btGravar";
            this.btGravar.Size = new System.Drawing.Size(83, 53);
            this.btGravar.TabIndex = 1;
            this.btGravar.Text = "&Gravar";
            this.btGravar.UseVisualStyleBackColor = true;
            this.btGravar.Click += new System.EventHandler(this.btGravar_Click);
            // 
            // EmpenhoReciboForm
            // 
            this.ClientSize = new System.Drawing.Size(747, 422);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "EmpenhoReciboForm";
            this.Load += new System.EventHandler(this.EmpenhoReciboForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgEmpenho)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dgEmpenho;
        private System.Windows.Forms.Label lbNrContrato;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbAno;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbNrEmpenho;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btGravar;
        private System.Windows.Forms.TextBox txRecibo;

    }
}
