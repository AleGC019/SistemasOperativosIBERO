namespace ComputerClasses;

public class Almacenamiento
{
    public string Tipo { get; set; }  // Ej: SSD o HDD
    
    public Almacenamiento(string tipo)
    {
        Tipo = tipo;
    }
}