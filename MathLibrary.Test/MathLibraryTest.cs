using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MathsLibrary;
using Moq;

namespace MathLibrary.Test
{
    [TestClass]
    public class MathLibraryTest
    {
        public TestContext TestContext { get; set; }
        private MathsLibrary.MathLibrary mathLibrary;

        private Calculator cal;
        [TestInitialize]
        public void TestIntialise()
        {            
            mathLibrary = new MathsLibrary.MathLibrary();
        }
        [TestMethod]
       
        public void TestAdd()
        {
            //Arranage
            int x = 12; int y = 13;

            //Act
            int result = mathLibrary.Add(x, y);

            //Assert
            Assert.AreEqual(25, result);


            MathsLibrary.MathLibrary mathLibrary1 = new MathsLibrary.MathLibrary();
            mathLibrary1 = mathLibrary;
            Assert.IsInstanceOfType(mathLibrary1, typeof(MathsLibrary.MathLibrary));
            Assert.AreSame(mathLibrary1, mathLibrary);
           

        }

        [TestMethod]

        public void TeestMoq()
        {
            Mock<IMathLibrary> mathLibrary = new Mock<IMathLibrary>();

            //mathLibrary.Setup(x => x.Add(It.IsAny<int>(), It.IsAny<int>())).Returns(12);
            mathLibrary.Setup(x => x.doCalculation).Returns(true);

            cal = new Calculator(mathLibrary.Object);

            var result = cal.Calculate(OperationType.Add);

            Assert.AreEqual(60, result);
        }
    }
}
