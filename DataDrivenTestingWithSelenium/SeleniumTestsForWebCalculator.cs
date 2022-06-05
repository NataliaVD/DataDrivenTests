using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace DataDrivenTestingWithSelenium
{
    public class SeleniumTestsForWebCalculator
    {
        private WebDriver driver;
        private Calculator calculator;

        [OneTimeSetUp]
        public void Setup()
        {
            this.driver = new ChromeDriver();
            this.driver.Url = "https://number-calculator.nakov.repl.co/";
            this.calculator = new Calculator(driver);
        }

        [OneTimeTearDown]
        public void ShutDown()
        {
            this.driver.Close();
        }

        [TestCase("4", "3")]
        [TestCase("5", "6")]
        [TestCase("7", "9")]
        [TestCase("100", "350")]
        public async Task AddTwoPositiveNumbers(string firstNum, string secondNum)
        {
           var expected = calculator.Add(firstNum, secondNum);
            var result = "Result: " + (Int16.Parse(firstNum) + Int16.Parse(secondNum));
           Assert.That(expected, Is.EqualTo(result));
            calculator.clear.Click();
        }

        [TestCase("4", "3")]
        [TestCase("6", "5")]
        [TestCase("9", "7")]
        public async Task SubtractTwoNegativeNumbers(string firstNum, string secondNum)
        {
            int num1 = Int32.Parse(firstNum);
            int num2 = Int32.Parse(secondNum);
            int sum = num1 - num2;
            var expected = calculator.Subtract(firstNum, secondNum);
            var result = "Result: " + sum;
            Assert.That(expected, Is.EqualTo(result));
            calculator.clear.Click();
        }

        [TestCase("4", "3")]
        [TestCase("5", "6")]
        [TestCase("7", "9")]
        public async Task MultiplyPositiveNumbers(string firstNum, string secondNum)
        {
            int num1 = Int32.Parse(firstNum);
            int num2 = Int32.Parse(secondNum);
            int sum = num1 * num2;
            var expected = calculator.Multiply(firstNum, secondNum);
            var result = "Result: " + sum;
            Assert.That(expected, Is.EqualTo(result));
            calculator.clear.Click();
        }

        [TestCase("4", "4")]
        [TestCase("6", "2")]
        [TestCase("9", "3")]
        public async Task DivideTwoPositiveNumbers(string firstNum, string secondNum)
        {
            int num1 = Int32.Parse(firstNum);
            int num2 = Int32.Parse(secondNum);
            int sum = num1 / num2;
            var expected = calculator.Divide(firstNum, secondNum);
            var result = "Result: " + sum;
            Assert.That(expected, Is.EqualTo(result));
            calculator.clear.Click();
        }
    }
}