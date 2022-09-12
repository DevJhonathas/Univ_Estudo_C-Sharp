using System;

//Apenas por : para herdar
class Colobarodor:Pessoa
{
    //Atributos
    private double salario;

    //Construtor
    public Colobarodor(string nome, int idade, double salario)
    {
        //Criando herença
        this.idade = idade;
        this.nome = nome;
        this.salario = salario;

        mensagemColoborador();
        mensagemPessoa();
    }

    //Metodo
    private void mensagemColoborador()
    {
        Console.WriteLine("Salário: " + salario);
    }
}