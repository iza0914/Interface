using System;
using System.Collections.Generic;
using System.Text;

namespace Interface
{
    public class Documento : ISalvavel
    {
        public void Salvar()
        {
            Console.WriteLine("Salvando o documento em formato .doc");
        }
    }
}
