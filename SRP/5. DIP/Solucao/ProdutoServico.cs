using SOLID._5._DIP.Solucao.Interfaces;
using System;

namespace SOLID._5._DIP.Solucao
{  
    public class ProdutoServico
    {
        private readonly IProdutoRepositorio _produtoRepositorio;

        public ProdutoServico(IProdutoRepositorio produtoRepositorio)
        {
            _produtoRepositorio = produtoRepositorio;
        }

        public void InserirProduto(Produto produto)
        {       
            if (string.IsNullOrWhiteSpace(produto.Descricao))
                throw new Exception();

            _produtoRepositorio.Adicionar(produto);

            Console.WriteLine("Produto cadastrado com sucesso!");
        }
    }
}
