using Biblioteca;

namespace Consola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //List<UsuarioDto> usuarios =  UsuarioDao.Leer();
            //foreach (var item in usuarios)
            //{
            //    Console.WriteLine(item.ToString());
            //}

            ////////////////////////////////////////////////////////////////////////
            
            //JuegoDto juego = JuegoDao.LeerPorId(1);
            //Console.WriteLine(juego);

            ///////////////////////////////////////////////////////////////////////

            //JuegoDto juegoDto = new JuegoDto("Warframe", 13000, "mmo", 1001);
            //JuegoDao.Guardar(juegoDto);

            //////////////////////////////////////////////////////////////////////

            //JuegoDao.Eliminar(2);

            /////////////////////////////////////////////////////////////////////

            JuegoDto juego = JuegoDao.LeerPorId(1);
            juego.Precio = 45000;
            JuegoDao.Modificar(juego);


        }
    }
}
