using projeto_net_core.core.Entidade;
using System;

namespace projeto_net_core.core
{
    class Program
    {
        static void Main(string[] args)
        {
            Carro carro = new Carro();
            carro.id = Guid.NewGuid();
            carro.modelo = "Gol";

            Console.WriteLine("Hello World!");
        }
    }
}
