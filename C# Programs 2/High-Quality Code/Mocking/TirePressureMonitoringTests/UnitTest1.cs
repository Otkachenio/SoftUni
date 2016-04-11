using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using Moq;
using Problem2.TirePressureMonitoringSystem;

namespace TirePressureMonitoringTests
{
    [TestClass]
    public class TirePressureMonitoringSystemTests
    {
        [TestMethod]
        public void Test_AlarmOn_ShouldReturnTrue()
        {
            //Arrange
            var alarm = new Alarm();

            //Act
            alarm.Check();

            //Assert
            Assert.IsTrue(alarm.AlarmOn);
        }

        [TestMethod]
        public void Test_AlarmOff_ShouldReturnFalse()
        {
            //Arrange
            var alarm = new Alarm();

            //Act
            //Nopthing for the moment...

            //Assert
            Assert.IsFalse(alarm.AlarmOn);
        }
    }
}
