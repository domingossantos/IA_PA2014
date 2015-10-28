using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using IA_PA2015.utils;
namespace IA_PA2015.forms
{
    public partial class ParearForm : IA_PA2015.forms.FormBase
    {
        ConexaoDB con;
        public ParearForm()
        {
            lerArquivoConfig();
            con = new ConexaoDB(strConecaoCPC);

            InitializeComponent();
        }


        private DataTable getEmenta()
        {

            DataTable dados = null;
            try
            {
                String sql = "select 0 cdEmenta,'Não se aplica' dsEmenta union "
                            + "select cdEmenta,dsEmenta from "+nomeBD_CPI+"..EMENTA";

                con.abreBanco();
                dados = con.retornarDataSet(sql);
            }
            catch (Exception ex)
            {
                MessageExcept.messageFacede("Erro: \n" + ex.Message, 1);
            }
            finally
            {
                con.fechaBanco();
            }

            return dados;
        }

        private DataTable getOrgao()
        {
            DataTable dados = null;
            try
            {
                String sql = "select 0 cdOrgao,'Não se Aplica' dsOrgaoUnidade union " 
                            +"select  cdOrgao, dsOrgaoUnidade from " + nomeBD_PPA + "..PPAOrgaoUnidade where cdUnidade = 0";

                con.abreBanco();
                dados = con.retornarDataSet(sql);
            }
            catch (Exception ex)
            {
                MessageExcept.messageFacede("Erro: \n" + ex.Message, 1);
            }
            finally
            {
                con.fechaBanco();
            }

            return dados;
        }

        private DataTable getTipoLicitacao() {

            DataTable dados = null;
            try
            {
                String sql = " select 0 cdTipoLicitacao,'Sem Licitação' dsTipoLicitacao union "
                           +"select cdTipoLicitacao,dsTipoLicitacao from " + nomeBD_CPC + "..TIPOLICITACAO "
                           + " order by cdTipoLicitacao ";

                con.abreBanco();
                dados = con.retornarDataSet(sql);
            }
            catch (Exception ex)
            {
                MessageExcept.messageFacede("Erro: \n" + ex.Message, 1);
            }
            finally {
                con.fechaBanco();
            }

            return dados;
        }



        private DataTable getLancamentoPadrao()
        {

            DataTable dados = null;
            try
            {
                String sql = "select id, dsLancamentoComp from " + nomeBD_AUX + "..aux_lancamento_padrao order by dsLancamento";

                con.abreBanco();
                dados = con.retornarDataSet(sql);
            }
            catch (Exception ex)
            {
                MessageExcept.messageFacede("Erro: \n" + ex.Message, 1);
            }
            finally
            {
                con.fechaBanco();
            }

            return dados;
        }


        private DataTable getNaturezaDespeza()
        {

            DataTable dados = null;
            try
            {
                String sql = " select '0' AS cdNaturezaDespesa,'0.0.00.00.00.00.00 - NÃO SE APLICA' AS dsDetalhadaNaturezaDespesa union "
                           + " select cdNaturezaDespesa, cdNaturezaDespesa + '- '+ upper( dsDetalhadaNaturezaDespesa) as dsDetalhadaNaturezaDespesa  "
                           + " from " + nomeBD_CPE + "..DATAVIEW_DESPESA "
                           + " where cdNaturezaDespesa in(select cdNaturezaDespesa from A15_CPE2015..MOVIMENTO) "
                           + " group by cdNaturezaDespesa,dsDetalhadaNaturezaDespesa";
                           

                con.abreBanco();
                dados = con.retornarDataSet(sql);
            }
            catch (Exception ex)
            {
                MessageExcept.messageFacede("Erro: \n" + ex.Message, 1);
            }
            finally
            {
                con.fechaBanco();
            }

            return dados;
        }

        private DataTable getEvento()
        {

            DataTable dados = null;
            try
            {
                String sql = "select cd_evento,ds_evento from " + nomeBD_AUX + "..aux_evento_tcm "
                           + " order by ds_evento ";

                con.abreBanco();
                dados = con.retornarDataSet(sql);
            }
            catch (Exception ex)
            {
                MessageExcept.messageFacede("Erro: \n" + ex.Message, 1);
            }
            finally
            {
                con.fechaBanco();
            }

            return dados;
        }

        private void getContaContabil(String nrAno) { 
        
            try
            {
                String sql = "select 0 as cdContaContabil, '0 Não se Aplica' as conta union "
                            + "select cdContaContabil, cdNivelContabil as conta from "+nomeBD_PPA+"..PPAPlanoConta  "
                            + " where cdContaContabil in(select cdContaContabil from "+nomeBD_CPE+"..MOVIMENTO where YEAR(dtMovimento) = "+nrAno+") "
                            + "order by conta ";

                con.abreBanco();

                cbNivelContabil.DataSource = con.retornarDataSet(sql);
                cbNivelContabil.DisplayMember = "conta";
                cbNivelContabil.ValueMember = "conta";
            }
            catch (Exception ex)
            {
                MessageExcept.messageFacede("Erro: \n" + ex.Message, 1);
            }

        }

        private void getHistorico(int id_evento)
        {

           
            try
            {
                String sql = "select cd_historico, ds_historico from " + nomeBD_AUX + "..aux_historico_tcm "
                           + " where cd_evento = "+ id_evento.ToString()
                           + " order by ds_historico ";

                con.abreBanco();

                cbHistorico.DataSource = con.retornarDataSet(sql);
                cbHistorico.DisplayMember = "ds_historico";
                cbHistorico.ValueMember = "cd_historico";
            }
            catch (Exception ex)
            {
                MessageExcept.messageFacede("Erro: \n" + ex.Message, 1);
            }
            finally
            {
                con.fechaBanco();
            }

            
        }

        private DataTable getNivelContabil()
        {

            DataTable dados = null;
            try
            {
                String sql = "select cdNivelContabil, cdNivelContabil + ' - ' +dsConta as dsConta from " + nomeBD_CPE + "..DATAVIEW_CONTA_CONTABIL "
                           + " order by cdNivelContabil ";

                con.abreBanco();
                dados = con.retornarDataSet(sql);
            }
            catch (Exception ex)
            {
                MessageExcept.messageFacede("Erro: \n" + ex.Message, 1);
            }
            finally
            {
                con.fechaBanco();
            }

            return dados;
        }

        private void ParearForm_Load(object sender, EventArgs e)
        {


            String nrAno = utils.Prompt.ShowDialog("Digite o ano de referência", "Informe o ano de referência para carregas os dados");

            if (!nrAno.Equals(""))
            {

                cbTipoLicitacao.DataSource = getTipoLicitacao();
                cbTipoLicitacao.DisplayMember = "dsTipoLicitacao";
                cbTipoLicitacao.ValueMember = "cdTipoLicitacao";

                cbOrgao.DataSource = getOrgao();
                cbOrgao.DisplayMember = "dsOrgaoUnidade";
                cbOrgao.ValueMember = "cdOrgao";


                cbEmenta.DataSource = getEmenta();
                cbEmenta.DisplayMember = "dsEmenta";
                cbEmenta.ValueMember = "cdEmenta";

                cbTipoLAncamentoPadrao.DataSource = getLancamentoPadrao();
                cbTipoLAncamentoPadrao.DisplayMember = "dsLancamentoComp";
                cbTipoLAncamentoPadrao.ValueMember = "id";

                cbNatureza.DataSource = getNaturezaDespeza();
                cbNatureza.DisplayMember = "dsDetalhadaNaturezaDespesa";
                cbNatureza.ValueMember = "cdNaturezaDespesa";


                cbEvento.DataSource = getEvento();
                cbEvento.DisplayMember = "ds_evento";
                cbEvento.ValueMember = "cd_evento";

                getContaContabil(nrAno);

                listaPareados();
            }

        }

        private void cbEvento_ValueMemberChanged(object sender, EventArgs e)
        {
            getHistorico(Convert.ToUInt16(cbEvento.SelectedValue.ToString()));
        }

        private void cbEvento_DropDownClosed(object sender, EventArgs e)
        {
            getHistorico(Convert.ToUInt16(cbEvento.SelectedValue.ToString()));
        }

        

        private void listaPareados() {
            String sql = "select  pc.id  ,(select p.dsLancamento from " + nomeBD_AUX + "..AUX_LANCAMENTO_PADRAO p 	"
				+ " where pc.idConjuntoLancamento = p.id ) as LancamentoPadao "
	            + " ,(select c.dsContaContabil from "+nomeBD_CPC+"..contacontabil c where c.cdContaContabil = 		"
                + " (select  p.cdContaCredito from " + nomeBD_AUX + "..AUX_LANCAMENTO_PADRAO p 	"
				+ " 	where pc.idConjuntoLancamento = p.id  )) as dsContaCredito "
                + " ,(select c.cdNivelContabil from " + nomeBD_CPC + "..contacontabil c where c.cdContaContabil = 		"
                + " (select  p.cdContaCredito from " + nomeBD_AUX + "..AUX_LANCAMENTO_PADRAO p 	"
				+ " 	where pc.idConjuntoLancamento = p.id )) as cdNivelCredito	"
                + " ,(select c.dsContaContabil from " + nomeBD_CPC + "..contacontabil c where c.cdContaContabil = 		"
                + " (select  p.cdContaDebito from " + nomeBD_AUX + "..AUX_LANCAMENTO_PADRAO p 	"
				+ " 	where pc.idConjuntoLancamento = p.id  )) as dsContaDebito "
                + " ,(select c.cdNivelContabil from " + nomeBD_CPC + "..contacontabil c where c.cdContaContabil = 		"
                + " (select  p.cdContaDebito from " + nomeBD_AUX + "..AUX_LANCAMENTO_PADRAO p 	"
                + " ,(select l.dsTipoLicitacao from  " + nomeBD_CPC + "..TIPOLICITACAO l where pc.cdTipoLicitacao = l.cdTipoLicitacao  ) as dsTipoLicitacao "
				+ " 	where pc.idConjuntoLancamento = p.id )) as cdNivelDebito "
	            + " ,pc.cdNaturezaDespesa  ,pc.cdEvento,pc.cdHistorico, pc.cdEmenta, pc.cdNivelContabil "
                + " from " + nomeBD_AUX + "..aux_paridade_conta pc   ";
            
            con.abreBanco();
            gridPareados.DataSource = con.retornarDataSet(sql);
            con.fechaBanco();
        }


        private void gravaRegistro(Pareamento paramento) {
            try
            {
                con.abreBanco();

                String sql = "";

                sql = "INSERT INTO " + nomeBD_AUX + "..aux_paridade_conta "
                                + "(idConjuntoLancamento ,cdNaturezaDespesa ,cdTipoLicitacao, cdEvento, "
                                + " cdHistorico, cdEmenta, cdORgao, cdNivelContabil, tpOperacao) VALUES "
                                + "(" + paramento.IdLancamentoPadrao + ", '" + paramento.IdNatureza + "', "
                                + paramento.IdTipoLicitacao + ", " + paramento.CdEvento + ","
                                + paramento.CdHistorico + "," + paramento.IdEmenta + ", "
                                + paramento.IdOrgao + ", '"+paramento.CdNivelContabil+"','"+paramento.TpOperacao+"')";

                con.executaSemRetorno(sql);
            }
            catch (Exception ex) {
                MessageExcept.messageFacede("Erro ao registrar. \nVerifique se já não há o registro gravado \n" + ex.Message, 1);
            }
        
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                
                Pareamento paramento = new Pareamento();
                paramento.IdEmenta = cbEmenta.SelectedValue.ToString();
                paramento.IdLancamentoPadrao = cbTipoLAncamentoPadrao.SelectedValue.ToString();
                paramento.IdNatureza = cbNatureza.SelectedValue.ToString();
                paramento.IdOrgao = cbOrgao.SelectedValue.ToString();
                paramento.IdTipoLicitacao = cbTipoLicitacao.SelectedValue.ToString();
                paramento.CdEvento = cbEvento.SelectedValue.ToString();
                paramento.CdHistorico = cbHistorico.SelectedValue.ToString();
                paramento.TpOperacao = cbOperacao.Text.Substring(0, 1);

                if (!cbNivelContabil.SelectedValue.ToString().Substring(0, 1).Equals("0")) {
                    paramento.CdNivelContabil = cbNivelContabil.Text.ToString();
                }

                if (ckTodosOrgaos.Checked)
                {
                    DataTable dados = getOrgao();
                    gravaRegistro(paramento);
                        
                    foreach (DataRow linha in dados.Rows) {
                        paramento.IdOrgao = linha[0].ToString();
                        gravaRegistro(paramento);
                    }

                }
                else
                {
                    gravaRegistro(paramento);
                }
                listaPareados();
                MessageExcept.messageFacede("Registro(s) gravado(s).", 2);
            }
            catch (Exception ex)
            {

                MessageExcept.messageFacede("Erro ao registrar. \nVerifique se já não há o registro gravado \n" + ex.Message, 1);
            }
            
            finally {
                con.fechaBanco();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                String sql = "delete from " + nomeBD_AUX + "..aux_paridade_conta where id = " + gridPareados[0, gridPareados.CurrentRow.Index].Value.ToString();
                con.abreBanco();
                con.executaSemRetorno(sql);
                MessageExcept.messageFacede("Registro apagado", 2);
                listaPareados();
            }
            finally {
                con.fechaBanco();
            }
        }

        private void tmAcompanhar_Tick(object sender, EventArgs e)
        {
            //lbTempo.Text = 
        }


        public class Pareamento {
            private String idLancamentoPadrao;

            public String IdLancamentoPadrao
            {
                get { return idLancamentoPadrao; }
                set { idLancamentoPadrao = value; }
            }
            private String idTipoLicitacao;

            public String IdTipoLicitacao
            {
                get { return idTipoLicitacao; }
                set { idTipoLicitacao = value; }
            }
            private String idEmenta;

            public String IdEmenta
            {
                get { return idEmenta; }
                set { idEmenta = value; }
            }
            private String idNatureza;

            public String IdNatureza
            {
                get { return idNatureza; }
                set { idNatureza = value; }
            }
            private String idOrgao;

            public String IdOrgao
            {
                get { return idOrgao; }
                set { idOrgao = value; }
            }
            private String cdEvento;

            public String CdEvento
            {
                get { return cdEvento; }
                set { cdEvento = value; }
            }
            private String cdHistorico;

            public String CdHistorico
            {
                get { return cdHistorico; }
                set { cdHistorico = value; }
            }

            private String cdNivelContabil;

            public String CdNivelContabil
            {
                get { return cdNivelContabil; }
                set { cdNivelContabil = value; }
            }

            private String tpOperacao;

            public String TpOperacao
            {
                get { return tpOperacao; }
                set { tpOperacao = value; }
            }



        }
        
    }
}
