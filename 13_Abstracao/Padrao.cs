using System;

abstract class Padrao
{
    //Obrigatorio metodo pode se pub ou protec
    public abstract void taxaEmprestimo(double valor); //obrigatorio: public, void, parametro

    //opcional metodo
    public void calculoPoupanca(double valor, double taxa)
    {
     Console.WriteLine("Ganhos obtidos pela poupança" +(valor * taxa));   
    }
}