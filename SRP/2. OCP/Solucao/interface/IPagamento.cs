namespace SOLID._2._OCP.Solucao
{
    public interface IPagamento
    {
        void RealizarPagamento(string conta, decimal valor);
    }
}
