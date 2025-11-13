# Atributos e Métodos

- Na Orientação a Objetos representamos modelamos os agentes do sistema em classes, 
que darão origem a objetos e a lógica do sistema consiste em como esses objetos 
funcionam e na interação entre eles.

- Um agente tem sempre:
  - Um **estado** (características que ele possui ou é);
  - Um **comportamento**(ações que ele faz ou modo como age).

- Em um classe representamos:
  - os **estados com atributos**;
  - os **comportamentos com métodos**

![barraRoxa.png](figuras/barraRoxa.png)

## Atributos
- São os valores (variáveis) que cada objeto deve ter;
- São sempre declarados no início da classe;
- Observe o atributo `nome` da classe [Pessoa.cs](Source/Pessoa/Pessoa.cs) 
  e nos objetos em [TestaPessoa.java](Source/Pessoa/TestaPessoa.java);

![barraRoxa.png](figuras/barraRoxa.png)

## Métodos e Propriedades
- São as ações (funções) esperada dos objetos;
- Em C#, usamos propriedades como forma preferida para acessar atributos;
- Os métodos para obter o valor dos atributos são chamados `getter`'s;
- E os métodos para colocar valor nos atributos são chamados `setter`'s;
- Observe os métodos `nome` da classe [Pessoa.cs](Source/Pessoa/Pessoa.cs) 
  e nos objetos em [TestaPessoa.java](Source/Pessoa/TestaPessoa.java);

- **OBSERVAÇÃO:** No exemplo a anterior o importante não é a lógica de programação, mas 
  entender a funcionalidade dos `getter`'s e `setter`'s.


![barraRoxa.png](figuras/barraRoxa.png)

    
## Sistema

1. Abra a classe `Banco` que você criou anteriormente e adicione os seguintes atributos:
   - `id` do tipo long,
   - `numero` do tipo String,
   - `cnpj` do tipo String,
   - `nome` do tipo String;
2. Ainda na classe `Banco`, crie as propriedades para cada atributo declarado.
3. Abra a classe `Agencia` que você criou anteriormente e adicione os seguintes atributos:
   - `id` do tipo long
   - `numero` do tipo String
   - `nome` do tipo String
4. Ainda na classe `Agencia`, crie as propriedades para cada atributo declarado.
5. Abra a classe Conta que você criou anteriormente e adicione os seguintes atributos:
   - `id` do tipo long
   - `numero` do tipo String
   - `saldo` do tipo double
6. Ainda na classe `Conta`, crie as propriedades  para cada atributo declarado.
7. Dentro do diretório sistema, crie a seguinte classe:
   - `ContaCorrente`, com os atributos:
      - Todos os atributos de `Conta` (`id`, `numero` e `saldo`);
      - e ainda o atributo `limite` do tipo double;
8. Ainda na classe `ContaCorrente`, crie as propriedades para cada atributo declarado.
9. Complemente o método `main` da classe `AplicacaoFinanceira` com as seguintes operações:
   - Crie o objeto `contaCorrente1` da classe `ContaCorrente`;
   - Atrbua valores a todos os atributos dos objetos `banco1`, `agencia1`, `conta1` e 
     `contaCorrente1` com valores compatíveis com seus tipos;
10. Complemente o método `main` da classe imprimindo o valor 
    dos atributos `id` e `numero`, via `System.out.println()` e as propriedades, 
    para os 3 primeiros objetos do passo anterior e `id` e `limite` para o objeto 
    `contaCorrente1`;
11. Compile todas as classes para verificar se existe algum erro.
