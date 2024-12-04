using Entidades;

namespace TestProject1
{
    [TestClass]
    public class ExtensionTest
    {
        [TestMethod]
        public void CalcularDiferenciaEnSegundos_DeberiaRetornarDiferenciaEnSegundos()
        {
            //Arrange
            DateTime inicio = new DateTime(2011, 11, 16, 12, 00, 00);
            DateTime fin = new DateTime(2011, 11, 16, 12, 01, 30);

            double valorEsperado = 90;

            //Act
            //double resultado = fin.CalcularDiferenciaEnSegundos(inicio);
            double resultado = Extension.CalcularDiferenciaEnSegundos(fin, inicio);

            //Assert
            Assert.AreEqual(valorEsperado, resultado);
        }
    }
}