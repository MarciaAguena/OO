namespace OO3_Encapsulamento.pessoa
{
    public class TestaPessoa
    {
        public static void main()
        {
            // Criando objeto
            Pessoa pessoa = new Pessoa();
            pessoa.Nome = "João";
            pessoa.Idade = 20;
        
            
            // Acessando através de propriedades
            Console.WriteLine(pessoa.Nome + " " + pessoa.Idade);
            
            // Modificando através de propriedades
            pessoa.Nome = "Maria";
            pessoa.Idade = 30;
            
            Console.WriteLine(pessoa.Nome + " " + pessoa.Idade);
            
        }
    }
}