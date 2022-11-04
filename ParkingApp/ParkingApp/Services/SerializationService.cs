using Newtonsoft.Json;
namespace ParkingApp.Services
{
    public class SerializationService : ISerializationService
    {
        private const string FileName = "place.json";
        private const string FolderName = "ParkingApp";

        private readonly string _cacheFilePath;
       
        public SerializationService(string? cacheFilePath = null)
        {
            if (string.IsNullOrWhiteSpace(cacheFilePath))
            {
                _cacheFilePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), FolderName, FileName);
            }
            else
            {
                _cacheFilePath = cacheFilePath;
            }
        }


        public ParkingBookModel DeserializeState()
        {
            var cacheFile = GetCacheFilePath();

            if (!File.Exists(cacheFile))
            {
                return ParkingBookModel.DefaultInstance;
            }
            string result =  File.ReadAllText(cacheFile);

            ParkingBookModel? dataResult = JsonConvert.DeserializeObject<ParkingBookModel>(result);
            if (dataResult is null)
            {
                Console.WriteLine($"Error deserializing '{cacheFile}', the file is not in expected format.");
                return ParkingBookModel.DefaultInstance;
            }
            return dataResult;
        }
        public string GetCacheFilePath()
        {
            string dir = Path.GetDirectoryName(_cacheFilePath) ?? throw new ArgumentException("Error get directory");
            Utils.EnsureDirectory(dir);
            return _cacheFilePath;
        }

        public void SerializeState(ParkingBookModel book)
        {
            if (book is null)
            {
                throw new ArgumentNullException(nameof(book));
            }
            var str = JsonConvert.SerializeObject(book);
            var pathToWrite = GetCacheFilePath();
            File.WriteAllText(pathToWrite, str);
        }
    }
}



