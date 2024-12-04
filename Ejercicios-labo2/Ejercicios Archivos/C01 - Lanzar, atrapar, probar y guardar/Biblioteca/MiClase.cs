namespace Biblioteca
{
    public class MiClase
    {

        public static void MiMetodoEstatico()
        {
            throw new DivideByZeroException("MetodoEstatico Division por cero");
        }

        public MiClase()
        {
            try
            {
                MiClase.MiMetodoEstatico();
            }
            catch (DivideByZeroException ex)
            {
                throw ex;
            }
        }

        public MiClase(int num1)
        {
            try
            {
                new MiClase();
            }
            catch (DivideByZeroException ex)
            {

                throw new UnaExcepcion("MiClase(int num1)", ex);
            }
        }

    }
}
