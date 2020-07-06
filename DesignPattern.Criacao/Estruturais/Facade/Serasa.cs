using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Criacao.Estruturais.Facade
{
    public class Serasa
    {

        public bool EstaNoSerasa(Cliente cliente)
        {
            Console.WriteLine("Verificando SERASA do cliente " + cliente.Nome);
            return false;
        }

    }
}
