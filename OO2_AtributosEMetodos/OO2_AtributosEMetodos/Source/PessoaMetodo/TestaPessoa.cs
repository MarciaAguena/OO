using System;

namespace Source.PessoaMetodo
{
    public class TestaPessoa
    {
        public static void Main()
        {
            Pessoa pessoa1 = new Pessoa();
            pessoa1.SetNome("João");
            pessoa1.SetIdade(25);

            Pessoa pessoa2 = new Pessoa();
            pessoa2.SetNome("Maria");
            pessoa2.SetIdade(30);

            Console.WriteLine($"Pessoa 1: {pessoa1.GetNome()}, {pessoa1.GetIdade()} anos");
            Console.WriteLine($"Pessoa 2: {pessoa2.GetNome()}, {pessoa2.GetIdade()} anos");
        }
    }
}