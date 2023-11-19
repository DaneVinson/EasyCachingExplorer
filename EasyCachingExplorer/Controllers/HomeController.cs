using EasyCachingExplorer.Models;
using EasyCachingExplorer.Services;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace EasyCachingExplorer.Controllers;

public class HomeController(CarsService carsService) : Controller
{
    private readonly CarsService _carsService = carsService ?? throw new ArgumentNullException(nameof(carsService));

	public IActionResult Index()
    {
		var car = _carsService.GetCar(1);
		var model = new AlphaViewModel()
		{
			Cars = _carsService.GetCarsFromEasyCaching(),
			CarsCaption = "EasyCaching Cars",
			Cars2 = _carsService.GetCarsFromMemoryCache(),
			Cars2Caption = "MemoryCache Cars",
		};

		return View(model);
    }
}
