using System.ComponentModel.Design;
using Projetoestacionamento.Models;


//coloca o encoding para UTF8 para exibir acentuação
Console.OutputEncoding = System.Text.Encoding.UTF8;

decimal precoInicial = 0;
decimal precoHora = 0;

Console.WriteLine("Seja bem vindo ao TaxaEstacionar!"); //Nome dado ao Projeto (TaxaEstacionar)

Console.WriteLine($"Informe o valor inicial:");
precoInicial = Convert.ToDecimal(Console.ReadLine());

Console.WriteLine($"Informe o valor por Hora:");
precoHora = Convert.ToDecimal(Console.ReadLine());

Estacionamento estacionar = new Estacionamento(precoInicial, precoHora);

bool exibirMenu = true;

Console.Clear();
while (exibirMenu)
{   
   Console.Clear();
    Console.WriteLine("1 - Cadastrar Veículos");
    Console.WriteLine("2 - Remover Veículos");
    Console.WriteLine("3 - Listar Veículos");
    Console.WriteLine("4 - Encerrar");
    int opcao = Convert.ToInt16(Console.ReadLine());
    Console.Clear();
    switch (opcao)
    {
        case 1:
            estacionar.AdicionarVeiculo();
            break;
        case 2:
            estacionar.RemoverVeiculo();
            break;

        case 3:
            estacionar.ListarVeiculo();
            break;

        case 4:
            exibirMenu = false;
            break;
    }
}