using System;
using NUnit.Allure.Attributes;
using NUnit.Framework;
using System.Diagnostics;
using Allure.Commons;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SamiiProjectOptimal.Additional
{
    public class AllureServe
    {
        [Test]
        [AllureTag("Regression")]
        [AllureSeverity(SeverityLevel.critical)]
        [AllureOwner("Sukharevsky Artem")]
        [AllureSuite("WebSite")]
        [AllureSubSuite("Client")]


        public void GoToAllureResults()
        {
            AllureConfigFilesHelper.CreateBatFile();
            Process.Start(Browser.RootPath() + "allure serve.bat");
        }
    }
}
