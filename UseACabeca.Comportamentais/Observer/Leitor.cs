using System;
using System.Collections.Generic;
using System.Text;

namespace UseACabeca.Comportamentais.Observer
{
    public class Leitor : IObserver
    {

        public string Nome { get; set; }

        public void Update(Comentario comentario)
        {
            var x = "Oi " + Nome + ", "+ comentario.Apelido + " comentou no seu status :" + comentario.Mensagem ;

            var z = x;
        }
    }
}
