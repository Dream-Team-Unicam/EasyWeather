using System.ComponentModel;
using System.Reflection;

namespace EasyWeather.Models.Weather
{
    public class WindDirection
    {
        public WindDirection(double degrees, WindDirectionCode directionCode)
        {
            Degrees = degrees;
            Direction = directionCode;
        }

        public double Degrees
        {
            get;
            private set;
        }

        public WindDirectionCode Direction
        {
            get;
            private set;
        }

        public String DirectionSymbol
        {
            get
            {
                DescriptionAttribute[] attributes = (DescriptionAttribute[])Direction
                    .GetType()
                    .GetField(Direction.ToString())
                    .GetCustomAttributes(typeof(DescriptionAttribute), false);
                return attributes.Length > 0 ? attributes[0].Description : string.Empty;
            }
        }
    }
}
