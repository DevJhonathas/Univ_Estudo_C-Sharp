using System;

namespace _03_Exercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instanciar o objeto da classe aluno
            Aluno a = new Aluno();
            a.nome = "Jhonathas";
            a.nota1 = 9;
            a.nota2 = 10;
            a.mensagem();
        }
    }
}