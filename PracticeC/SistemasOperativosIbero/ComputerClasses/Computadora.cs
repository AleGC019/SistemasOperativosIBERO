namespace ComputerClasses;

public class Computadora
{
    public string Marca { get; set; }
    public Procesador Procesador { get; set; }  // Asociación binaria
    public List<MemoriaRAM> MemoriasRAM { get; set; }  // Agregación
    public Almacenamiento Almacenamiento { get; set; }  // Composición
    public TarjetaMadre TarjetaMadre { get; set; }  // Asociación n-aria
    public Usuario Usuario { get; set; }  // Composición

    public Computadora(string marca, Procesador procesador, Almacenamiento almacenamiento, Usuario usuario)
    {
        Marca = marca;
        Procesador = procesador;
        Almacenamiento = almacenamiento;
        MemoriasRAM = new List<MemoriaRAM>();
        Usuario = usuario;
    }

    public void ConectarDispositivo(DispositivoPeriferico dispositivo) // Dependencia
    {
        Console.WriteLine($"Conectando {dispositivo.GetType().Name} a la computadora {Marca}");
    }

    public void MostrarComponentes()
    {
        Console.WriteLine($"Computadora marca {Marca} con procesador {Procesador.Modelo}, almacenamiento de tipo {Almacenamiento.Tipo}");
    }
}