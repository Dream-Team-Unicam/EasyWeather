namespace EasyWeather.Models.Weather
{
    public class TemperatureModel
    {


        public TemperatureModel(double current, double min, double max, double feelsLike, TemperatureUnitEnum unit)
        {
            Current = current;
            Min = min;
            Max = max;
            FeelsLike = feelsLike;
            Unit = unit;
        }

        public double Current
        {
            get;
            private set;
        }

        public double Min
        {
            get;
            private set;
        }

        public double Max
        {
            get;
            private set;
        }

        public double FeelsLike
        {
            get;
            private set;
        }

        public TemperatureUnitEnum Unit
        {
            get;
            private set;
        }
    }
}
