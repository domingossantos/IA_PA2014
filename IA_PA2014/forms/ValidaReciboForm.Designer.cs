namespace IA_PA2015.forms
{
    partial class ValidaReciboForm
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
            this.gridRecibo = new System.Windows.Forms.DataGridView();
            this.Empenho = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ano = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Valido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Recibo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reciboValidado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridRecibo)).BeginInit();
            this.SuspendLayout();
            // 
            // gridRecibo
            // 
            this.gridRecibo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridRecibo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Empenho,
            this.Ano,
            this.Valido,
            this.Recibo,
            this.reciboValidado});
            this.gridRecibo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridRecibo.Location = new System.Drawing.Point(0, 0);
            this.gridRecibo.Name = "gridRecibo";
            this.gridRecibo.Size = new System.Drawing.Size(717, 433);
            this.gridRecibo.TabIndex = 0;
            // 
            // Empenho
            // 
            this.Empenho.HeaderText = "Empenho";
            this.Empenho.Name = "Empenho";
            this.Empenho.ReadOnly = true;
            // 
            // Ano
            // 
            this.Ano.HeaderText = "Ano";
            this.Ano.Name = "Ano";
            this.Ano.ReadOnly = true;
            // 
            // Valido
            // 
            this.Valido.HeaderText = "Validação";
            this.Valido.Name = "Valido";
            this.Valido.ReadOnly = true;
            // 
            // Recibo
            // 
            this.Recibo.HeaderText = "Recibo Original";
            this.Recibo.Name = "Recibo";
            this.Recibo.ReadOnly = true;
            this.Recibo.Width = 320;
            // 
            // reciboValidado
            // 
            this.reciboValidado.HeaderText = "Recibo Validado";
            this.reciboValidado.Name = "reciboValidado";
            this.reciboValidado.ReadOnly = true;
            this.reciboValidado.Width = 320;
            // 
            // ValidaReciboForm
            // 
            this.ClientSize = new System.Drawing.Size(717, 433);
            this.Controls.Add(this.gridRecibo);
            this.Name = "ValidaReciboForm";
            this.Text = "Validação de Recibo Mural";
            this.Load += new System.EventHandler(this.ValidaReciboForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridRecibo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView gridRecibo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Empenho;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ano;
        private System.Windows.Forms.DataGridViewTextBoxColumn Valido;
        private System.Windows.Forms.DataGridViewTextBoxColumn Recibo;
        private System.Windows.Forms.DataGridViewTextBoxColumn reciboValidado;
    }
}
