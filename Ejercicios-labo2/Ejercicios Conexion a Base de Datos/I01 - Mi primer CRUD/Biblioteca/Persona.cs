﻿namespace Biblioteca
{
    public class Persona
    {
        private int id;
        private string nombre;
        private string apellido;

        
        public Persona(string nombre, string apellido)
        { 
            this.nombre = nombre;
            this.apellido = apellido;
        }
        public Persona(int id, string nombre, string apellido):this(nombre,apellido)
        {
            this.id = id;
        }

        public int Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }

        public override string ToString()
        {
            return $"ID: {this.Id}, NOMBRE: {this.Nombre}, APELLIDO: {this.Apellido}";
        }
    }
}