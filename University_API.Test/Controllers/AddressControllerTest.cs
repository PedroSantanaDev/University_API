using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using University_API.Controllers;
using University_API.Models;

namespace University_API.Test.Controllers
{
    [TestClass]
    public class AddressControllerTest
    {
        [TestMethod]
        public void GetAddressesTest()
        {
            // Arrange
            AddressController controller = new AddressController();

            // Act
            IEnumerable<Address> result = controller.GetAddresses();
              
            // Assert
            Assert.IsNotNull(result);
            //Assert.AreEqual(2, result.Count());
            //Assert.AreEqual("value1", result.ElementAt(0));
            //Assert.AreEqual("value2", result.ElementAt(1));

            
        }

        [TestMethod]
        public void GetAddressesByIdTest()
        {
            // Arrange
            AddressController controller = new AddressController();

            // Act
            var result = controller.GetAddress(5);

            // Assert
            Assert.IsNotNull(result);
        }

    }
}
