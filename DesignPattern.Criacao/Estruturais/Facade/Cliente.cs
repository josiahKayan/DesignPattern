using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Criacao.Estruturais.Facade
{
    public class Cliente
    {

        public string Nome { get; set; }
        public Cliente(string nome)
        {
            Nome = nome;
        }

    }
}
