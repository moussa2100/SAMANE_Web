using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace APITestGeneric.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        [Route("gets")]
        public string Get()
        {
            return "working";
        }

        [HttpGet]
        [Route("Filter")]
        public ActionResult<List<T>> Filter<T>(Func<T, bool> filter) where T : class
        {
            List<T> result;
            using (AppDbContext context = new AppDbContext())
            {


                 result = context.Set<T>().Where(filter).ToList();
            }
            return result;
        }
    }
}