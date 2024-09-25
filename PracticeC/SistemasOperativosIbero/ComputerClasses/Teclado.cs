namespace ComputerClasses;

public class Teclado : DispositivoPeriferico
{
    public string TipoTecla { get; set; }  // Mecánico, Membrana, etc.
    
    public Teclado(string marca, string tipoTecla) : base(marca)
    {
        TipoTecla = tipoTecla;
    }
}