using System;
namespace SOLID._5._DIP.Violacao
{
    public class ProdutoServico
    {
        public void InserirProduto(Produto produto)
        {
            //Fazer as validações
            if (string.IsNullOrWhiteSpace(produto.Descricao))
                throw new Exception();

            //Alto acoplamento
            var repository = new ProdutoRepositorio();
            repository.Adicionar(produto);

            Console.WriteLine("Produto cadastrado com sucesso!");
        }
    }
}
