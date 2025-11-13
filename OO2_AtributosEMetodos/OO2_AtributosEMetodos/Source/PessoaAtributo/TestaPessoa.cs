using System;

namespace Source.PessoaAtributo
{
    public class TestaPessoa
    {
        public static void Main()
        {
            Pessoa pessoa1 = new Pessoa();
            pessoa1.nome="João";
            pessoa1.idade=25;

            Pessoa pessoa2 = new Pessoa();
            pessoa2.nome="Maria";
            pessoa2.idade=30;

            Console.WriteLine($"Pessoa 1: {pessoa1.nome}, {pessoa1.idade} anos");
            Console.WriteLine($"Pessoa 2: {pessoa2.nome}, {pessoa2.idade} anos");
        }
    }
}