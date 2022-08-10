﻿using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SamiiProjectOptimal.Additional
{
    public class AllureConfigFilesHelper
    {
        public static string CreateBatFile()
        {
            string path = Browser.RootPath() + "allure serve.bat";
            string allureResultsDirectory = Browser.RootPath() + @"allure-results";
            string allureResults = @"allure serve " + allureResultsDirectory;
            FileInfo fileInf = new FileInfo(path);
            if (fileInf.Exists)
            {
                fileInf.Delete();
            }
            else if (!Directory.Exists(allureResultsDirectory))
            {
                Directory.CreateDirectory(allureResultsDirectory);
            }
            using (FileStream fstream = new FileStream($"{path}", FileMode.OpenOrCreate))
            {
                byte[] array = Encoding.Default.GetBytes(allureResults);
                fstream.Write(array, 0, array.Length);
            }
            return path;
        }

        public static string CopyJsonConfigFile()
        {

            FileInfo fileInf = new FileInfo(Path.GetFullPath(Path.Combine(AppContext.BaseDirectory)) + "allureConfig.json");
            if (fileInf.Exists == true)
            {
                fileInf.Delete();
            }
            string mainpath = Path.GetFullPath(Path.Combine(AppContext.BaseDirectory)) + "allureConfig.json";
            string str = Path.Combine(Browser.RootPath() + "allure-results");
            string path = str.Replace("\\", "\\\\");

            string body = string.Format("{{" +
                            "\"allure\"" + ":" + "{{" +
                                                "\"directory\":" + "\"" + $"{path}" + "\"" + "," +
                                                "\"links\":" + "[" +
                                                                    "\"" + "{{" + "link" + "}}" + "\"" + "," +
                                                                    "\"https://testrail.com/browse/" + "{{" + "tms" + "}}" + "\"" + "," +
                                                                    "\"https://jira.com/browse/" + "{{" + "issue" + "}}" + "\"" +
                                                               "]" +
                                                    "}}" + "," +
                            "\"specflow\":" + "{{" +
                                                    "\"stepArguments\":" + "{{" +
                                                                                "\"convertToParameters\":" + "\"true\"" + "," +
                                                                                "\"paramNameRegex\":" + "\"\"" + "," +
                                                                                "\"paramValueRegex\":" + "\"\"" +
                                                                                "}}" + "," +
                                                    "\"grouping\":" + "{{" +
                                                                            "\"suites\":" + "{{" +
                                                                                                    "\"parentSuite\":" + "\"^parentSuite:?(.+)\"" + "," +
                                                                                                    "\"suite\":" + "\"^suite:?(.+)\"" + "," +
                                                                                                    "\"subSuite\":" + "\"^subSuite:?(.+)\"" +
                                                                                                    "}}" + "," +
                                                                            "\"behaviors\":" + "{{" +
                                                                                                        "\"epic\":" + "\"^epic:?(.+)\"" + "," +
                                                                                                        "\"story\":" + "\"^story:(.+)\"" +
                                                                                                    "}}" +
                                                                            "}}" + "," +
                                                                            "\"labels\":" + "{{" +
                                                                                                    "\"owner\":" + "\"^author:?(.+)\"" + "," +
                                                                                                    "\"severity\":" + "\"^(normal|blocker|critical|minor|trivial)\"" +
                                                                                                    "}}" + "," +
                                                                            "\"links\":" + "{{" +
                                                                                                "\"tms\":" + "\"^story:(.+)\"" + "," +
                                                                                                "\"issue\":" + "\"^issue:(.+)\"" + "," +
                                                                                                "\"link\":" + "\"^link:(.+)\"" +
                                                                                            "}}" +
                                                                        "}}" +
                                             "}}");

            string jsonBody = body.Replace("[[", "[").Replace("]]", "]");
            File.WriteAllText(mainpath, jsonBody);
            return mainpath;
        }
    }
}
