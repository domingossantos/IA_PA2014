using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using IA_PA2015.modelo;
using IA_PA2015.utils;

namespace IA_PA2014.forms
{
    public partial class DuplicarPadraoForm : IA_PA2015.forms.FormBase
    {
        Contabilidade contabilidade;
        public DuplicarPadraoForm()
        {
            lerArquivoConfig();
            contabilidade = new Contabilidade(strConexaoAUX);
            InitializeComponent();
        }

        private void getLancamento() {
            cbLancamento.DataSource = contabilidade.getListaLancamentoPadao(nomeBD_AUX);
            cbLancamento.DisplayMember = "dsLancamentoComp";
            cbLancamento.ValueMember = "id";
        }

        private void getPareados() {
            grid.DataSource = contabilidade.getLancamentoPadraoDuplicado(nomeBD_AUX);
        }

        private void DuplicarPadraoForm_Load(object sender, EventArgs e)
        {
            getPareados();
            getLancamento();
        }

        private void btnExclui_Click(object sender, EventArgs e)
        {
            contabilidade.apagaLancamentoDuplicar(nomeBD_AUX, grid[0, grid.CurrentRow.Index].Value.ToString());
            MessageExcept.messageFacede("Registro apagado", 2);
            getPareados();
        }

        private void btnGrava_Click(object sender, EventArgs e)
        {
            contabilidade.gravaLancamentoDuplicar(nomeBD_AUX, cbLancamento.SelectedValue.ToString(), txContaDebito.Text, txContaCredito.Text);
            MessageExcept.messageFacede("Registro gravado", 2);
            getPareados();
        }
    }
}
