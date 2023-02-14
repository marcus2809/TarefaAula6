using TarefaAula6;

var weatherService = new WeatherService();
var cityListReader = new CityListReader();

Task<string> weatherInfoTask = weatherService.GetWeatherAsync();
Task<IEnumerable<string>> citiesTask = cityListReader.ReadCityListAsync();

/*string weatherInfo = await weatherInfoTask;
IEnumerable<string> cities = await citiesTask;

Console.WriteLine(weatherInfo);
Console.WriteLine("[{0}]", string.Join(",", cities));*/

Console.WriteLine(weatherInfoTask.Result);
Console.WriteLine("[{0}]", string.Join(",", citiesTask.Result));