

class Personaje
{
    public string Nombre { get; set; }
public int Nivel { get; set; }

public Personaje(string nombre, int nivel)
{
    Nombre = nombre;
    Nivel = nivel;
}

public virtual void Atacar()
{
    Console.WriteLine($"{Nombre} ataca con un nivel de {Nivel}.");
}

public virtual void Defenderse()
{
    Console.WriteLine($"{Nombre} se defiende con un nivel de {Nivel}.");
}
}