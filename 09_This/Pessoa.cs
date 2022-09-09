using System;

class Pessoa
{

    // Atributo
    private string nome = "Tatiana";
    //construtor
    public Pessoa(string nome)
    {
        Console.WriteLine(nome);
        Console.WriteLine(this.nome); // Sempre liga o atributo ao seu metodo
    }
}