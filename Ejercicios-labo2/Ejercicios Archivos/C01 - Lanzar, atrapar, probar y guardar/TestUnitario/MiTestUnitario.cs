using Biblioteca;

namespace TestUnitario
{
    [TestClass]
    public class MiTestUnitario
    {
        [TestMethod]
        [ExpectedException(typeof(DivideByZeroException))]
        public void TestMetodoEstatico()
        {
            MiClase.Metodo();
        }

        [TestMethod]
        [ExpectedException(typeof(DivideByZeroException))]
        public void TestConstrutorSinParametro()
        {
            MiClase miClase = new MiClase();
        }

        [TestMethod]
        [ExpectedException(typeof(UnaExcepcion))]
        public void TestConstrutorConParametro()
        {
            MiClase miClase = new MiClase(10);
        }

    }
}