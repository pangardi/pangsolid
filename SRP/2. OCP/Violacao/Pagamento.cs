using System;

namespace SOLID._2._OCP.Violacao
{
    public class Pagamento
    {
        public void RealizarPagamento(string conta, decimal valor, TipoPagamento tipoPagamento)
        {
            if (tipoPagamento == TipoPagamento.DEBITO)
            {
                Console.WriteLine($"DOC Realizado para o cliente {conta} no valor de {valor}");
            }
            else if (tipoPagamento == TipoPagamento.CREDITO)
            {
                Console.WriteLine($"TED Realizado para o cliente {conta} no valor de {valor}");
            }
        }
    }
}
