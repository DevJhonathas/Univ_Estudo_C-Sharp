using System;

class Pessoa
{
    //atributos o que é: Apenas a classe que é criado aquele atributo ou metodo além de classes que extende/herdar a classe Pessoa
    //A propria classe pode usar atributos ou outras classes que herdam
    protected string nome;
    protected int idade;

    //Metodos 
    protected void mensagemPessoa()
    {
        Console.WriteLine("Nome: " + nome);
        Console.WriteLine("Idade: " + idade);
    }
}