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
    public partial class EmpenhoReciboForm : IA_PA2015.forms.FormBase
    {
        ConexaoDB con;       
        public EmpenhoReciboForm()
        {
            lerArquivoConfig();
            con = new ConexaoDB(strConecaoCPC);
            InitializeComponent();
        }

        public void listaEmpenhos() {
            con.abreBanco();
            String sql = "select nrEmpenho, dtAnoEmissao,nrLicitacao, dtEmissaoEmpenho, "
                        + "nrProcessoCompra, nrContrato  from "+nomeBD_CPE+"..EMPENHO "
                        + "where dtAnoEmissao = 2015";

            dgEmpenho.DataSource = con.retornarDataSet(sql);
        }

        private void EmpenhoReciboForm_Load(object sender, EventArgs e)
        {
            listaEmpenhos();
        }

        private void dgEmpenho_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            String empenho = dgEmpenho[0, dgEmpenho.CurrentRow.Index].Value.ToString();
            String ano = dgEmpenho[1, dgEmpenho.CurrentRow.Index].Value.ToString();
            String contrato = dgEmpenho[4, dgEmpenho.CurrentRow.Index].Value.ToString();

            lbNrEmpenho.Text = empenho;
            lbAno.Text = ano;
            lbNrContrato.Text = contrato;
            txRecibo.Text = "";
            

        }

        private void btGravar_Click(object sender, EventArgs e)
        {
            try
            {
                String sql = "insert into " + nomeBD_AUX + "..AUX_EMPENHO_RECIBO (nrEmpenho, nrAno,cdBarrasRecibo) values ("
                            + "'" + lbNrEmpenho.Text + "', '" + lbAno.Text + "','" + txRecibo.Text + "')";
                con.abreBanco();
                con.executaSemRetorno(sql);
                con.fechaBanco();
                
            }
            catch(Exception ex){
                MessageExcept.messageFacede("Erro ao gravar.\n"+ex.Message,1);
            }
        }


    }
}
