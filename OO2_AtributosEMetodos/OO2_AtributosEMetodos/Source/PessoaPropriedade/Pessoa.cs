using System;

namespace Source.PessoaPropriedade
{
    public class Pessoa
    {
        // Propriedades (forma preferida em C#)
        public string Nome { get; set; }
        public int Idade { get; set; }

        // Métodos adicionais
        public void Apresentar()
        {
            Console.WriteLine($"Olá, me chamo {Nome} e tenho {Idade} anos");
        }

        public void FazerAniversario()
        {
            Idade++;
            Console.WriteLine($"Feliz aniversário! Agora tenho {Idade} anos");
        }
    }
}