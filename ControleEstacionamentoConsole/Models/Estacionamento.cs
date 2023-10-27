using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ControleEstacionamentoConsole.Models
{
        public class Estacionamento
        {
            private decimal precoInicial;
            private decimal precoHora;
            private List<string> veiculos;

            public Estacionamento(decimal precoInicial, decimal precoHora)
        {
            this.precoInicial = precoInicial;
            this.precoHora = precoHora;
            this.veiculos = new List<string>();
        }
        public void AdicionarVeiculo(string placa)
        {
            veiculos.Add(placa);
            Console.WriteLine($"Veículo com placa {placa} adicionado ao estacionamento.");
        }
        public void RemoverVeiculo(string placa, decimal horasEstacionado)
        {
            if (veiculos.Contains(placa))
            {
                veiculos.Remove(placa);
                decimal valorCobrado = precoInicial + (horasEstacionado * precoHora);
                Console.WriteLine($"Veículo com placa {placa} foi removido. Valor a ser cobrado: R${valorCobrado:F2}");
            }
            else
            {
                Console.WriteLine($"Veículo com placa {placa} não está estacionado.");
            }
        }
        public void ListarVeiculos()
        {
            if (veiculos.Count == 0)
        {
            Console.WriteLine("Não há veículos estacionados.");
        }
        else
        {
            Console.WriteLine("Veículos estacionados:");
            foreach (var placa in veiculos)
            {
                Console.WriteLine(placa);
            }
        }

        }
    }
}