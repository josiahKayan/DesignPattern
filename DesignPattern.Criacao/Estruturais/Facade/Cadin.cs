using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Criacao.Estruturais.Facade
{
    public class Cadin
    {
        public bool EstaNoCadin(Cliente cliente)
        {
            Console.WriteLine("Verificando o CADIN para o cliente " + cliente.Nome);
            return false;
        }
    }
}
