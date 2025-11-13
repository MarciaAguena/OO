# Classes e Objetos

## Abstração

- Abstração é a representação do real considerando suas características e comportamentos;
- Na abstração são considerados os aspectos essenciais de um contexto 
  ignorando os detalhes que não são importantes nele;
- Em um projeto de OO, um sistema é composto por parte menores. Cada nível de 
  abstração deve ignorar os detalhes menores ou maiores para ser resolvido.

![barraRoxa.png](figuras/barraRoxa.png)

## Classes e Objetos
- Uma **classe** é um Tipo Abstrato de Dados que define uma **estrutura padrão**, 
  por meio de atributos e métodos, que todos os seus objetos seguem; 
- Uma classe é declarada por meio da palavra-chave `class`; 
- Um **objeto** é a **instância de uma classe**, ou seja, ele segue toda a estrutura 
  que a classe determina em valores e comportamento;
- Uma analogia para facilitar a compreensão:

  - fôrma de bolo ➡️ classe
  - bolos ➡️ objetos
  - A fôrma determina o formato do bolo, mas não determina o recheio;
  - Diferentes recheiros dão origem a diferentes bolos, mas sempre dentro da mesma forma.

![forma_e_bolo.png](figuras/forma_e_bolo.png)

### Criando uma Classe
- Em java, geralmente cada classe ocupa um arquivo.
- Por convenção nomes das classes começam sempre com **letra maiúscula**.
- O arquivo deve ter o mesmo nome da classe.
- Codigo: [pessoa/Pessoa.cs](pessoa/Pessoa.cs)

![classePessoa.png](figuras/classePessoa.png)

### Criando um Objeto
- Para criar um objeto devemos:
  - Declarar a classe e o objeto;
  - Instanciá-lo com o comando `new`;
  - Objetos, por convenção, tem o nome iniciado sem com **letra minúscula**.
  - Codigo: [pessoa/TestaPessoa.java](pessoa/TestaPessoa.java)

![classeTestaPessoa.png](figuras/classeTestaPessoa.png)

![barraRoxa.png](figuras/barraRoxa.png)


### Pacotes
- Assim como organizamos nossos arquivos em pastas, também podemos organizar nosso 
  código em pastas, mas dentro de um projeto chamamos de `package` ou pacotes.
- Marcamos todas as classes do mesmo pacote com o comando na 1a linha:
```
package <nomeDoPacote>;
```
- Por convenção os nomes dos pacotes iniciam com letras minúsculas e o *camelCase*
  deve ser evitado;
- Para representar hierarquia, ou quando um pacote foi escrito dentro de outro, 
  utilizamos . (ponto) para separá-los, como em `aula1_introducao.pessoa`;


![barraRoxa.png](figuras/barraRoxa.png)


## Sistema

###  Importante:
- De agora em diante, nossos exercícios serão acumulativos, então cada aula deverá
  colocada dentro de um pacote com o nome `aulan`, onde `n` é o número da aula.
- O **Exercícios Sistema** deve ficar em um pacote fora das aulas pois é acumulativo,
  ou seja, a cada aula vamos complementá-lo.
1. Crie um pacote chamado `sistema`;
2. Dentro do diretório sistema, crie as seguintes classes (todas como públicas):
   - `Banco`,
   - `Agencia`,
   - `Conta`,
   - `AplicacaoFinanceira`.
   
3. Dentro da classe AplicacaoFinanceira, crie o método main de Java; 
4. Dentro do método main, faça as seguintes operações:
   - Declare e crie um objeto `banco1` da classe `Banco`,
   - Declare e crie um objeto `agencia1` da classe `Agencia`,
   - Declare e crie um objeto `conta1` da classe `Conta`,
5. Compile todas as classes para verificar se existe algum erro.
6. Teste o método `System.out.println(objeto)`

![barraRoxa.png](figuras/barraRoxa.png)
