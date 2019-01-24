using Microsoft.VisualStudio.TestTools.UnitTesting;
using WinFormPrueba;

namespace WinFormPrueba.Tests
{
    [TestClass()]
    public class Form1Tests
    {
        [TestMethod()]
        public void GenerarTest()
        {
            var instance = new Form1();
            int Leap = 4;
            int[] Path = new int[11] { 1, 1, 0, 0, 1, 1, 0, 1, 0, 1, 1 };
            string generar1 = instance.Generar(Path,Leap);
            
            Assert.IsNotNull(generar1);
        }

        [TestMethod()]
        public void GenerarTest2()
        {
            var instance = new Form1();
            int Leap = 1;
            int[] Path = new int[11] { 1, 1, 1, 0, 1, 1, 0, 1, 0, 0, 0 };
            string generar1 = instance.Generar(Path, Leap);

            Assert.IsNotNull(generar1);
        }
        [TestMethod()]
        public void GenerarTest3()
        {
           
            var instance = new Form1();
            int Leap = 5;
            int[] Path = new int[11] {1,0,0,0,0,1,0,1,1,0,0};
            string generar1 = instance.Generar(Path, Leap);

            Assert.IsNotNull(generar1);
        }

        [TestMethod()]
        public void GenerarTest4()
        {

            var instance = new Form1();
            int Leap = 3;
            int[] Path = new int[11] { 1, 0, 0, 0, 0, 1, 0, 1, 1, 0, 0 };
            string generar1 = instance.Generar(Path, Leap);

            Assert.IsNotNull(generar1);
        }



    }
}