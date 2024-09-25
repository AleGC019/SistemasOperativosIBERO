namespace ComputerClasses;

public class PuertoUSB
{
    public int Velocidad { get; set; }  // Ej: USB 3.0

    // Asociación reflexiva: un PuertoUSB puede conectarse a otro
    public PuertoUSB ConectadoA { get; set; }
    
    public PuertoUSB(int velocidad)
    {
        Velocidad = velocidad;
    }

    public void Conectar(PuertoUSB otroPuerto)
    {
        ConectadoA = otroPuerto;
        Console.WriteLine("Puerto USB conectado.");
    }
}