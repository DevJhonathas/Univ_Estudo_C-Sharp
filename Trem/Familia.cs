using System;

class Pai
{
    public int rodas = 4, retrovisor = 2;
    public string modelo, ano;
    public double kmMinimo, kmMaximo;
    
    public int Carro()
    {
        Console.WriteLine("Qual o modelo do carro: 1. Corolla / 2. Fiat / 3. Gol" + modelo);
        Console.WriteLine("Qual o ano do carro?" + ano);
    }

    public string MensagemEscolhaCarro()
    {
        Console.WriteLine("Seu carro é" + modelo + " e o ano: " + ano);
    }

    public string MensagemErroAoEscolherCarro()
    {
        Console.WriteLine("A sua escolha não esta entre as possibilidades anteriores.");
    }

    public string MensagemErroKM()
    {

    }

    public void EscolhaModeloAnoDoCarro()
    {
        if (modelo = 1)
        {
            MensagemEscolhaCarro();
            kmMaximo = 350;
        }
        else if (modelo = 2) 
        {
            MensagemEscolhaCarro();
            kmMaximo = 200;
        }
        else if (modelo = 3) 
        {
            MensagemEscolhaCarro();
            kmMaximo = 250;
        }
        else
        {
            MensagemErroAoEscolherCarro();
        }

    }
    public void Velocidade(double kmMinimo, double kmMaximo)
    {
        
    }
}