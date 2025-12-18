# Construtor

Um construtor é um método especial de uma classe que é executado automaticamente quando **um objeto é instanciado**. Ele é responsável por inicializar os atributos da classe e preparar o objeto para uso.

## Características dos Construtores

- Tem exatamente o mesmo nome da classe;
- Não tem tipo de retorno (nem mesmo void);
- É executado automaticamente na instanciação;
- Podemos ter vários construtores diferenciados apenas pelos parâmetros 
  ([Pessoa.cs](pessoa/Pessoa.cs)):

- Na chamada a escolha dos argumentos definem qual construtor será chamado
  ([TestaPessoa.cs](pessoa/TestaPessoa.cs)):

- Caso você **não declare um construtor, o compilador Java cria um construtor 
  vazio padrão automaticamente** para a classe em questão.
- Porém, se você implementar qualquer construtor não for o vazio, e chamar 
  um construtor vazio, precisa implementar o construtor vazio. 


## Sistema:
1. Crie a classe Cliente, com os seguintes atributos privados:
- `cpf` do tipo `String`;
- `nome` do tipo `String`;
2. Crie métodos `getter`’s e `setter`’s para `Cliente`;
3. Crie construtores vazios para as classes: `Banco`, `Agencia`, `Conta`, `ContaCorrente`,
   `ContaPoupanca` e `Cliente`;
4. Crie construtores com todos os atributos para as classes: `Banco`, `Agencia`, `Conta`, `ContaCorrente`,
   `ContaPoupanca` e `Cliente`;
5. Na classe `AplicacaoFinanceira`:
- Crie um objeto `cliente1` da classe `Cliente` utilizando o construtor completo;
- Mostre os valores dos atributos de `cliente1` utilizando os métodos `getter`’s;
- Altere a criação dos objetos `Banco`, `Agencia`, `Conta`, `ContaCorrente` e
  `ContaPoupanca` utilizando construtores completos;
6. Compile a classe `AplicacaoFinanceira` e corrija os possíveis erros.