using EasyCaching.InMemory;
using EasyCachingExplorer.Services;
using Microsoft.Extensions.Caching.Memory;

var builder = WebApplication.CreateBuilder(args);

builder.Services
    .AddSingleton<CarsService>()
    .AddControllersWithViews();

builder.Services
	.AddEasyCaching(options =>
	{
		// Default settings are good for most use cases
		//options.UseInMemory("alpha-cache");

		// Customize alpha-cache for responsiveness while exploring
		options.UseInMemory(config =>
		{
			config.DBConfig = new InMemoryCachingOptions
			{
				ExpirationScanFrequency = 1, // default 60
			};
			config.MaxRdSecond = 0; // default 120
		},
		Names.MemoryCacheAlpha);
	})
	.AddMemoryCache(options =>
	{
		options.ExpirationScanFrequency = TimeSpan.FromSeconds(1);
	});

var app = builder.Build();

app
    .UseHttpsRedirection()
    .UseStaticFiles()
    .UseRouting();

app.MapControllerRoute(name: "default", pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
