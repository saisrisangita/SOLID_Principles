using System;

public interface ITemperatureSensor
{
    double GetTemperature();
}

public class WeatherTracker
{
    private ITemperatureSensor temperatureSensor;

    public WeatherTracker(ITemperatureSensor sensor)
    {
        temperatureSensor = sensor;
    }

    public void DisplayTemperature()
    {
        double temperature = temperatureSensor.GetTemperature();
        Console.WriteLine("Current temperature: " + temperature);
    }
}

public class Thermometer : ITemperatureSensor
{
    public double GetTemperature()
    {
       
        return 25.0;
    }
}

public class Program
{
    static void Main()
    {
        ITemperatureSensor thermometer = new Thermometer();
        WeatherTracker weatherTracker = new WeatherTracker(thermometer);

        weatherTracker.DisplayTemperature();

        Console.ReadLine();
    }
}
