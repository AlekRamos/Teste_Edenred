using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;

namespace CodedUITestProject1.Funcionalidade
{
    class JavaScriptExecute
    {
        private WebDriver _webDriver;

        public JavaScriptExecute(WebDriver webDriver)
        {
            _webDriver = webDriver;

        }

        public void Executescript(WebDriver webDriver)
        {
            IWebElement element = webDriver.Wait.Until(el => el.FindElement(By.XPath("//*[@id='Painel']/table/tbody/tr[19]/td[1]/strong")));
            Actions act = new Actions(webDriver.Current);
            act.MoveToElement(element);
            act.Perform();
        }

        public void Executescript2(WebDriver webDriver)
        {
            ((IJavaScriptExecutor)webDriver.Current).ExecuteScript("window.scrollBy(0,500)", "");
        }

        public string RandomNumber()
        {
            Random random = new Random();
            int valor;
            valor = random.Next(99999, 9999999);
            String stValor = valor.ToString();
            return stValor;



        }

    }
}
