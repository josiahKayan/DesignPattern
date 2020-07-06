using System;
using System.Collections.Generic;
using System.Text;

namespace UseACabeca.Comportamentais.Observer
{
    public interface ISubject
    {

        void addObserver(IObserver observer);

        void removeObserver(IObserver observer);

        void notifyObservers();

    }
}
