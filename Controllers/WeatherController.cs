using EasyWeather.Views.Weather;
using Microsoft.AspNetCore.Mvc;

namespace EasyWeather.Controllers
{

    [Route("weather")]
    public class WeatherController : Controller
    {
        private WeatherRepository weatherRepository = new WeatherRepository();

        public ActionResult Index()
        {
            return View();
        }

        [Route("get")]
        public ActionResult HourlyForecastByCoordinates(double latitude, double longitude)
        {
            var forecast = weatherRepository.GetForecastByCoordinates(latitude, longitude).GetAwaiter().GetResult();
            
            var viewModel = new HourlyForecastByCoordinatesModel
            {
                Forecast = forecast
            };
            
            return View(viewModel);
        }
    }
}
