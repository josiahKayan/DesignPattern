using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.UseACabeca.Observer
{
    public interface Subject
    {

        void RegisterObserver(IObserver o);
        void RemoveObserver(IObserver o);

        void NotifyObservers();

    }
}
