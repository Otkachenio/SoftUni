using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using Moq;
using DateTimeTest;

namespace DateTimeTests
{
    [TestClass]
    public class DateTimeTest
    {
        [TestMethod]
        public void Test_DateTimeNow_AddDays_ShouldReturnOneDayAdded()
        {
            //Assert
            var mock = new Mock<IDateTimeProvider>();
            mock.Setup(d => d.DateTimeNow).Returns(new DateTime(2015, 04, 03));

            //Act
            var date = mock.Object.DateTimeNow.AddDays(1);
            var expected = new DateTime(2015, 04, 04);

            //Assert
            Assert.AreEqual(expected, date);
        }

        [TestMethod]
        public void Test_DateTimeNow_AddDaysAtTheEndOfTheMonth_ShouldReturNewMonthAndDate()
        {
            //Assert
            var mock = new Mock<IDateTimeProvider>();
            mock.Setup(d => d.DateTimeNow).Returns(new DateTime(2015, 04, 30));

            //Act
            var date = mock.Object.DateTimeNow.AddDays(1);
            var expected = new DateTime(2015, 05, 01);

            //Assert
            Assert.AreEqual(expected, date);
        }

        [TestMethod]
        public void Test_DateTimeNow_AddNegativeValue_ShouldReturnEarlierDate()
        {
            //Assert
            var mock = new Mock<IDateTimeProvider>();
            mock.Setup(d => d.DateTimeNow).Returns(new DateTime(2015, 04, 30));

            //Act
            var date = mock.Object.DateTimeNow.AddDays(-5);
            var expected = new DateTime(2015, 04, 25);

            //Assert
            Assert.AreEqual(expected, date);
        }

        [TestMethod]
        public void Test_AddNegativeValueAtTheBigginingOfTheMonth_ShouldReturnEarlierMontAndDate()
        {
            //Assert
            var mock = new Mock<IDateTimeProvider>();
            mock.Setup(d => d.DateTimeNow).Returns(new DateTime(2015, 04, 04));

            //Act
            var date = mock.Object.DateTimeNow.AddDays(-5);
            var expected = new DateTime(2015, 03, 30);

            //Assert
            Assert.AreEqual(expected, date);
        }

        [TestMethod]
        public void Test_AddingDayToLeapYear_ShouldReturnFebruary29()
        {
            //Assert
            var mock = new Mock<IDateTimeProvider>();
            mock.Setup(d => d.DateTimeNow).Returns(new DateTime(2016, 02, 28));

            //Act
            var date = mock.Object.DateTimeNow.AddDays(1);
            var expected = new DateTime(2016, 02, 29);

            //Assert
            Assert.AreEqual(expected, date);
        }

        [TestMethod]
        public void Test_AddingDayToNonLeapYear_ShouldReturnMarch01()
        {
            //Assert
            var mock = new Mock<IDateTimeProvider>();
            mock.Setup(d => d.DateTimeNow).Returns(new DateTime(1900, 02, 28));

            //Act
            var date = mock.Object.DateTimeNow.AddDays(1);
            var expected = new DateTime(1900, 03, 01);

            //Assert
            Assert.AreEqual(expected, date);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException), "Should throw out of range exception!")]
        public void Test_AddingDayDateTimeMaxValue_ShouldThrowException()
        {
            //Assert
            var mock = new Mock<IDateTimeProvider>();
            mock.Setup(d => d.DateTimeNow).Returns(DateTime.MaxValue);

            //Act
            var date = mock.Object.DateTimeNow.AddDays(1);
        }

        [TestMethod]
        public void Test_AddingDayToDateTimeMinValue_ShouldFirstDatePlusTheDaysAdded()
        {
            //Assert
            var mock = new Mock<IDateTimeProvider>();
            mock.Setup(d => d.DateTimeNow).Returns(DateTime.MinValue);

            //Act
            var date = mock.Object.DateTimeNow.AddDays(1);
            var expected = new DateTime(1, 01, 02);

            //Assert
            Assert.AreEqual(expected, date);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException), "Should throw out of range exception")]
        public void Test_SubstrackDayFromDateTimeMinValue_ShouldThrowException()
        {
            //Assert
            var mock = new Mock<IDateTimeProvider>();
            mock.Setup(d => d.DateTimeNow).Returns(DateTime.MinValue);

            //Act
            var date = mock.Object.DateTimeNow.AddDays(-1);
        }

        [TestMethod]
        public void Test_SubstracktDayToDateTimeMax_ShouldReturnCorectValueInTicks()
        {
            //Assert
            var mock = new Mock<IDateTimeProvider>();
            mock.Setup(d => d.DateTimeNow).Returns(DateTime.MaxValue);

            //Act
            var date = mock.Object.DateTimeNow.AddDays(-1);
            var expected = new DateTime(3155378111999999999);

            //Assert
            Assert.AreEqual(expected, date);
        }
    }
}