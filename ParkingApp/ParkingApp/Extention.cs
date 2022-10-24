using ParkingApp.Services;
using System.Linq.Expressions;

namespace ParkingApp
{
    internal static class Extention
    {
        public static bool CheckPathValidCharacters(this IFileService fileService, string ?path)
        {
            char[] invalidChars = Path.GetInvalidPathChars();
            if (path != null && path.IndexOfAny(invalidChars) > 0)
            {
                throw new ArgumentException("Invalid characters in path", nameof(path));
            }
            if (string.IsNullOrEmpty(path))
            {
                throw new ArgumentNullException(nameof(path), "Empty path name");
            }
            
            return true;
        }

        public static bool IsExistDirectory(this IFileService fileService,string directoryPath)
        {
            if (!Directory.Exists(directoryPath))
            {
                Directory.CreateDirectory(directoryPath);                
            }
            return true;
        }
    }
}
