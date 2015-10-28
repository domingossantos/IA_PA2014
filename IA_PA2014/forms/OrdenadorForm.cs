using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using IA_PA2015.utils;

namespace IA_PA2015.forms
{
    public partial class OrdenadorForm : FormBase
    {
        modelo.Contabilidade contabilidade;
        public OrdenadorForm()
        {
            InitializeComponent();

        }

        private void OrdenadorForm_Load(object sender, EventArgs e)
        {
                if (lerArquivoConfig())
                {
                    contabilidade = new modelo.Contabilidade(strConecaoCPC);

                    cmbPessoa.DataSource = contabilidade.getPessoas(nomeBD_CPC);
                    cmbPessoa.DisplayMember = "nmPessoa";
                    cmbPessoa.ValueMember = "nrCpf";
                    cmbPessoa.SelectedIndex = -1;

                    //lista.DataSource = contabilidade.getListaPessoas(nomeBD_CPC,nomeBD_AUX);
                    listaGrid();
                }
        }

        private void btSalva_Click(object sender, EventArgs e)
        {
            try
            {
                String cpf = cmbPessoa.SelectedValue.ToString().Replace(',', '.');
                contabilidade.pareaOrdenador(cpf, nomeBD_AUX);
                MessageExcept.messageFacede("registro salvo",2);
                listaGrid();

            }
            catch (Exception ex) {
                MessageExcept.messageFacede("Erro: "+ex,1);
            }
        }

        private void listaGrid() {
            lista.DataSource = contabilidade.getListaPessoas(nomeBD_CPC, nomeBD_AUX);
            lista.Columns[0].HeaderText = "CPF";
            lista.Columns[0].Width = 60;
            lista.Columns[1].HeaderText = "NOME";
            lista.Columns[1].Width = 360;
            lista.Columns[2].HeaderText = "TIPO";
            lista.Columns[2].Width = 160;
        }

        private void btApaga_Click(object sender, EventArgs e)
        {
            try
            {
                String cpf = lista[0, lista.CurrentRow.Index].Value.ToString();

                contabilidade.apagarOrdenador(cpf, nomeBD_AUX);

                MessageExcept.messageFacede("Apagado", 3);

                listaGrid();
            }
            catch (Exception ex)
            {
                MessageExcept.messageFacede("Erro: " + ex, 1);
            }
        }

       
    }
}
