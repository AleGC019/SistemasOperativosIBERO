using System;
using ComputerClasses;

public class Program
{
    public static void Main()
    {
        // Crear procesador y almacenamiento
        Procesador procesador = new Procesador("Intel i7");
        Almacenamiento almacenamiento = new Almacenamiento("SSD", "1TB");

        // Crear la computadora con su procesador y almacenamiento
        Computadora computadora = new Computadora("Dell", procesador, almacenamiento);

        // Agregar Memorias RAM
        computadora.MemoriasRAM.Add(new MemoriaRAM(16)); // 16GB RAM
        computadora.MemoriasRAM.Add(new MemoriaRAM(8));  // 8GB RAM

        // Asignar Tarjeta Madre
        computadora.TarjetaMadre = new TarjetaMadre("ASUS Prime");

        // Mostrar los componentes principales de la computadora
        Console.WriteLine("\n------ Componentes de la Computadora ------\n");
        computadora.MostrarComponentes();
        MostrarMemorias(computadora);
        MostrarTarjetaMadre(computadora);

        // Conexión reflexiva de puertos USB
        PuertoUSB puerto1 = new PuertoUSB(3);
        PuertoUSB puerto2 = new PuertoUSB(3);
        puerto1.Conectar(puerto2);
        
        // Mostrar la conexión de los puertos
        MostrarConexionesPuerto(puerto1);

        // Conectar dispositivos periféricos
        Teclado teclado = new Teclado("Logitech", "Mecánico");
        Mouse mouse = new Mouse("Logitech", 5);
        
        Console.WriteLine("------ Conectando Periféricos ------");
        computadora.ConectarDispositivo(teclado);
        computadora.ConectarDispositivo(mouse);

        // Simular una acción en la computadora usando los periféricos conectados
        SimularEscribir(teclado);
        SimularClic(mouse);
        
        //Esperar tecla para cerrar
        Console.WriteLine("\nPresione cualquier tecla para salir...");
        Console.ReadKey();
    }

    // Función para mostrar las memorias RAM instaladas
    public static void MostrarMemorias(Computadora computadora)
    {
        Console.WriteLine("\nMemorias RAM instaladas:");
        foreach (var memoria in computadora.MemoriasRAM)
        {
            Console.WriteLine($"- {memoria.Capacidad} GB");
        }
    }

    // Función para mostrar la tarjeta madre instalada
    public static void MostrarTarjetaMadre(Computadora computadora)
    {
        Console.WriteLine($"\nTarjeta Madre instalada: {computadora.TarjetaMadre.Modelo}");
    }

    // Función para mostrar la conexión de los puertos USB
    public static void MostrarConexionesPuerto(PuertoUSB puerto)
    {
        if (puerto.ConectadoA != null)
        {
            Console.WriteLine($"\nPuerto USB de velocidad {puerto.Velocidad} conectado a otro puerto USB.");
        }
        else
        {
            Console.WriteLine("\nPuerto USB no está conectado a otro puerto.");
        }
    }

    // Simulación de escribir con un teclado
    public static void SimularEscribir(Teclado teclado)
    {
        Console.WriteLine($"\nEscribiendo con el teclado {teclado.Marca} de tipo {teclado.TipoTecla}.");
    }

    // Simulación de clic con el mouse
    public static void SimularClic(Mouse mouse)
    {
        Console.WriteLine($"Haciendo clic con el mouse {mouse.Marca} que tiene {mouse.NumeroBotones} botones.");
    }
}