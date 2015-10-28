using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;


namespace IA_PA2015
{
    public partial class dbConfig : Form
    {
        public string nomeArquivo;
        public string cod_bd;
        public string Linha;
        public bool Montou;
        public SqlConnection conn;
        string strPatch;
        public StreamWriter arquivo;
        public int unidade;
        public string strConn_CPC;

        public dbConfig(String pathDir)
        {
            strPatch = pathDir;
            InitializeComponent();
        }

        private void dbConfig_Load(object sender, EventArgs e)
        {
            if (!Directory.Exists(strPatch))
            {
                Directory.CreateDirectory(strPatch);
            }

            nomeArquivo = strPatch + @"\configdb.gov";

            if (File.Exists(nomeArquivo))
            {
                MessageBox.Show("Configuração já realizada!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
                pnlSQL.Visible = true;

                DataTable dt = new DataTable();

                SqlDataSourceEnumerator sqls = SqlDataSourceEnumerator.Instance;
                dt = sqls.GetDataSources();

                cmbServer.DataSource = dt;
                cmbServer.DisplayMember = "ServerName";

                cmbInstance.DataSource = dt;
                cmbInstance.DisplayMember = "InstanceName";

                cmbCPC.Focus();
            
        }

        private DataSet conectaInstancia()
        {
            string sSQL;
            string sConnString = string.Empty;

            sConnString = "Data Source=" + cmbServer.Text.Trim();
            if (cmbInstance.Text.Length > 0)
                sConnString = sConnString + "\\" + cmbInstance.Text.Trim();
            sConnString = sConnString + ";Initial Catalog=master;Integrated Security=True";

            sSQL = "SELECT distinct name FROM master.dbo.sysdatabases WHERE name NOT IN ('master','model','msdb','tempdb')";

            conn = new SqlConnection(sConnString);

            try
            {
                conn.Open();
            }
            catch (Exception err)
            {
                MessageBox.Show("Ocorreu um erro na conexão:/n" + err.Message);
                return null;
            }

            SqlCommand comm = new SqlCommand(sSQL, conn);

            SqlDataAdapter da = new SqlDataAdapter();

            DataSet ds = new DataSet();

            da.SelectCommand = comm;
            da.Fill(ds);

            conn.Close();

            return ds;
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            arquivo = new StreamWriter(nomeArquivo);

            String dataSourceParte0 = cmbServer.Text;
            if(!cmbInstance.Text.Equals("")){
                dataSourceParte0 += "\\" + cmbInstance.Text;
            }
            String dataSourceParte1 = "Data Source="+dataSourceParte0+";Initial Catalog=";
            String dataSourceParte2 = ";Persist Security Info=True;User ID=" + txtUserName.Text.Trim();
            dataSourceParte2 += ";Password=" + txtPassword.Text.Trim();


            // CPC String de Conexao
            Linha = "CPC_sc: "+dataSourceParte1 + cmbCPC.Text.Trim() + dataSourceParte2;
            arquivo.WriteLine(Linha);
            Linha = "CPC_bd: " + cmbCPC.Text.Trim();
            arquivo.WriteLine(Linha);

            // CPE String de Conexao
            Linha = "CPE_sc: " + dataSourceParte1 + cmbCPE.Text.Trim() + dataSourceParte2;
            arquivo.WriteLine(Linha);
            Linha = "CPE_bd: " + cmbCPE.Text.Trim();
            arquivo.WriteLine(Linha);

            // CPI String de Conexao
            Linha = "CPI_sc: " + dataSourceParte1 + cmbCPI.Text.Trim() + dataSourceParte2;
            arquivo.WriteLine(Linha);
            Linha = "CPI_bd: " + cmbCPI.Text.Trim();
            arquivo.WriteLine(Linha);

            // AUX String de Conexao
            Linha = "AUX_sc: " + dataSourceParte1 + cmbAux.Text.Trim() + dataSourceParte2;
            arquivo.WriteLine(Linha);
            Linha = "AUX_bd: " + cmbAux.Text.Trim();
            arquivo.WriteLine(Linha);

            // PPA String de Conexao
            Linha = "PPA_sc: " + dataSourceParte1 + cmbPPA.Text.Trim() + dataSourceParte2;
            arquivo.WriteLine(Linha);
            Linha = "PPA_bd: " + cmbPPA.Text.Trim();
            arquivo.WriteLine(Linha);

            Linha = "MOV_CR: 461, 462, 465";
            arquivo.WriteLine(Linha);

            Linha = "PREFOR: " + txPrefixoFornecedor.Text.ToUpper();
            arquivo.WriteLine(Linha);

            arquivo.Close();
            this.Close();
        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            atualizaListaBancos();

        }

        private void atualizaListaBancos() {
            cmbCPC.DataSource = conectaInstancia().Tables[0];
            cmbCPC.DisplayMember = "name";

            cmbCPE.DataSource = conectaInstancia().Tables[0];
            cmbCPE.DisplayMember = "name";

            cmbCPI.DataSource = conectaInstancia().Tables[0];
            cmbCPI.DisplayMember = "name";

            cmbAux.DataSource = conectaInstancia().Tables[0];
            cmbAux.DisplayMember = "name";

            cmbPPA.DataSource = conectaInstancia().Tables[0];
            cmbPPA.DisplayMember = "name";
        }

        private void btnCriarBanco_Click(object sender, EventArgs e)
        {
            try
            {
                string nomeBanco = (Microsoft.VisualBasic.Interaction.InputBox("Nome do banco de dados Auxiliar", "AI PA", "0", 150, 150));

                if(nomeBanco != ""){

                    Linha = "Data Source=" + cmbServer.Text.Trim();
                    if (cmbInstance.Text.Length > 0)
                        Linha = Linha + "\\" + cmbInstance.Text.Trim();
                    Linha = Linha + ";Initial Catalog=" + cmbCPC.Text.Trim();
                    Linha = Linha + ";Persist Security Info=True;User ID=" + txtUserName.Text.Trim();
                    Linha = Linha + ";Password=" + txtPassword.Text.Trim();

                    conn = new SqlConnection(Linha);

                    conn.Open();

                    String sqlCreate = "create database "+nomeBanco;
 
                    SqlCommand cmd = new SqlCommand(sqlCreate,conn);
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("Banco Auxiliar Criado","Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    atualizaListaBancos();
                } else {
                    MessageBox.Show("Voce deve informar o nome do bando de dados Auxiliar", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex) {
                MessageBox.Show("Erro ao criar banco auxiliar\n" + ex.Message, "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
