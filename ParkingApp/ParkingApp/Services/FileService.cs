using Newtonsoft.Json;
namespace ParkingApp.Services
{
    internal class FileService : IFileService
    {
        private const string Filename = "place.json";        

        public Dictionary<int, ParkingPlace> DeserializeState()
        {
            var pathToRead = GetPathDirectory();
            string result = File.ReadAllText(pathToRead);

            Dictionary<int, ParkingPlace> res = JsonConvert.DeserializeObject<Dictionary<int, ParkingPlace>>(result)!;
            //foreach (KeyValuePair<int, ParkingPlace> item in res)
            //{
            //    Console.WriteLine(item.Value.NumberPlace);
            //}
            return res;
        }

        public string GetPathDirectory()
        {
            string pathFile = "";
            var dir = Directory.GetCurrentDirectory();
            var rr = Directory.GetParent(dir);

            if (rr is not null)
            {
                var tt = rr.Parent;
                if (tt is not null)
                {
                    var ee = tt.Parent;
                    if (ee is not null)
                    {
                        string path = Path.Combine(ee.FullName, Filename);
                        pathFile = path;
                    }
                }
            }
            return pathFile;
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



