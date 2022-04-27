using Newtonsoft.Json;
using System.IO;
using TestsDB.Models;

namespace TestsDB.Utils
{
    internal class JsonUtils
    {
        private const string TestDataPath = "TestData//testdata.json";
        private const string RequestsPath = "SqlRequests//requests.json";

        public static Requests GetRequests()
        {
            return JsonConvert.DeserializeObject<Requests>(File.ReadAllText(RequestsPath));
        }
        public static TestData GetTestData()
        {
            return JsonConvert.DeserializeObject<TestData>(File.ReadAllText(TestDataPath));
        }
    }
}
