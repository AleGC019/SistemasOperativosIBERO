namespace ComputerClasses;

public class Almacenamiento
{
    public string Tipo { get; set; }  // Ej: SSD o HDD
    
    public string Capacidad { get; set; }  // Ej: 1TB
    
    public Almacenamiento(string tipo, string capacidad)
    {
        Tipo = tipo;
        Capacidad = capacidad;
    }
}