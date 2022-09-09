using System;

namespace _08_GetSet
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa obj = new Pessoa();
            obj.Nome = "Johnny";
            Console.WriteLine(obj.Nome);
        }
    }
}