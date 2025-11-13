namespace Source.PessoaPropriedade
{
    public class TestaPessoa
    {
        public static void Main()
        {
            Pessoa pessoa1 = new Pessoa();
            pessoa1.Nome = "João";  // Usando setter da propriedade
            pessoa1.Idade = 25;

            Pessoa pessoa2 = new Pessoa 
            { 
                Nome = "Maria",     // Inicializador de objeto
                Idade = 30 
            };

            pessoa1.Apresentar();
            pessoa2.Apresentar();
            
            pessoa1.FazerAniversario();
        }
    }
}