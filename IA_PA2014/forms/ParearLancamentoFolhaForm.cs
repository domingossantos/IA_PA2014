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
    public partial class ParearLancamentoFolhaForm : IA_PA2015.forms.FormBase
    {
        ConexaoDB con;
        public ParearLancamentoFolhaForm()
        {
            lerArquivoConfig();
            con = new ConexaoDB(strConexaoAUX);
            InitializeComponent();
        }

        private DataTable getOrgao() {
            DataTable dados = null;
            try
            {
                String sql = "select 0 cdOrgao,'Não se Aplica' dsOrgaoUnidade union "
                           + "select  cdOrgao, dsOrgaoUnidade from " + nomeBD_PPA + "..PPAOrgaoUnidade where cdUnidade = 0";

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

        private DataTable getFornecedor()
        {

            DataTable dados = null;
            try
            {
                String sql = "select  cdFornecedor, nmFornecedor from "+nomeBD_CPE+"..QueryFornecedor e "
                             + " where  e.nmFornecedor like '%"+prefixoFornecedor+"%' ";

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

        private void getHistorico(int id_evento)
        {


            try
            {
                String sql = "select cd_historico, ds_historico from " + nomeBD_AUX + "..aux_historico_tcm "
                           + " where cd_evento = " + id_evento.ToString()
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

        private void ParearLancamentoFolhaForm_Load(object sender, EventArgs e)
        {
            cbFornecedor.DataSource = getFornecedor();
            cbFornecedor.DisplayMember = "nmFornecedor";
            cbFornecedor.ValueMember = "cdFornecedor";

            cbOrgao.DataSource = getOrgao();
            cbOrgao.DisplayMember = "dsOrgaoUnidade";
            cbOrgao.ValueMember = "cdOrgao";

            cbTipoLAncamentoPadrao.DataSource = getLancamentoPadrao();
            cbTipoLAncamentoPadrao.DisplayMember = "dsLancamentoComp";
            cbTipoLAncamentoPadrao.ValueMember = "id";
            
            cbEvento.DataSource = getEvento();
            cbEvento.DisplayMember = "ds_evento";
            cbEvento.ValueMember = "cd_evento";

            listaPareados();

        }

        private void btGrava_Click(object sender, EventArgs e)
        {
            try
            {

                String sql = "";
                
                con.abreBanco();



                sql = "INSERT INTO " + nomeBD_AUX + "..parear_folha_evento_historico "
                            + "(cdUnidadeGestora ,cdFornecedor , cdEvento, cdHistorico, cdOrgao, idLancamento) VALUES "
                            + "(1, " + cbFornecedor.SelectedValue.ToString() + ", "
                            + cbEvento.SelectedValue.ToString() + ","
                            + cbHistorico.SelectedValue.ToString() + ","
                            + cbOrgao.SelectedValue.ToString() + "," 
                            + cbTipoLAncamentoPadrao.SelectedValue.ToString() +")";
                //MessageExcept.messageFacede(sql, 1);
                con.executaSemRetorno(sql);


                listaPareados();
                MessageExcept.messageFacede("Registro(s) gravado(s).", 2);
            }
            catch (Exception ex)
            {

                MessageExcept.messageFacede("Erro ao registrar. \nVerifique se já não há o registro gravado \n" + ex.Message, 1);
            }

            finally
            {
                con.fechaBanco();
            }
        }

        private void listaPareados()
        {
            String sql = "select p.id,f.nmFornecedor,p.cdEvento, p.cdHistorico, cdOrgao, idLancamento from "+nomeBD_AUX+"..parear_folha_evento_historico p "
                          + " inner join "+nomeBD_CPE+"..QueryFornecedor f on f.cdFornecedor = p.cdFornecedor";
            con.abreBanco();
            gridConta.DataSource = con.retornarDataSet(sql);
            con.fechaBanco();
                
        }

        private void cbEvento_ValueMemberChanged(object sender, EventArgs e)
        {
            getHistorico(Convert.ToUInt16(cbEvento.SelectedValue.ToString()));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                String sql = "delete from " + nomeBD_AUX + "..parear_folha_evento_historico where id = " + gridConta[0, gridConta.CurrentRow.Index].Value.ToString();
                con.abreBanco();
                con.executaSemRetorno(sql);
                MessageExcept.messageFacede("Registro apagado", 2);
                listaPareados();
            }
            finally
            {
                con.fechaBanco();
            }
        }

        private void cbEvento_DropDown(object sender, EventArgs e)
        {
            getHistorico(Convert.ToUInt16(cbEvento.SelectedValue.ToString()));
        }
    }
}
