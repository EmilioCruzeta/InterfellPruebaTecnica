using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Edge;
using System.Threading.Tasks;


namespace TestAPI
{
    [TestClass]
    public class EdgeDriverTest
    {
        // In order to run the below test(s), 
        // please follow the instructions from http://go.microsoft.com/fwlink/?LinkId=619687
        // to install Microsoft WebDriver.

        private EdgeDriver _driver;
        private EdgeDriver _TittleAPI;

        [TestInitialize]
        public void EdgeDriverInitialize()
        {
            // Initialize edge driver 
            var options = new EdgeOptions
            {
                PageLoadStrategy = PageLoadStrategy.Normal
            };
            _driver = new EdgeDriver(options);
            _TittleAPI = new EdgeDriver(options);

        }

        [TestMethod]
        public void VerifyPageTitle()
        {
            // Replace with your own test logic
            _driver.Url = "https://www.bing.com";
            Assert.AreEqual("Bing", _driver.Title);
        }

        [TestCleanup]
        public void EdgeDriverCleanup()
        {
            _driver.Quit();
            _TittleAPI.Quit();
        }


        [TestMethod]
        public void VerifyPageAPITitle()
        {
            // Replace with your own test logic
            _TittleAPI.Url = "https://localhost:44308/swagger/index.html";
            Assert.AreEqual("Swagger UI", _TittleAPI.Title);
        }


        [TestMethod]
        public void GetClientes()
        {
            //var Result = new ;
            Assert.AreEqual("Swagger UI", _TittleAPI.Title);
        }
    }
}
