using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WebAPI_TestStore;
using WebAPI_TestStore.Controllers;

namespace WebAPI_TestStore.Tests.Controllers
{
    [TestClass]
    public class HomeControllerTest
    {
        [TestMethod]
        public void Index()
        {
            // Arrange
            HomeController controller = new HomeController();

            // Act
            ViewResult result = controller.Index() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual("Home Page", result.ViewBag.Title);
        }
    }
}
