class Program
{
    static void Main(string[] args)
    {
        Guerrero guerrero = new Guerrero("Guillermo", 5);
        Mago mago = new Mago("Mercedes", 8);

        guerrero.Atacar();
        guerrero.Defenderse();

        mago.Atacar();
        mago.Defenderse();
    }
}