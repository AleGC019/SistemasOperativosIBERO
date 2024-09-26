namespace ComputerClasses;

public class Usuario
{
    public string Nombre { get; set; }
    public string Correo { get; set; }

    public Usuario(string nombre, string correo)
    {
        Nombre = nombre;
        Correo = correo;
    }
}