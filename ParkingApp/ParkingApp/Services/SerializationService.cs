using Newtonsoft.Json;
using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("ParkingApp.UI")]
[assembly:InternalsVisibleTo("ParkingApp.UnitTests")]

namespace ParkingApp.Services
{
    internal class SerializationService : ISerializationService
    {
        private const string FileName = "place.json";
        private const string FolderName = "ParkingApp";
        private readonly string _cacheFilePath;       

        public SerializationService(string? cacheFilePath=null)
        {
            _cacheFilePath = cacheFilePath ?? Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), FolderName, FileName);
            
        }

         public ParkingBookModel DeserializeState()
         {
            var pathToRead = GetPathDirectory();
            if (!File.Exists(pathToRead))
            {
                var defaultModel = new ParkingBookModel().Default;//попыталась доступится до проперти с дефолтными значениями.
                return new ParkingBookModel(defaultModel);//работает-но выглядит оно ужасно.
            }
            string result = File.ReadAllText(pathToRead);
            ParkingBookModel dataResult = JsonConvert.DeserializeObject<ParkingBookModel>(result) ?? throw new ArgumentNullException(nameof(result), "Error deserialize file");
            return dataResult;
        }
        public string GetPathDirectory()
        {
            //c:/User/users/AppData/Local
            //var dirApp = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
            //string locationFile = Path.Combine(dirApp, FolderName, FileName);
            string dir = Path.GetDirectoryName(_cacheFilePath) ?? throw new ArgumentException("Error get directory");   
            //string location = Path.Combine(FileSystem.Current.AppDataDirectory, FolderName, FileName);
            Utils.EnsureDirectory(dir);
            return _cacheFilePath;
        }

        public void SerializeState(ParkingBookModel parkingBook)
        {           
            if (parkingBook is not null)
            {
                var str = JsonConvert.SerializeObject(parkingBook);
                var pathToWrite = GetPathDirectory();
                File.WriteAllText(pathToWrite, str);               
            }           
            else
            {
                throw new ArgumentNullException(nameof(parkingBook));                
            }
        }
    }
}



