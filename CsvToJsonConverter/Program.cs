using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

namespace CsvToJsonConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            string csvPath = Path.Combine(Directory.GetCurrentDirectory(), "users.csv");
            CsvReader reader = new CsvReader(csvPath);
            List<User> users = reader.LoadUsers();

            foreach(User user in users)
            {
                string jsonUser = JsonConvert.SerializeObject(user);
                Console.WriteLine("User as json: {0}\n", jsonUser);
            }
        }
    }
}
