using IA_PA2015.utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace IA_PA2015.forms
{
    public partial class FormBase : Form
    {
        public String path = System.AppDomain.CurrentDomain.BaseDirectory.ToString();
        public String arquivoConfig = @"\configdb.gov";
        public String nomeBD_PPA = "";
        public String nomeBD_CPC = "";
        public String nomeBD_CPE = "";
        public String nomeBD_CPI = "";
        public String nomeBD_AUX = "";
        public String strConecaoCPC = "";
        public String strConexaoCPE = "";
        public String strConexaoCPI = "";
        public String strConexaoAUX = "";
        public String codigosMovimentoReceita = "";
        public String prefixoFornecedor = "";

        public FormBase() { InitializeComponent(); }
        
        public bool lerArquivoConfig()
        {
            bool status = false;
            try
            {
                if (!File.Exists(path + arquivoConfig))
                {
                    MessageExcept.messageFacede("Não há arquivo de configuração.\nFavor criar antecipadamente este arquivo através da opção Configurar Banco.", 2);
                }
                else
                {

                    StreamReader arquivo = new StreamReader(path + arquivoConfig);
                    String linha = "";

                    while ((linha = arquivo.ReadLine()) != null)
                    {
                        if (linha.Substring(0, 6).Equals("CPC_sc"))
                        {
                            strConecaoCPC = linha.Substring(8, linha.Length - 8).Trim();
                        }

                        if (linha.Substring(0, 6).Equals("CPC_bd"))
                        {
                            nomeBD_CPC = linha.Substring(8, linha.Length - 8).Trim();
                        }

                        if (linha.Substring(0, 6).Equals("CPE_sc"))
                        {
                            strConexaoCPE = linha.Substring(8, linha.Length - 8).Trim();
                        }

                        if (linha.Substring(0, 6).Equals("CPE_bd"))
                        {
                            nomeBD_CPE = linha.Substring(8, linha.Length - 8).Trim();
                        }

                        if (linha.Substring(0, 6).Equals("CPI_sc"))
                        {
                            strConexaoCPI = linha.Substring(8, linha.Length - 8).Trim();
                        }

                        if (linha.Substring(0, 6).Equals("CPI_bd"))
                        {
                            nomeBD_CPI = linha.Substring(8, linha.Length - 8).Trim();
                        }

                        if (linha.Substring(0, 6).Equals("AUX_sc"))
                        {
                            strConexaoAUX = linha.Substring(8, linha.Length - 8).Trim();
                        }

                        if (linha.Substring(0, 6).Equals("AUX_bd"))
                        {
                            nomeBD_AUX = linha.Substring(8, linha.Length - 8).Trim();
                        }

                        if (linha.Substring(0, 6).Equals("PPA_bd"))
                        {
                            nomeBD_PPA = linha.Substring(8, linha.Length - 8).Trim();
                        }

                        if (linha.Substring(0, 6).Equals("MOV_CR"))
                        {
                            codigosMovimentoReceita = linha.Substring(8, linha.Length - 8).Trim();
                        }
                        
                        if (linha.Substring(0, 6).Equals("PREFOR"))
                        {
                            prefixoFornecedor = linha.Substring(8, linha.Length - 8).Trim();
                        }

                    }

                    arquivo.Dispose();
                    status = true;
                }

            }
            finally
            {
                
            }

            return status;
        }

       
    }
}
