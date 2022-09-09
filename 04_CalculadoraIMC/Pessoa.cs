using System;


class Pessoa
{
    public double peso, altura;
    
    public double Calculo()
    {
        return peso / (altura * altura);
    }
    
    public string Situacao(double imc)
    {
        //Variavel
        string retorno;
        //Condicional
        if (imc < 18.5)
        {
            retorno = "Abaixo do peso";
        }
        else if (imc < 25)
        {
            retorno = "Peso normal";
        }
        else if (imc < 30)
        {
             retorno = "Acima do Peso";
        }
        else if (imc < 35)
        {
             retorno = "Obsidade I";
        }
        else if (imc < 40)
        {
            retorno = "Obsidade II";
        }
        else
        {
            retorno = "Obsidade III";
        }
        return retorno;
    }

    public void mensagem()
    {
        //obter calculo
        double obterCalculo = Calculo();
        
        //obter situacao
        string obterSituacao = Situacao(obterCalculo);

        //mensagem
        Console.WriteLine("Seu IMC é de: "+ obterCalculo);
        Console.WriteLine("Sua situação é "+ obterSituacao);
    }

}






