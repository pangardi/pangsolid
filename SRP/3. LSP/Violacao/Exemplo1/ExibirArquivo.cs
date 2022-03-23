using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID._3._LSP.Violacao
{
    public class ExibirArquivo
    {
        public ExibirArquivo(Arquivo arquivo)
        {
            if (arquivo is PDF)
            {
                ((PDF)arquivo).ExibirPDF();
            }
            else if (arquivo is Excel)
            {
                ((Excel)arquivo).ExibirExcel();
            }
        }
    }
}
