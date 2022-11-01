using Newtonsoft.Json;
namespace ParkingApp.Services
{
    public class SerializationService : ISerializationService
    {
        private const string FileName = "place.json";
        private const string FolderName = "ParkingApp";
       
        public ParkingPlace[] DeserializeState()
        {
            var pathToRead = GetPathDirectory();
            string result =  File.ReadAllText(pathToRead);           
            ParkingPlace[] dataResult = JsonConvert.DeserializeObject<ParkingPlace[]>(result)??throw new ArgumentNullException(nameof(result),"Error deserialize file");
            return dataResult;
        }
        public string GetPathDirectory()
        {
            //c:/User/users/AppData/Local
            var dirApp = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
            string locationFile = Path.Combine(dirApp, FolderName, FileName);
            string dir = Path.GetDirectoryName(locationFile) ?? throw new ArgumentException("Error get directory");
            Utils.EnsureDirectory(dir);
            return locationFile;
        }

        public void SerializeState(ParkingPlace[] places)
        {           
            if (places is not null)
            {
                var str = JsonConvert.SerializeObject(places);
                var pathToWrite = GetPathDirectory();
                File.WriteAllText(pathToWrite, str);               
            }           
            else
            {
                throw new NullReferenceException(nameof(places));                
            }
        }
    }
}



