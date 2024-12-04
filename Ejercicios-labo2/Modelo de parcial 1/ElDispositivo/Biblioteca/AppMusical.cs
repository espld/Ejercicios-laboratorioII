using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class AppMusical: Aplicacion
    {
        private List<string> listaCanciones;

        public AppMusical(string nombre,SistemaOperativo sistemaOperativo,int tamanioInicial)
            :this(nombre,sistemaOperativo,tamanioInicial, new List<string>())
        {

        }
        public AppMusical(string nombre, SistemaOperativo sistemaOperativo, int tamanioInicial,List<string> listaCanciones)
            :base(nombre,sistemaOperativo,tamanioInicial)
        {
            if (listaCanciones is null)
            {
                this.listaCanciones = new List<string>();
            }
            else
            {
                this.listaCanciones = listaCanciones;
            }
        }

        //Propiedades
        protected override int Tamanio
        {
            get 
            {
                return this.tamanioMb + (this.listaCanciones.Count * 2);
            }
        }

        //Metodos
        public override string ObtenerInformacionApp()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(base.ObtenerInformacionApp());
            foreach (var item in this.listaCanciones)
            {
                sb.AppendLine(item);
            }

            return sb.ToString();
        }


    }
}
