namespace SOLID._2._OCP.Solucao
{
    public class PagamentoDOC : IPagamento
    {    
        public void RealizarPagamento(string conta, decimal valor)
        {
            //Aplicar regras para DOC
            System.Console.WriteLine($"DOC realizado para o cliente {conta} no valor de {valor}!");
        }
    }
}
