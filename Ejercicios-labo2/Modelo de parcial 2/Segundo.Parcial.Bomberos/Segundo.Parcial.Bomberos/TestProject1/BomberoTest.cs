using Entidades;

namespace TestProject1
{
    [TestClass]
    public class BomberoTest
    {
        [TestMethod]
        public void LeerEnBombero_CuandoSeEjecuta_DeberiaRetornarElBomberoSerializado()
        {
            //Arrange
            Bombero bombero = new Bombero("Test");

            //Act
            bombero.Guardar(bombero);

            //Assert
            Bombero bomberoSerializado = bombero.Leer();
            Assert.AreEqual(bomberoSerializado.Nombre, bombero.Nombre);
        }
    }
}