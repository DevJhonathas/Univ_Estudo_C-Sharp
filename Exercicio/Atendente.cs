using System;

class Atendente : Imposto
{
    public override void valeAlimentacao(double salario)
    {
        Console.WriteLine("O desconto de imposto sobre seu vale alimentacao é:" + (salario * 0.15));
    }
}