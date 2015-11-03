namespace IA_PA2014.forms
{
    partial class ContaAContaForm
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
            this.gridContas = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txContaPC = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txContaTC = new System.Windows.Forms.TextBox();
            this.btnGrava = new System.Windows.Forms.Button();
            this.btnExclui = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridContas)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnExclui);
            this.panel1.Controls.Add(this.btnGrava);
            this.panel1.Controls.Add(this.txContaTC);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txContaPC);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(539, 94);
            this.panel1.TabIndex = 0;
            // 
            // gridContas
            // 
            this.gridContas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridContas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridContas.Location = new System.Drawing.Point(0, 94);
            this.gridContas.Name = "gridContas";
            this.gridContas.Size = new System.Drawing.Size(539, 341);
            this.gridContas.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Conta PC";
            // 
            // txContaPC
            // 
            this.txContaPC.Location = new System.Drawing.Point(15, 25);
            this.txContaPC.Name = "txContaPC";
            this.txContaPC.Size = new System.Drawing.Size(180, 20);
            this.txContaPC.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(218, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Conta TCM";
            // 
            // txContaTC
            // 
            this.txContaTC.Location = new System.Drawing.Point(221, 25);
            this.txContaTC.Name = "txContaTC";
            this.txContaTC.Size = new System.Drawing.Size(180, 20);
            this.txContaTC.TabIndex = 3;
            // 
            // btnGrava
            // 
            this.btnGrava.Location = new System.Drawing.Point(15, 51);
            this.btnGrava.Name = "btnGrava";
            this.btnGrava.Size = new System.Drawing.Size(75, 23);
            this.btnGrava.TabIndex = 4;
            this.btnGrava.Text = "Gravar";
            this.btnGrava.UseVisualStyleBackColor = true;
            this.btnGrava.Click += new System.EventHandler(this.btnGrava_Click);
            // 
            // btnExclui
            // 
            this.btnExclui.Location = new System.Drawing.Point(120, 51);
            this.btnExclui.Name = "btnExclui";
            this.btnExclui.Size = new System.Drawing.Size(75, 23);
            this.btnExclui.TabIndex = 5;
            this.btnExclui.Text = "Excluir";
            this.btnExclui.UseVisualStyleBackColor = true;
            this.btnExclui.Click += new System.EventHandler(this.btnExclui_Click);
            // 
            // ContaAContaForm
            // 
            this.ClientSize = new System.Drawing.Size(539, 435);
            this.Controls.Add(this.gridContas);
            this.Controls.Add(this.panel1);
            this.Name = "ContaAContaForm";
            this.Text = "Parear Conta PC a Conta TC";
            this.Load += new System.EventHandler(this.ContaAContaForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridContas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnExclui;
        private System.Windows.Forms.Button btnGrava;
        private System.Windows.Forms.TextBox txContaTC;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txContaPC;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView gridContas;
    }
}
