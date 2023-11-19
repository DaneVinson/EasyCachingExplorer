namespace EasyCachingExplorer.Models;

public class AlphaViewModel
{
	public Car[] Cars { get; set; } = Array.Empty<Car>();
	public string CarsCaption { get; set; } = string.Empty;
	public Car Car { get; set; } = Services.StaticCars.NotCar;
	public string CarCaption { get; set; } = string.Empty;
}
