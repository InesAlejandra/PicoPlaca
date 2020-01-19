using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PicoyPlaca;

namespace TestPicoyPlaca
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]

        public void TestSchedule()
        {
            DateTime time = new DateTime(2020, 01, 17, 7, 59, 59);

            var verificar = new Functions();
            var resultadoEsperado = true;
            var resultado = verificar.CheckSchedule(time, new TimeSpan(7, 00, 0), new TimeSpan(9, 30, 0));

            Assert.AreEqual(resultadoEsperado, resultado);
        }

        [TestMethod]
        public void TestRango()
        {
            DateTime time = new DateTime(2020, 01, 17, 7, 59, 59);
            var verificar = new Functions();
            var resultadoEsperado = true;
            var resultado = verificar.CheckRanges(time);

            Assert.AreEqual(resultadoEsperado, resultado);
        }

        [TestMethod]
        public void VerifyPlate()
        {
            String plate = "AAA-1234";
            var verificar = new Functions();
            var resultadoEsperado = "Tuesday";
            var resultado = verificar.VerifyPlate(plate);

            Assert.AreEqual(resultadoEsperado, resultado);
        }

        [TestMethod]
        public void VerifyPicoyPlaca()
        {

            String plateNumber = "AAA-1239";
            DateTime time = new DateTime(2020, 01, 17, 00, 59, 59);

            var verificar = new Functions();
            var resultadoEsperado = "This car has no vehicle restriction";
            var resultado = verificar.ChechkPicoPlaca(time, plateNumber);

            Assert.AreEqual(resultadoEsperado, resultado);
        }
    }
}
