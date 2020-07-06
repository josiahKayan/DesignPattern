using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.UseACabeca.Observer
{
    public class WeatherData : Subject
    {

        private readonly ArrayList observers;
        float temp;
        float humidity;
        float pressure;

        public WeatherData()
        {
            observers = new ArrayList();
        }

        //----------interface Subject
        public void NotifyObservers()
        {
            foreach (IObserver ob in observers)
            {
                ob.Update(this.temp, this.humidity, this.pressure);
            }
        }

        public void RegisterObserver(IObserver o)
        {
            observers.Add(o);
        }

        public void RemoveObserver(IObserver o)
        {
            observers.Remove(o);
        }
        //----------

        public void measurementsChanged()
        {
            NotifyObservers();
        }

        public void setMeasurements(float temp, float hum, float pres)
        {
            this.temp = temp;
            this.humidity = hum;
            this.pressure = pres;
            measurementsChanged();
        }

    }
}
