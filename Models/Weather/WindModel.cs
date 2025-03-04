namespace EasyWeather.Models.Weather
{
    public class WindModel
    {
        public WindModel(string name, double speed, WindSpeedUnit unit, double gusts, WindDirection direction)
        {
            Name = name;
            Speed = speed;
            Unit = unit;
            Gusts = gusts;
            Direction = direction;

        }

        public string Name
        {
            get;
            private set;
        }

        public double Speed
        {
            get;
            private set;
        }

        public double Gusts
        {
            get;
            private set;
        }

        public WindSpeedUnit Unit
        {
            get;
            private set;
        }

        public WindDirection Direction
        {
            get;
            private set;
        }
    }
}
