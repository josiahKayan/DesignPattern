using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Criacao.Estruturais.Composite
{
    public class InputFormMessage : IMessage
    {
        public string Nome { get; set; }

        public InputFormMessage(string name)
        {
            Nome = name;
        }
        public void ExibirMensagens(int sub)
        {
            Console.WriteLine(new string('-', sub) + Nome);
        }
    }
}
