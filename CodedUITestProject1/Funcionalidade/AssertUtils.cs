using OpenQA.Selenium;
using System;

namespace CodedUITestProject1.Funcionalidade
{
    public class AssertUtils
    {
        private WebDriver _webDriver;
        ElementUtils elementUtils;
        JavaScriptExecute jsExecute;


        public AssertUtils(WebDriver webDriver)
        {
            _webDriver = webDriver;
            jsExecute = new JavaScriptExecute(webDriver);
            elementUtils = new ElementUtils(webDriver);
        }

        public AssertUtils()
        {
        }

        //##############################################################################################
        //[ Métodos Assertivos Genéricos ]##############################################################

     

        public void Executescript(WebDriver webDriver)
        {
            var javaScroll = webDriver.Current as IJavaScriptExecutor;
            ((IJavaScriptExecutor)webDriver).ExecuteScript("window.scrollBy(0,720)", "");
        }


    }
}



