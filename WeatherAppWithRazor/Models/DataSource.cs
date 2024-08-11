namespace WeatherAppWithRazor.Models
{
	public class DataSource
	{
		public static List<WeatherData> weatherDatas = new List<WeatherData>()
		{
			new WeatherData()
			{
				CityUniqueCode = "LDN",
				CityName = "London",
				DateAndTime = "2030-01-01 8:00",
				TemperatureFahrenheit = 33
			},
			new WeatherData()
			{
				CityUniqueCode = "NYC",
				CityName = "London",
				DateAndTime = "2030-01-01 3:00",
				TemperatureFahrenheit = 60,
			},
			new WeatherData()
			{
				CityUniqueCode = "PAR",
				CityName = "Paris",
				DateAndTime = "2030-01-01 9:00",
				TemperatureFahrenheit = 82
			}
		};
	}
}
