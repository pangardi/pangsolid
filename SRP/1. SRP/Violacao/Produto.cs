using System;

namespace SRP
{
    public class Produto
    {
        public Guid Codigo { get; set; }
        public string Descricao { get; set; }
        public decimal Valor { get; set; }
        public int QuantidadeEstoque { get; set; }
        public Categoria Categoria { get; set; }

        public void CadastrarProduto()
        {
            //Implementação
        }

        public void ValidarProduto()
        {
            //Implementação
        }

        public void SalvarProduto()
        {
            //Implementação
        }

        public void AtualizarProduto()
        {
            //Implementação
        }
    }

    public class Categoria
    {
        public int Id { get; set; }
        public string Nome { get; set; }
    }
}
