using Biblioteca;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //LEER LISTA DE PERS
                //List<Persona> listaPersona = PersonaDAO.Leer();

                //foreach (var item in listaPersona)
                //{
                //    Console.WriteLine(item.ToString());
                //}

                //LEER POR ID
                //Persona persona = PersonaDAO.LeerPorId(2);
                //Console.WriteLine(persona);

                //GUARDAR
                //Persona persona = new Persona("Cuqui", "Silvera");
                //PersonaDAO.Guardar(persona);

                //ELIMINAR
                //PersonaDAO.Eliminar(3);


                //MODIFICAR
                //Persona persona = PersonaDAO.LeerPorId(4);
                //Console.WriteLine(persona.ToString());
                //persona.Nombre = "CUQUI";
                //persona.Apellido = "SILVERA";
                //PersonaDAO.Modificar(persona);
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message); 
            }
            



        }
    }
}
