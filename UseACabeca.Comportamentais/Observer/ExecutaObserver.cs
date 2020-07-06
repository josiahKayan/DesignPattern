using System;
using System.Collections.Generic;
using System.Text;

namespace UseACabeca.Comportamentais.Observer
{
    public class ExecutaObserver
    {

        // O Padrão Observer


        public static void Executa()
        {

            Leitor l1 = new Leitor();
            l1.Nome = "Josias";

            Leitor l2 = new Leitor();
            l2.Nome = "Sammya";
          
            TimeLine timeline = new TimeLine();

            timeline.addObserver(l1);
            timeline.addObserver(l2);

            Comentario c1 = new Comentario();
            c1.Apelido = "Longhi";
            c1.Mensagem = "Gostei muito da festa caipira de ontem";

            Comentario c2 = new Comentario();
            c2.Apelido = "Luan";
            c2.Mensagem = "Pense numa festa top";

            timeline.setComentario(c1);
            timeline.setComentario(c2);




        }


    }
}
