using System;

class Gerente : Imposto
{
    public override void valeAlimentacao(double salario)
    {
        Console.WriteLine("Desconto Gerente do vale alimentacao R$"+ (salario * 0.15));
    }
}