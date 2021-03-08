using System;

namespace NomeCompleto
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome;
            string sobrenome;
            string nomeCompleto;
            string nomeCatalogo;

            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("Veja seu nome em diferentes perspectivas.");
            Console.WriteLine("-----------------------------------------\n");
           
            //<---Inicio(Nome e Sobrenome)--->//
            Console.Write("Digite seu primeiro nome: ");
            nome = Console.ReadLine();

            Console.Write("Digite seu sobrenome: ");
            sobrenome = Console.ReadLine();
            //<---Fim(Nome e Sobrenome)--->//

            //<---Inicio(Nome de Catálogo)--->//
            nomeCompleto = $"{nome} {sobrenome}";
            nomeCatalogo = $"{sobrenome.ToUpper()}, {nome}";  

            Console.WriteLine();
            Console.WriteLine($"Nome completo: {nomeCompleto}");
            Console.WriteLine($"Nome de catálogo: {nomeCatalogo}");
            //<---Fim(Nome de Catálogo)--->//

            //<---Inicio(Sair)--->//
            Console.WriteLine("Pressione ENTER para sair");
            Console.ReadKey();
            //<---Fim(Sair)--->//
        }
    }
}
