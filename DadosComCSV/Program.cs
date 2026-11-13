using System.Collections;
using DadosComCSV.Repositories;
using DadosComCSV.Services;

var repository = new JogoRepository();
var service = new JogoService(repository);

bool executando = true;

while (executando)
{
   // Console.Clear();
    Console.WriteLine("==========GESTÃO DE JOGOS==========");
    Console.WriteLine("1 - Cadastrar Jogo");
    Console.WriteLine("2 - Listar Jogos");
    Console.WriteLine("0 - Sair");
    Console.WriteLine("\nEscolha uma opção: ");

    string? opcao = Console.ReadLine();

    try
    {
        switch (opcao)
        {
            case "1":
                //Cadastrar()
                break;
            case "2":
                var listaJogos = service.Listar();
                foreach (var item in listaJogos)
                {
                    Console.WriteLine($"Nome: {item.Nome} - Preco: {item.Preco}");
                }
                break;
            case "0":
                executando = false;
                break;
            default:
                Console.WriteLine("opção invalida");
                break;
        }
    }
    catch (ArgumentException ex)
    {
        Console.WriteLine($"\nErro: {ex.Message}");
        throw;
    }
}

