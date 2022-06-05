using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataDrivenTestingWithSelenium
{
    public class Calculator
    {
        private readonly IWebDriver driver;

        public Calculator(IWebDriver driver)
        {
            this.driver = driver;

        }

        public IWebElement firstField =>
            driver.FindElement(By.Id("number1"));

        public IWebElement secondField =>
            driver.FindElement(By.Id("number2"));

        public IWebElement operation =>
            driver.FindElement(By.Id("operation"));

        public IWebElement rezult =>
            driver.FindElement(By.Id("calcButton"));

        public IWebElement clear =>
            driver.FindElement(By.Id("resetButton"));

        public IWebElement expected =>
            driver.FindElement(By.Id("result"));

        public string Add(string num1, string num2)
        {
            firstField.SendKeys(num1);
            operation.FindElement(By.XPath("//option[. = '+ (sum)']")).Click();
            secondField.SendKeys(num2);
            rezult.Click();

            return expected.Text;          
        }

        public string Subtract(string num1, string num2)
        {
            firstField.SendKeys(num1);
            operation.FindElement(By.XPath("//option[. = '- (subtract)']")).Click();
            secondField.SendKeys(num2);
            rezult.Click();

            return expected.Text;
        }

        public string Multiply(string num1, string num2)
        {
            firstField.SendKeys(num1);
            operation.FindElement(By.XPath("//option[. = '* (multiply)']")).Click();
            secondField.SendKeys(num2);
            rezult.Click();

            return expected.Text;
        }

        public string Divide(string num1, string num2)
        {
            firstField.SendKeys(num1);
            operation.FindElement(By.XPath("//option[. = '/ (divide)']")).Click();
            secondField.SendKeys(num2);
            rezult.Click();

            return expected.Text;
        }
    }
}
