﻿using NUnit.Framework;
using SamiiProjectOptimal.Additional;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdminTests
{
    public class BaseAdmin : BaseWeb
    {
        [SetUp]
        public void SetUp()
        {
            Browser._Driver.Navigate().GoToUrl(EndPoints.logInPageUrl);
        }
    }
}
