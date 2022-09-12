using System;

class Imposto
{
    public virtual void valeAlimentacao(double salario)
    {
        Console.WriteLine("O desconto de imposto sobre seu vale alimentacao é:" + (salario * 0.1));
    }

    public virtual void valeTransporte(double salario)
    {
        Console.WriteLine("O desconto de imposto sobre seu vale transporte é:" + (salario * 0.06));
    }
}