using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using AskUsFresh.Domain;
using AskUsFresh.Service.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Serilog;
using ILogger = Serilog.ILogger;

namespace AskUsFresh.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        public static IConfiguration configuration { get; } = new ConfigurationBuilder()
           .SetBasePath(Directory.GetCurrentDirectory())
           .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
           .AddJsonFile($"appsettings.{Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT") ?? "Production"}.json", optional: true)
           .Build();
        public IConfiguration Configuration { get; }

        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private static readonly string[] Summaries1 = new[]
{
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<WeatherForecast> _logger;

        private IRegisterService _registerService { get; set; }
        public WeatherForecastController(ILogger<WeatherForecast> logger, IConfiguration configuration, IRegisterService registerService)
        {
            this._logger = logger;
            this.Configuration = configuration;
            this._registerService = registerService;
        }

        [HttpGet]
        public IEnumerable<WeatherForecast> Get()
        {
            // Log.Logger = new LoggerConfiguration().ReadFrom.
            //Configuration(configuration)
            //.CreateLogger();

            // Log.Warning("Testing the warning with new log");
            // Log.CloseAndFlush();

            var user = TestMethod(10);           

            for (int i = 0; i < 10; i++)
            {
                Summaries1[i] = user.FirstName;  //this.Configuration.GetSection("TestString").Value;
            }

            this._logger.LogWarning("Test Warning");
            var rng = new Random();
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = rng.Next(-20, 55),
                Summary = Summaries1[rng.Next(Summaries1.Length)]
            })
            .ToArray();
        }


        public Users TestMethod(int mobileNumber)
        {
           return this._registerService.GetUserByMobileNumber(mobileNumber);
        
        }
    }
}
