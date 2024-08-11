using Microsoft.AspNetCore.Mvc;
using WeatherAppWithRazor.Models;

namespace WeatherAppWithRazor.Controllers
{
	public class WeatherController : Controller
	{
		[HttpGet]
		[Route("/")]
		public IActionResult Index()
		{
			return View(DataSource.weatherDatas);
		}

		[HttpGet]
		[Route("/weather/{weatherCode}")]
		public IActionResult WeatherDetail(string weatherCode)
		{
			WeatherData? selectedWeatherData = DataSource.weatherDatas.Where(weather => weather.CityUniqueCode == weatherCode).FirstOrDefault();
			if (selectedWeatherData != null)
			{
				return View(selectedWeatherData);
			}
			return LocalRedirect($"/error/${weatherCode}");
		}

		[Route("/error/{weatherCode}")]
		public IActionResult ErrorView(string weatherCode)
		{
			ViewBag.weatherCode = weatherCode;
			return View();
		}
	}
}
