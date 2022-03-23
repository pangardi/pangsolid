using SOLID._2._OCP.Solucao;
using SOLID._3._LSP.Violacao;

namespace App
{
    class Program
    {
        static void Main(string[] args)
        {
            Pagar(new PagamentoDOC());            
        }

        public static void Pagar(IPagamento pagamento)
        {
            Pagamento pag = new Pagamento();
            pag.RealizarPagamento("Pangardi", 2000, pagamento);
        }
    
               
    }
}
