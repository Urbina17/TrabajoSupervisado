using System;

class Persona
{
    private string nombre;
    private string apellido;
    private int edad;
    private double alturaCms;

    public Persona(string nombre, string apellido, int edad, double alturaCms)
    {
        this.nombre = nombre;
        this.apellido = apellido;
        this.edad = edad;
        this.alturaCms = alturaCms;
    }

    public string NombreCompleto()
    {
        return $"{nombre} {apellido}";
    }

    public double AlturaEnMetros()
    {
        return alturaCms / 100;
    }

    public void ImprimirDatos()
    {
        Console.WriteLine($"Nombre: {nombre}");
        Console.WriteLine($"Apellido: {apellido}");
        Console.WriteLine($"Edad: {edad}");
        Console.WriteLine($"Altura en cms: {alturaCms}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        
        Persona persona = new Persona("Diego", "Urbina", 19, 181);

        
        persona.ImprimirDatos();
        Console.WriteLine($"Nombre completo: {persona.NombreCompleto()}");
        Console.WriteLine($"Altura en metros: {persona.AlturaEnMetros()}");

        
        Console.Write("Ingrese el número de filas: ");
        int filas = int.Parse(Console.ReadLine());
        Console.Write("Ingrese el número de columnas: ");
        int columnas = int.Parse(Console.ReadLine());

        
        int[,] tabla = new int[filas, columnas];
        for (int i = 0; i < filas; i++)
        {
            for (int j = 0; j < columnas; j++)
            {
                tabla[i, j] = (i + 1) * (j + 1);
            }
        }

        Console.WriteLine("Tabla de multiplicación:");
        for (int i = 0; i < filas; i++)
        {
            for (int j = 0; j < columnas; j++)
            {
                Console.Write($"{tabla[i, j],3} ");
            }
            Console.WriteLine();
        }
    }
}