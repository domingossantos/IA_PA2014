namespace IA_PA2015.forms
{
    partial class OrdenadorForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrdenadorForm));
            this.cmbPessoa = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btSalva = new System.Windows.Forms.Button();
            this.btApaga = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lista = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lista)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbPessoa
            // 
            this.cmbPessoa.FormattingEnabled = true;
            this.cmbPessoa.Location = new System.Drawing.Point(12, 25);
            this.cmbPessoa.Name = "cmbPessoa";
            this.cmbPessoa.Size = new System.Drawing.Size(538, 21);
            this.cmbPessoa.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Pessoa";
            // 
            // btSalva
            // 
            this.btSalva.Image = ((System.Drawing.Image)(resources.GetObject("btSalva.Image")));
            this.btSalva.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btSalva.Location = new System.Drawing.Point(403, 50);
            this.btSalva.Name = "btSalva";
            this.btSalva.Size = new System.Drawing.Size(75, 30);
            this.btSalva.TabIndex = 2;
            this.btSalva.Text = "Salva";
            this.btSalva.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btSalva.UseVisualStyleBackColor = true;
            this.btSalva.Click += new System.EventHandler(this.btSalva_Click);
            // 
            // btApaga
            // 
            this.btApaga.Image = ((System.Drawing.Image)(resources.GetObject("btApaga.Image")));
            this.btApaga.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btApaga.Location = new System.Drawing.Point(484, 50);
            this.btApaga.Name = "btApaga";
            this.btApaga.Size = new System.Drawing.Size(75, 30);
            this.btApaga.TabIndex = 3;
            this.btApaga.Text = "Apaga";
            this.btApaga.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btApaga.UseVisualStyleBackColor = true;
            this.btApaga.Click += new System.EventHandler(this.btApaga_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btApaga);
            this.panel1.Controls.Add(this.btSalva);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.cmbPessoa);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(562, 86);
            this.panel1.TabIndex = 0;
            // 
            // lista
            // 
            this.lista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.lista.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lista.Location = new System.Drawing.Point(0, 86);
            this.lista.Name = "lista";
            this.lista.Size = new System.Drawing.Size(562, 206);
            this.lista.TabIndex = 1;
            // 
            // OrdenadorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 292);
            this.Controls.Add(this.lista);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "OrdenadorForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ordenador de Despesa";
            this.Load += new System.EventHandler(this.OrdenadorForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lista)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbPessoa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btSalva;
        private System.Windows.Forms.Button btApaga;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView lista;

    }
}