namespace OO4_Construtor.pessoa
{
    public class TestaPessoa
    {
        public static void main()
        {
            // Criando uma instância da classe Pessoa
            Pessoa pessoa1 = new Pessoa(); //Chamada do construtor padrão
            Pessoa pessoa2 = new Pessoa("Maria", 25); //Chamada do construtor com parâmetros

            // Atribuindo valores aos atributos
            pessoa1.Nome = "João";
            pessoa1.Idade = 30;

            // Exibindo as informações da pessoa
            pessoa1.ExibirInfo();
            pessoa2.ExibirInfo();
        }
    }
}