using Newtonsoft.Json.Linq;
using OpenQA.Selenium;
using System.IO;

namespace CodedUITestProject1.Funcionalidade
{
    public class ElementUtils
    {
        private WebDriver _webDriver;
        JObject dataMass;
        JavaScriptExecute jsExecute;


        public ElementUtils(WebDriver webDriver)
        {
            _webDriver = webDriver;
            jsExecute = new JavaScriptExecute(webDriver);
        }


        public void MethodElementClick(string element)
        {
            switch (element)
            {
                case "Blog":
                case "Buscar":
                case "Assinar":
                    _webDriver.Wait.Until(el => el.FindElement(By.XPath("/html/body/nav/div/div/a[5]"))).Click();
                    break;
                default:
                    break;
            }
        }

        public void MethodElementFieldSendKeys(string elementDataType, string element)
        {
            switch (elementDataType)
            {
                case "O que você procura":
                    _webDriver.Wait.Until(el => el.FindElement(By.ClassName("btnLogin"))).SendKeys(element);
                    break;
                default:
                    break;
            }
        }


    }
}