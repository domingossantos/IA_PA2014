using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IA_PA2015.utils
{
    class FuncoesUteis
    {

        /// <summary>
        /// Retorno o numerido do mes de competencia inicial a partior do tipo de arquivo a ser gerado
        /// </summary>
        /// <param name="valor">Codigo do tipo de arquivo</param>
        /// <returns>mes inicial</returns>
        public static String getMesInicio(String valor)
        {
            String retorno = "";
            switch (valor)
            {
                case "401": retorno = "01"; break;
                case "402": retorno = "05"; break;
                case "403": retorno = "09"; break;
                case "901": retorno = "01"; break;
                case "902": retorno = "01"; break;
                case "903": retorno = "01"; break;
                case "999": retorno = "01"; break;
            }

            return retorno;
        }
        /// <summary>
        /// Retorno o numerido do mes de competencia final a partior do tipo de arquivo a ser gerado
        /// </summary>
        /// <param name="valor">codigo do tipo de arquivo</param>
        /// <returns></returns>
        public static String getMesFim(String valor)
        {
            String retorno = "";
            switch (valor)
            {
                case "401": retorno = "05"; break;
                case "402": retorno = "08"; break;
                case "403": retorno = "12"; break;
                case "901": retorno = "12"; break;
                case "902": retorno = "12"; break;
                case "903": retorno = "12"; break;
                case "999": retorno = "12"; break;
            }

            return retorno;
        }
        /// <summary>
        /// Preenche uma string com um caracter novo com a quantidade informada
        /// </summary>
        /// <param name="txtOrigem">Texto original</param>
        /// <param name="txtInserir">Texto a ser inserido</param>
        /// <param name="lado">Ládo que o texto será inserido 1 - Direito, 0 - Esquedo</param>
        /// <param name="quantidade">Numero de repetiçoes do texto a ser inserido</param>
        /// <returns>String formatada</returns>
        public static string preencher(string txtOrigem, string txtInserir, int lado, int quantidade)
        {
            string txtNovo;
            if (txtOrigem == null)
            {
                txtOrigem = "";
            }

            txtNovo = txtOrigem;

            if (txtNovo.Length < quantidade)
            {
                while (txtNovo.Length < quantidade)
                {
                    if (lado == 1)
                    {
                        txtNovo = txtNovo + txtInserir;
                    }
                    else
                    {
                        if (lado == 0)
                        {
                            txtNovo = txtInserir + txtNovo;
                        }
                    }
                }
            }
            else
            {
                if (txtNovo.Length >= quantidade)
                {
                    txtNovo = txtNovo.Substring(0, quantidade);
                }
            }
            
            return txtNovo;
        }


        public static String converteCPFToString(String entrada){
            
            decimal CPF = Convert.ToDecimal(entrada);
            String CPF2 = entrada;
            CPF = CPF * 100;
            String    sCPF = string.Format("{0:0.##}", CPF);
            int    pos = CPF2.IndexOf(",0000");
            if (pos > 0)
            {
                CPF2 = CPF2.Remove(pos, 5);
            }

            return CPF2;
        }

        public static String removeAlfa(string alfa)
        {
            string C_alfa = "ÄÅÁÂÀÃäáâàãÉÊËÈéêëèÍÎÏÌíîïìÖÓÔÒÕöóôòõÜÚÛüúûùÇçº!@#$%¨&*()_+={[ª?//°;:.>,<|\\§-}]";
            string S_alfa = "AAAAAAaaaaaEEEEeeeeIIIIiiiiOOOOOoooooUUUuuuuCco!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!";

            for (int i = 0; i < C_alfa.Length; i++)
                alfa = alfa.Replace(C_alfa[i].ToString(), S_alfa[i].ToString());
            alfa = alfa.Replace("!", "");
            return alfa;
        }

        public static String formataNumero(string pValor)
        {
            Decimal valor = Convert.ToDecimal(pValor);
            valor = valor * 100;
            String sValor = string.Format("{0:0.##}", valor);
            int pos = sValor.IndexOf(",");
            if (pos > 0)
            {
                sValor = sValor.Remove(pos, 1);
            }

            return sValor;
        }

        public static String limpaCaracter(String texto) {
            texto = texto.Replace(".","").Replace("/","").Replace("-","");
            return texto;
        }

        public static int getDigitoMod10(String str) {
            int i = 2;
            int sum = 0;
            int res = 0;
            foreach (char c in str.ToCharArray())
            {
                res = Convert.ToInt32(c.ToString()) * i;
                sum += res > 9 ? (res - 9) : res;
                i = i == 2 ? 1 : 2;
            }
            
            sum = 10 - (sum % 10);

            if (sum == 10)
                sum = 0;

            return sum;
        }
    }
}
