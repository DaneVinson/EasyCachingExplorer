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
		new Car(21, "Kia", "Soul"),
		new Car(22, "Volkswagen", "Jetta"),
		new Car(23, "Volkswagen", "Passat"),
		new Car(24, "Volkswagen", "Tiguan"),
		new Car(25, "Subaru", "Crosstrek"),
		new Car(26, "Subaru", "Forester"),
		new Car(27, "Subaru", "Outback"),
		new Car(28, "BMW", "3 Series"),
		new Car(29, "BMW", "5 Series"),
		new Car(30, "BMW", "X3"),
		new Car(31, "Mercedes-Benz", "C-Class"),
		new Car(32, "Mercedes-Benz", "E-Class"),
		new Car(33, "Mercedes-Benz", "GLC-Class"),
		new Car(34, "Lexus", "ES"),
		new Car(35, "Lexus", "RX"),
		new Car(36, "Lexus", "NX"),
		new Car(37, "Audi", "A4"),
		new Car(38, "Audi", "A6"),
		new Car(39, "Audi", "Q5"),
		new Car(40, "Mazda", "CX-5"),
		new Car(41, "Mazda", "CX-9"),
		new Car(42, "Mazda", "Mazda3")
	];
	internal static readonly Car NotCar = new Car(-1, "This car does not exist", "nor does its model");
}
