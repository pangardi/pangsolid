namespace SOLID._2._OCP.Solucao
{
    public class Pagamento
    {       
        public void RealizarPagamento(string conta, decimal valor, IPagamento pagamento)
        {
            pagamento.RealizarPagamento(conta, valor);
        }
    }
}
