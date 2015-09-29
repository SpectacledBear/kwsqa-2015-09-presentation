using System.Collections.Generic;
using System.IO;
using NUnit.Framework;

namespace CsvToJsonConverter.Tests
{
    [TestFixture]
    public class CsvReaderTests
    {
        private const int NUMBER_OF_USERS = 2;

        // This is not a great test but exists to provide coverage.
        [Test]
        public void SomeTest()
        {
            string path = Path.Combine(Directory.GetCurrentDirectory(), "users.csv");
            CsvReader reader = new CsvReader(path);
            List<User> users = reader.LoadUsers();

            Assert.IsTrue(users.Count == NUMBER_OF_USERS, "The exepected user with a specific username was not found.");
        }
    }
}
