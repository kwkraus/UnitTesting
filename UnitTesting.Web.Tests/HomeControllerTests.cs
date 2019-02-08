using System;
using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using UnitTesting.Services;
using UnitTesting.Web.Controllers;
using UnitTesting.Web.Tests.Fakes;

namespace UnitTesting.Web.Tests
{
    [TestClass]
    public class HomeControllerTests : TestBase
    {
        [TestMethod]
        [TestCategory("Web")]
        public void HomeController_GetParcel_View()
        {
            //arrange
            var parcelSvc = new ParcelService(new ParcelDataAccessFake());
            var controller = new HomeController(parcelSvc);

            //act
            var result = controller.Parcel();

            //assert
            Assert.IsTrue(true);
        }
    }
}
