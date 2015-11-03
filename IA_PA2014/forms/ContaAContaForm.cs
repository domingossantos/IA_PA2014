using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using IA_PA2015.utils;
using IA_PA2015.modelo;

namespace IA_PA2014.forms
{
    public partial class ContaAContaForm : IA_PA2015.forms.FormBase
    {
        Contabilidade contabilidade;
        public ContaAContaForm()
        {
            lerArquivoConfig();
            contabilidade = new Contabilidade(strConexaoAUX);
            InitializeComponent();
        }


        private void getContas() {
            
            gridContas.DataSource = contabilidade.getContaAConta(nomeBD_AUX);
            
        }

        private void ContaAContaForm_Load(object sender, EventArgs e)
        {
            getContas();
        }

        private void btnGrava_Click(object sender, EventArgs e)
        {
            
            if(txContaPC.Text.Equals("") || txContaTC.Text.Equals("")){
                MessageExcept.messageFacede("Todos os compos são obrigatorios",3);
                return;
            } else {
                contabilidade.gravaContaAConta(nomeBD_AUX, txContaPC.Text, txContaTC.Text);
                MessageExcept.messageFacede("Registro Gravado",2);
                getContas();
            }
        }

        private void btnExclui_Click(object sender, EventArgs e)
        {
            contabilidade.apagaContaAConta(nomeBD_AUX, gridContas[0, gridContas.CurrentRow.Index].Value.ToString());
            MessageExcept.messageFacede("Registro apagado", 2);
        }
    }
}
