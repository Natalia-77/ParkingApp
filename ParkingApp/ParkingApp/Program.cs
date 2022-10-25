// See https://aka.ms/new-console-template for more information
using ParkingApp;
using ParkingApp.Services;

Console.WriteLine("Hello, World!");

ParkingBook parkingBook = new ParkingBook();
//parkingBook.FirstInitDictionary();
//parkingBook.ShowDict();
//parkingBook.SaveState();
//Car car = new Car("1234AB");
//parkingBook.AddCar(car);
//parkingBook.SaveState();
//parkingBook.ShowDict();
parkingBook.GetDataState();
parkingBook.ShowDict();


Console.ReadKey();




