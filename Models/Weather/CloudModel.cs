namespace EasyWeather.Models.Weather
{
    public class CloudModel
    {
        public CloudModel(string name, int value)
        {
            Name = name;
            Value = value;
        }

        public string Name
        {
            get;
            private set;
        }

        public int Value
        {
            get;
            private set;
        }
    }
}
