using Microsoft.VisualStudio.TestTools.UnitTesting;
using Mez01.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mez01.AppData;

namespace Mez01.Pages.Tests
{
    [TestClass()]
    public class AddEditSpravTests
    {
        [TestMethod()]
        public void CheckInformationMarkaTest()
        {
            Sprav inf = new Sprav { Marka = "Fiat", Model = "номер 1", Price = 3 };
            bool expected = false;
            bool actual = AddEditSprav.CheckInformation(inf);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void CheckInformationModelTest()
        {
            Sprav inf = new Sprav { Marka = "Fiat", Model = "номер 1", Price = 3 };
            bool expected = false;
            bool actual = AddEditSprav.CheckInformation(inf);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void CheckInformationPriceTest()
        {
            Sprav inf = new Sprav { Marka = "Fiat", Model = "номер 1", Price = -3 };
            bool expected = false;
            bool actual = AddEditSprav.CheckInformation(inf);
            Assert.AreEqual(expected, actual);
        }
    }
}