using Microsoft.VisualStudio.TestTools.UnitTesting;
using WinFormPrueba;

namespace WinFormPrueba.Tests
{
    [TestClass()]
    public class Form1Tests
    {
        

        [TestMethod()]
        public void generarTest()
        {
            //Arrange
            var instance = new Form1();

            //Act
            int Leap = 4;
            int[] Path = new int[11] { 1, 1, 0, 0, 1, 1, 0, 1, 0, 1, 1 };
          
            //Assert
            //Assert.Fail();
        }
    }
}