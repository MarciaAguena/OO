using System;

namespace Source.PessoaMetodo
{
    public class Pessoa
    {
        // Atributos (campos privados)
        public string nome;
        public int idade;

        // Métodos para acessar os atributos
        public void SetNome(string nome)
        {
            this.nome = nome;Source.PessoaAtributo.TestaPessoa.Main();
        }

        public string GetNome()
        {
            return nome;
        }

        public void SetIdade(int idade)
        {
            this.idade = idade;
        }

        public int GetIdade()
        {
            return idade;
        }
    }
}