using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Biblioteca
    {
        private string genero;
        private string juego;
        private string usuario;
        private int codigoJuego;
        private double precio;


        public Biblioteca(string usuario,string genero,string juego,double precio,int codigoJuego)
        {
            this.usuario = usuario;
            this.genero = genero;
            this.juego = juego;
            this.precio = precio;
            this.codigoJuego = codigoJuego;
        }

        public string Juego
        {
            get { return this.juego; }
        }
        public string Genero
        {
            get { return this.genero; }
        }
        public double Precio
        {
            get { return this.precio; }
        }
        public string Usuario
        {
            get { return this.usuario; }
        }
        public int CodigoJuego
        {
            get { return this.codigoJuego; }
        }


    }
}
