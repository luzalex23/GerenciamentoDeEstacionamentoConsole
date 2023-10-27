using ControleEstacionamentoConsole.Models;

class Programs
{
    static void Main()
    {
        Console.Write("Digite o preço inicial: ");
        decimal precoInicial = decimal.Parse(Console.ReadLine());

        Console.Write("Digite o preço por hora: ");
        decimal precoHora = decimal.Parse(Console.ReadLine());

        Estacionamento estacionamento = new Estacionamento(precoInicial, precoHora);

         while (true)
        {
            Console.WriteLine("\nMenu:");
            Console.WriteLine("1. Cadastrar veículo");
            Console.WriteLine("2. Remover veículo");
            Console.WriteLine("3. Listar veículos");
            Console.WriteLine("4. Encerrar");
            Console.Write("Escolha uma opção: ");

            string escolha = Console.ReadLine();

            switch (escolha)
            {
                case "1":
                    Console.Write("Digite a placa do veículo: ");
                    string placa = Console.ReadLine();
                    estacionamento.AdicionarVeiculo(placa);
                    break;

                case "2":
                    Console.Write("Digite a placa do veículo a ser removido: ");
                    string placaRemover = Console.ReadLine();
                    Console.Write("Digite a quantidade de horas estacionado: ");
                    decimal horasEstacionado = decimal.Parse(Console.ReadLine());
                    estacionamento.RemoverVeiculo(placaRemover, horasEstacionado);
                    break;

                case "3":
                    estacionamento.ListarVeiculos();
                    break;
                     case "4":
                    return;

                default:
                    Console.WriteLine("Opção inválida. Por favor, escolha uma opção válida.");
                    break;
            }
        }   


    }
}