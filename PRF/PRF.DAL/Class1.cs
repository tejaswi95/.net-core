using System;
using Microsoft.Extensions.Configuration;

namespace PRF.DAL
{

    public interface IWeatherData
    {
        void GetData();
    }
    public class WeatherData : IWeatherData
    {
        private readonly IConfiguration config;
        public WeatherData(IConfiguration configuration)
        {
            config = configuration;
        }
        public void GetData()
        {
            var data  = config.GetSection("MySettings").GetSection("DbConnection").Value;
        }
    }
}
