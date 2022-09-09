using System;

namespace _01Conceitos
{
    class Conceitos
    {
        static void Main(string[] args)
        {
            //Instanciar um objeto
            Pessoa obj = new Pessoa();
            obj.nome = "Gustavo Lima";
            obj.idade = 30;
            obj.mensagem();
        }
    }
}