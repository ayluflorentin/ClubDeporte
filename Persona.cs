using System;
using System.Collections.Generic;

namespace ClubDeportes
{   
	public class ClubDeportivo
    { //representará a todas las personas asociadas al club deportivo
        private List<Persona> personas;
        public ClubDeportivo()
        {
            personas = new List<Persona>();
        }

	public class Persona
    {
        // Atributos protegidos para poder acceder desde otras clases
        protected string nombre;
        protected string dni;
        protected int edad;

        // Propiedades públicas para acceso a los Atributos privados
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public string Dni
        {
            get { return dni; }
            set { dni = value; }
        }

        public int Edad
        {
            get { return edad; }
            set { edad = value; }
        }

        // Constructor que inicializa todos los Atributos
        public Persona(string nombre, string dni, int edad)
        {
            this.nombre = nombre;
            this.dni = dni;
            this.edad = edad;
        }
       //metodo
        public string ObtenerInformacion()
    {
        return "Nombre: " + nombre + " Dni: " + dni +" Edad: "+ edad;
    }
    
