using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.UseACabeca.Observer
{
    public interface IObserver
    {

        void Update(float temp, float humidity, float pressure);

    }
}
