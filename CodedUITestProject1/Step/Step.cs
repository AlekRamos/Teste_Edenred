using Newtonsoft.Json.Linq;
using OpenQA.Selenium;
using System;
using System.Configuration;
using System.IO;
using System.Threading;
using TechTalk.SpecFlow;

namespace CodedUITestProject1.Funcionalidade
{
    [Binding]
    [Scope(Tag = "TestScenario")]
    [Scope(Tag = "MassaReaproveitavel")]
    [Scope(Tag = "MassaNaoReaproveitavel")]


    public class Steps
    {
        private WebDriver _webDriver;
        AssertUtils assertUtils;
        ElementUtils elementUtils;
        JavaScriptExecute javaScriptExecute;
        protected string DataMass => ConfigurationManager.AppSettings["DataMass"];

        public Steps(WebDriver webDriver)
        {
            _webDriver = webDriver;
            _webDriver.Current.Manage().Window.Maximize();
            elementUtils = new ElementUtils(webDriver);
            assertUtils = new AssertUtils(webDriver);
            javaScriptExecute = new JavaScriptExecute(webDriver);

        }

        //##############################################################################################
        //[ Métodos Gancho(Hooks) ]#####################################################################

        [AfterScenario]
        public void tearDown()
        {
            if (_webDriver != null)
            {
                _webDriver.Quit();
            }
        }


        //##############################################################################################
        //[ Métodos Given ]#############################################################################

        [Given(@"que estou na página ""(.*)""")]
        [Given(@"que eu acesse a pagina ""(.*)""")]
        public void StepPages(string url)
        {
            var driver = _webDriver.Current;

            switch (url)
            {
                case "Edenred":
                    driver.Url = "https://www.edenredprepagos.com.br/";
                    break;
                default:
                    break;
            }
        }

        //##############################################################################################
        //[ Métodos When ]##############################################################################

        [When(@"eu aguardar por (.*) segundos")]
        public void StepWait(int waitTime)
        {
            Thread.Sleep(TimeSpan.FromSeconds(waitTime));
        }

        [When(@"eu clicar no botão ""(.*)""")]
        [When(@"eu clicar no link ""(.*)""")]
        [When(@"eu clicar no campo ""(.*)""")]
        [When(@"eu clicar no ícone ""(.*)""")]
        public void StepElementClick(string element)
        {
            elementUtils.MethodElementClick(element);
        }

        [When(@"no campo ""(.*)"" eu digitar ""(.*)""")]
        public void StepElementFieldSendKeys(string elementDataType, string element)
        {
            elementUtils.MethodElementFieldSendKeys(elementDataType, element);
        }


        //##############################################################################################
        //[ Métodos Then ]##############################################################################

        [Then(@"rolando para baixo o sistema apresenta os dados")]
        public void EntaoRolandoParaBaixoOSistemaApresentaOsDados()
        {
            javaScriptExecute.Executescript2(_webDriver);
        }


    }
}
