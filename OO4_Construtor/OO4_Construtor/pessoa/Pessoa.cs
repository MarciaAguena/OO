namespace OO4_Construtor.pessoa
{
    public class Pessoa
    {
        // Atributos
        private string nome;
        private int idade;
    
        // Propriedades para acessar os atributos
        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        public int Idade
        {
            get { return idade; }
            set { idade = value; }
        }
        
        // Construtor padrão
        public Pessoa(){}
        public Pessoa(string _nome, int _idade)
        {
            Nome = _nome;
            Idade = _idade;
        }
        // Método para exibir informações da pessoa
        public void ExibirInfo()
        {
            System.Console.WriteLine($"Nome: {Nome}, Idade: {Idade}");
        }
    }
}