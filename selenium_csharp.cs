using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selenium_Task
{
   class sample
    {
        private void sample2()
        {
            var driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://app.cloudqa.io/home/AutomationPracticeForm");
            var title_field = driver.findElement(By.id("fname"));
            if (title_field != null)
            {
                Actions actions = new Actions(driver);
                actions.MoveToElement(title_field);
                actions.Click();
                actions.SendKeys("Hello");
                actions.Build().Perform();
            }
            var title_field_2 = driver.findElement(By.id("lname"));
            if (title_field_2 != null)
            {
                Actions actions = new Actions(driver);
                actions.MoveToElement(title_field_2);
                actions.Click();
                actions.SendKeys("Everyone");
                actions.Build().Perform();
            }
            var title_field_3 = driver.findElement(By.id("mobile"));
            if (title_field_3 != null)
            {
                Actions actions = new Actions(driver);
                actions.MoveToElement(title_field_3);
                actions.Click();
                actions.SendKeys("123456789");
                actions.Build().Perform();
            }
        }
    }
}