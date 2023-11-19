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
			Car = car,
			CarCaption = $"Car {car.Id}",
			Cars = _carsService.GetCurrentCars(),
			CarsCaption = "Cars seen in the last few seconds",
		};

		return View(model);
    }
}
