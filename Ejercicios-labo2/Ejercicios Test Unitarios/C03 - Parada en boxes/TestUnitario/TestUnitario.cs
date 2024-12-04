using Biblioteca;

namespace TestUnitario
{
    [TestClass]
    public class TestUnitario
    {
        [TestMethod]
        public void ConstructorSinParametros_CuandoSeInstanciaUnaCompetencia_DeberiaInicializarLista()
        {
            //arrange
            short cantidadVueltas = 5;
            short cantidadCompetidores = 3;
            Competencia.TipoCompetencia tipo = Competencia.TipoCompetencia.F1;
            //act
            Competencia competencia = new Competencia(cantidadVueltas,cantidadCompetidores,tipo);
            //assert
            Assert.IsNotNull(competencia.ListaDeVehiculos);
        }

        [TestMethod]
        [ExpectedException(typeof(CompetenciaNoDisponibleException))]
        public void AgregarAutoF1_CuandoAgregoObjetoTipoAutoF1ACompetenciaTipoMotoCross_DeberiaLanzarExcepcionCompetenciaNoDisponibleException()                
        {
            //arrange
            Competencia competenciaMotocross = new Competencia(3, 5, Competencia.TipoCompetencia.MotoCross);
            AutoF1 autoF1 = new AutoF1(13, "Ferrari");
            bool valida;

            //act
            valida = competenciaMotocross + autoF1;
        }

        [TestMethod]
        public void AgregarMotoCross_CuandoAgregoObjetoTipoMotoCrossACompetenciaTipoMotoCross_DeberiaNoLanzarExcepcionCompetenciaNoDisponibleException()
        {
            //arrange
            Competencia competenciaMotocross = new Competencia(3, 5, Competencia.TipoCompetencia.MotoCross);
            MotoCross moto = new MotoCross(4, "RedBull");
            //act
            bool validacion = competenciaMotocross + moto;
            //assert
            Assert.IsTrue(validacion);
        }
        [TestMethod]
        public void ValidaAgregarVehiculoEnCompetencia()
        {
            //Arrange
            Competencia competencia = new Competencia(10, 5, Competencia.TipoCompetencia.MotoCross);
            MotoCross moto = new MotoCross(25, "Valentino");
            //Act           
            //Assert
            if (competencia + moto)
            {
                Assert.IsTrue(competencia == moto);
            }
        }
        [TestMethod]
        public void ValidaQuitarVehiculoEnCompetencia()
        {
            //Arrange
            Competencia competencia = new Competencia(10, 5, Competencia.TipoCompetencia.MotoCross);
            MotoCross moto = new MotoCross(25, "Valentino");
            //Act           
            //Assert
            if (competencia - moto)
            {
                Assert.IsTrue(competencia != moto);
            }
        }

    }
}