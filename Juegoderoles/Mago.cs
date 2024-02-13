class Mago : Personaje
{
    public Mago(string nombre, int nivel) : base(nombre, nivel) { }

    public override void Atacar()
    {
        Console.WriteLine($"{Nombre} lanza un hechizo de fuego de un nivel de {Nivel}.");
    }

    public override void Defenderse()
    {
        Console.WriteLine($"{Nombre} evoca una barrera mágica para protegerse de un ataque de un nivel de {Nivel}.");
    }
}
