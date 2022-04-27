using NUnit.Framework;
using TestsDB.Models;
using TestsDB.Utils;

namespace TestsDB.Tests
{
    internal class BaseTest
    {
        [Test]
        public static void SqlRequests()
        {
            Requests requests = JsonUtils.GetRequests();
            Util.PrintTable(DBUtils.SendRequest(Util.InsertBrowsers(requests.BrowserTestCounts)));
            Util.PrintTable(DBUtils.SendRequest(Util.InsertDate(requests.EarlierDateTests)));
            Util.PrintTable(DBUtils.SendRequest(requests.UniqueProjectTestCounts));
            Util.PrintTable(DBUtils.SendRequest(requests.MinWorkTimeTests));
        }
    }
}
