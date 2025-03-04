namespace EasyWeather.Models.Weather
{
    public class WeatherModel
    {
        public WeatherModel(WindModel wind, CloudModel cloud, TemperatureModel temperature, double humidity, int visibility, PrecipitationModel precipitation, string lastUpdate)
        {
            Wind = wind;
            Cloud = cloud;
            Temperature = temperature;
            Precipitation = precipitation;

            Humidity = humidity;
            Visibility = visibility;
            LastUpdate = lastUpdate;
        }

        public WindModel Wind
        {
            get;
            private set;
        }

        public CloudModel Cloud
        {
            get;
            private set;
        }

        public TemperatureModel Temperature
        {
            get;
            private set;
        }
        
        public double Humidity
        {
            get;
            private set;
        }

        public int Visibility
        {
            get;
            private set;
        }

        public PrecipitationModel Precipitation
        {
            get;
            private set;
        }

        public string LastUpdate
        {
            get;
            private set;
        }
    }
}

