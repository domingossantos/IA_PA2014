using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using IA_PA2015.utils;
using System.Data;
using System.Data.SqlClient;

namespace IA_PA2015.modelo
{
    class Contabilidade
    {
        ConexaoDB conexao;
        public int numeroRegistros = 0;

        public Contabilidade(String strConexao)
        {
            conexao = new ConexaoDB(strConexao);
        }


        public DataTable getOrdenadores(String cdUnidadeGestora, String nomeBD_Auxiliar, String nomeBD_CPC)
        {
            DataTable dados = null;

            try
            {
                conexao.abreBanco();
                StringBuilder strQuery = new StringBuilder();
                strQuery.Append("select distinct tab.* from  ( ");
                strQuery.Append("SELECT p.nmPessoa, t.dsTpIdentificadorPessoa,");
                strQuery.Append(" p.nrCPF,  p.nrCRC,");
                strQuery.Append(" p.nrIdentidade, p.nmOrgaoEmissor, p.dtEmissaoIdentidade, p.dsEndereco, ");
                strQuery.Append(" p.dsBairro, p.dsCidade, p.cdCEP, p.sgUF, p.nrTelefoneResidencial,");
                strQuery.Append(" p.nrTelefoneComercial , p.nrTelefoneCelular, p.dsEnderecoEletronico ");
                strQuery.Append(" ,case ip.tpIdentificadorPessoa when 3 then 1 else ip.tpIdentificadorPessoa end tpIdentificadorPessoa ");
                strQuery.Append(" ,ip.dsCargo ");
                strQuery.Append(" FROM " + nomeBD_CPC + "..Pessoa p, " + nomeBD_CPC + "..IdentificadorPessoa ip, " + nomeBD_CPC + "..TipoIdentificadorPessoa t ");
                strQuery.Append(" WHERE ip.cdPessoa = p.cdPessoa and ip.cdUnidadeGEstora = "+ cdUnidadeGestora);
                strQuery.Append(" AND ip.tpIdentificadorPessoa = t.tpIdentificadorPessoa ");
                strQuery.Append(" AND p.nrCPF in(select cpf from " + nomeBD_Auxiliar + "..AUX_PESSOA)");
                strQuery.Append(") as tab ORDER BY nmPessoa ");

                dados = conexao.retornarDataSet(strQuery.ToString());
                numeroRegistros = dados.Rows.Count;

            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao selecionar ordenador.\n" + ex.Message);
            }
            finally
            {
                conexao.fechaBanco();
            }

            return dados;
        }

        /*
        #region PLano de Contas
        public DataTable getListaContasTCM(String nomeBancoAux )
        {
            DataTable dados = null;
            try
            {
                String sql = "SELECT CONTA, ANALIT+ ' - ' + CONTA + ' - '+DESCRICAO as DESCRICAO FROM " + nomeBancoAux + "..AUX_PLANOUNICO ";
                conexao.abreBanco();
                dados = conexao.retornarDataSet(sql);

            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao selecionar contas TCM.\n"+ex.Message);
            }
            finally {
                conexao.fechaBanco();
            }
            return dados;
        }

        public DataTable getListaContasPL(String nomeBD_CPE, String nomeBD_AUX)
        {
            DataTable dados = null;

            try
            {
                StringBuilder sql = new StringBuilder();
                sql.Append("select c.cdContaContabil, c.cdNivelContabil +' - ' +c.dsConta dsConta from " + nomeBD_CPE + "..DATAVIEW_MOVIMENTO m ");
                sql.Append("inner join " + nomeBD_CPE + "..DATAVIEW_CONTA_CONTABIL c on c.cdContaContabil = m.cdContaContabil ");
                sql.Append(" where c.cdContaContabil not in (select cdContaContabil from " + nomeBD_AUX + "..AUX_PLANOUNICO_CONTACONTABIL) ");
                sql.Append("group by c.cdContaContabil, c.cdNivelContabil +' - ' +c.dsConta");

                conexao.abreBanco();
                dados = conexao.retornarDataSet(sql.ToString());
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao selecionar plano de contascontas pareado.\n" + ex.Message);
            }
            finally
            {
                conexao.fechaBanco();
            }
            return dados;
        }

        private void getListaContasPareadas(String strConexao)
        {
            StringBuilder sql = new StringBuilder();

            sql.Append("select p.cdContaContabil PL, pl.cdNivelContabil+ ' - '+ pl.dsConta Descricao ,  ");
            sql.Append("p.cdPlanoUnico CTM, ctm.CONTA + ' - ' +ctm.DESCRICAO Descricao ");
            sql.Append("from " + strAUX + "..AUX_PLANOUNICO_CONTACONTABIL p ");
            sql.Append("inner join DATAVIEW_CONTA_CONTABIL pl on pl.cdContaContabil = p.cdContaContabil ");
            sql.Append("inner join " + strAUX + "..AUX_PLANOUNICO ctm on ctm.CONTA = p.cdPlanoUnico ");

            clDataBase clDB = new clDataBase();
            grdPlano.DataSource = clDB.RetornaDataSet(sql.ToString(), strConexao).Tables[0];
            grdPlano.Columns[0].HeaderText = "Plano de Contas TCM";
            grdPlano.Columns[0].Width = 80;
            grdPlano.Columns[1].HeaderText = "Descrição";
            grdPlano.Columns[1].Width = 600;
            grdPlano.Columns[2].HeaderText = "Plano de Contas";
            grdPlano.Columns[2].Width = 140;
            grdPlano.Columns[3].HeaderText = "Descrição";
            grdPlano.Columns[3].Width = 600;
        }

        private void setParContas(String cdContaCTM, int cdContaPl, String conexao)
        {
            String sql = "INSERT INTO " + strAUX + "..AUX_PLANOUNICO_CONTACONTABIL (cdContaContabil,cdPlanoUnico) VALUES (" + cdContaPl.ToString() + ",'" + cdContaCTM + "' )";
            clDataBase clDB = new clDataBase();
            clDB.ExComando(sql, conexao);
        }

        private void excluiContaPareada(String cdContaCTM, int cdContaPl, String conexao)
        {
            String sql = "delete from " + strAUX + "..AUX_PLANOUNICO_CONTACONTABIL where cdPlanoUnico = '" + cdContaCTM + "' and cdContaContabil = " + cdContaPl;
            clDataBase clDB = new clDataBase();
            clDB.ExComando(sql, conexao);
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            if (lbxListaPL.SelectedIndex == -1)
            {
                MessageBox.Show("Selecionepelo menos plano PL");
                return;
            }

            if (lbxListaCTM.SelectedIndex == -1)
            {
                MessageBox.Show("Selecionepelo menos plano CTM");
                return;
            }

            String cdPlanoCTM = lbxListaCTM.SelectedValue.ToString();

            for (int i = 0; i < lbxListaPL.SelectedItems.Count; i++)
            {
                DataRowView linha = (DataRowView)lbxListaPL.SelectedItems[i];
                int cdPlanoPl = int.Parse(linha[0].ToString());

                setParContas(cdPlanoCTM, cdPlanoPl, strConexao_CPE);

            }

            MessageBox.Show("Contas pareadas com sucesso!");
            getListaContasPareadas(strConexao_CPE);
            getListaContasCTM(strConexao_CPE);
            getListaContasPL(strConexao_CPE);

        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {

            int cdContaPL = int.Parse(grdPlano[0, grdPlano.CurrentRow.Index].Value.ToString());
            String cdContaCTM = grdPlano[2, grdPlano.CurrentRow.Index].Value.ToString();

            try
            {
                excluiContaPareada(cdContaCTM, cdContaPL, strConexao_CPE);
                MessageBox.Show("Contas Exluida");
                getListaContasPareadas(strConexao_CPE);
                getListaContasCTM(strConexao_CPE);
                getListaContasPL(strConexao_CPE);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao excluir\n" + ex.Message);
            }

        }
        #endregion

        #region historico padrao

        public void getListaHistoriocoPadraoPL()
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("select codigo,descricao ");
            sql.Append("from " + strAUX + "..AUX_HISTORICOPADRAOCPC ");


            clDataBase clDB = new clDataBase();
            lbxHistoricoPl.DataSource = clDB.RetornaDataSet(sql.ToString(), strConexao_CPE).Tables[0];
            lbxHistoricoPl.ValueMember = "codigo";
            lbxHistoricoPl.DisplayMember = "descricao";
            lbxHistoricoPl.SelectedIndex = -1;
        }

        public void getListaHistoriocoPadraoCTM()
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("select  CODIGO,DESCRICAO from " + strAUX + "..AUX_HISTORICOPADRAO");
            clDataBase clDB = new clDataBase();
            lbxHistoricoCTM.DataSource = clDB.RetornaDataSet(sql.ToString(), strConexao_CPE).Tables[0];
            lbxHistoricoCTM.DisplayMember = "DESCRICAO";
            lbxHistoricoCTM.ValueMember = "CODIGO";
            lbxHistoricoCTM.SelectedIndex = -1;
        }

        public void setHistoricoPar(string cdHistoricoPl, int cdHistoricoCTM)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("insert into " + strAUX + "..aux_historicopadrao_par (cdHistoricoPl, cdHistoricoCTM) ");
            sql.Append("values ('" + cdHistoricoPl + "'," + cdHistoricoCTM.ToString() + ")");
            clDataBase clDB = new clDataBase();
            clDB.ExComando(sql.ToString(), strConexao_CPE);
        }

        public void listaHistoricoPareado()
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("select p.cdHistoricoPL ");
            sql.Append(",(select top 1 c.descricao from  " + strAUX + "..AUX_HISTORICOPADRAOCPC c where c.codigo = p.cdHistoricoPL) descricaoPL ");
            sql.Append(",p.cdHistoricoCTM ");
            sql.Append(",(select top 1 h_ctm.DESCRICAO  from " + strAUX + "..AUX_HISTORICOPADRAO h_ctm where h_ctm.codigo = p.cdHistoricoCTM) descricaoCTM ");
            sql.Append("from " + strAUX + "..AUX_HISTORICOPADRAO_PAR p ");

            clDataBase clDB = new clDataBase();
            gdrHistorico.DataSource = clDB.RetornaDataSet(sql.ToString(), strConexao_CPE).Tables[0];
        }

        public void excluiHistoricoPar(String cdHistoricoPl, int cdHistoricoCTM)
        {
            String sql = "delete from " + strAUX + "..AUX_HISTORICOPADRAO_PAR where cdHistoricoPL = '" + cdHistoricoPl + "' and cdHistoricoCTM = " + cdHistoricoCTM;
            clDataBase clDB = new clDataBase();
            clDB.ExComando(sql, strConexao_CPE);
        }


       
        #endregion

        #region Evento

        public void getListaEventoCTM()
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("SELECT CODIGO,DESCRICAO FROM " + strAUX + "..AUX_TABEVENTOS");
            clDataBase clDB = new clDataBase();

            lbxEventoCTM.DataSource = clDB.RetornaDataSet(sql.ToString(), strConexao_CPE).Tables[0];
            lbxEventoCTM.ValueMember = "CODIGO";
            lbxEventoCTM.DisplayMember = "DESCRICAO";
            lbxEventoCTM.SelectedIndex = -1;
        }

        public void getListaEventoPl()
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("select distinct codigo,descricao ");
            sql.Append("from " + strAUX + "..AUX_HISTORICOPADRAOCPC ");
            sql.Append("where codigo not in(select distinct cdEventoPL from " + strAUX + "..AUX_EVENTO_PAR )");
            sql.Append("group by codigo,descricao");
            clDataBase clDB = new clDataBase();
            lbxEventoPl.DataSource = clDB.RetornaDataSet(sql.ToString(), strConexao_CPE).Tables[0];
            lbxEventoPl.DisplayMember = "descricao";
            lbxEventoPl.ValueMember = "codigo";
        }

        private void getListaEventoParteado()
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("select p.cdEventoPL ");
            sql.Append(",(select top 1 c.descricao from  " + strAUX + "..AUX_HISTORICOPADRAOCPC c where c.codigo = p.cdEventoPL) descricaoPL ");
            sql.Append(",p.cdEventoCTM ");
            sql.Append(",(select top 1 h_ctm.DESCRICAO  from " + strAUX + "..AUX_TABEVENTOS h_ctm where h_ctm.codigo = p.cdEventoCTM) descricaoCTM ");
            sql.Append("from " + strAUX + "..AUX_EVENTO_PAR p ");


            clDataBase clDB = new clDataBase();
            dgrEventos.DataSource = clDB.RetornaDataSet(sql.ToString(), strConexao_CPE).Tables[0];
        }
        #endregion
        */
        #region Ordenador
        public DataTable getPessoas(String nomeBD_CPC)
        {
            DataTable dados = null;

            try
            {
                conexao.abreBanco();
                string sql = "SELECT Pessoa.nrCPF, Pessoa.nmPessoa " +
                                "FROM " + nomeBD_CPC + "..Pessoa, " + nomeBD_CPC + "..IdentificadorPessoa, " + nomeBD_CPC + "..TipoIdentificadorPessoa " +
                                "WHERE IdentificadorPessoa.cdPessoa = Pessoa.cdPessoa " +
                                "AND IdentificadorPessoa.tpIdentificadorPessoa = TipoIdentificadorPessoa.tpIdentificadorPessoa " +
                                "order by 2";
                dados = conexao.retornarDataSet(sql);
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao listar pessoas.\n" + ex.Message);
            }
            finally
            {
                conexao.fechaBanco();
            }

            return dados;

        }

        public DataTable getListaPessoas(String nomeBD_CPC, String nomeBD_AUX)
        {
            DataTable dados = null;
            try
            {
                conexao.abreBanco();
                string sql = "SELECT Pessoa.nrCPF as CPF, Pessoa.nmPessoa as Nome, TipoIdentificadorPessoa.dsTpIdentificadorPessoa as Tipo " +
                                "FROM " + nomeBD_CPC + "..Pessoa, " + nomeBD_CPC + "..IdentificadorPessoa, " + nomeBD_CPC + "..TipoIdentificadorPessoa " +
                                "WHERE IdentificadorPessoa.cdPessoa = Pessoa.cdPessoa " +
                                "AND IdentificadorPessoa.tpIdentificadorPessoa = TipoIdentificadorPessoa.tpIdentificadorPessoa " +
                                "and Pessoa.nrCPF in(select cpf from " + nomeBD_AUX + "..AUX_PESSOA) " +
                                "order by 2";

                dados = conexao.retornarDataSet(sql);
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao listar ordenador pareado.\n" + ex.Message);
            }
            finally
            {
                conexao.fechaBanco();
            }

            return dados;
        }

        public void pareaOrdenador(String cpf, String nomeBD_AUX)
        {
            try
            {
                conexao.abreBanco();
                String sql = "insert into " + nomeBD_AUX + "..AUX_PESSOA (cpf) values (" + cpf + ")";
                conexao.executaSemRetorno(sql);
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao incluir ordenador.\n" + ex.Message);
            }
            finally
            {
                conexao.fechaBanco();
            }
        }

        public void apagarOrdenador(String cpf, String nomeBD_AUX)
        {
            try
            {
                conexao.abreBanco();
                String sql = "delete from " + nomeBD_AUX + "..AUX_PESSOA where cpf = '" + cpf.Replace(',', '.') + "'";
                conexao.executaSemRetorno(sql);
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao apagar ordenador.\n" + ex.Message);
            }
            finally
            {
                conexao.fechaBanco();
            }
        }

        public DataTable getOrdenadores(String nomeBD_CPC)
        {
            DataTable dados = null;
            try
            {
                StringBuilder strQuery = new StringBuilder();
                strQuery.Append("SELECT ip.*, p.nmPessoa, t.dsTpIdentificadorPessoa,");
                strQuery.Append(" p.nrCPF, ip.dtInicioGestao, ip.dtFimGestao, p.nrCRC,");
                strQuery.Append(" p.nrIdentidade, p.nmOrgaoEmissor, p.dtEmissaoIdentidade, p.dsEndereco, ");
                strQuery.Append(" p.dsBairro, p.dsCidade, p.cdCEP, p.sgUF, p.nrTelefoneResidencial,");
                strQuery.Append(" p.nrTelefoneComercial , p.nrTelefoneCelular, p.dsEnderecoEletronico ");
                strQuery.Append(" FROM " + nomeBD_CPC + "..Pessoa p, " + nomeBD_CPC + "..IdentificadorPessoa ip, " + nomeBD_CPC + "..TipoIdentificadorPessoa t ");
                strQuery.Append(" WHERE IdentificadorPessoa.cdPessoa = Pessoa.cdPessoa ");
                strQuery.Append(" AND (ip.tpIdentificadorPessoa = 2 or ip.tpIdentificadorPessoa = 3) ");
                strQuery.Append(" AND ip.tpIdentificadorPessoa = t.tpIdentificadorPessoa ");
                strQuery.Append(" ORDER BY nmPessoa ");

                conexao.abreBanco();

                dados = conexao.retornarDataSet(strQuery.ToString());
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao listar ordenador.\n" + ex.Message);
            }
            finally
            {
                conexao.fechaBanco();
            }

            return dados;
        }

        #endregion



        #region Fonte de Recurso
        public DataTable getFonteRecurso(String nmBancoCPC)
        {
            DataTable dados = null;
            try
            {
                String sql = "select * from " + nmBancoCPC + "..FonteRecurso";

                conexao.abreBanco();

                dados = conexao.retornarDataSet(sql);
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao listar fontes de recurso.\n" + ex.Message);
            }
            finally
            {
                conexao.fechaBanco();
            }
            return dados;
        }
        #endregion

        #region Movimento
        public DataTable getMovimento(String nmBancoAux, int tipo, String inicio, String fim, String cdUnidadeGestora, String PPA, String CPC, String CPE)
        {
            DataTable dados = null;
            try
            {
                StringBuilder sql = new StringBuilder();

                sql.Append("select * ");
                sql.Append(" from " + nmBancoAux + "..dataview_movimento_tcm m where 1 = 1 and m.cdHistoricoPadrao in(464,465)  and m.nrSequenciaSistema > 0 ");
                sql.Append(" and SUBSTRING(m.cdNivelContabil,1,1) not in('7','8') ");

                if (tipo == 1)
                {
                    sql.Append(" \t and  (m.cdContaContabil > 0)  and MONTH(m.dtMovimento) = 01 and DAY(m.dtMovimento) = 1 \n" +
                        "and (m.cdNivelContabil like '5.2.1.1.%' \n" +
                        "or m.cdNivelContabil like '6.2.1.1.%' \n" +
                        "or m.cdNivelContabil like '5.2.2.1.1.%' \n" +
                        "or m.cdNivelContabil like '6.2.2.1.1.%') and m.cdFonteRecurso is null \n");
                }
                else
                {
                    sql.Append(" \t and  MONTH(m.dtMovimento) > = " + inicio + " and MONTH(m.dtMovimento) < =  " + fim); ;

                    if (!cdUnidadeGestora.Equals(""))
                    {
                        sql.Append(" \t and m.cdUnidadeGestora = " + cdUnidadeGestora); ;
                    }
                }

                sql.Append(" \t order by m.nrControleFatoContabil,  m.tpOperacao desc ");

                conexao.abreBanco();

                dados = conexao.retornarDataSet(sql.ToString());
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao listar movimento.\n" + ex.Message);
            }
            finally
            {
                conexao.fechaBanco();
            }
            return dados;

        }

        public String getReciboMural(String empenho, String ano, String nmBancoAux, String nmBancoCPE)
        {
            String recibo = "";
            /*
            try
            {

                String sql = "select "+nmBancoAux+".dbo.fn_removeCaracteresNaoInteiros (dsConteudo) from "+nmBancoCPE+"..movimentonota where "
                                + " nrsequencia = (select NRSEQUENCIA from " + nmBancoCPE + "..movimento where cdunidadegestora = 1 "
                                +" and nrempenho = '"+empenho+"' "
                                +" and dtanoemissao = "+ano
                                +" and cdtipomovimento in (430,431,432)) "
                                +" and idformulariogerador = 1 and cdcampogerador in (352,353,354,355)";

                conexao.abreBanco();

                DataTable dados = conexao.retornarDataSet(sql);

                if(dados.Rows.Count > 0){
                    recibo = dados.Rows[0][0].ToString();
                    
                }
            }
            finally
            {
                conexao.fechaBanco();
            }
            */
            recibo = utils.FuncoesUteis.preencher(recibo, "0", 1, 48);
            return recibo;
        }

        public String getLancamentoPadrao(string fornecedor, string unidade, string ementa, string lancamento, string ano, string licitacao
                                         , string operacao, string conta, string natureza
                                         , string orgao, string nmBancoAux, string nmBancoCPC)
        {
            int origemConta = 0;

            if (licitacao == "")
            {
                licitacao = "0";
            }

            if (ementa == null)
            {
                ementa = "0";
            }

            String sql = "select  p.cdEvento,p.cdHistorico " +
                        ",(select h.ds_historico  from " + nmBancoAux + "..AUX_HISTORICO_TCM h where h.cd_historico = p.cdHistorico) as dsHistorico" +
                        ",(select c.cdnivelcontabil from " + nmBancoCPC + "..CONTACONTABIL c where c.cdContaContabil = l.cdContaCredito) cdNivelCredito " +
                        ",(select c.cdnivelcontabil from " + nmBancoCPC + "..CONTACONTABIL c where c.cdContaContabil = l.cdContaDebito) cdNivelDebito " +
                        "	from " + nmBancoAux + "..aux_paridade_conta p " +
                        "inner join " + nmBancoAux + "..AUX_LANCAMENTO_PADRAO l on p.idConjuntoLancamento = l.id where 1 = 1 ";


            sql += " and l.idLancamento = " + lancamento + " and l.nrAno = " + ano;



            if (!orgao.Equals("0"))
            {
                sql += " and p.cdOrgao = " + orgao;
            }
            else
            {
                sql += " and p.cdOrgao = 0 ";
            }

            if (!ementa.Equals("0"))
            {
                sql += " and p.cdEmenta = " + ementa;
            }

            if (!licitacao.Equals("0"))
            {
                sql += " and p.cdTipoLicitacao = " + licitacao;
            }

            if (!natureza.Equals("0"))
            {
                sql += " and p.cdNaturezaDespesa = '" + natureza + "'";
            }

            DataTable linhas = conexao.retornarDataSet(sql.ToString());

            String linha = "";



            if (linhas.Rows.Count <= 0)
            {
                sql = "select  p.cdEventoCredito, p.cdEventoDebito, p.cdHistoricoCredito, cdHistoricoDebito " +
                      ",(select h.ds_historico  from " + nmBancoAux + "..AUX_HISTORICO_TCM h where h.cd_historico = p.cdHistoricoCredito) as dsHistoricoCredito " +
                      ",(select h.ds_historico  from " + nmBancoAux + "..AUX_HISTORICO_TCM h where h.cd_historico = p.cdHistoricoDebito) as dsHistoricoDebito " +
                      "from " + nmBancoAux + "..AUX_PAREAR_NAO_PADRAO p " +
                      "where p.idLancamento = " + lancamento + " and p.cdUnidadeGestora = " + unidade;

                linhas = conexao.retornarDataSet(sql.ToString());
                origemConta = 1;
            }

            if (linhas.Rows.Count <= 0)
            {
                sql = "select p.cdEvento, p.cdHistorico, (select h.ds_historico from " + nmBancoAux + "..AUX_HISTORICO_TCM h where h.cd_historico = cdHistorico) as dsHistorico " +
                      ",(select c.cdnivelcontabil from " + nmBancoCPC + "..CONTACONTABIL c where c.cdContaContabil = l.cdContaCredito) cdNivelCredito " +
                      ",(select c.cdnivelcontabil from " + nmBancoCPC + "..CONTACONTABIL c where c.cdContaContabil = l.cdContaDebito) cdNivelDebito " +
                      ",cdHistorico  from " + nmBancoAux + "..PAREAR_FOLHA_EVENTO_HISTORICO p " +
                      "inner join " + nmBancoAux + "..AUX_LANCAMENTO_PADRAO l on p.idLancamento = l.id " +
                      " where l.idLancamento = " + lancamento + " and l.nrAno = " + ano + " and p.cdFornecedor = " + fornecedor + " and p.cdUnidadeGestora = " + unidade;

                linhas = conexao.retornarDataSet(sql.ToString());
                origemConta = 2;
            }



            if (linhas.Rows.Count > 0)
            {
                linha = "";
                DataRow dados = linhas.Rows[0];



                if (origemConta == 1)
                {
                    if (operacao.Equals("C"))
                        linha = FuncoesUteis.preencher(FuncoesUteis.removeAlfa(dados[0].ToString()).ToUpper(), " ", 1, 4);
                    else
                        linha = FuncoesUteis.preencher(FuncoesUteis.removeAlfa(dados[1].ToString()).ToUpper(), " ", 1, 4);

                    linha += FuncoesUteis.preencher(FuncoesUteis.removeAlfa(conta), " ", 1, 11);
                    linha += operacao;

                    if (operacao.Equals("C"))
                    {
                        linha += FuncoesUteis.preencher(FuncoesUteis.removeAlfa(dados[2].ToString()).ToUpper(), " ", 1, 5);
                        linha += FuncoesUteis.preencher(FuncoesUteis.removeAlfa(dados[4].ToString()).ToUpper(), " ", 1, 300);
                    }
                    else
                    {
                        linha += FuncoesUteis.preencher(FuncoesUteis.removeAlfa(dados[3].ToString()).ToUpper(), " ", 1, 5);
                        linha += FuncoesUteis.preencher(FuncoesUteis.removeAlfa(dados[5].ToString()).ToUpper(), " ", 1, 300);
                    }
                }
                else if (origemConta == 2)
                {

                    linha = FuncoesUteis.preencher(FuncoesUteis.removeAlfa(dados[0].ToString()).ToUpper(), " ", 1, 4);
                    if (operacao.Equals("C"))
                        linha += FuncoesUteis.preencher(FuncoesUteis.removeAlfa(dados[3].ToString()), " ", 1, 11);
                    else
                        linha += FuncoesUteis.preencher(FuncoesUteis.removeAlfa(dados[4].ToString()), " ", 1, 11);

                    linha += operacao;
                    linha += FuncoesUteis.preencher(FuncoesUteis.removeAlfa(dados[1].ToString()).ToUpper(), " ", 1, 5);
                    linha += FuncoesUteis.preencher(FuncoesUteis.removeAlfa(dados[2].ToString()).ToUpper(), " ", 1, 300);

                }

                else
                {
                    linha = FuncoesUteis.preencher(FuncoesUteis.removeAlfa(dados[1].ToString()).ToUpper(), " ", 1, 4);
                    linha += FuncoesUteis.preencher(FuncoesUteis.removeAlfa(conta), " ", 1, 11);
                    linha += operacao;
                    linha += FuncoesUteis.preencher(FuncoesUteis.removeAlfa(dados[1].ToString()).ToUpper(), " ", 1, 5);
                    linha += FuncoesUteis.preencher(FuncoesUteis.removeAlfa(dados[2].ToString()).ToUpper(), " ", 1, 300);
                }


            }
            else
            {
                if (!lancamento.Equals("41") || !lancamento.Equals("47"))
                {
                    linha = "";
                }
                linha = "9000";
                linha += FuncoesUteis.preencher(FuncoesUteis.removeAlfa(conta).ToUpper(), " ", 1, 11);
                linha += operacao;
                linha += "90001";
                linha += FuncoesUteis.preencher("PELO REGISTRO DO HISTORICO DO JURISDINADO", " ", 1, 300);

            }

            return linha;
        }

        public String getRoteiroTCM(string operacao, string fatorContabil, string contaContabil, string aux, string cpe)
        {

            StringBuilder sql = new StringBuilder();
            sql.Append(" select e.cd_evento, h.cd_historico, h.ds_historico from " + aux + "..aux_historico_evento_par t ");
            sql.Append("inner join " + aux + "..aux_evento_tcm e on t.cd_evento_tcm = e.cd_evento ");
            sql.Append("inner join " + aux + "..aux_historico_tcm h on t.cd_historico_tcm = h.cd_historico ");
            sql.Append("where t.tp_operacao =  ");
            sql.Append("(select top 1  CASE WHEN t.cdTipoMovimento IN (461, 462, 465) THEN 'C' ELSE 'D' END  COLLATE Latin1_General_CI_AS from " + cpe + "..MOVIMENTO t ");
            sql.Append(" where t.nrControleFatoContabil = " + fatorContabil + " order by nrSequencia)");
            sql.Append(" and t.cd_conta_contabil = (select c.cdNivelContabil from " + cpe + "..DATAVIEW_CONTA_CONTABIL c where c.cdContaContabil = ( ");
            sql.Append("select top 1 t.cdContaContabil from " + cpe + "..MOVIMENTO t  ");
            sql.Append(" where t.nrControleFatoContabil = 0101000028 order by nrSequencia)) ");
            sql.Append("and t.cd_historico = (select top 1 t.cdHistoricoPadrao from " + cpe + "..MOVIMENTO t ");
            sql.Append(" where t.nrControleFatoContabil = " + fatorContabil + " order by nrSequencia)");

            String linha = "";
            DataTable linhas = conexao.retornarDataSet(sql.ToString());
            if (linhas.Rows.Count > 0)
            {
                linha = "";
                DataRow dados = linhas.Rows[0];
                linha += FuncoesUteis.preencher(dados[0].ToString(), "0", 0, 4);

                contaContabil = contaContabil.Replace(".", "");
                if (contaContabil.Length > 11)
                {
                    contaContabil = contaContabil.Substring(0, 11);
                }
                linha += FuncoesUteis.preencher(contaContabil, "0", 0, 11);

                linha += FuncoesUteis.preencher(operacao, "0", 0, 1);

                linha += FuncoesUteis.preencher(dados[1].ToString(), "0", 0, 5);
                linha += FuncoesUteis.preencher(FuncoesUteis.removeAlfa(dados[2].ToString()).ToUpper(), " ", 1, 300);
            }
            else
            {
                linha = FuncoesUteis.preencher("", "0", 0, 321);
            }


            return linha;
        }

        public String getLinhaDocLiquidacao(String nmBancoCPI, String cdUndGestora, String dtAno, String pNrEmpenho)
        {

            String linha = "";

            if (!pNrEmpenho.Equals(""))
            {
                StringBuilder sql = new StringBuilder();
                sql.Append("SELECT top 1 nrEmpenho,tpDocumento,nrSerie,nrDocumento,dtEmissaoDocto ");
                sql.Append(",vlICMSDestacado,vlICMSRetido,nrSerieSeloSEFA,nrSeloSEFA,cdCST ");
                sql.Append("FROM " + nmBancoCPI + "..PA_DocumentoLiquidacao where cdUnidadeGestora = " + cdUndGestora);
                sql.Append(" and dtAnoEmissao = " + dtAno + " and nrEmpenho = '" + pNrEmpenho + "'");


                DataTable linhas = conexao.retornarDataSet(sql.ToString());

                if (linhas.Rows.Count > 0)
                {
                    linha = "";
                    DataRow dados = linhas.Rows[0];

                    linha += FuncoesUteis.preencher(dados["tpDocumento"].ToString(), "0", 0, 2);
                    linha += FuncoesUteis.preencher(dados["nrSerie"].ToString(), " ", 1, 5);
                    linha += FuncoesUteis.preencher(dados["nrDocumento"].ToString(), "0", 0, 10);
                    linha += Convert.ToDateTime(dados["dtEmissaoDocto"].ToString()).ToString("ddMMyyyy");
                    linha += FuncoesUteis.preencher(FuncoesUteis.formataNumero(dados["vlICMSDestacado"].ToString()), "0", 0, 15);
                    linha += FuncoesUteis.preencher(FuncoesUteis.formataNumero(dados["vlICMSRetido"].ToString()), "0", 0, 15);
                    linha += FuncoesUteis.preencher(dados["nrSerieSeloSEFA"].ToString(), "0", 0, 2);
                    linha += FuncoesUteis.preencher(dados["nrSeloSEFA"].ToString(), "0", 0, 10);
                    //linha += FuncoesUteis.preencher((dados["dtEmissaoDocto"].ToString()), "0", 1, 6);
                    linha += Convert.ToDateTime(dados["dtEmissaoDocto"].ToString()).ToString("MMyyyy");
                    linha += FuncoesUteis.preencher(dados["cdCST"].ToString(), "0", 0, 4);
                }
                else
                {
                    linha += FuncoesUteis.preencher("0", "0", 1, 2);
                    linha += FuncoesUteis.preencher("0", "0", 1, 5);
                    linha += FuncoesUteis.preencher("0", "0", 1, 10);
                    linha += FuncoesUteis.preencher("0", "0", 1, 8);
                    linha += FuncoesUteis.preencher("0", "0", 1, 15);
                    linha += FuncoesUteis.preencher("0", "0", 1, 15);
                    linha += FuncoesUteis.preencher("0", "0", 1, 2);
                    linha += FuncoesUteis.preencher("0", "0", 1, 10);
                    linha += FuncoesUteis.preencher("010114", "0", 1, 6);
                    linha += FuncoesUteis.preencher("0", "0", 1, 4);
                }
            }
            else
            {
                linha += FuncoesUteis.preencher("0", "0", 1, 2);
                linha += FuncoesUteis.preencher("0", "0", 1, 5);
                linha += FuncoesUteis.preencher("0", "0", 1, 10);
                linha += FuncoesUteis.preencher("0", "0", 1, 8);
                linha += FuncoesUteis.preencher("0", "0", 1, 15);
                linha += FuncoesUteis.preencher("0", "0", 1, 15);
                linha += FuncoesUteis.preencher("0", "0", 1, 2);
                linha += FuncoesUteis.preencher("0", "0", 1, 10);
                linha += FuncoesUteis.preencher("0", "0", 1, 6);
                linha += FuncoesUteis.preencher("0", "0", 1, 4);
            }
            return linha;
        }
        #endregion

        #region Parear Empenho Recibo

        public DataTable getEmpenhos(int nrAno)
        {
            String sql = "select nrEmpenho, dtAnoEmissao,nrLicitacao, dtEmissaoEmpenho, "
                        + "nrProcessoCompra, nrContrato  from A15_CPE2015..EMPENHO "
                        + "where dtAnoEmissao = 2015";


            DataTable linhas = conexao.retornarDataSet(sql);

            return linhas;
        }

        #endregion

        public DataTable getUnidadesGestoras(String nmBancoPPA)
        {
            DataTable dados = null;
            try
            {
                conexao.abreBanco();

                dados = conexao.retornarDataSet("select cdUnidadeGestora, convert(varchar, cdUnidadeGestora) +' - '+dsUnidadeGestora as dsUnidadeGestora from " + nmBancoPPA + "..PPAUnidadeGestora order by cdUnidadeGestora");

            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao listar Unidades Gestoras");

            }

            return dados;
        }


        public DataTable getContaAConta(String nmBancoAUX)
        {
            DataTable dados = null;
            try
            {
                conexao.abreBanco();

                dados = conexao.retornarDataSet("select  * from " + nmBancoAUX + "..AUX_CONTA_A_CONTA ");

            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao listar Contas");

            }

            return dados;
        }

        public void gravaContaAConta(String nmBancoAUX, String contaPC, String contaTC)
        {
            try
            {
                String sql = "insert into " + nmBancoAUX + "..aux_conta_a_conta (contaPC, contaTC) values ('" + contaPC + "','" + contaTC + "')";

                conexao.abreBanco();
                conexao.executaSemRetorno(sql);
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao gravar Contas");

            }
        }

        public void apagaContaAConta(String nmBancoAUX, String id)
        {
            try
            {
                String sql = "delete from " + nmBancoAUX + "..aux_conta_a_conta where id = " + id;

                conexao.abreBanco();
                conexao.executaSemRetorno(sql);
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao apagar Contas");

            }
        }

        public DataTable getLancamentoPadraoDuplicado(String nmBancoAUX)
        {
            DataTable dados = null;
            try
            {
                conexao.abreBanco();

                dados = conexao.retornarDataSet("select  * from " + nmBancoAUX + "..AUX_DUPLICAR_LANCAMENTO ");

            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao listar Contas");

            }

            return dados;
        }

        public void gravaLancamentoDuplicar(String nmBancoAUX, String idLancamento, String contaDebito, String contaCredito)
        {
            try
            {
                String sql = "insert into " + nmBancoAUX + "..AUX_DUPLICAR_LANCAMENTO (idLancamento,contaDebito, contaCredito) values (" + idLancamento + ",'" + contaDebito + "','" + contaCredito + "')";

                conexao.abreBanco();
                conexao.executaSemRetorno(sql);
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao gravar Contas");

            }
        }

        public void apagaLancamentoDuplicar(String nmBancoAUX, String id)
        {
            try
            {
                String sql = "delete from " + nmBancoAUX + "..AUX_DUPLICAR_LANCAMENTO where id = " + id;

                conexao.abreBanco();
                conexao.executaSemRetorno(sql);
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao apagar Contas");

            }
        }

        public DataTable getListaLancamentoPadao(String nomeBD_AUX)
        {

            DataTable dados = null;
            try
            {
                String sql = "select id, dsLancamentoComp from " + nomeBD_AUX + "..aux_lancamento_padrao order by dsLancamento";

                conexao.abreBanco();
                dados = conexao.retornarDataSet(sql);
            }
            catch (Exception ex)
            {
                MessageExcept.messageFacede("Erro: \n" + ex.Message, 1);
            }
            finally
            {
                conexao.fechaBanco();
            }

            return dados;
        }

        public String ajustaConta(String conta, String nmBancoAUX)
        {
            
            String sql = "";

            sql = "select contaTC from "+nmBancoAUX+"..aux_conta_a_conta where contaPC = '"+conta+"'";


            DataTable linhas = conexao.retornarDataSet(sql);

            if (linhas.Rows.Count > 0)
            {
                DataRow dados = linhas.Rows[0];
                conta = dados[0].ToString();
            }

            return conta;
        }
    }
}
