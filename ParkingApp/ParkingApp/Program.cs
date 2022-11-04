// See https://aka.ms/new-console-template for more information
using ParkingApp;
using ParkingApp.Services;

ISerializationService serializationService = new SerializationService();
ParkingBook parkingBook = ParkingBook.GetDataState(serializationService);
//parkingBook.InitDictionary();
//parkingBook.ShowDict();
//parkingBook.SaveState();
Console.ReadKey();




