using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EasyWeather.Controllers
{
    [Route("weather")]
    public class WeatherController : Controller
    {
        // GET: Weather
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }
    }
}
