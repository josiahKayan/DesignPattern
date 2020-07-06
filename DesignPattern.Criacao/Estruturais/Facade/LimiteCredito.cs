using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Criacao.Estruturais.Facade
{
    public class LimiteCredito
    {

        public bool PossuiLimiteCredito(Cliente cliente, double valor)
        {
            Console.WriteLine("Verificando o limite de crédito do cliente " + cliente.Nome);
            if (valor > 200000.00)
                return false;
            else
                return true;
        }

    }
}
