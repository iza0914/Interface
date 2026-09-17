namespace Interface
{
    public class Program
    {
        static void Main(string[] args)
        {
            Espada minhaEspada = new Espada("Espada Longa", 50);
            Arco meuArco = new Arco("Arco Recurvo", 40);

            minhaEspada.ExibirInfo();
            Console.WriteLine($"Ataque Crítico: {minhaEspada.CalcularAtaqueCritico()}\n");

            meuArco.ExibirInfo();
            Console.WriteLine($"Ataque Crítico: {meuArco.CalcularAtaqueCritico()}");
        }
    }
}
