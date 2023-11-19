using EasyCaching.Core;
using EasyCachingExplorer.Models;
using Microsoft.Extensions.Caching.Memory;

namespace EasyCachingExplorer.Services;

public class CarsService(IEasyCachingProviderFactory cachingFactory, IMemoryCache memoryCache)
{
	private readonly IEasyCachingProviderFactory _cachingFactory = cachingFactory;
	private readonly IMemoryCache _memoryCache = memoryCache;
	private readonly Random _random = new();

	public Car GetCar(int id)
	{
		return StaticCars.MasterList.FirstOrDefault(c => c.Id == id) ?? StaticCars.NotCar;
	}

	public Car[] GetCarsFromEasyCaching()
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

	public Car[] GetCarsFromMemoryCache()
	{
		var cacheKey = typeof(IEnumerable<Car>).Name;
		var cars = _memoryCache.Get<Car[]>(cacheKey);
		if (cars is not null && cars.Length > 0)
		{
			return cars;
		}

		var randomCars = GetRandomCars();

		_memoryCache.Set(
			cacheKey,
			randomCars,
			TimeSpan.FromSeconds(5));

		return randomCars;
	}

	private Car[] GetRandomCars()
	{
		var cars = new List<Car>();
		var count = _random.Next(1, 10);

		while (cars.Count < count)
		{
			var index = _random.Next(0, StaticCars.MasterList.Length - 1);
			var car = StaticCars.MasterList[index];
			if (!cars.Any(c => c.Id == car.Id))
			{
				cars.Add(new Car(car.Id, car.Make, car.Model));
			}
		}
		return cars.ToArray();
	}
}
