using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using UnitTesting.DataAccess;
using UnitTesting.Models;

namespace UnitTesting.Services.Tests
{
    [TestClass]
    public class ParcelServiceTests : TestBase
    {
        [TestMethod]
        public void ParcelSvc_GetParcel_ValidateData()
        {
            //arrange
            int id = 4;
            var parcel = new Parcel
            {
                Id = id,
                Name = "AJ's House",
                Township = "Las Vegas",
                Owner = "Clark County"
            };

            Mock<IParcelDataAccess> daMock = new Mock<IParcelDataAccess>();
            daMock.Setup(dataAccess => dataAccess.GetParcel(It.IsAny<int>())).Returns(parcel);

            var parcelSvc = new ParcelService(daMock.Object);

            //act
            var result = parcelSvc.GetParcel(id);

            //assert
            Assert.IsTrue(result.Id == id, "failed to return expected value");
        }
    }
}
