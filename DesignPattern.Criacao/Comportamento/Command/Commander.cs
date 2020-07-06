using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Criacao.Comportamento
{
    internal abstract class Commander
    {
        public abstract void Executar();
        public abstract void Desfazer();
    }
}
