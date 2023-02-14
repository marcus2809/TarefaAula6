using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TarefaAula6
{
    public class WeatherService
    {
        public async Task<string> GetWeatherAsync()
        {
            Console.WriteLine("Getting weather informations...");
            await Task.Delay(5000);
            return "Weather info returned!";
        }
    }
}
