namespace Alhs.Noaa.Blazor.Components
{
    public class RootWeatherForecast
    {
        public WeatherForecast Properties { get; set; }
    }

    public class WeatherForecast
    {
        public string Forecast { get; set; }
        public RelativeLocation RelativeLocation { get; set; }
    }

    public class RelativeLocation
    {
        public LocationProperties Properties { get; set; }
    }
    public class LocationProperties
    {
        public string City { get; set; }
        public string State { get; set; }
    }
}
