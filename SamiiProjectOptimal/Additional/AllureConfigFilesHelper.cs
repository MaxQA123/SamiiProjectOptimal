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
            string allureResultsDirectory = Browser.RootPath() + @"\allure-results";
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
            string mainpath = Path.GetFullPath(Path.Combine(AppContext.BaseDirectory)) + "allureConfig.json";
            using (FileStream fstream = new FileStream($"{mainpath}", FileMode.OpenOrCreate))
            {
                byte[] array = Encoding.Default.GetBytes("test");
                fstream.Write(array, 0, array.Length);
            }
            FileInfo fileInf = new FileInfo(mainpath);

            if (fileInf.Exists)
            {
                fileInf.Delete();
            }
            File.Copy(Browser.RootPath() + @"\AllureConfigFIle\allureConfig.json", mainpath);

            return mainpath;
        }
    }
}
