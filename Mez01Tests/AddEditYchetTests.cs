using Mez01.AppData;
using Mez01.Pages;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mez01Tests
{
    [TestClass()]
    public class AddEditYchetTests
    {
        [TestMethod()]
        public void CheckInformationKodAutoTest()
        {
            Ychet yhc = new Ychet { KodAuto = -1, FIO = "ФИО1", Mesyacz = "Январь", KolvoAuto = 34 };
            bool expected = false;
            bool actual = AddEditYchet.CheckYchet(yhc);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void CheckInformationFIOTest()
        {
            Ychet yhc = new Ychet { KodAuto = 1, FIO = "ФИО1", Mesyacz = "Январь", KolvoAuto = 34 };
            bool expected = false;
            bool actual = AddEditYchet.CheckYchet(yhc);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void CheckInformationMesyaczTest()
        {
            Ychet yhc = new Ychet { KodAuto = 1, FIO = "", Mesyacz = "Январь", KolvoAuto = 34 };
            bool expected = false;
            bool actual = AddEditYchet.CheckYchet(yhc);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void CheckInformationKolvoAutoTest()
        {
            Ychet yhc = new Ychet { KodAuto = 1, FIO = "ФИО1", Mesyacz = "Январь", KolvoAuto = -34 };
            bool expected = false;
            bool actual = AddEditYchet.CheckYchet(yhc);
            Assert.AreEqual(expected, actual);
        }
    }
}
