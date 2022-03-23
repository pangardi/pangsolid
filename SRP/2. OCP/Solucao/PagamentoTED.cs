namespace SOLID._2._OCP.Solucao
{
    public class PagamentoTED : IPagamento
    {
        public void RealizarPagamento(string conta, decimal valor)
        {
            //Aplicar regras para TED
            System.Console.WriteLine($"TED realizado para o cliente {conta} no valor de {valor}!");
        }
    }
}
