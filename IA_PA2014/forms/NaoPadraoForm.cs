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
    public partial class NaoPadraoForm : IA_PA2015.forms.FormBase
    {
        ConexaoDB con;
        public NaoPadraoForm()
        {
            lerArquivoConfig();
            con = new ConexaoDB(strConecaoCPC);
            InitializeComponent();
        }

        private DataTable getLancamento()
        {

            DataTable dados = null;
            try
            {
                String sql = "select idLancamento,dsLancamento from "+nomeBD_PPA+"..PPALancamentoPadronizado "
                            + " where inFixa = 0 or idLancamento in(101, 509,94,103,100,102) order by dsLancamento ";

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

        public DataTable getUnidadesGestoras()
        {
            DataTable dados = null;
            try
            {
                con.abreBanco();

                dados = con.retornarDataSet("select cdUnidadeGestora, convert(varchar, cdUnidadeGestora) +' - '+dsUnidadeGestora as dsUnidadeGestora from " + nomeBD_PPA + "..PPAUnidadeGestora order by cdUnidadeGestora");

            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao listar Unidades Gestoras");

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

        private void getHistorico(int id_evento, ComboBox combo)
        {

            try
            {
                String sql = "select cd_historico, ds_historico from " + nomeBD_AUX + "..aux_historico_tcm "
                           + " where cd_evento = " + id_evento.ToString()
                           + " order by ds_historico ";

                con.abreBanco();

                combo.DataSource = con.retornarDataSet(sql);
                combo.DisplayMember = "ds_historico";
                combo.ValueMember = "cd_historico";
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

        private void listaPareados() {

            try
            {
                String sql = "select n.*, p.dsLancamento "
                            + "from AUXILIAR..aux_parear_nao_padrao n "
                            + "inner join A_PPA..PPALancamentoPadronizado p on p.idLancamento = n.idLancamento";

                con.abreBanco();

                dgPareados.DataSource = con.retornarDataSet(sql);

                con.fechaBanco();
            }
            catch (Exception ex) {
                MessageExcept.messageFacede("Erro ao ler dados \n" + ex.Message, 1);
            }
        }

        private void NaoPadraoForm_Load(object sender, EventArgs e)
        {
            cbTipoLAncamentoPadrao.DataSource = getLancamento();
            cbTipoLAncamentoPadrao.DisplayMember = "dsLancamento";
            cbTipoLAncamentoPadrao.ValueMember = "idLancamento";

            cbUnidadeGestora.DataSource = getUnidadesGestoras();
            cbUnidadeGestora.ValueMember = "cdUnidadeGestora";
            cbUnidadeGestora.DisplayMember = "dsUnidadeGestora";

            cbEventoDebito.DataSource = getEvento();
            cbEventoDebito.DisplayMember = "ds_evento";
            cbEventoDebito.ValueMember = "cd_evento";

            cbEventoCredito.DataSource = getEvento();
            cbEventoCredito.DisplayMember = "ds_evento";
            cbEventoCredito.ValueMember = "cd_evento";

            listaPareados();

        }

        private void carregaHistoricoCredito(int idEvento) {
            getHistorico(idEvento, cbHistoricoCredito);
        }

        private void carregaHistoricoDebito(int idEvento)
        {
            getHistorico(idEvento, cbHistoricoDebito);

        }

        private void cbEventoCredito_DropDownClosed(object sender, EventArgs e)
        {
            carregaHistoricoCredito(Convert.ToUInt16(cbEventoCredito.SelectedValue.ToString()));
        }

        private void cbEventoDebito_DropDown(object sender, EventArgs e)
        {
            carregaHistoricoDebito(Convert.ToUInt16(cbEventoDebito.SelectedValue.ToString()));
        }

        private void cbEventoCredito_ValueMemberChanged(object sender, EventArgs e)
        {
            carregaHistoricoCredito(Convert.ToUInt16(cbEventoCredito.SelectedValue.ToString()));
        }

        private void cbEventoDebito_ValueMemberChanged(object sender, EventArgs e)
        {
            carregaHistoricoDebito(Convert.ToUInt16(cbEventoDebito.SelectedValue.ToString()));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Parametro parametro = new Parametro();
            parametro.IdLancamento = cbTipoLAncamentoPadrao.SelectedValue.ToString();
            parametro.CdEventoCredito = cbEventoCredito.SelectedValue.ToString();
            parametro.CdHistoricoCredito = cbHistoricoCredito.SelectedValue.ToString();
            parametro.CdEventoDebito = cbEventoDebito.SelectedValue.ToString();
            parametro.CdHistoricoDebito = cbHistoricoDebito.SelectedValue.ToString();

            if (ckTodosOrgaos.Checked)
            {

                DataTable dados = getUnidadesGestoras();
                foreach (DataRow linha in dados.Rows)
                {
                    parametro.CdUnidadeGestora = linha[0].ToString();

                    gravaRegistro(parametro);
                }

                
            }
            else {
                parametro.CdUnidadeGestora = cbUnidadeGestora.SelectedValue.ToString();
                gravaRegistro(parametro);
            }


            MessageExcept.messageFacede("Registro(s) Salvo(s)", 2);
            listaPareados();
        }


        private void gravaRegistro(Parametro paramentro) { 
            con.abreBanco();

            String sql = "INSERT INTO " + nomeBD_AUX + "..aux_parear_nao_padrao "
                        + " (cdUnidadeGestora, cdEventoCredito,cdHistoricoCredito,cdEventoDebito,cdHistoricoDebito "
                        + ",idLancamento) VALUES (" + paramentro.CdUnidadeGestora + ", " + paramentro.CdEventoCredito + ", "
                        + paramentro.CdHistoricoCredito + "," + paramentro.CdEventoDebito + "," + paramentro.CdHistoricoDebito
                        + "," + paramentro.IdLancamento + ")";

            con.executaSemRetorno(sql);
        }


        public class Parametro {
            private String idLancamento;

            public String IdLancamento
            {
                get { return idLancamento; }
                set { idLancamento = value; }
            }
            private String cdUnidadeGestora;

            public String CdUnidadeGestora
            {
                get { return cdUnidadeGestora; }
                set { cdUnidadeGestora = value; }
            }
            private String cdEventoCredito;

            public String CdEventoCredito
            {
                get { return cdEventoCredito; }
                set { cdEventoCredito = value; }
            }
            private String cdHistoricoCredito;

            public String CdHistoricoCredito
            {
                get { return cdHistoricoCredito; }
                set { cdHistoricoCredito = value; }
            }
            private String cdEventoDebito;

            public String CdEventoDebito
            {
                get { return cdEventoDebito; }
                set { cdEventoDebito = value; }
            }
            private String cdHistoricoDebito;

            public String CdHistoricoDebito
            {
                get { return cdHistoricoDebito; }
                set { cdHistoricoDebito = value; }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                String sql = "delete from " + nomeBD_AUX + "..aux_parear_nao_padrao where id = " + dgPareados[0, dgPareados.CurrentRow.Index].Value.ToString();
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



    }



    
}
