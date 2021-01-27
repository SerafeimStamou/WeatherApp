using System;


namespace WeatherApp
{
    public class WeatherForecastModel
    {
        public DayForecast[] Consolidated_weather { get; set; }
        public DateTime Sun_rise { get; set; }
        public DateTime Sun_set { get; set; }
        public string Title { get; set; }
        public string Timezone { get; set; }
    }
}
