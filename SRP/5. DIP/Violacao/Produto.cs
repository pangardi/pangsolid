using System;

namespace SOLID._5._DIP.Violacao
{
    public class Produto
    {
        public Guid Codigo { get; set; }
        public string Descricao { get; set; }
        public decimal Valor { get; set; }
        public int QuantidadeEstoque { get; set; }
    }
}
