namespace Interface
{
    public class Program
    {
        static void Main(string[] args)
        {
            ISalvavel doc = new Documento();
            ISalvavel foto = new Foto();

            doc.Salvar();
            foto.Salvar();
        }
    }
}
