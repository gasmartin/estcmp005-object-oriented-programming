using System;
using System.Collections;
using System.Threading;

namespace ObserverPattern
{
    public interface Subject
    {
        public void NotifyObservers();
        public void RegisterObserver(Observer o);
        public void RemoveObserver(Observer o);
    }

    public interface Observer
    {
        public void Update(float temp, float humidity, float pressure);
    }

    public interface DisplayElement
    {
        public void Display();
    }

    public class WeatherData : Subject
    {
        private ArrayList Observers { get; set; }
        private float Temperature { get; set; }
        private float Humidity { get; set; }
        private float Pressure { get; set; }

        public WeatherData()
        {
            Observers = new ArrayList();
        }

        public void NotifyObservers()
        {
            foreach(Observer o in Observers)
            {
                o.Update(Temperature, Humidity, Pressure);
            }
        }

        public void RegisterObserver(Observer o)
        {
            Observers.Add(o);
        }

        public void RemoveObserver(Observer o)
        {
            int i = Observers.IndexOf(o);
            if(i >= 0)
            {
                Observers.Remove(o);
            }
        }

        public void MeasurementsChanged()
        {
            NotifyObservers();
        }

        public void SetMeasurements(float temperature, float humidity, float pressure)
        {
            Temperature = temperature;
            Humidity = humidity;
            Pressure = pressure;

            MeasurementsChanged();
        }
    }

    public class CurrentConditionsDisplay : Observer, DisplayElement
    {
        private float Temperature { get; set; }
        private float Humidity { get; set; }
        private Subject Data { get; set; }

        public CurrentConditionsDisplay(Subject weatherData)
        {
            Data = weatherData;
            Data.RegisterObserver(this);
        }

        public void Display()
        {
            Console.WriteLine("Current conditions: " + Temperature + "F degrees and " + Humidity + "% humidity");
        }

        public void Update(float temp, float humidity, float pressure)
        {
            Temperature = temp;
            Humidity = humidity;

            Display();
        }
    }

    class ObserverPattern
    {
        static void Main(string[] args)
        {
            WeatherData weatherData = new WeatherData();

            CurrentConditionsDisplay currentConditionsDisplay = new CurrentConditionsDisplay(weatherData);

            weatherData.SetMeasurements(80, 65, 30.4f);

            Thread.Sleep(3000);

            weatherData.SetMeasurements(82, 70, 29.2f);

            Thread.Sleep(1000);

            weatherData.SetMeasurements(78, 90, 29.2f);

            Console.ReadLine();
        }
    }
}
