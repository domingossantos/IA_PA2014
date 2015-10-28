using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace IA_PA2015.utils
{
    class MessageExcept
    {
        /// <summary>
        /// Função retorna ao usúario messagem do internas do sistema.
        /// </summary>
        /// <param name="txtMsg">Descrição da messagem.</param>        
        /// <param name="nrMsg">Número da messagem: {1} Erro, {2} Informação, {3} Advertência, {4} Questionamento.</param>
        public static void messageFacede(string txtMsg, Int16 nrMsg)
        {
            switch (nrMsg)
            {
                case 1:
                    {
                        MessageBox.Show(txtMsg, "Erro:", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                    }

                case 2:
                    {
                        MessageBox.Show(txtMsg, "Informação:", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                    }

                case 3:
                    {
                        MessageBox.Show(txtMsg, "Advertência:", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        break;
                    }

                case 4:
                    {
                        MessageBox.Show(txtMsg, "Questionamento:", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                        break;
                    }

                default:
                    break;
            }
        }
    }
}
