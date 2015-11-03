using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;


namespace IA_PA2015
{
    public partial class FormMain : Form
    {
        private String pathApp;
        private String pathExe;
        public FormMain()
        {
            pathExe = System.AppDomain.CurrentDomain.BaseDirectory.ToString();
            pathApp = pathExe+ @"\ArquivosGerados";

            InitializeComponent();
            Splash splash = new Splash();
            splash.Show();
            Thread.Sleep(3000);
            splash.Dispose();
            splash.Close();
            this.Show();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            if (!Directory.Exists(pathApp)) {
                Directory.CreateDirectory(pathApp);
            }

        }

        private void confgurarBancoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dbConfig DbConfig = new dbConfig(pathExe);
            DbConfig.MdiParent = this;
            DbConfig.Show();
        }

        private void gerarArquivoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            forms.GerarArquivo gerarArquivo = new forms.GerarArquivo(pathExe);
            gerarArquivo.MdiParent = this;
            gerarArquivo.Show();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ordenadorDespesasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            forms.OrdenadorForm ordenadorForm = new forms.OrdenadorForm();
            ordenadorForm.MdiParent = this;
            ordenadorForm.Show();
        }

        private void históricoPadrãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            forms.ParearForm parearForm = new forms.ParearForm();
            parearForm.MdiParent = this;
            parearForm.Show();

        }

        private void empenhoVsReciboMuralToolStripMenuItem_Click(object sender, EventArgs e)
        {
            forms.ValidaReciboForm empenhoReciboForm = new forms.ValidaReciboForm();
            empenhoReciboForm.MdiParent = this;
            empenhoReciboForm.Show();

        }

        private void eventoHistoricoFolhaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            forms.ParearLancamentoFolhaForm lancamentoFolhaForm = new forms.ParearLancamentoFolhaForm();
            lancamentoFolhaForm.MdiParent = this;
            lancamentoFolhaForm.Show();
        }

        private void lançamentoNãoPAdrãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            forms.NaoPadraoForm  naoPadraoForm = new forms.NaoPadraoForm();
            naoPadraoForm.MdiParent = this;
            naoPadraoForm.Show();
        }

        private void contaPCAContaTCMToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IA_PA2014.forms.ContaAContaForm contaAContaForm = new IA_PA2014.forms.ContaAContaForm();
            contaAContaForm.MdiParent = this;
            contaAContaForm.Show();
        }
    }
}
