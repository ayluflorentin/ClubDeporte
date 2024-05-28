using System;
using System.Collections.Generic;

public class Entrenador : Persona
{
    private string deporte;
    private string categoria;
    private List<string> diasEntrenamiento;
    private List<string> horariosEntrenamiento;

    // Propiedad DiasEntrenamiento
    public List<string> DiasEntrenamiento
    {
        get { return diasEntrenamiento; }
        set { diasEntrenamiento = value; }
    }

    // Propiedad HorariosEntrenamiento
    public List<string> HorariosEntrenamiento
    {
        get { return horariosEntrenamiento; }
        set { horariosEntrenamiento = value; }
    }

    // Propiedad Deporte
    public string Deporte
    {
        get { return deporte; }
        set { deporte = value; }
    }

    // Propiedad Categoria
    public string Categoria
    {
        get { return categoria; }
        set { categoria = value; }
    }

    // Constructor
    public Entrenador(string nombre, string dni, int edad, List<string> diasEntrenamiento, List<string> horariosEntrenamiento)
    {
        Nombre = nombre;
        DNI = dni;
        Edad = edad;
        this.diasEntrenamiento = diasEntrenamiento;
        this.horariosEntrenamiento = horariosEntrenamiento;
    }

    // Método para dar de alta un entrenador
    public static void DarDeAltaEntrenador(List<Entrenador> entrenadores)
    {
        Console.WriteLine("Ingrese nombre del entrenador:");
        string nombre = Console.ReadLine();
        Console.Write("DNI del entrenador: ");
        string dni = Console.ReadLine();
        Console.Write("Edad del entrenador: ");
        int edad = int.Parse(Console.ReadLine());
        Console.Write("Días de entrenamiento (separados por comas): ");
        List<string> diasEntrenamiento = new List<string>(Console.ReadLine().Split(','));
        Console.Write("Horarios de entrenamiento (separados por comas): ");
        List<string> horariosEntrenamiento = new List<string>(Console.ReadLine().Split(','));

        Entrenador nuevoEntrenador = new Entrenador(nombre, dni, edad, diasEntrenamiento, horariosEntrenamiento);
        entrenadores.Add(nuevoEntrenador);
        Console.WriteLine("El entrenador fue añadido con éxito.");
    }

    // Método para dar de baja un entrenador
    public static void DarDeBajaEntrenador(List<Entrenador> entrenadores)
    {
        Console.WriteLine("Ingrese DNI del entrenador a dar de baja:");
        string dni = Console.ReadLine();

        Entrenador entrenadorABorrar = entrenadores.Find(e => e.DNI == dni);

        if (entrenadorABorrar != null)
        {
            entrenadores.Remove(entrenadorABorrar);
            Console.WriteLine("Entrenador dado de baja con éxito.");
        }
        else
        {
            Console.WriteLine("Entrenador no encontrado.");
        }
    }
}
        
