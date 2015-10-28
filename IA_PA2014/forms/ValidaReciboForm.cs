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
    public partial class ValidaReciboForm : IA_PA2015.forms.FormBase
    {
        ConexaoDB con;
        String code1;
        String code2;
        String code3;
        String code4;
        String dvCode1;
        String dvCode2;
        String dvCode3;
        String dvCode4;

        public ValidaReciboForm()
        {
            lerArquivoConfig();
            con = new ConexaoDB(strConexaoAUX);
            InitializeComponent();
        }

        private void ValidaReciboForm_Load(object sender, EventArgs e)
        {

            String sql = "select tab.dsConteudo "
	                    +" ,(select m.nrEmpenho from "+nomeBD_CPE+"..movimento m where m.nrSequencia = tab.nrSequencia ) as nrEmpenho "
                        + " ,(select m.dtAnoEmissao from " + nomeBD_CPE + "..movimento m where m.nrSequencia = tab.nrSequencia ) as nrEmpenho "
                        + " from ( select dbo.FN_RemoveCaracteresNaoInteiros(dsConteudo) dsConteudo, nrSequencia from " + nomeBD_CPE + "..movimentonota  "
                        + " where nrsequencia in (select NRSEQUENCIA from " + nomeBD_CPE + "..movimento where cdunidadegestora = 1      "
                        +" and cdtipomovimento in (430,431,432))          "
                        +" and idformulariogerador = 1 and cdcampogerador in (352,353,354,355) ) tab  "
                        + " where len(tab.dsConteudo) > 40";

            con.abreBanco();
            DataTable data = con.retornarDataSet(sql);
 
            foreach(DataRow row in data.Rows){
                addGridLine(row);
            }
        }

        private void addGridLine(DataRow row) {

            if (isBarCode(numberOnly(row[0].ToString()))) {
                DataGridViewRow newLine = (DataGridViewRow)gridRecibo.Rows[0].Clone();
                newLine.Cells[0].Value = row[1].ToString();
                newLine.Cells[1].Value = row[2].ToString();
                String origBarCode = separeteBarCode(numberOnly(row[0].ToString()));
                String recoBarCode = recomposeBarCode(); 

                newLine.Cells[2].Value = isValidBarCode(origBarCode,recoBarCode);
                newLine.Cells[3].Value = origBarCode;
                newLine.Cells[4].Value = recoBarCode;

                gridRecibo.Rows.Add(newLine);
            }
        }


        private String isValidBarCode(String orige, String recompose) { 
            String valid = "Invalido";

            if (orige.Equals(recompose)) {
                valid = "Valido";
            }

            return valid;
        }


        private String numberOnly(String word) {
            return String.Join("", System.Text.RegularExpressions.Regex.Split(word, @"[^\d]"));
        }

        private bool isBarCode(String codeBar) {
            bool isCode = false;
            if (codeBar.Length == 48) {
                isCode = true;
            }

            return isCode;
        }


        private String recomposeBarCode() {
            String strReturn = code1 + "-" + FuncoesUteis.getDigitoMod10(code1).ToString() + " " +
                               code2 + "-" + FuncoesUteis.getDigitoMod10(code2).ToString() + " " +
                               code3 + "-" + FuncoesUteis.getDigitoMod10(code3).ToString() + " " +
                               code4 + "-" + FuncoesUteis.getDigitoMod10(code4).ToString();  
            return strReturn; 
        }

        private String separeteBarCode(String barCode) {

            code1 = barCode.Substring(0, 11);
            dvCode1 = barCode.Substring(11, 1);

            code2 = barCode.Substring(12, 11);
            dvCode2 = barCode.Substring(23, 1);

            code3 = barCode.Substring(24, 11);
            dvCode3 = barCode.Substring(35, 1);

            code4 = barCode.Substring(36, 11);
            dvCode4 = barCode.Substring(47, 1);


            return code1 + "-" + dvCode1 + " " + code2 + "-" + dvCode2 + " " + code3 + "-" + dvCode3 + " " + code4 + "-" + dvCode4;
        }




        private bool validateDV(String code, String dv) { 
            bool isValid = false;
            
            if (FuncoesUteis.getDigitoMod10(code) == Convert.ToInt16(dv)) {
                isValid = false;
            }

            return isValid;
        }


    }
}
