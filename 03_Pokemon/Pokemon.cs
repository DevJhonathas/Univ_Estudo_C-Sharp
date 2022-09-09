using System;


class Pokemon
{
    private int ataque, defesa, PS;
    private double CalculoIV()
    {
        return (ataque + defesa + PS) * 2.2;
    }

    public string Situacao(double poder)
    {
        string retorno;
        if (poder < 19.8)
        {
            retorno = "0 estrelas";
        }
        else if (poder < 39.6)
        {
            retorno = "1 estrelas";
        }
        else if (poder < 59.4)
        {
            retorno = "2 estrelas";
        }
        else if (poder < 79.2)
        {
            retorno = "3 estrelas";
        }
        else
        {
            retorno = "4 estrelas! Pokemon Master";
        }
        return retorno;
    }

    public void Dialogo()
    {
        //obter calculo
        double obterCalculo = CalculoIV();
        
        //obter situacao
        string obterSituacao = Situacao(obterCalculo);


        Console.WriteLine("Informe os pontos de ataque");
        ataque = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Informe os pontos de defesa");
        defesa = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Informe os pontos de PS");
        PS = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Seu pokemon tem: " + CalculoIV());
    }
}
