// See https://aka.ms/new-console-template for more information
using ParkingApp;
using ParkingApp.Services;

class Program
{
    static void Main(string[] args)
    {
        ISerializationService serv = new SerializationService();
        ParkingService servise = new ParkingService(serv);
        //servise.SaveState();
        servise.GetState();
        servise.Show();    
        Console.ReadKey();
    }
}





