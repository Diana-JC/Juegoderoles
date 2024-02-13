class Guerrero : Personaje
{
    public Guerrero(string nombre, int nivel) : base(nombre, nivel) { }

    public override void Atacar()
    {
        Console.WriteLine($"{Nombre} golpea con una espada de un nivel de {Nivel}.");
    }


    public override void Defenderse()
    {
        Console.WriteLine($"{Nombre} levanta su escudo para protegerse de un ataque de un nivel de {Nivel}.");
    }
}

