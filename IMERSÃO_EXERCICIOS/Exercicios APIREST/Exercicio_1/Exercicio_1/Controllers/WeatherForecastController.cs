using Microsoft.AspNetCore.Mvc;

namespace Exercicio_1.Controllers
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

        [HttpGet(Name = "GetWeatherForecast")]
        public IEnumerable<WeatherForecast> Get()
        {
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            })
            .ToArray();
        }

        [HttpGet("Rnome")]
        public string Nome()
        {
            return "Anthony Carlos Da Silva";
        }
        [HttpGet("idade")]
        public int Idade()
        {
            return 21;
        }
        [HttpGet("nomeR")]
        public string NomeR(string nome)
        {
            return nome;
        }
        [HttpGet("nomeR")]
        public string NomeIdade(string nome, int idade)
        {
            if(idade >= 18)
            {
                return nome + "É MAIOR DE IDADE";
            }
            return nome + "É MENOR DE IDADE";
        }
    }
}