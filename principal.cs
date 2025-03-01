using System;
using System.Collections.Generic;

namespace proyecto_club
{
	class Program
	{
		
                    Console.ReadKey(true);}}}
            public static void Main(string[] args)
		{ 

        	while (true)
        {
            Console.WriteLine("Menú Principal:");
            Console.WriteLine("a- Dar de alta a un entrenador");
            Console.WriteLine("b- Dar de baja a un entrenador");
            Console.WriteLine("c- Dar de alta a un niño/socio en un deporte");
            Console.WriteLine("d- Dar de baja a un niño/socio en un deporte");
            Console.WriteLine("e- Simular el pago de una cuota");
            Console.WriteLine("f- Submenú de inscripción");
            Console.WriteLine("g- Listado de deudores");
            Console.WriteLine("h- Agregar un deporte");
            Console.WriteLine("i- Eliminar un deporte");
            Console.WriteLine("q- Salir");
            Console.Write("Seleccione una opción: ");
            string opcion = Console.ReadLine();

            switch (opcion)
            {
                case "a":
                    DarDeAltaEntrenador(entrenadores, deportes);
                    break;
                case "b":
                    DarDeBajaEntrenador(entrenadores);
                    break;
                case "c":
                    DarDeAltaNiñoSocio(socios, deportes);
                    break;
                case "d":
                    DarDeBajaNiñoSocio(socios, deportes);
                    break;
                case "e":
                    SimularPagoCuota(socios);
                    break;
                case "f":
                    SubmenuInscripcion(socios);
                    break;
                case "g":
                    ListadoDeudores(socios);
                    break;
                case "h":
                    AgregarDeporte(deportes);
                    break;
                case "i":
                    EliminarDeporte(deportes, socios);
                    break;
                case "q":
                    return;
                default:
                    Console.WriteLine("Opción no válida.");
                    break;
}}}
