using System;

namespace _04_CalculadoraIMG
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instanciar um objeto
            Pessoa obj= new Pessoa();
            obj.peso = 75;
            obj.altura = 1.82;
            obj.mensagem();
        }
    }
}