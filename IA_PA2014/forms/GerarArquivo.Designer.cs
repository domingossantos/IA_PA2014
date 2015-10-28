namespace IA_PA2015.forms
{
    partial class GerarArquivo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GerarArquivo));
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbRetificar = new System.Windows.Forms.CheckBox();
            this.txVersaoTCM = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.rbLegislativo = new System.Windows.Forms.RadioButton();
            this.rbExecutivo = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.cbTipoArquivo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btGerarArquivo = new System.Windows.Forms.Button();
            this.barraProgresso = new System.Windows.Forms.ProgressBar();
            this.panel3 = new System.Windows.Forms.Panel();
            this.cbUnidadeGestora = new System.Windows.Forms.ComboBox();
            this.cmbEsferaOrc = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txCNPJResponsavel = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txNome = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txCNPJ = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cmbTipoAdm = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtCodUnidade = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txCodigoMunicipio = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txAno = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cbRetificar);
            this.panel1.Controls.Add(this.txVersaoTCM);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.rbLegislativo);
            this.panel1.Controls.Add(this.rbExecutivo);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.cbTipoArquivo);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(626, 57);
            this.panel1.TabIndex = 0;
            // 
            // cbRetificar
            // 
            this.cbRetificar.AutoSize = true;
            this.cbRetificar.Location = new System.Drawing.Point(501, 27);
            this.cbRetificar.Name = "cbRetificar";
            this.cbRetificar.Size = new System.Drawing.Size(83, 17);
            this.cbRetificar.TabIndex = 7;
            this.cbRetificar.Text = "Retificadora";
            this.cbRetificar.UseVisualStyleBackColor = true;
            // 
            // txVersaoTCM
            // 
            this.txVersaoTCM.Location = new System.Drawing.Point(360, 26);
            this.txVersaoTCM.MaxLength = 9;
            this.txVersaoTCM.Name = "txVersaoTCM";
            this.txVersaoTCM.Size = new System.Drawing.Size(100, 20);
            this.txVersaoTCM.TabIndex = 6;
            this.txVersaoTCM.Text = "BAL201500";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(357, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Versão do Arquivo TCM";
            // 
            // rbLegislativo
            // 
            this.rbLegislativo.AutoSize = true;
            this.rbLegislativo.Location = new System.Drawing.Point(261, 27);
            this.rbLegislativo.Name = "rbLegislativo";
            this.rbLegislativo.Size = new System.Drawing.Size(75, 17);
            this.rbLegislativo.TabIndex = 4;
            this.rbLegislativo.Text = "Legislativo";
            this.rbLegislativo.UseVisualStyleBackColor = true;
            // 
            // rbExecutivo
            // 
            this.rbExecutivo.AutoSize = true;
            this.rbExecutivo.Checked = true;
            this.rbExecutivo.Location = new System.Drawing.Point(183, 27);
            this.rbExecutivo.Name = "rbExecutivo";
            this.rbExecutivo.Size = new System.Drawing.Size(72, 17);
            this.rbExecutivo.TabIndex = 3;
            this.rbExecutivo.TabStop = true;
            this.rbExecutivo.Text = "Executivo";
            this.rbExecutivo.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(180, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Esfera de Poder";
            // 
            // cbTipoArquivo
            // 
            this.cbTipoArquivo.FormattingEnabled = true;
            this.cbTipoArquivo.Items.AddRange(new object[] {
            "901 - LOA",
            "902 - LDO",
            "903 - PPA ",
            "999 - Balanço Geral",
            "401 - 1o. Quadrimestre",
            "402 - 2o. Quadrimestre",
            "403 - 3o. Quadrimestre"});
            this.cbTipoArquivo.Location = new System.Drawing.Point(15, 25);
            this.cbTipoArquivo.Name = "cbTipoArquivo";
            this.cbTipoArquivo.Size = new System.Drawing.Size(149, 21);
            this.cbTipoArquivo.TabIndex = 1;
            this.cbTipoArquivo.SelectedValueChanged += new System.EventHandler(this.cbTipoArquivo_SelectedValueChanged);
            this.cbTipoArquivo.Leave += new System.EventHandler(this.cbTipoArquivo_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tipo de Arquivo";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btGerarArquivo);
            this.panel2.Controls.Add(this.barraProgresso);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 410);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(626, 42);
            this.panel2.TabIndex = 1;
            // 
            // btGerarArquivo
            // 
            this.btGerarArquivo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btGerarArquivo.Image = ((System.Drawing.Image)(resources.GetObject("btGerarArquivo.Image")));
            this.btGerarArquivo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btGerarArquivo.Location = new System.Drawing.Point(493, 6);
            this.btGerarArquivo.Name = "btGerarArquivo";
            this.btGerarArquivo.Size = new System.Drawing.Size(128, 32);
            this.btGerarArquivo.TabIndex = 1;
            this.btGerarArquivo.Text = "Gerar Arquivo";
            this.btGerarArquivo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btGerarArquivo.UseVisualStyleBackColor = true;
            this.btGerarArquivo.Click += new System.EventHandler(this.btGerarArquivo_Click);
            // 
            // barraProgresso
            // 
            this.barraProgresso.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.barraProgresso.Location = new System.Drawing.Point(3, 7);
            this.barraProgresso.Name = "barraProgresso";
            this.barraProgresso.Size = new System.Drawing.Size(484, 32);
            this.barraProgresso.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.cbUnidadeGestora);
            this.panel3.Controls.Add(this.cmbEsferaOrc);
            this.panel3.Controls.Add(this.label13);
            this.panel3.Controls.Add(this.label12);
            this.panel3.Controls.Add(this.groupBox1);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.cmbTipoAdm);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.txtCodUnidade);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.txCodigoMunicipio);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.txAno);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 57);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(626, 353);
            this.panel3.TabIndex = 2;
            // 
            // cbUnidadeGestora
            // 
            this.cbUnidadeGestora.FormattingEnabled = true;
            this.cbUnidadeGestora.Location = new System.Drawing.Point(167, 124);
            this.cbUnidadeGestora.Name = "cbUnidadeGestora";
            this.cbUnidadeGestora.Size = new System.Drawing.Size(273, 21);
            this.cbUnidadeGestora.TabIndex = 31;
            // 
            // cmbEsferaOrc
            // 
            this.cmbEsferaOrc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEsferaOrc.FormattingEnabled = true;
            this.cmbEsferaOrc.Items.AddRange(new object[] {
            "10 - Orçamento Fiscal",
            "20 - Seguridade Social",
            "30 - Investimento"});
            this.cmbEsferaOrc.Location = new System.Drawing.Point(168, 195);
            this.cmbEsferaOrc.Name = "cmbEsferaOrc";
            this.cmbEsferaOrc.Size = new System.Drawing.Size(177, 21);
            this.cmbEsferaOrc.TabIndex = 29;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(29, 198);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(106, 13);
            this.label13.TabIndex = 30;
            this.label13.Text = "Esfera Orçamentária:";
            // 
            // label12
            // 
            this.label12.Location = new System.Drawing.Point(19, 236);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(120, 100);
            this.label12.TabIndex = 28;
            this.label12.Text = "As Informações do Credor são necessárias para completar os dados da geração em re" +
    "gistro que não possuem esta informação";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txCNPJResponsavel);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.txNome);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.txCNPJ);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Location = new System.Drawing.Point(167, 236);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(452, 100);
            this.groupBox1.TabIndex = 27;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informações do Credor";
            // 
            // txCNPJResponsavel
            // 
            this.txCNPJResponsavel.Location = new System.Drawing.Point(119, 65);
            this.txCNPJResponsavel.Name = "txCNPJResponsavel";
            this.txCNPJResponsavel.Size = new System.Drawing.Size(100, 20);
            this.txCNPJResponsavel.TabIndex = 6;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(10, 68);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(102, 13);
            this.label14.TabIndex = 5;
            this.label14.Text = "CNPJ Responsável:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(234, 16);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(110, 13);
            this.label11.TabIndex = 4;
            this.label11.Text = "Sem pontos ou traços";
            // 
            // txNome
            // 
            this.txNome.Location = new System.Drawing.Point(119, 39);
            this.txNome.MaxLength = 100;
            this.txNome.Name = "txNome";
            this.txNome.Size = new System.Drawing.Size(306, 20);
            this.txNome.TabIndex = 3;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(74, 39);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(38, 13);
            this.label10.TabIndex = 2;
            this.label10.Text = "Nome:";
            // 
            // txCNPJ
            // 
            this.txCNPJ.Location = new System.Drawing.Point(119, 13);
            this.txCNPJ.MaxLength = 14;
            this.txCNPJ.Name = "txCNPJ";
            this.txCNPJ.Size = new System.Drawing.Size(100, 20);
            this.txCNPJ.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(74, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "CNPJ:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(54, 127);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(90, 13);
            this.label9.TabIndex = 26;
            this.label9.Text = "Unidade Gestora:";
            // 
            // cmbTipoAdm
            // 
            this.cmbTipoAdm.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoAdm.FormattingEnabled = true;
            this.cmbTipoAdm.Items.AddRange(new object[] {
            "1 - Adm. Direta",
            "2 - Adm. Indireta",
            "9 - Não Especificado"});
            this.cmbTipoAdm.Location = new System.Drawing.Point(168, 159);
            this.cmbTipoAdm.Name = "cmbTipoAdm";
            this.cmbTipoAdm.Size = new System.Drawing.Size(177, 21);
            this.cmbTipoAdm.TabIndex = 23;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(40, 162);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 13);
            this.label8.TabIndex = 25;
            this.label8.Text = "Tipo Administração:";
            // 
            // txtCodUnidade
            // 
            this.txtCodUnidade.Location = new System.Drawing.Point(168, 92);
            this.txtCodUnidade.MaxLength = 10;
            this.txtCodUnidade.Name = "txtCodUnidade";
            this.txtCodUnidade.Size = new System.Drawing.Size(78, 20);
            this.txtCodUnidade.TabIndex = 21;
            this.txtCodUnidade.Text = "008001";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(42, 95);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 13);
            this.label6.TabIndex = 24;
            this.label6.Text = "Código da Unidade:";
            // 
            // txCodigoMunicipio
            // 
            this.txCodigoMunicipio.Location = new System.Drawing.Point(167, 55);
            this.txCodigoMunicipio.MaxLength = 8;
            this.txCodigoMunicipio.Name = "txCodigoMunicipio";
            this.txCodigoMunicipio.Size = new System.Drawing.Size(79, 20);
            this.txCodigoMunicipio.TabIndex = 3;
            this.txCodigoMunicipio.Text = "150080";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(42, 55);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Código do Município:";
            // 
            // txAno
            // 
            this.txAno.Location = new System.Drawing.Point(167, 16);
            this.txAno.MaxLength = 4;
            this.txAno.Name = "txAno";
            this.txAno.Size = new System.Drawing.Size(48, 20);
            this.txAno.TabIndex = 1;
            this.txAno.Text = "2015";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(45, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Ano Processamento:";
            // 
            // GerarArquivo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(626, 452);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "GerarArquivo";
            this.Text = "Gerar Arquivo";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.GerarArquivo_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btGerarArquivo;
        private System.Windows.Forms.ProgressBar barraProgresso;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ComboBox cbTipoArquivo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txVersaoTCM;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton rbLegislativo;
        private System.Windows.Forms.RadioButton rbExecutivo;
        private System.Windows.Forms.TextBox txCodigoMunicipio;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txAno;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cmbTipoAdm;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtCodUnidade;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txNome;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txCNPJ;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox cbRetificar;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cmbEsferaOrc;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txCNPJResponsavel;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox cbUnidadeGestora;
    }
}