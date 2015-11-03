using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using IA_PA2015.utils;

namespace IA_PA2015.forms
{
    public partial class GerarArquivo : FormBase
    {
        String path;
        String arquivoConfig = @"\configdb.gov";
        String nomeBD_PPA = "";
        String nomeBD_CPC = "";
        String nomeBD_CPE = "";
        String nomeBD_AUX = "";
        String strConecaoCPC = "";
        String strConexaoCPE = "";
        String strConexaoCPI = "";
        String strConexaoAUX = "";
        String codigosMovimentoReceita = "";

        modelo.Contabilidade contabilidade;
        
        public GerarArquivo(String _path)
        {
            path = _path;
            InitializeComponent();
        }

        private void lerArquivoConfig() {
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

                    }

                }

            }
            finally
            {

            }
        }
        
        private String getTipoArquivo() {
            try
            {
                String retorno = "";

                if (!cbTipoArquivo.Text.Equals(""))
                {
                    retorno = cbTipoArquivo.Text.Substring(0, 3);
                }

                return retorno;
            }
            finally { 
                
            }
        }

        private void setVisibilidadeCampos() {
            /*
            if (getTipoArquivo().Equals("901") || getTipoArquivo().Equals("902") || getTipoArquivo().Equals("903"))
            {
                txUnidadeGestora.Enabled = false;
                cmbEsferaOrc.Enabled = false;
                cmbTipoAdm.Enabled = false;
            }
            else {
                txUnidadeGestora.Enabled = true;
                cmbEsferaOrc.Enabled = true;
                cmbTipoAdm.Enabled = true;
            }
            */
        }

        private String getTipoEsfera() {
            String esfera = "1";

            if (rbLegislativo.Checked) {
                esfera = "2";
            }

            return esfera;
        }

        private void cbTipoArquivo_Leave(object sender, EventArgs e)
        {
            setVisibilidadeCampos();
            
        }

        private void cbTipoArquivo_SelectedValueChanged(object sender, EventArgs e)
        {
            setVisibilidadeCampos();
        }

        private void btGerarArquivo_Click(object sender, EventArgs e)
        {
            //try
            //{
                if (txAno.Text.Equals(""))
                {
                    MessageBox.Show("Informe Ano de Processamento!");
                    txAno.Focus();
                    return;
                }

                if (txCodigoMunicipio.Text.Equals(""))
                {
                    MessageBox.Show("Informe Código do Município!");
                    txCodigoMunicipio.Focus();
                    return;
                }

                if (txtCodUnidade.Text.Equals(""))
                {
                    MessageBox.Show("Informe Código da Unidade!");
                    txtCodUnidade.Focus();
                    return;
                }




                #region Criação do arquivo

                // Variáveis de apoio
                String pathGerarArquivo = path + @"\ArquivosGerados";
                String nomeArquivo = @"\IA-PA" + txAno.Text + FuncoesUteis.preencher(cbUnidadeGestora.SelectedValue.ToString(),"0",0,3)
                                     + txCodigoMunicipio.Text + "-"
                                     + getTipoArquivo()
                                     + "-" + Convert.ToDateTime(DateTime.Now.ToString()).ToString("ddMMyyyy") + ".txt";

                String nomeArquivoApoio = @"\IA-PA-APOI-" + txAno.Text + FuncoesUteis.preencher(cbUnidadeGestora.SelectedValue.ToString(), "0", 0, 3)
                                     + txCodigoMunicipio.Text + "-"
                                     + getTipoArquivo()
                                     + "-" + Convert.ToDateTime(DateTime.Now.ToString()).ToString("ddMMyyyy") + ".txt";
                

                String linha = "";
                Int16 contador = 0;


                // Verifica a existencia do diretorio TXT
                
                if (!Directory.Exists(pathGerarArquivo))
                {
                    Directory.CreateDirectory(pathGerarArquivo);
                }


                StreamWriter arquivo = new StreamWriter(pathGerarArquivo + nomeArquivo);
                StreamWriter arquivoApoio = new StreamWriter(pathGerarArquivo + nomeArquivoApoio);


                #endregion

                #region Header do arquivo

                linha = "000"
                        + FuncoesUteis.preencher(contador.ToString(), "0", 0, 10)
                        + " "
                        + txAno.Text
                        + txCodigoMunicipio.Text
                        + getTipoEsfera()
                        + " "
                        + txVersaoTCM.Text
                        + getTipoArquivo()
                        + DateTime.Now.Day.ToString().PadLeft(2, '0') + DateTime.Now.Month.ToString().PadLeft(2, '0') + DateTime.Now.Year.ToString()
                        + FuncoesUteis.preencher(" ", " ", 0, 20) // Codigo da declaração
                        + FuncoesUteis.preencher(" ", " ", 0, 20) // Codigo da declaração a retificar
                        + FuncoesUteis.preencher(txCNPJResponsavel.Text, "0", 0, 14) // CNPJ do orgao responsável pela declaração
                        + FuncoesUteis.preencher(" ", " ", 0, 100)
                        + FuncoesUteis.preencher(" ", " ", 0, 999)
                        +"*";
                arquivo.WriteLine(linha);
                
                #endregion

                #region Ordenador/Contador

                DataTable dados = contabilidade.getOrdenadores(nomeBD_AUX, nomeBD_CPC);

                String cpfContador = "";
                String cpfOrdenador = "";

                barraProgresso.Maximum = dados.Rows.Count;
                barraProgresso.Value = 1;
                foreach (DataRow linhaDados in dados.Rows) {
                    contador++;
                    linha = "";

                    if (linhaDados["tpIdentificadorPessoa"].ToString().Equals("1")) { 
                        cpfOrdenador = FuncoesUteis.converteCPFToString(linhaDados["nrCpf"].ToString());
                    } else {
                        cpfContador = FuncoesUteis.converteCPFToString(linhaDados["nrCpf"].ToString());
                    }

                    linha += "010";
                    linha += FuncoesUteis.preencher(contador.ToString(),"0",0,10);
                    linha += " ";
                    linha += getTipoEsfera();
                    linha += FuncoesUteis.preencher(txtCodUnidade.Text, "0", 0, 10);
                    linha += FuncoesUteis.preencher(FuncoesUteis.converteCPFToString(linhaDados["nrCpf"].ToString()),"0",0,11);
                    linha += getIntervaloOrdenador(getTipoArquivo());
                    linha += FuncoesUteis.preencher(linhaDados["tpIdentificadorPessoa"].ToString(),"0",0,1);
                    linha += FuncoesUteis.preencher(FuncoesUteis.removeAlfa(linhaDados["nmPessoa"].ToString()), " ", 1, 50);
                    linha += FuncoesUteis.preencher(FuncoesUteis.removeAlfa(linhaDados["dsCargo"].ToString()), " ", 1, 30);
                    linha += FuncoesUteis.preencher(linhaDados["nrIdentidade"].ToString(), "0", 0, 20);
                    linha += FuncoesUteis.preencher(FuncoesUteis.removeAlfa(linhaDados["nmOrgaoEmissor"].ToString()), " ", 1, 20);
                    linha += Convert.ToDateTime(linhaDados["dtEmissaoIdentidade"].ToString()).ToString("ddMMyyyy");
                    linha += FuncoesUteis.preencher(FuncoesUteis.removeAlfa(linhaDados["dsEndereco"].ToString()), " ", 1, 50);
                    linha += FuncoesUteis.preencher(FuncoesUteis.removeAlfa(linhaDados["dsBairro"].ToString()), " ", 1, 20);
                    linha += FuncoesUteis.preencher(FuncoesUteis.removeAlfa(linhaDados["dsCidade"].ToString()), " ", 1, 20);
                    linha += FuncoesUteis.preencher(linhaDados["cdCEP"].ToString(), "0", 0, 8);
                    linha += FuncoesUteis.preencher(linhaDados["sgUF"].ToString(), " ", 1, 2);
                    linha += FuncoesUteis.preencher(linhaDados["nrTelefoneResidencial"].ToString(), "0", 0, 10);
                    linha += FuncoesUteis.preencher(linhaDados["nrTelefoneComercial"].ToString(), "0", 0, 10);
                    linha += FuncoesUteis.preencher(linhaDados["nrTelefoneCelular"].ToString(), "0", 0, 10);
                    linha += FuncoesUteis.preencher(linhaDados["dsEnderecoEletronico"].ToString(), " ", 1, 100);
                    linha += FuncoesUteis.preencher(" ", " ", 1, 788);
                    linha += "*";

                    arquivo.WriteLine(linha);
                    barraProgresso.Value = contador;
                }


                #endregion

                #region Fonte de Recursos

                dados = contabilidade.getFonteRecurso(nomeBD_CPC);
                barraProgresso.Value = 0;
                barraProgresso.Maximum = dados.Rows.Count;
                int contaProgresso = 0;
                foreach (DataRow linhaDados in dados.Rows)
                {
                    contador++;
                    linha = "";
                    linha += "020";
                    linha += FuncoesUteis.preencher(contador.ToString(),"0",0,10);
                    linha += " ";
                    linha += getTipoEsfera();
                    linha += FuncoesUteis.preencher(txtCodUnidade.Text, "0", 0, 10);
                    linha += FuncoesUteis.preencher(linhaDados["cdFonteRecurso"].ToString(), "0", 1, 10);
                    linha += FuncoesUteis.preencher(FuncoesUteis.removeAlfa(linhaDados["dsFonteRecurso"].ToString()).ToUpper(), " ", 1, 60);
                    linha += FuncoesUteis.preencher(" ", " ", 0, 1104);
                    linha += "*";

                    arquivo.WriteLine(linha);
                    contaProgresso++;
                    barraProgresso.Value = contaProgresso;
                }
                #endregion


                #region Movimento
                // Tipo SQL
                int tipo = 0;
                if (getTipoArquivo() == "901" || getTipoArquivo() == "902" || getTipoArquivo() == "903") {
                    tipo = 1;
                }

                dados = contabilidade.getMovimento(nomeBD_AUX
                                        , tipo
                                        , FuncoesUteis.getMesInicio(getTipoArquivo())
                                        , FuncoesUteis.getMesFim(getTipoArquivo())
                                        , cbUnidadeGestora.SelectedValue.ToString()
                                        , nomeBD_PPA,nomeBD_CPC,nomeBD_CPE);

                
                String contaContabil = "";
                String naturezaReceitaDespesa = "";

                String linhaApoio = "";
          
                int seqMovimento = 0;
                
                barraProgresso.Value = 0;
                barraProgresso.Maximum = dados.Rows.Count;
                foreach(DataRow rowMov in dados.Rows){
                    contaContabil = rowMov["cdNivelContabil"].ToString();

                    if (seqMovimento > 46) {
                        naturezaReceitaDespesa = "";
                    }


                   

                    linha = "";
                    linhaApoio = "";
                    
                    seqMovimento++;


                    linhaApoio = FuncoesUteis.preencher(Convert.ToString(contador), "0", 0, 10);
                    linhaApoio += contaContabil;
                    linhaApoio += FuncoesUteis.preencher(rowMov["idLancamento"].ToString(), "0", 0, 6);
                    linhaApoio += FuncoesUteis.preencher(rowMov["nrAnoLancamento"].ToString(), "0", 0, 6);
                    
                    
                    
                    linha = "";
                    linha += "100";
                    linha += FuncoesUteis.preencher(Convert.ToString(contador), "0", 0, 10);
                    linha += " ";
                    linha += FuncoesUteis.preencher(getTipoEsfera(), "0", 0, 1);
                    linha += FuncoesUteis.preencher(txtCodUnidade.Text, "0", 0, 10);
                    linha += FuncoesUteis.preencher(Convert.ToString(seqMovimento), "0", 0, 10);
                    linha += Convert.ToDateTime(rowMov["dtMovimento"].ToString()).ToString("ddMMyyyy");
                    
                    contaContabil = contaContabil.Replace(".", "");
                    if (contaContabil.Length > 11)
                    {
                        contaContabil = contaContabil.Substring(0, 11);
                    }

                    contaContabil = ajusteConta(contaContabil, rowMov["tpOperacao"].ToString());

                    if (contador == 79) {
                        contaContabil = contaContabil;
                    }

                    linha += contabilidade.getLancamentoPadrao(rowMov["cdUnidadeGestora"].ToString()
                                                               , rowMov["cdEmenta"].ToString()
                                                               , rowMov["idLancamento"].ToString()
                                                               , rowMov["nrAnoLancamento"].ToString()
                                                               , rowMov["cdTipoLicitacao"].ToString()
                                                               , rowMov["tpOperacao"].ToString()
                                                               , rowMov["cdNivelContabil"].ToString()
                                                               , rowMov["naturezaReceitaDespesa"].ToString()
                                                               , rowMov["cdOrgao"].ToString()
                                                               ,nomeBD_AUX
                                                               ,nomeBD_CPC);

                    linha += FuncoesUteis.preencher(FuncoesUteis.formataNumero(rowMov["vlMovimento"].ToString()), "0", 0, 15);
                    // Vinculo contábil
                    linha += FuncoesUteis.preencher("0", "0", 0, 10);
                    
                    linha += FuncoesUteis.preencher(cmbEsferaOrc.Text.Substring(0,2) , "0", 0, 2);
                    
                    linha += FuncoesUteis.preencher(cmbTipoAdm.Text.Substring(0,1), "0", 1, 1);

                    linha += FuncoesUteis.preencher(rowMov["cdFuncao"].ToString(), "0", 0, 2);
                    linha += FuncoesUteis.preencher(rowMov["cdSubFuncao"].ToString(), "0", 0, 3);
                    linha += FuncoesUteis.preencher(rowMov["cdPrograma"].ToString(), "0", 0, 4);
                    linha += FuncoesUteis.preencher(FuncoesUteis.removeAlfa(rowMov["dsPrograma"].ToString().ToUpper()), " ", 1, 100).Substring(0, 100);
                    linha += "1";
                    // No e Descricao do Projeto Atividade
                    linha += FuncoesUteis.preencher(rowMov["nrProjetoAtividade"].ToString(), "0", 0, 3);
                    linha += FuncoesUteis.preencher(FuncoesUteis.removeAlfa(rowMov["dsProjetoAtividade"].ToString().ToUpper()), " ", 1, 100).Substring(0, 100);

                    linha += FuncoesUteis.preencher(rowMov["cdFonteRecurso"].ToString(), "0", 0, 10);
                    // Tipo alteração orcamnetaria
                    linha += FuncoesUteis.preencher("0", "0", 0, 2);
                    // No da Lei
                    linha += FuncoesUteis.preencher("0", "0", 1, 10);
                    // Data da lei
                    linha += "01012014"; //FuncoesUteis.preencher("0", "0", 1, 8);
                    // No portaria/decreto
                    linha += FuncoesUteis.preencher("0", "0", 0, 10);
                    // Data da portaria
                    linha += "01012014";  //FuncoesUteis.preencher("0", "0", 1, 8);
                    // No Documento
                    linha += FuncoesUteis.preencher("0", "0", 0, 10);
                    //Codigo Documento PRocessado
                    linha += FuncoesUteis.preencher("0", "0", 0, 2);
                    //CPF/CNPJ
                    linha += FuncoesUteis.preencher(FuncoesUteis.limpaCaracter(rowMov["nrDocumento"].ToString()), "0", 0, 14);
                    
                    if (rowMov["nmCredor"].ToString() == "")
                    {
                        linha += FuncoesUteis.preencher(FuncoesUteis.removeAlfa(txNome.Text), " ", 1, 50);    
                    }
                    else
                    {
                        linha += FuncoesUteis.preencher(FuncoesUteis.removeAlfa(rowMov["nmCredor"].ToString()), " ", 1, 50);
                    }

                    // Modalidade empenho
                    linha += FuncoesUteis.preencher(rowMov["cdTipoEmpenho"].ToString(), "0", 0, 1);
                    // Modalidade licitacao
                    //linha += "02";
                    // Modelidade Licitação
                    linha += FuncoesUteis.preencher(rowMov["tpModalidadeLicitacao"].ToString(), "0", 0, 2);
                    // TIpo Licitacao
                    linha += FuncoesUteis.preencher(rowMov["cdTipoLicitacao"].ToString(), "0", 0, 1);
                    // No Licitacao
                    linha += FuncoesUteis.preencher(rowMov["nrLicitacao"].ToString(), " ", 1, 15);
                    if (rowMov["dtHomologacao"].ToString().Equals(""))
                    {
                        linha += Convert.ToDateTime(rowMov["dtMovimento"].ToString()).ToString("ddMMyyyy");
                    }
                    else {
                        linha += Convert.ToDateTime(rowMov["dtHomologacao"].ToString()).ToString("ddMMyyyy");
                    }

                    linha += FuncoesUteis.preencher(FuncoesUteis.removeAlfa(rowMov["dsObjetoDespesa"].ToString()), " ", 1, 100).Substring(0, 100);
                    // Tipo Apuracao
                    linha += "1";
                    // TIpo pubicacao
                    linha += "1";
                    // Data Publicacao
                    linha += Convert.ToDateTime(rowMov["dtMovimento"].ToString()).ToString("ddMMyyyy");
                    // Vlaor Adjundicado
                    linha += FuncoesUteis.preencher("0", "0", 0, 15);
                    linha += contabilidade.getLinhaDocLiquidacao(nomeBD_CPI, rowMov["cdUnidadeGestora"].ToString().Trim(),
                                                   rowMov["dtAnoLicitacao"].ToString().Trim(),
                                                   rowMov["nrLicitacao"].ToString().Trim());
                                                   
                    // Valor ISS
                    linha += FuncoesUteis.preencher("0", "0", 0, 15);
                    // Valor INSS
                    linha += FuncoesUteis.preencher("0", "0", 0, 15);
                    // Validade Nota
                    linha += "3112"+txAno.Text;
                    // BAnco
                    linha += FuncoesUteis.preencher(rowMov["cdBanco"].ToString(), "0", 0, 3);
                    // agencia
                    linha += FuncoesUteis.preencher(rowMov["cdAgencia"].ToString(), " ", 1, 10);
                    // Conta corrente
                    if (rowMov["cdContaCorrente"].ToString() == "")
                    {
                        linha += FuncoesUteis.preencher(" ", " ", 1, 10);
                    }
                    else
                    {
                        String[] strContaInt = rowMov["cdContaCorrente"].ToString().Split(',');
                        int cdContaInt = Convert.ToInt32(strContaInt[0]);
                        linha += FuncoesUteis.preencher(cdContaInt.ToString(), " ", 1, 10);
                    }
                    // Tipo Transação
                    linha += "1";
                    // No transacao
                    linha += FuncoesUteis.preencher("0", "0", 0, 15);
                    // CPF Ordenador 
                    linha += FuncoesUteis.preencher(cpfOrdenador, "0", 0, 11);
                    // CPF Contador
                    linha += FuncoesUteis.preencher(cpfContador, "0", 0, 11);
                    // Calssificação da receira/natureza
                    naturezaReceitaDespesa = rowMov["naturezaReceitaDespesa"].ToString().Replace(".", "");

                    if (naturezaReceitaDespesa.Length > 10) {
                        naturezaReceitaDespesa = naturezaReceitaDespesa.Substring(0, 10);
                    }
                    naturezaReceitaDespesa = ajusteNaturezaReceitaDespesa(naturezaReceitaDespesa);
                    linha += FuncoesUteis.preencher(naturezaReceitaDespesa, "0", 0, 10);
                    linha += contabilidade.getReciboMural(rowMov["nrEmpenho"].ToString(), rowMov["dtAnoEmissao"].ToString(), nomeBD_AUX, nomeBD_CPE);

                    linha += FuncoesUteis.preencher(" ", " ", 1, 84);
                    linha += "*";
                    contador++;
                    arquivo.WriteLine(linha);
                    arquivoApoio.WriteLine(linhaApoio);
                    barraProgresso.Value = seqMovimento;
                }

                #endregion

                linha = "999" + FuncoesUteis.preencher(contador.ToString(), "0", 0, 10) + FuncoesUteis.preencher(" ", " ", 0, 1189)+ "*";

                arquivo.Close();
                arquivo.Dispose();

                arquivoApoio.Close();
                arquivoApoio.Dispose();

                MessageExcept.messageFacede("Arquivo Gerado", 2);
            /*}
            catch (Exception ex)
            {
                //ex.Message();
                //MessageExcept.messageFacede("Erro ao gerar arquivo:\n" + ex.Message, 1);
            }
            finally { 
                
            }*/
        }


        
        

        private void GerarArquivo_Load(object sender, EventArgs e)
        {
            lerArquivoConfig();
            contabilidade = new modelo.Contabilidade(strConecaoCPC);
            getUnidadesGetoras();
            
        }


        private void getUnidadesGetoras() {
            cbUnidadeGestora.DataSource = contabilidade.getUnidadesGestoras(nomeBD_PPA);
            cbUnidadeGestora.ValueMember = "cdUnidadeGestora";
            cbUnidadeGestora.DisplayMember = "dsUnidadeGestora";
        }

        public String ajusteConta(String conta, string op) {
            
             
            
            if (conta.Equals("62111000000"))
            {

                conta = "62110000000";
                /*
                if (op.Equals("D"))
                {
                             
                    conta = "52211010000";
                }
                else
                {
                    conta = "62110000000";
                }*/
            }
            
            if (conta.Equals("82111000000")) {
                if (op.Equals("D"))
                {
                    conta = "52292010100";
                }
            }
                              
            if (conta.Equals("82112000000"))
            {
                if (op.Equals("C"))
                {
                    conta = "62292010100";
                }
            }
            if (conta.Substring(0,7).Equals("1111119"))
            {
                conta = "11111190000";
            }


            if (conta.Substring(0,9).Equals("111115099"))
            {
                conta = "11111509900";
            }

            //1126101.01.01 
            if (conta.Substring(0, 7).Equals("1126101"))
            {
                conta = "11261010000";
            }

            //1.1.4.1.1.02.07.00 
            if (conta.Substring(0, 7).Equals("1141102"))
            {
                conta = "11411020000";
            }
            //218810113
            if (conta.Substring(0, 9).Equals("218810113")) {
                conta = "21881011300";
            }

            if (conta.Substring(0, 9).Equals("218810499"))
            {
                conta = "21881049900";
            }
            
            if (conta.Substring(0, 4).Equals("6212"))
            {
                conta = "62120000000";
            }

            if (conta.Equals("23111010000"))
            {
                conta = "23111000000";
            }

            if (conta.Equals("21881011800"))
            {
                conta = "21881019900";
            }

            if (conta.Substring(0,9).Equals("218810115"))
            {
                conta = "21881011500";
            }

            if (conta.Equals("31111013700"))
            {
                conta = "31111019900";
            }

            if (conta.Equals("21141040100"))
            {
                conta = "21145980000";
            }

            if (conta.Equals("21881010201"))
            {
                conta = "21881010200";
            }

            if (conta.Equals("49991010000"))
            {
                conta = "49991000000";
            }

            if (conta.Equals("21142040100"))
            {
                conta = "21145980000";
            }

            if (conta.Equals("44511010000"))
            {
                conta = "44511000000";
            }

            if (conta.Equals("49991020000"))
            {
                conta = "49991000000";
            }

            if (conta.Equals("21142040200"))
            {
                conta = "21145980000";
            }

            return conta;
        }

        public String ajusteEvento(String evento, String conta, String op) {

            if (!evento.Equals("2000") && !evento.Equals("1100") && !evento.Equals("1201")) {
                evento = "9000";
            }

            return evento;
        }

        public String ajusteHistorico(String evento,String historico, String conta, String op)
        {
            if (!evento.Equals("2000") && !evento.Equals("1100") && !evento.Equals("1201"))
            {
                historico = "90001";
            }
            /*
            if (evento.Equals("1201"))
            {
                if (conta.Equals("11111190000"))
                {
                    if (op.Equals("D"))
                    {
                        historico = "17001";
                    }
                }
            }*/
            return historico;
        }

        public String ajustaDescricaoHistorico(string evento, String descricao) { 
        if (!evento.Equals("2000") && !evento.Equals("1100") && !evento.Equals("1201")) {
                descricao = "PELO REGISTRO DO HISTORICO DO JURISDICIONADO";
            }
        return descricao;
        }

       public String ajusteNaturezaReceitaDespesa(String natureza){
           
           if(natureza.Equals("3190050000")){
                natureza =  "3190139900";
           }
           return natureza;
       }

        public String getIntervaloOrdenador(String tpArq) {
            String Linha = "";
            
            if (tpArq == "401")
            {
                Linha = Linha + "0101" + txAno.Text;
                Linha = Linha + "3004" + txAno.Text;
            }
            if (tpArq == "402")
            {
                Linha = Linha + "0105" + txAno.Text;
                Linha = Linha + "3108" + txAno.Text;
            }
            if (tpArq == "403")
            {
                Linha = Linha + "0109" + txAno.Text;
                Linha = Linha + "3112" + txAno.Text;
            }
            if (tpArq == "901")
            {
                Linha = Linha + "0101" + txAno.Text;
                Linha = Linha + "3112" + txAno.Text;
            }
            if (tpArq == "999")
            {
                Linha = Linha + "0101" + txAno.Text;
                Linha = Linha + "3112" + txAno.Text;
            }

            return Linha;
        }

    }
}
