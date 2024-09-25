namespace ComputerClasses;

public class Mouse : DispositivoPeriferico
{
    public int NumeroBotones { get; set; }
    
    public Mouse(string marca, int numeroBotones) : base(marca)
    {
        NumeroBotones = numeroBotones;
    }
}