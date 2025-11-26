# Encapsulamento

- **Definição**: "Ocultar ou proteger detalhes de implementação"
- **Origem**: Em linguagens procedurais, procedimentos e funções já ocultavam detalhes de implementação
- **Principais vantagens**:
  - Legibilidade do código;
  - Segurança e confiabilidade do cógigo;
- Em C#, o encapsulamento é implementado principalmente através dos modificadores de acesso `private`, `protected`, `internal` e `public`

## Exemplo do Relógio
- Em um relógio de ponteiro, no período de uma hora:
  - O ponteiro dos minutos dá uma volta completa;
  - O ponteiro de horas anda 1/12 de volta;
- Assim, toda vez que o ponteiro dos minutos passa pelo 12, 
  o ponteiro das horas está exatamente sobre uma hora.
- Se fosse permitido manipular os ponteiros de um relógio, essa proporção entre os ângulos poderia ser perdida.

![relogios.png](figuras\relogios.png)


- Outro aspecto é que **queremos apenas saber as horas** e não nos importa como o relógio
  **funciona por dentro** para essa informação.
- Em outras palavras, o mecanismo do relógio deve ser permanecer **encapsulado** para 
  que mostre sempre uma informação correta sem detalhes desnecessários.

![barraRoxa.png](figuras\barraRoxa.png)

## `private` e `public`
  - `private`:
    - é o modificador de escopo que faz com que um atributo, método
      ou classe sejam acessados somente dentro da classe que o criou.
    - **atributo** são geralmente `private`; 
  - `public`:
    - é o modificador de escopo que faz com que um atributo, método
      ou classe sejam acessados em qualquer lugar de um projeto.
    - **classes** são geralmente `public`, assim como a maioria dos 
      **métodos**.
  - Ainda há mais dois modificadores: `protected` e `internal` que serão tratados mais a frente.


## Propriedades

- Como já vimos, para acessar diretamente um atributo seja colocando ou consultando o seu valor, em C# utilizamos suas **propriedades**;
- Propriedades são uma forma menos verbosa de criar métodos *getters* e *setters*
- Observe o exemplo das classes [Pessoa.cs](pessoa/Pessoa.cs)
    e [TestaPessoa.cs](pessoa/TestaPessoa.cs);

![barraRoxa.png](figuras/barraRoxa.png)

## Exercício:
- Faça o encapsulamento dos atributos e métodos da classe 
  [Relogio.cs](relogio/Relogio.cs) e teste-a na classe
  [TestaRelogio.cs](relogio/TestaRelogio.cs).

### Sistema:
1. Dentro do diretório sistema, crie a seguinte classe:
 - `ContaPoupanca`.
 - Crie os seguintes atributos para a classe ContaPoupança:
   - Todos os atributos da classe conta (`id`, `numero`, `saldo`); 
   - `diaDeAniversario` do tipo short; 
   - `taxaDeCorrecao` do tipo double.
2. Para as classes `Banco`, `Agencia`, `Conta`, `ContaCorrente` e 
   `ContaPoupança`, deixe todos os atributos **privados**;
3. Para as classes `Banco`, `Agencia`, `Conta`, `ContaCorrente` e 
   `ContaPoupança`,  crie as propriedades para todos os atributos;
4. Na classe `AplicacaoFinanceira`:
   - Substitua todas os acessos diretos a atributos dos objetos 
     `banco1`, `agencia1`, `conta1` e `contaCorrente1` pelas propriedades de todos os atributos;
   - Crie um objeto `contaPoupanca1` da classe `ContaPoupanca`; 
5. Compile a classe `AplicacaoFinanceira` e corrija os possíveis erros.
