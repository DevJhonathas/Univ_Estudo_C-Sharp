using System;

class Aluno
{
    //Atributos
    public string nome;
    public double nota1, nota2;
    //Media
    public double media()
    {
        return (nota1+nota2)/2;
    }
    //Situacao
    public string situacao(double media)
    {
        return media >= 7 ? "Aprovado" : "Reprovado";
    }
    //Mensagem
    public void mensagem()
    {
        //Obter a media
        double obterMedia = media();

        //Obter a situacao
        string obterSituacao = situacao(obterMedia);

        //Menssagem
        Console.WriteLine(nome+" está " +obterSituacao+" com media "+obterMedia);
    }
}