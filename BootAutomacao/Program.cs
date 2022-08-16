using System;
using OpenQA.Selenium;
using prmToolkit.Selenium;
using prmToolkit.Selenium.Enum;

namespace BootAutomacao
{
	class Program
	{
		static void Main(string[] args)
		{
			string localDriver = System.AppDomain.CurrentDomain.BaseDirectory.ToString();
			IWebDriver webDriver = WebDriverFactory.CreateWebDriver(Browser.Chrome,localDriver + "/driver");

			webDriver.LoadPage(TimeSpan.FromSeconds(8), "https://www.portaltransparencia.gov.br/despesas/orgao?ordenarPor=orgaoSuperior&direcao=asc");
			//webDriver.Navigate().GoToUrl("http://www.google.com/");

		}
	}
}
