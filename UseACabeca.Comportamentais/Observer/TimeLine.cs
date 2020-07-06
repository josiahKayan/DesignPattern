using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UseACabeca.Comportamentais.Observer
{
    public class TimeLine : ISubject
    {
        public IList<IObserver> observers;

        private Comentario comentario { get; set; }

        public TimeLine()
        {
            observers = new List<IObserver>();
        
            comentario = new Comentario();
            comentario.Mensagem = "";
            comentario.Apelido = "";
        }

        public void addObserver(IObserver observer)
        {
            observers.Add(observer);
        }

        public void notifyObservers()
        {
            foreach (var item in observers)
            {
                item.Update(comentario);
            }
        }

        public void removeObserver(IObserver observer)
        {
            observers.Remove(observer);
        }

    
        public void setComentario(Comentario comentario)
        {
            if (comentario.Mensagem == this.comentario.Mensagem && comentario.Apelido == this.comentario.Apelido)
            {
                return;
            }
            
            this.comentario.Mensagem = comentario.Mensagem;
            this.comentario.Apelido = comentario.Apelido;
            notifyObservers();
        }

}
}
