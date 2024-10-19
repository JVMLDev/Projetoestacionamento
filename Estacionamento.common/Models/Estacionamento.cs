using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Threading.Tasks;

namespace Projetoestacionamento.Models
{
    public class Estacionamento
    {
        private decimal precoInicial = 0;
        private decimal precoHora = 0;
        private List<string> listaPlaca = new List<string>(); // lista para armazenar alguns dados do sistema.


        public Estacionamento(decimal precoInicial, decimal precoHora)
        {
            this.precoInicial = precoInicial;
            this.precoHora = precoHora;
        }
        public void AdicionarVeiculo() // Método Público que faz adicionar Veículos no sistema.
        {
            Console.WriteLine("Informe a Placa do Veículo:");

            string adicionarPlaca = Console.ReadLine();

            listaPlaca.Add($"{adicionarPlaca}");

            Console.WriteLine("Pressione qualquer tecla para continuar...\n");
            Console.ReadKey();
        }

        public void RemoverVeiculo() // Método Público que faz Remover Veículos do sistema.
        {

            Console.WriteLine("Informe a placa do Veículo que deseja remover:");
            string removerPlaca = Console.ReadLine();


            if (listaPlaca.Contains(removerPlaca))// usado para verificar se um Placa está existente no programa
            {
                Console.WriteLine($"Por quantas horas esse veículo ficou estacionado?");
                int hora = Convert.ToInt32(Console.ReadLine());

                listaPlaca.Remove($"{removerPlaca}");
                decimal valorTotal = precoInicial + precoHora * hora;

                Console.WriteLine($"Placa removida: {removerPlaca} | valorTotal: {valorTotal} Reais");
            }else{
                Console.Clear();
                Console.WriteLine($"Placa não existente em nosso Sistema!");
            }

            Console.WriteLine("Pressione qualquer tecla para continuar...\n");
            Console.ReadKey();
        }

        public void ListarVeiculo() // Método Público que faz Listar Veículos do sistema.
        {
            int contador = 0;
            Console.WriteLine("Listando Veiculos:");
            foreach (string listandoVeiculos in listaPlaca) // Listando as placas cadastradas no sistema.
            {
                Console.WriteLine($"Posição: {contador} | Placa: {listandoVeiculos}");
                contador++;
            }
            if (contador == 0)// verifica se a lista tem alguma placa cadastrada. Caso não tiver ele imprimirar o Console abaixo.
            {
                Console.WriteLine("Porfavor, Cadastre um veiculo e depois volte aqui...!\n");
            }
            Console.WriteLine("Pressione qualquer tecla para continuar...");
            Console.ReadKey();
        }
    }
}