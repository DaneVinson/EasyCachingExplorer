using EasyCaching.Core;
using EasyCachingExplorer.Models;

namespace EasyCachingExplorer.Services;

public class CarsService(IEasyCachingProviderFactory cachingFactory)
{
	private readonly IEasyCachingProviderFactory _cachingFactory = cachingFactory;
	private readonly Random _random = new();

	public Car GetCar(int id)
	{
		return StaticCars.MasterList.FirstOrDefault(c => c.Id == id) ?? StaticCars.NotCar;
	}

	public Car[] GetCurrentCars()
    {
		var cachingProvider = _cachingFactory.GetCachingProvider(Names.MemoryCacheAlpha);
		var cacheKey = typeof(IEnumerable<Car>).Name;

		var cacheValue = cachingProvider.Get<Car[]>(cacheKey);
		if (cacheValue.HasValue)
		{
			return cacheValue.Value;
		}

		var randomCars = GetRandomCars();

		cachingProvider.Set(
			cacheKey,
			randomCars,
			TimeSpan.FromSeconds(5));

		return randomCars;
	}

	private Car[] GetRandomCars()
	{
		var cars = new List<Car>();
		var count = _random.Next(1, 6);

		while (cars.Count < count)
		{
			var index = _random.Next(0, StaticCars.MasterList.Length - 1);
			var car = StaticCars.MasterList[index];
			if (!cars.Contains(car))
			{
				cars.Add(car);
			}
		}
		return cars.ToArray();
	}
}
