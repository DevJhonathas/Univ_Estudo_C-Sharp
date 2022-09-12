/*Calcular e apresentar o valor do volume de uma lata de óleo, utilizando a fórmula:  V =  3.14159 * R * R * A Onde as variáveis: V, R e A representam respectivamente o volume, o raio e a altura.*/

class Calculo
{
    public double Volume, Raio, Altura;

    public double FormulaDoCalculo()
    {
        return Volume = 3.14159 * Raio * Raio * Altura;
    }

    public void Mensagem()
    {
        double ObterFormula = FormulaDoCalculo();
        Console.WriteLine("Volume = "+ ObterFormula);
    }
}