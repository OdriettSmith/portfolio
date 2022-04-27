using Aquality.Selenium.Browsers;
using System.Data;
using TestsDB.Utils;

namespace TestsDB
{
    internal static class Util
    {     
        public static void PrintTable(DataTable dataTable)
        {
            string table = "\n";

            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                if (i == 0)
                {
                    for (int j = 0; j < dataTable.Columns.Count; j++)
                    {
                        table += $"\t{dataTable.Columns[j]}";
                    }
                    table += "\n";
                }

                for (int j = 0; j < dataTable.Columns.Count; j++)
                {
                    table += $"\t{dataTable.Rows[i][dataTable.Columns[j]]}";
                }
                table += "\n";
            }
            AqualityServices.Logger.Info(table);
        }

        public static string InsertBrowsers(string request)
        {
            return request.Replace("FirstBrowser", JsonUtils.GetTestData().FirstBrowser).Replace("SecondBrowser", JsonUtils.GetTestData().SecondBrowser);
        }

        public static string InsertDate(string request)
        {
            return request.Replace("DateValue", JsonUtils.GetTestData().Date);
        }
    }
}
