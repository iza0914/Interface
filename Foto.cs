using Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Interface
{
    public class Foto : ISalvavel
    {
        public void Salvar()
        {
            Console.WriteLine("Salvando a foto em formato .jpg");
        }
    }
}