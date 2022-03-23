using System;

namespace SOLID._4._ISP.Solucao
{
    public class Carro : IMeioTransporte
    {
        public bool TemCombustivel { get; set; }

        public void Ligar()
        {
            if (TemCombustivel)
                Console.WriteLine("Carro ligado");
            throw new Exception("Não possui combustível");
        }
    }
}
