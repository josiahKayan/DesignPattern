using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Criacao.Estruturais.Composite
{
    public interface IMessage
    {

        string Nome { get; set; }

        void ExibirMensagens(int sub);


    }
}
