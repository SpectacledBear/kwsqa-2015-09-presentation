using System.Collections.Generic;
using System.IO;

namespace CsvToJsonConverter
{
    public class CsvReader
    {
        private string _path = null;
        private const int USER_FIELD_COUNT = 4;

        public CsvReader(string path)
        {
            if (File.Exists(path)) _path = path;
        }

        public List<User> LoadUsers()
        {
            if (_path == null) return null;

            List<User> users = new List<User>();
                        
            using (StreamReader reader = new StreamReader(_path))
            {
                string line = null;
                while ((line = reader.ReadLine()) != null) {
                    if (line.StartsWith("#")) continue;

                    string[] contents = line.Split(',');
                    if (contents.Length != USER_FIELD_COUNT) continue;
                    User newUser = new User
                    {
                        Username = contents[0],
                        FirstName = contents[1],
                        LastName = contents[2],
                        Password = contents[3]
                    };
                    users.Add(newUser);
                }
            }

            return users;
        }
    }
}
