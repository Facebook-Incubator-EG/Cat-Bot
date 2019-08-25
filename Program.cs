using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace botFacebook
{
    class Program
    {
        static void Main(string[] args)
        {
            var chromeOptions = new ChromeOptions();
            chromeOptions.AddArguments("--disable-notifications");
            IWebDriver driver = new ChromeDriver(chromeOptions);
            Thread.Sleep(1000);
            //carrega pagina do facebook
            driver.Navigate().GoToUrl("http:www.facebook.com");
            IWebElement element = driver.FindElement(By.Name("email"));
            //Login
            element.SendKeys("");
            //Thread.Sleep(1000);
            element = driver.FindElement(By.Name("pass"));
            //Senha
            element.SendKeys("#");
            try
            {
                driver.FindElement(By.Id("u_0_2")).Click();
            }
            catch
            {
                try
                {
                    driver.FindElement(By.Id("u_0_3")).Click();
                }
                catch
                {
                    driver.FindElement(By.Id("u_0_a")).Click();
                }
            }
            //driver.FindElement(By.XPath("//div[@class='_6rk2 img sp_S8pk_WlQaUU_1_5x sx_f6459b']")).Click();
            //Thread.Sleep(500);
            /*
            driver.FindElement(By.Name("mercurymessages")).Click();
            Thread.Sleep(1000);
            driver.FindElement(By.XPath("//div[@class='author']")).Click();
            //element = driver.FindElement(By.XPath("// div[@class='_5rp7 _5rp8']"));
            Thread.Sleep(5000);
            */
            driver.FindElement(By.XPath("//a[@data-testid='UFI2ReactionLink']")).Click();
            Thread.Sleep(5000);
        }
    }
}
