namespace EasyWeather.Models.Weather
{
    public class PrecipitationModel
    {
        public PrecipitationModel(double? value, string mode)
        {
            Value = value;
            Mode = mode;
        }

        public double? Value
        {
            get;
            private set;
        }

        public string Mode
        {
            get;
            private set;
        }

        public bool IsPrecipitation()
        {
            return Mode != "no";
        }
    }
}
