using System;

namespace _11_Polimorfismo
{
    class Program
    {
        static void Main(string[] args)
        {
            Imposto objetoEstagio = new Imposto();
            objetoEstagio.valeAlimentacao(1000);
            objetoEstagio.valeTransporte(1000);
            Console.WriteLine("----------------");
            
            Imposto objetoGerente = new Gerente();
            objetoGerente.valeAlimentacao(1000);
            objetoGerente.valeTransporte(1000);
            Console.WriteLine("----------------");
            
            Imposto objetoAtendente = new Atendente();
            objetoAtendente.valeAlimentacao(1000);
            objetoAtendente.valeTransporte(1000);
        }
    }
}