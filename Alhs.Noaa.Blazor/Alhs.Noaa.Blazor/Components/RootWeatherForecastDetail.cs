namespace Alhs.Noaa.Blazor.Components
{
    public class RootWeatherForecastDetail
    {
        public ForecastDetail Properties { get; set; }
    }

    public class ForecastDetail
    {
        public List<DetailRecord> Periods { get; set; }
    }

    public class DetailRecord
    {
        public decimal Temperature { get; set; }
        public string Name { get; set; }
        public string Icon { get; set; }
        public string ShortForecast { get; set; }
    }
}
