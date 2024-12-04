namespace Biblioteca
{
    public class MiClase
    {

        public static void Metodo()
        {
            throw new DivideByZeroException();
        }

        public MiClase()
        {
            try
            {
                MiClase.Metodo();
            }
            catch (DivideByZeroException ex)
            {
                throw ex;
            }
        }

        public MiClase(int n1)
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
