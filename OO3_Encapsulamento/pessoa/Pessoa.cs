namespace OO3_Encapsulamento.pessoa
{
    public class Pessoa
    {
        private string nome;
        private int idade;

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        public int Idade
        {
            get { return idade; }
            set
            {
                if (value >= 0)
                {
                    idade = value;
                }
                else
                {
                    idade = 0;
                }
            }
        }
    }
}