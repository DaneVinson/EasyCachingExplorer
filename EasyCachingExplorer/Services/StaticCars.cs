using EasyCachingExplorer.Models;

namespace EasyCachingExplorer.Services;

internal static class StaticCars
{
	internal static readonly Car[] MasterList =
	[
		new Car(1, "Ford", "Focus"),
		new Car(2, "Ford", "Fusion"),
		new Car(3, "Ford", "Mustang"),
		new Car(4, "Honda", "Accord"),
		new Car(5, "Honda", "Civic"),
		new Car(6, "Honda", "CR-V"),
		new Car(7, "Toyota", "Camry"),
		new Car(8, "Toyota", "Corolla"),
		new Car(9, "Toyota", "RAV4"),
		new Car(10, "Nissan", "Altima"),
		new Car(11, "Nissan", "Maxima"),
		new Car(12, "Nissan", "Sentra"),
		new Car(13, "Hyundai", "Elantra"),
		new Car(14, "Hyundai", "Sonata"),
		new Car(15, "Hyundai", "Tucson"),
		new Car(16, "Chevrolet", "Cruze"),
		new Car(17, "Chevrolet", "Malibu"),
		new Car(18, "Chevrolet", "Silverado"),
		new Car(19, "Kia", "Forte"),
		new Car(20, "Kia", "Optima"),
	];
	internal static readonly Car NotCar = new Car(-1, "This car does not exist", "nor does its model");
}
