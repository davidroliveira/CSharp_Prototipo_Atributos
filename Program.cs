using System;
using System.Reflection;

namespace ConsoleApp1
{
    class Program
    {
        private static void PrintAuthorInfo(System.Type myType)
        {
            foreach (var propriedade in myType.GetProperties())
            {
                foreach (var atributo in propriedade.GetCustomAttributes())
                {
                    if (atributo is AuthorAttribute)
                    {
                        var autor = (AuthorAttribute)atributo;
                        Console.WriteLine("Nome: " + autor.Name + " versao: " + autor.Version.ToString());
                    }
                }
            }

        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var teste = new SampleClass();
            teste.Id = 1;
            teste.Nome = "teste";

            PrintAuthorInfo(typeof(SampleClass));

        }
    }
}
