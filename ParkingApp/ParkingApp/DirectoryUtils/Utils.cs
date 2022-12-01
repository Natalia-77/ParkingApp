namespace ParkingApp.Services;
internal static class Utils
{
    public static void EnsureDirectory(string directoryPath)
    {
        if (!Directory.Exists(directoryPath))
        {
            Directory.CreateDirectory(directoryPath);
        }        
    }
}
