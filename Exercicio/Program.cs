using System;

namespace Exercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            Imposto objEstagiario = new Imposto();
            objEstagiario.valeAlimentacao(1000);
            objEstagiario.valeTransporte(1000);
            Console.WriteLine("----------------");

            Imposto objAtendente = new Atendente();
            objAtendente.valeAlimentacao(1000);
            objAtendente.valeTransporte(1000);
            Console.WriteLine("----------------");

            Imposto objGerente = new Gerente();
            objGerente.valeAlimentacao(1000);
            objGerente.valeTransporte(1000);
            Console.WriteLine("----------------");

        }
    }
}