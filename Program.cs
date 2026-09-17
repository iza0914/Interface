namespace Interface
{
    public class Program
    {
        static void Main(string[] args)
        {
            Drone meuDrone = new Drone();
            meuDrone.TirarFoto();
            meuDrone.Decolar();
            meuDrone.Pousar();


        }
    }
}