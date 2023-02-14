using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TarefaAula6
{
    public class CityListReader
    {
        public async Task<IEnumerable<string>> ReadCityListAsync()
        {

            Console.WriteLine("Getting cities...");

            var cityList = new List<string>() 
            {
                "Fortaleza",
                "São Paulo",
                "Santa Catarina",
                "Natal",
                "Espírito Santo"
            };  

            await Task.Delay(10000); 

            return cityList;
        }
    }
}
