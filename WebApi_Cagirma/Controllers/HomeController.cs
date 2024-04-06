using Microsoft.AspNetCore.Mvc;
using RestSharp;
using System.Diagnostics;
using System.Net;
using WebApi_Cagirma.Models;

namespace WebApi_Cagirma.Controllers
{
	public class HomeController : Controller
	{

		public HomeController()
		{

		}

		public IActionResult Index()
		{
			RestSharp.RestClient cli = new RestSharp.RestClient("https://localhost:7036/");
			RestSharp.RestRequest request = new RestSharp.RestRequest("WeatherForecast");
			request.Method = RestSharp.Method.Get;
		

			var response =  cli.ExecuteGet(request);



			return View();
		}

		public IActionResult Privacy()
		{
			return View();
		}

		[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
		public IActionResult Error()
		{
			return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
		}
	}
}
