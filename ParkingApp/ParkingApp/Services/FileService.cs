using Newtonsoft.Json;
namespace ParkingApp.Services
{
    public class FileService : IFileService
    {
        private const string FileName = "place.json";
        private const string FolderName = "ParkingApp";
       
        public Dictionary<int, ParkingPlace> DeserializeState()
        {
            var pathToRead = GetPathDirectory();
            string result =  File.ReadAllText(pathToRead);

            Dictionary<int, ParkingPlace> resultDeserialize = JsonConvert.DeserializeObject<Dictionary<int, ParkingPlace>>(result )!;
            return resultDeserialize;
        }        
        public string GetPathDirectory()
        {
            //c:/User/users/AppData/Local
            var dirApp = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);                  
            string locationFile = Path.Combine(dirApp, FolderName, FileName);
            var res = Extention.CheckPathValidCharacters(this,locationFile);
            //Console.WriteLine(location);
            if (res)
            {
                string dir = Path.GetDirectoryName(locationFile)??throw new ArgumentException("Error get directory");
                _ = Extention.IsExistDirectory(this, dir);
            }
            return locationFile; 
        }

        public void SerializeState(Dictionary<int, ParkingPlace> dictionary)
        {           
            if (dictionary.Any())
            {
                var str = JsonConvert.SerializeObject(dictionary);
                var pathToWrite = GetPathDirectory();
                File.WriteAllText(pathToWrite, str);            
            }
        }
    }
}



