using Microsoft.AspNetCore.Mvc;

namespace PhoneBookService.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HealthCheckController : ControllerBase
    {

        private readonly ILogger<HealthCheckController> _logger;

        public HealthCheckController(ILogger<HealthCheckController> logger)
        {
            _logger = logger;
        }

        //[HttpGet(Name = "GetWeatherForecast")]
        //public IEnumerable<WeatherForecast> Get()
        //{
        //    return Enumerable.Range(1, 5).Select(index => new WeatherForecast
        //    {
        //        Date = DateTime.Now.AddDays(index),
        //        TemperatureC = Random.Shared.Next(-20, 55),
        //        Summary = Summaries[Random.Shared.Next(Summaries.Length)]
        //    })
        //    .ToArray();
        //}

        public static bool IsUp = false;

        [HttpGet(Name = "GetHealthCheck")]
        public bool Get() { return IsUp; }

        [HttpPost(Name = "PostHealthCheck")]
        public void Post()
        {
            IsUp = !IsUp;
            //if (IsUp == false)
            //{
            //    IsUp = true;
            //}
            //else
            //{
            //    IsUp = false;
            //}

            _logger.LogWarning("This is a log message");
        }
    }
}