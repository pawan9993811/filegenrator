using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using PegaSeleniumBase.Configuration;
using PegaSeleniumBase.Types;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PegaSeleniumBase.Extensions
{
    public static class WaitExtension
    {
        public static void WaitForElementVisibility(IWebDriver driver,ElementLocator locator)

        {
            ISearchContext element;
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(BaseConfiguration.ShortTimeout));
            wait.Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy(locator.ToBy()));
        }
    }
}
