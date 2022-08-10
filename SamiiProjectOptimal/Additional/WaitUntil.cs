﻿using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SamiiProjectOptimal.Additional
{
    public class WaitUntil
    {
        public static void ShouldLocate(By location)
        {
            new WebDriverWait(Browser._Driver, TimeSpan.FromSeconds(60)).Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy(location));
        }

        public static void ElementIsClickable(IWebElement element, int seconds = 10)
        {
            new WebDriverWait(Browser._Driver, TimeSpan.FromSeconds(seconds)).Until(ExpectedConditions.ElementToBeClickable(element));
        }

        public static void ElementVisibileAndClickable(By element, int seconds = 10)
        {
            new WebDriverWait(Browser._Driver, TimeSpan.FromSeconds(seconds)).Until(ExpectedConditions.ElementToBeClickable(element));
            new WebDriverWait(Browser._Driver, TimeSpan.FromSeconds(seconds)).Until(ExpectedConditions.ElementIsVisible(element));
        }

        public static void WaitSomeInterval(int seconds)
        {
            Task.Delay(TimeSpan.FromSeconds(seconds)).Wait();
        }

        public static void ElementIsVesible(By element, int seconds = 10)
        {
            new WebDriverWait(Browser._Driver, TimeSpan.FromSeconds(seconds)).Until(ExpectedConditions.ElementIsVisible(element));
        }

        public static void CustomElevemtIsVisible(IWebElement element, int seconds = 10)
        {
            WebDriverWait wait = new WebDriverWait(Browser._Driver, TimeSpan.FromSeconds(seconds));
            wait.PollingInterval = TimeSpan.FromMilliseconds(100);
            try
            {
                wait.Until(e =>
                {
                    try
                    {
                        if (element.Enabled == true)
                        {
                            return true;
                        }
                        return false;
                    }
                    catch (NoSuchElementException)
                    {
                        return false;
                    }
                    catch (StaleElementReferenceException)
                    {
                        return false;
                    }

                });
            }
            catch (NoSuchElementException) { }
            catch (StaleElementReferenceException) { }

        }

    }
}
