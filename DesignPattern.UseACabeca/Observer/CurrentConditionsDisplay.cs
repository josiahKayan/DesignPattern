using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.UseACabeca.Observer
{
    public class CurrentConditionsDisplay : IObserver, DisplayElement
    {
        float temp;
        float humidity;
        float pressure;



        public void Display()
        {
            throw new NotImplementedException();
        }

        public void Update(float temp, float humidity, float pressure)
        {
            throw new NotImplementedException();
        }
    }
}
